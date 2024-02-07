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

namespace WinFormsApp1
{
    public partial class F_Configuracoes : Form
    {
        private F_Principal f_Principal;

        public F_Configuracoes(F_Principal f_Principal)
        {
            this.f_Principal = f_Principal;
            InitializeComponent();
            nud_Velocidade.Value = Properties.Settings.Default.IntervaloAtualizacao;
            VerificarInicializacaoComWindows();
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

        private void nud_Velocidade_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.IntervaloAtualizacao = (int)nud_Velocidade.Value;
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

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

