namespace WinFormsApp1
{
    partial class F_Confi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            cb_IniciarWindows = new CheckBox();
            groupBox4 = new GroupBox();
            groupBox10 = new GroupBox();
            nud_IntPrincipal = new NumericUpDown();
            label1 = new Label();
            groupBox6 = new GroupBox();
            cb_ram_principal = new CheckBox();
            cb_Cpu_principal = new CheckBox();
            cb_Gpu_princpal = new CheckBox();
            groupBox5 = new GroupBox();
            lb_TransPrincipal = new Label();
            tb_TranspPrincipal = new TrackBar();
            groupBox7 = new GroupBox();
            groupBox3 = new GroupBox();
            nud_UniGrafico = new NumericUpDown();
            label3 = new Label();
            nud_IntGrafico = new NumericUpDown();
            label2 = new Label();
            groupBox8 = new GroupBox();
            cb_Ram_Grafico = new CheckBox();
            cb_Cpu_Grafico = new CheckBox();
            cb_Gpu_Grafico = new CheckBox();
            groupBox9 = new GroupBox();
            lb_TranspGrafico = new Label();
            tb_TransGrafico = new TrackBar();
            bt_Aplicar = new Button();
            bt_Cancelar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_IntPrincipal).BeginInit();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tb_TranspPrincipal).BeginInit();
            groupBox7.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_UniGrafico).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_IntGrafico).BeginInit();
            groupBox8.SuspendLayout();
            groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tb_TransGrafico).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(391, 98);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Geral";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cb_IniciarWindows);
            groupBox2.Location = new Point(6, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(360, 56);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Iniciar";
            // 
            // cb_IniciarWindows
            // 
            cb_IniciarWindows.AutoSize = true;
            cb_IniciarWindows.Location = new Point(6, 26);
            cb_IniciarWindows.Name = "cb_IniciarWindows";
            cb_IniciarWindows.Size = new Size(169, 24);
            cb_IniciarWindows.TabIndex = 2;
            cb_IniciarWindows.Text = "Iniciar com Windows";
            cb_IniciarWindows.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(groupBox10);
            groupBox4.Controls.Add(groupBox6);
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Location = new Point(12, 116);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(391, 242);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Janela Principal";
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(nud_IntPrincipal);
            groupBox10.Controls.Add(label1);
            groupBox10.Location = new Point(12, 165);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(360, 61);
            groupBox10.TabIndex = 2;
            groupBox10.TabStop = false;
            groupBox10.Text = "Valores";
            // 
            // nud_IntPrincipal
            // 
            nud_IntPrincipal.Anchor = AnchorStyles.Right;
            nud_IntPrincipal.Location = new Point(229, 23);
            nud_IntPrincipal.Maximum = new decimal(new int[] { 3600000, 0, 0, 0 });
            nud_IntPrincipal.Minimum = new decimal(new int[] { 55, 0, 0, 0 });
            nud_IntPrincipal.Name = "nud_IntPrincipal";
            nud_IntPrincipal.Size = new Size(117, 27);
            nud_IntPrincipal.TabIndex = 3;
            nud_IntPrincipal.Value = new decimal(new int[] { 55, 0, 0, 0 });
            nud_IntPrincipal.ValueChanged += nud_IntPrincipal_ValueChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(217, 20);
            label1.TabIndex = 2;
            label1.Text = "Velocidade de atualização (ms)";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(cb_ram_principal);
            groupBox6.Controls.Add(cb_Cpu_principal);
            groupBox6.Controls.Add(cb_Gpu_princpal);
            groupBox6.Location = new Point(12, 91);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(354, 58);
            groupBox6.TabIndex = 1;
            groupBox6.TabStop = false;
            groupBox6.Text = "Medições";
            // 
            // cb_ram_principal
            // 
            cb_ram_principal.AutoSize = true;
            cb_ram_principal.Location = new Point(283, 26);
            cb_ram_principal.Name = "cb_ram_principal";
            cb_ram_principal.Size = new Size(63, 24);
            cb_ram_principal.TabIndex = 2;
            cb_ram_principal.Text = "RAM";
            cb_ram_principal.UseVisualStyleBackColor = true;
            cb_ram_principal.CheckedChanged += cb_RamPrincipal_CheckedChanged;
            // 
            // cb_Cpu_principal
            // 
            cb_Cpu_principal.AutoSize = true;
            cb_Cpu_principal.Location = new Point(6, 28);
            cb_Cpu_principal.Name = "cb_Cpu_principal";
            cb_Cpu_principal.Size = new Size(58, 24);
            cb_Cpu_principal.TabIndex = 1;
            cb_Cpu_principal.Text = "CPU";
            cb_Cpu_principal.UseVisualStyleBackColor = true;
            cb_Cpu_principal.CheckedChanged += cb_CpuPrincipal_CheckedChanged;
            // 
            // cb_Gpu_princpal
            // 
            cb_Gpu_princpal.AutoSize = true;
            cb_Gpu_princpal.Location = new Point(150, 28);
            cb_Gpu_princpal.Name = "cb_Gpu_princpal";
            cb_Gpu_princpal.Size = new Size(59, 24);
            cb_Gpu_princpal.TabIndex = 0;
            cb_Gpu_princpal.Text = "GPU";
            cb_Gpu_princpal.UseVisualStyleBackColor = true;
            cb_Gpu_princpal.CheckedChanged += cb_GpuPrincpal_CheckedChanged;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lb_TransPrincipal);
            groupBox5.Controls.Add(tb_TranspPrincipal);
            groupBox5.Location = new Point(12, 26);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(354, 59);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Transparência";
            // 
            // lb_TransPrincipal
            // 
            lb_TransPrincipal.AutoSize = true;
            lb_TransPrincipal.ForeColor = SystemColors.GrayText;
            lb_TransPrincipal.Location = new Point(303, 25);
            lb_TransPrincipal.Name = "lb_TransPrincipal";
            lb_TransPrincipal.Size = new Size(21, 20);
            lb_TransPrincipal.TabIndex = 1;
            lb_TransPrincipal.Text = "%";
            // 
            // tb_TranspPrincipal
            // 
            tb_TranspPrincipal.Dock = DockStyle.Left;
            tb_TranspPrincipal.Location = new Point(3, 23);
            tb_TranspPrincipal.Maximum = 90;
            tb_TranspPrincipal.Name = "tb_TranspPrincipal";
            tb_TranspPrincipal.Size = new Size(279, 33);
            tb_TranspPrincipal.TabIndex = 0;
            tb_TranspPrincipal.TickFrequency = 10;
            tb_TranspPrincipal.Value = 90;
            tb_TranspPrincipal.MouseCaptureChanged += tb_TranspPrincipal_MouseCaptureChanged;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(groupBox3);
            groupBox7.Controls.Add(groupBox8);
            groupBox7.Controls.Add(groupBox9);
            groupBox7.Location = new Point(12, 364);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(391, 257);
            groupBox7.TabIndex = 2;
            groupBox7.TabStop = false;
            groupBox7.Text = "Gráfico";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(nud_UniGrafico);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(nud_IntGrafico);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(12, 155);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(360, 87);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Valores";
            // 
            // nud_UniGrafico
            // 
            nud_UniGrafico.Location = new Point(229, 53);
            nud_UniGrafico.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            nud_UniGrafico.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            nud_UniGrafico.Name = "nud_UniGrafico";
            nud_UniGrafico.Size = new Size(117, 27);
            nud_UniGrafico.TabIndex = 6;
            nud_UniGrafico.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            nud_UniGrafico.ValueChanged += nud_UniGrafico_ValueChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(6, 54);
            label3.Name = "label3";
            label3.Size = new Size(153, 20);
            label3.TabIndex = 5;
            label3.Text = "Unidades no histórico";
            // 
            // nud_IntGrafico
            // 
            nud_IntGrafico.Anchor = AnchorStyles.Right;
            nud_IntGrafico.Location = new Point(229, 21);
            nud_IntGrafico.Maximum = new decimal(new int[] { 3600000, 0, 0, 0 });
            nud_IntGrafico.Minimum = new decimal(new int[] { 55, 0, 0, 0 });
            nud_IntGrafico.Name = "nud_IntGrafico";
            nud_IntGrafico.Size = new Size(117, 27);
            nud_IntGrafico.TabIndex = 4;
            nud_IntGrafico.Value = new decimal(new int[] { 55, 0, 0, 0 });
            nud_IntGrafico.ValueChanged += nud_IntGrafico_ValueChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(6, 23);
            label2.Name = "label2";
            label2.Size = new Size(217, 20);
            label2.TabIndex = 3;
            label2.Text = "Velocidade de atualização (ms)";
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(cb_Ram_Grafico);
            groupBox8.Controls.Add(cb_Cpu_Grafico);
            groupBox8.Controls.Add(cb_Gpu_Grafico);
            groupBox8.Location = new Point(12, 91);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(354, 58);
            groupBox8.TabIndex = 1;
            groupBox8.TabStop = false;
            groupBox8.Text = "Medições";
            // 
            // cb_Ram_Grafico
            // 
            cb_Ram_Grafico.AutoSize = true;
            cb_Ram_Grafico.Location = new Point(283, 26);
            cb_Ram_Grafico.Name = "cb_Ram_Grafico";
            cb_Ram_Grafico.Size = new Size(63, 24);
            cb_Ram_Grafico.TabIndex = 2;
            cb_Ram_Grafico.Text = "RAM";
            cb_Ram_Grafico.UseVisualStyleBackColor = true;
            cb_Ram_Grafico.CheckedChanged += cb_Ram_Grafico_CheckedChanged;
            // 
            // cb_Cpu_Grafico
            // 
            cb_Cpu_Grafico.AutoSize = true;
            cb_Cpu_Grafico.Location = new Point(6, 28);
            cb_Cpu_Grafico.Name = "cb_Cpu_Grafico";
            cb_Cpu_Grafico.Size = new Size(58, 24);
            cb_Cpu_Grafico.TabIndex = 1;
            cb_Cpu_Grafico.Text = "CPU";
            cb_Cpu_Grafico.UseVisualStyleBackColor = true;
            cb_Cpu_Grafico.CheckedChanged += cb_Cpu_Grafico_CheckedChanged;
            // 
            // cb_Gpu_Grafico
            // 
            cb_Gpu_Grafico.AutoSize = true;
            cb_Gpu_Grafico.Location = new Point(150, 28);
            cb_Gpu_Grafico.Name = "cb_Gpu_Grafico";
            cb_Gpu_Grafico.Size = new Size(59, 24);
            cb_Gpu_Grafico.TabIndex = 0;
            cb_Gpu_Grafico.Text = "GPU";
            cb_Gpu_Grafico.UseVisualStyleBackColor = true;
            cb_Gpu_Grafico.CheckedChanged += cb_Gpu_Grafico_CheckedChanged;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(lb_TranspGrafico);
            groupBox9.Controls.Add(tb_TransGrafico);
            groupBox9.Location = new Point(12, 26);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(354, 59);
            groupBox9.TabIndex = 0;
            groupBox9.TabStop = false;
            groupBox9.Text = "Transparência";
            // 
            // lb_TranspGrafico
            // 
            lb_TranspGrafico.AutoSize = true;
            lb_TranspGrafico.ForeColor = SystemColors.GrayText;
            lb_TranspGrafico.Location = new Point(303, 26);
            lb_TranspGrafico.Name = "lb_TranspGrafico";
            lb_TranspGrafico.Size = new Size(21, 20);
            lb_TranspGrafico.TabIndex = 3;
            lb_TranspGrafico.Text = "%";
            // 
            // tb_TransGrafico
            // 
            tb_TransGrafico.Dock = DockStyle.Left;
            tb_TransGrafico.Location = new Point(3, 23);
            tb_TransGrafico.Maximum = 90;
            tb_TransGrafico.Name = "tb_TransGrafico";
            tb_TransGrafico.Size = new Size(279, 33);
            tb_TransGrafico.TabIndex = 2;
            tb_TransGrafico.TickFrequency = 10;
            tb_TransGrafico.MouseCaptureChanged += tb_TransGrafico_MouseCaptureChanged;
            // 
            // bt_Aplicar
            // 
            bt_Aplicar.Location = new Point(307, 627);
            bt_Aplicar.Name = "bt_Aplicar";
            bt_Aplicar.Size = new Size(94, 29);
            bt_Aplicar.TabIndex = 3;
            bt_Aplicar.Text = "Aplicar";
            bt_Aplicar.UseVisualStyleBackColor = true;
            bt_Aplicar.Click += bt_Aplicar_Click;
            // 
            // bt_Cancelar
            // 
            bt_Cancelar.Location = new Point(207, 627);
            bt_Cancelar.Name = "bt_Cancelar";
            bt_Cancelar.Size = new Size(94, 29);
            bt_Cancelar.TabIndex = 4;
            bt_Cancelar.Text = "Cancelar";
            bt_Cancelar.UseVisualStyleBackColor = true;
            bt_Cancelar.Click += bt_Cancelar_Click;
            // 
            // F_Confi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 664);
            Controls.Add(bt_Cancelar);
            Controls.Add(bt_Aplicar);
            Controls.Add(groupBox7);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Name = "F_Confi";
            Text = "F_Confi";
            TopMost = true;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_IntPrincipal).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tb_TranspPrincipal).EndInit();
            groupBox7.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_UniGrafico).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_IntGrafico).EndInit();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tb_TransGrafico).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox cb_IniciarWindows;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private CheckBox cb_Gpu_princpal;
        private CheckBox cb_ram_principal;
        private CheckBox cb_Cpu_principal;
        private GroupBox groupBox7;
        private GroupBox groupBox8;
        private CheckBox cb_Ram_Grafico;
        private CheckBox cb_Cpu_Grafico;
        private CheckBox cb_Gpu_Grafico;
        private GroupBox groupBox9;
        private Button bt_Aplicar;
        private Button bt_Cancelar;
        private Label lb_TransPrincipal;
        private TrackBar tb_TranspPrincipal;
        private Label lb_TranspGrafico;
        private TrackBar tb_TransGrafico;
        private GroupBox groupBox10;
        private NumericUpDown nud_IntPrincipal;
        private Label label1;
        private GroupBox groupBox3;
        private NumericUpDown nud_IntGrafico;
        private Label label2;
        private Label label3;
        private NumericUpDown nud_UniGrafico;
    }
}