using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreHardwareMonitor.Hardware;
using static Azure.Core.HttpHeader;

namespace WinFormsApp1
{
    static public class Componentes
    {
        private static LibreHardwareMonitor.Hardware.Computer computer;
        private static LibreHardwareMonitor.Hardware.HardwareType TipoGpu;
        private static ComputerInfo computerInfo;
        private static string[] listaComponentes;
        public static Dictionary<HardwareType, string> nomes;
        public static double ramTotal;

        static Componentes()
        {
            computerInfo = new ComputerInfo();
            computer = new LibreHardwareMonitor.Hardware.Computer();
            computer.IsCpuEnabled = true;
            computer.IsGpuEnabled = true;
            computer.IsMotherboardEnabled = true;

            computer.Open();

            nomes = new Dictionary<HardwareType, string>();

            if (Enum.IsDefined(typeof(LibreHardwareMonitor.Hardware.HardwareType), LibreHardwareMonitor.Hardware.HardwareType.GpuNvidia))
            {
                TipoGpu = HardwareType.GpuNvidia;
            }
            else if (Enum.IsDefined(typeof(HardwareType), HardwareType.GpuAmd))
            {
                TipoGpu = HardwareType.GpuAmd;
            }

            listaComponentes = new string[] { "Cpu", TipoGpu.ToString() };

            for (int i = 0; i < listaComponentes.Length; i++)
            {
                foreach (var hardware in computer.Hardware)
                {
                    if (hardware.HardwareType.ToString() == listaComponentes[i])
                    {
                        nomes.Add(hardware.HardwareType, hardware.Name);
                        //System.Diagnostics.Debug.WriteLine(nomes[hardware.HardwareType]);
                        break;
                    }
                }
            }
            ramTotal = computerInfo.TotalPhysicalMemory / (1024.0 * 1024.0);
        }

        private static float coletaViaOHM(HardwareType componente, SensorType tipoSensor, string nomeSensor)
        {
            foreach (var hardware in computer.Hardware)
            {
                if (hardware.HardwareType == componente)
                {
                    hardware.Update();
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == tipoSensor && sensor.Name == nomeSensor)
                        {
                            //System.Diagnostics.Debug.WriteLine(sensor.Name);
                            return (float)sensor.Value;
                        }
                    }
                }
            }
            return -3;
        }

        public abstract class ComponenteGenerico
        {
            protected HardwareType componente;
            protected string nomeSensorUso;
            protected string nomeSensorTemperatura;
            protected string nome;
            protected void coletaNome(HardwareType componente)
            {
                if (nomes != null && nomes.ContainsKey(componente))
                {
                    nome = nomes[componente];
                }
                else nome = $"{componente} indefinido";
            }

            public string Nome
            {
                get { return nome; }
            }

            public virtual float Temperatura()
            {
                return (float)Math.Round(coletaViaOHM(componente, SensorType.Temperature, nomeSensorTemperatura), 2);
            }

            public virtual float Uso()
            {
                return (float)Math.Round(coletaViaOHM(componente, SensorType.Load, nomeSensorUso), 2);
            }
        }

        public class Cpu : ComponenteGenerico
        {
            public Cpu()
            {
                componente = HardwareType.Cpu;
                nomeSensorUso = "CPU Total";
                nomeSensorTemperatura = "Core (Tctl/Tdie)";
                coletaNome(HardwareType.Cpu);
            }

        }

        public class Gpu : ComponenteGenerico
        {
            public Gpu()
            {
                componente = TipoGpu;
                nomeSensorUso = "GPU Core";
                nomeSensorTemperatura = "GPU Core";
                coletaNome(TipoGpu);
            }

        }

        public class Ram : ComponenteGenerico
        {
            private PerformanceCounter ramDisponivel;
            public static double ramTotal;
            public Ram()
            {
                componente = HardwareType.Memory;
                ramDisponivel = new PerformanceCounter("Memory", "Available MBytes");

                ramTotal = computerInfo.TotalPhysicalMemory / (1024.0 * 1024.0);
            }

            public int RamTotal { get { return (int)ramTotal; } }

            public override float Uso()
            {
                //return (float)Math.Round(coletaViaOHM(componente, SensorType.Load, "Memory"), 2);
                return (int)ramTotal - ramDisponivel.NextValue();
            }
        }
    }
}
