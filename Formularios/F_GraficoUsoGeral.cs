using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static WinFormsApp1.Componentes;
using WinFormsApp1;

namespace WinFormsApp1
{
    public partial class F_GraficoUsoGeral : Form
    {
        private bool cpuHabilitada, gpuHabilitada, ramHabilitada;
        private Componentes.Cpu cpu;
        private Componentes.Gpu gpu;
        private Componentes.Ram ram;

        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        private int ramTotal, tamanhoEixoX;

        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private int intervaloAtualizacao;
        private float transparencia;

        private Graficos graficoUsoGeral;
        public F_GraficoUsoGeral()
        {
            InitializeComponent();
            this.Padding = new Padding(10);

            ramTotal = (int)Componentes.ramTotal;

            intervaloAtualizacao = Properties.Settings.Default.IntervaloAtualizacaoGraficoUsoGeral;
            tamanhoEixoX = Properties.Settings.Default.UnidadesEixoXGraficoUsoGeral;
            this.Opacity = 1 - (float)Properties.Settings.Default.TransparenciaGrafico / 100;

            ch_UsoGeral.MouseDown += Chart_MouseDown;
            ch_UsoGeral.MouseMove += Chart_MouseMove;
            ch_UsoGeral.MouseUp += Chart_MouseUp;

            graficoUsoGeral = new Graficos(ch_UsoGeral, tamanhoEixoX, "Uso Geral (%)");

            AtualizaComponenteHabilitados();

            tm_1.Interval = intervaloAtualizacao;
            tm_1.Tick += tm_1_Tick;
            tm_1.Start();

        }

        private void Chart_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                startPoint = new Point(e.X, e.Y);
            }
        }

        private void Chart_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(new Point(e.X, e.Y));
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void Chart_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = false;
            }
        }

        private void AtualizaComponenteHabilitados()
        {
            bool VerificaComponenteHabilitado(bool setting, string nomeSerie)
            {

                if (setting)
                {
                    graficoUsoGeral.AtualizarSeries(nomeSerie);
                    return true;
                }
                else
                {
                    return false;
                }
            }

            graficoUsoGeral.Zerar();
            cpuHabilitada = VerificaComponenteHabilitado(Properties.Settings.Default.CpuHabilitadaGraficoUsoGeral, "CPU");
            gpuHabilitada = VerificaComponenteHabilitado(Properties.Settings.Default.GpuHabilitadaGraficoUsoGeral, "GPU");
            ramHabilitada = VerificaComponenteHabilitado(Properties.Settings.Default.RamHabilitadaGraficoUsoGeral, "RAM");
            System.Diagnostics.Debug.WriteLine(cpuHabilitada.ToString() + gpuHabilitada.ToString() + ramHabilitada.ToString());
            if (cpuHabilitada) { cpu = new Componentes.Cpu(); }
            if (gpuHabilitada) { gpu = new Componentes.Gpu(); }
            if (ramHabilitada) { ram = new Componentes.Ram(); }
        }

        private void F_GraficoUsoGeral_Load(object sender, EventArgs e)
        {

        }

        private void tm_1_Tick(object sender, EventArgs e)
        {
            if(cpuHabilitada)
            {
                graficoUsoGeral.AdicionarValor("CPU", cpu.Uso());
            }
            if (gpuHabilitada)
            {
                graficoUsoGeral.AdicionarValor("GPU", gpu.Uso());
            }
            if (ramHabilitada)
            {
                graficoUsoGeral.AdicionarValor("RAM", ram.Uso()/ramTotal * 100);
            }
        }

        public void AtualizaConfiguracoes()
        {
            if (this.IsDisposed == false)
            {
                tamanhoEixoX = Properties.Settings.Default.UnidadesEixoXGraficoUsoGeral;
                intervaloAtualizacao = Properties.Settings.Default.IntervaloAtualizacaoGraficoUsoGeral;
                this.Opacity = 1 - (float)Properties.Settings.Default.TransparenciaGrafico / 100;
                graficoUsoGeral = new Graficos(ch_UsoGeral, tamanhoEixoX, "Uso Geral (%)");
                tm_1.Interval = intervaloAtualizacao;
                AtualizaComponenteHabilitados();
            }

        }
    }




    public class Graficos
    {
        //private float[] arrayHistorico;
        private Dictionary<string, Queue<float>> historicoValores;
        private Queue<float> filaZeradaValores;
        private List<Series> listaSeries;
        private static readonly Random random = new Random();
        private int tamanhoEixoX;
        private string nome;
        private Chart chart;
        private bool resetado;

        public Graficos(Chart chart, int tamanhoEixoX, string nome)
        {
            this.chart = chart;
            this.tamanhoEixoX = tamanhoEixoX;
            this.nome = nome;
            var objChart = chart.ChartAreas[0];

            historicoValores = new Dictionary<string, Queue<float>>();
            filaZeradaValores = new Queue<float>();

            for (int i = 0; i < tamanhoEixoX; i++)
            {
                filaZeradaValores.Enqueue(0);
            }


            objChart.Name = nome;

            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisX.Minimum = 1;
            objChart.AxisX.Maximum = tamanhoEixoX;

            objChart.AxisY.Minimum = 0;
            objChart.AxisY.Maximum = 100;

            objChart.AxisX.IsLabelAutoFit = false;
            objChart.AxisX.LabelStyle.Enabled = false;


            chart.ChartAreas[0].Position.X = 0;


            chart.ChartAreas[0].Position.Y = 5;


            chart.ChartAreas[0].Position.Width = 85;


            chart.ChartAreas[0].Position.Height = 90;


            /*for (int i = 0; i < tamanhoEixoX - 1; i++)
            {
                historicoValores.Enqueue(0);
            }*/
        }

        public void AtualizarSeries(string nomeSerie)
        {
                int red = random.Next(256);
                int green = random.Next(170);
                int blue = random.Next(170);

                chart.Series.Add(nomeSerie);
                //chart.Series[serie].ChartArea = "ChartArea1";
                chart.Series[nomeSerie].Color = Color.FromArgb(red, green, blue);
                chart.Series[nomeSerie].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;


                historicoValores.Add(nomeSerie, new Queue<float>(filaZeradaValores));
                System.Diagnostics.Debug.WriteLine(historicoValores);
        }
        public void AdicionarValor(string serie, float valor)
        {
            historicoValores[serie].Enqueue(valor);
            historicoValores[serie].Dequeue();

            //List <string> listaSeries = new List<string>();


            //dsfgsdfgsdfgsdfg
            List<object> listaValores = new List<object>(historicoValores[serie].Cast<object>());



            chart.Series[serie].Points.Clear();

            for (int i = 0; i < listaValores.Count - 1; i++)
            {
                //System.Diagnostics.Debug.WriteLine($"Série: {serie}, Valor: {valor}");
                chart.Series[serie].Points.AddY(listaValores[i]);//listaValores[i]);
            }
        }

        public void Zerar()
        {
            chart.Series.Clear();
        }


    }
}