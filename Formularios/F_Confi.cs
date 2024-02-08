using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using static WinFormsApp1.Componentes;

namespace WinFormsApp1
{
    public partial class F_Confi : Form
    {
        private F_Principal f_Principal;

        public F_Confi(F_Principal f_Principal)
        {
            this.f_Principal = f_Principal;
            InitializeComponent();
            nud_IntPrincipal.Value = Properties.Settings.Default.IntervaloAtualizacao;
            nud_IntGrafico.Value = Properties.Settings.Default.IntervaloAtualizacaoGraficoUsoGeral;
            VerificarInicializacaoComWindows();
            cb_Cpu_principal.Checked = Properties.Settings.Default.CpuHabilitadaPrincipal;
            cb_Gpu_princpal.Checked = Properties.Settings.Default.GpuHabilitadaPrincipal;
            cb_ram_principal.Checked = Properties.Settings.Default.RamHabilitadaPrincipal;
            tb_TransGrafico.Value = Properties.Settings.Default.TransparenciaGrafico;
            tb_TranspPrincipal.Value = Properties.Settings.Default.TransparenciaPrincipal;
            lb_TranspGrafico.Text = Properties.Settings.Default.TransparenciaGrafico.ToString() + "%";

            lb_TransPrincipal.Text = Properties.Settings.Default.TransparenciaPrincipal.ToString() + "%";

            cb_Cpu_Grafico.Checked = Properties.Settings.Default.CpuHabilitadaGraficoUsoGeral;
            cb_Gpu_Grafico.Checked = Properties.Settings.Default.GpuHabilitadaGraficoUsoGeral;
            cb_Ram_Grafico.Checked = Properties.Settings.Default.RamHabilitadaGraficoUsoGeral;

            nud_UniGrafico.Minimum = 5;
            nud_UniGrafico.Maximum = 2000;

            nud_UniGrafico.Value = Properties.Settings.Default.UnidadesEixoXGraficoUsoGeral;
        }

        private void VerificarInicializacaoComWindows()
        {
            string runOnStartup = System.Configuration.ConfigurationManager.AppSettings["RunOnStartup"];

            if (!string.IsNullOrEmpty(runOnStartup) && runOnStartup.ToLower() == "true")
            {
                Properties.Settings.Default.IniciarWindows = true;
                cb_IniciarWindows.Checked = true;
            }
            else Properties.Settings.Default.IniciarWindows = false;
        }

        private void bt_Aplicar_Click(object sender, EventArgs e)
        {

            if (f_Principal != null)
            {
                Properties.Settings.Default.Save();

                using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
                {
                    if (cb_IniciarWindows.Checked)
                    {
                        key.SetValue(Application.ProductName, Application.ExecutablePath);
                        Properties.Settings.Default.IniciarWindows = true;
                    }
                    else
                    {
                        key.DeleteValue(Application.ProductName, false);
                        Properties.Settings.Default.IniciarWindows = false;
                    }
                }
            }
            this.Close();
        }



        private void bt_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void cb_RamPrincipal_CheckedChanged(object sender, EventArgs e)
        {

            Properties.Settings.Default.RamHabilitadaPrincipal = cb_ram_principal.Checked;
        }


        private void cb_GpuPrincpal_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.GpuHabilitadaPrincipal = cb_Gpu_princpal.Checked;
        }

        private void cb_CpuPrincipal_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CpuHabilitadaPrincipal = cb_Cpu_principal.Checked;
        }

        private void tb_TranspPrincipal_MouseCaptureChanged(object sender, EventArgs e)
        {
            lb_TransPrincipal.Text = tb_TranspPrincipal.Value.ToString() + "%";
            Properties.Settings.Default.TransparenciaPrincipal = tb_TranspPrincipal.Value;
        }

        private void tb_TransGrafico_MouseCaptureChanged(object sender, EventArgs e)
        {
            lb_TranspGrafico.Text = tb_TransGrafico.Value.ToString() + "%";
            Properties.Settings.Default.TransparenciaGrafico = tb_TransGrafico.Value;
            System.Diagnostics.Debug.WriteLine(Properties.Settings.Default.TransparenciaGrafico);
        }

        private void nud_IntPrincipal_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.IntervaloAtualizacao = (int)nud_IntPrincipal.Value;
        }

        private void nud_IntGrafico_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.IntervaloAtualizacaoGraficoUsoGeral = (int)nud_IntGrafico.Value;
        }

        private void cb_Cpu_Grafico_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CpuHabilitadaGraficoUsoGeral = cb_Cpu_Grafico.Checked;
        }

        private void cb_Gpu_Grafico_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.GpuHabilitadaGraficoUsoGeral = cb_Gpu_Grafico.Checked;
        }

        private void cb_Ram_Grafico_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.RamHabilitadaGraficoUsoGeral = cb_Ram_Grafico.Checked;
        }

        private void nud_UniGrafico_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UnidadesEixoXGraficoUsoGeral = (int)nud_UniGrafico.Value;
        }
    }
}

