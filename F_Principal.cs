using System.Diagnostics;
using System.Drawing.Text;
using System.Windows.Forms.DataVisualization.Charting;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Devices;
using System.Runtime.InteropServices;
using OpenHardwareMonitor;
//using OpenHardwareMonitor.Hardware;
using LibreHardwareMonitor.Hardware;
using System.Threading;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Contracts;
using System.Management;
using System.Collections.Generic;
using System;
using HidSharp.Reports.Units;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.ComponentModel;



namespace WinFormsApp1
{
    public partial class F_Principal : Form
    {

        [DllImport("OpenHardwareMonitorLib.dll")]
        public static extern int OpenHardwareMonitor(string hardwareType, string sensorType);

        private double opacidadePadrao = Properties.Settings.Default.OpacidadePadrao;
        private double opacidadeFoco = Properties.Settings.Default.OpacidadeFoco;
        private bool cpuHabilitada; bool gpuHabilitada; bool ramHabilitada;

        private F_GraficoUsoGeral f_GraficoUsoGeral;

        private int ramTotal;
        private int intervaloAtualizacao;

        private Componentes.Cpu cpu; private Componentes.Gpu gpu; private Componentes.Ram ram;

        private Graficos graficoUso;

        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public F_Principal()
        {
            //this.MouseDown += new MouseEventHandler(F_Principal_MouseDown);
            //this.MouseMove += new MouseEventHandler(F_Principal_MouseMove);
            //this.MouseUp += new MouseEventHandler(F_Principal_MouseUp);

            intervaloAtualizacao = Properties.Settings.Default.IntervaloAtualizacao;

            this.Opacity = 1-(float)Properties.Settings.Default.TransparenciaPrincipal/100;

            System.Diagnostics.Debug.WriteLine(1 - Properties.Settings.Default.TransparenciaPrincipal / 100);

            InitializeComponent();

            tableLayoutPanel2.MouseDown += TableLayoutPanel2_MouseDown;
            tableLayoutPanel2.MouseMove += TableLayoutPanel2_MouseMove;
            tableLayoutPanel2.MouseUp += TableLayoutPanel2_MouseUp;

            AtualizaComponentesHabilitados();
            ramTotal = (int)Componentes.ramTotal;
            //ch_Geral.IsAccessible = true;
            //graficoUso = new Graficos(ch_Geral, 1000, "geral");
            //graficoUso.AtualizarSeries("Uso CPU", "Uso GPU", "Uso RAM");//, "Uso GPU", "Uso RAM");
            //ch_Geral.Series["Uso CPU"].Enabled = true;
            //tm_1.Interval = tempoAtualizacao;
            pb_Ram.Maximum = ramTotal;
            lb_nomeRam.Text = $"RAM {ramTotal / 1000}GB";
            tm_1.Interval = 1000;
            tm_1.Tick += timer1_Tick;
            tm_1.Start();
            //coletarGpu();
        }


        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        /*private void F_Principal_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                startPoint = new Point(e.X, e.Y);
            }
        }

        private void F_Principal_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(new Point(e.X, e.Y));
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void F_Principal_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = false;
            }
        }*/

        private void TableLayoutPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                startPoint = new Point(e.X, e.Y);
            }
        }

        private void TableLayoutPanel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(new Point(e.X, e.Y));
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void TableLayoutPanel2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = false;
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cpuHabilitada)
            {
                var nomeCpu = cpu.Nome;
                var usoCpu = cpu.Uso();

                lb_nomeCpu.Text = nomeCpu.ToString();
                lb_usoCpu.Text = $"{usoCpu.ToString()}%";
                pb_Cpu.Value = (int)(usoCpu);
            }

            if (gpuHabilitada)
            {
                var nomeGpu = gpu.Nome;
                var usoGpu = gpu.Uso();

                lb_nomeGpu.Text = nomeGpu.ToString();
                lb_usoGpu.Text = $"{usoGpu.ToString()}%";
                pb_Gpu.Value = (int)(usoGpu);
            }

            if (ramHabilitada)
            {
                var usoRam = ram.Uso();

                lb_usoRam.Text = $"{usoRam}MB";
                pb_Ram.Value = (int)(usoRam);
            }

            //graficoUso.AdicionarValor("Uso CPU", usoCpu);
            //graficoUso.AdicionarValor("Uso GPU", usoGpu);
            //graficoUso.AdicionarValor("Uso RAM", (usoRam / ramTotal) * 100);

            //graficoUso.AdicionarValor("Uso GPU", usoGpu);
            //graficoUso.AdicionarValor("Uso RAM", ramTotal/usoRam*100);





        }


        public void Fechar()
        {
            this.Close();
        }

        public void AtualizaComponentesHabilitados()
        {
            bool VerificaComponenteHabilitado(bool setting, string nome, Label labelNome, ProgressBar progressBar, Label labelValor)
            {
                if (setting == false)
                {
                    labelNome.ForeColor = Color.FromArgb(64, 64, 64);
                    labelNome.Text = nome;
                    progressBar.Value = 0;
                    labelValor.Text = "Desabilitado";
                    labelValor.ForeColor = Color.FromArgb(64, 64, 64);
                    return false;
                }
                else
                {
                    labelNome.ForeColor = Color.FromArgb(0, 0, 0);
                    labelValor.ForeColor = Color.FromArgb(0, 0, 0);

                    return true;
                }
            }

            cpuHabilitada = VerificaComponenteHabilitado(Properties.Settings.Default.CpuHabilitadaPrincipal, "CPU", lb_nomeCpu, pb_Cpu, lb_usoCpu);
            gpuHabilitada = VerificaComponenteHabilitado(Properties.Settings.Default.GpuHabilitadaPrincipal, "GPU", lb_nomeGpu, pb_Gpu, lb_usoGpu);
            ramHabilitada = VerificaComponenteHabilitado(Properties.Settings.Default.RamHabilitadaPrincipal, "RAM", lb_nomeRam, pb_Ram, lb_usoRam);
            if (cpuHabilitada) { cpu = new Componentes.Cpu(); }
            if (gpuHabilitada) { gpu = new Componentes.Gpu(); }
            if (ramHabilitada) { ram = new Componentes.Ram(); }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Confi f_Configuracoes = new F_Confi(this);

            f_Configuracoes.ShowDialog();


            AtualizaComponentesHabilitados();
            tm_1.Interval = Properties.Settings.Default.IntervaloAtualizacao;

            this.Opacity = 1 - (float) Properties.Settings.Default.TransparenciaPrincipal/100;

            System.Diagnostics.Debug.WriteLine(1 - Properties.Settings.Default.TransparenciaPrincipal / 100);

            if(f_GraficoUsoGeral !=  null)
            {
                f_GraficoUsoGeral.AtualizaConfiguracoes();
            }
        }

        private void usoGeralToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if(usoGeralToolStripMenuItem.Checked == true)
            {
                f_GraficoUsoGeral = new F_GraficoUsoGeral();
                f_GraficoUsoGeral.Show();
            }
            else if(f_GraficoUsoGeral != null)
            {
                f_GraficoUsoGeral.Close();
                f_GraficoUsoGeral.Dispose();
            }
        }
    }
}

