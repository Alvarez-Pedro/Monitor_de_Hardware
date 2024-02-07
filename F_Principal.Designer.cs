namespace WinFormsApp1
{
    partial class F_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tm_1 = new System.Windows.Forms.Timer(components);
            lb_usoCpu = new Label();
            lb_usoRam = new Label();
            lb_usoGpu = new Label();
            lb_nomeCpu = new Label();
            lb_nomeGpu = new Label();
            lb_nomeRam = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            pb_Gpu = new ProgressBar();
            pb_Cpu = new ProgressBar();
            pb_Ram = new ProgressBar();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            menuStrip1 = new MenuStrip();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            gráficosToolStripMenuItem = new ToolStripMenuItem();
            usoGeralToolStripMenuItem = new ToolStripMenuItem();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel2 = new TableLayoutPanel();
            lb_NomeForm = new Label();
            tableLayoutPanel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tm_1
            // 
            tm_1.Enabled = true;
            tm_1.Interval = 1000;
            tm_1.Tick += timer1_Tick;
            // 
            // lb_usoCpu
            // 
            lb_usoCpu.AutoSize = true;
            lb_usoCpu.Font = new Font("Segoe UI", 10F);
            lb_usoCpu.Location = new Point(3, 54);
            lb_usoCpu.Name = "lb_usoCpu";
            lb_usoCpu.Size = new Size(49, 23);
            lb_usoCpu.TabIndex = 0;
            lb_usoCpu.Text = "     %";
            // 
            // lb_usoRam
            // 
            lb_usoRam.AutoSize = true;
            lb_usoRam.Font = new Font("Segoe UI", 10F);
            lb_usoRam.Location = new Point(535, 54);
            lb_usoRam.Name = "lb_usoRam";
            lb_usoRam.Size = new Size(65, 23);
            lb_usoRam.TabIndex = 1;
            lb_usoRam.Text = "      MB";
            // 
            // lb_usoGpu
            // 
            lb_usoGpu.AutoSize = true;
            lb_usoGpu.Font = new Font("Segoe UI", 10F);
            lb_usoGpu.Location = new Point(269, 54);
            lb_usoGpu.Name = "lb_usoGpu";
            lb_usoGpu.Size = new Size(49, 23);
            lb_usoGpu.TabIndex = 2;
            lb_usoGpu.Text = "     %";
            // 
            // lb_nomeCpu
            // 
            lb_nomeCpu.AutoSize = true;
            lb_nomeCpu.Dock = DockStyle.Fill;
            lb_nomeCpu.Font = new Font("Segoe UI", 12F);
            lb_nomeCpu.Location = new Point(3, 0);
            lb_nomeCpu.Name = "lb_nomeCpu";
            lb_nomeCpu.Size = new Size(260, 28);
            lb_nomeCpu.TabIndex = 3;
            lb_nomeCpu.Text = "CPU";
            // 
            // lb_nomeGpu
            // 
            lb_nomeGpu.AutoSize = true;
            lb_nomeGpu.Dock = DockStyle.Fill;
            lb_nomeGpu.Font = new Font("Segoe UI", 12F);
            lb_nomeGpu.Location = new Point(269, 0);
            lb_nomeGpu.Name = "lb_nomeGpu";
            lb_nomeGpu.Size = new Size(260, 28);
            lb_nomeGpu.TabIndex = 4;
            lb_nomeGpu.Text = "GPU";
            // 
            // lb_nomeRam
            // 
            lb_nomeRam.AutoSize = true;
            lb_nomeRam.Font = new Font("Segoe UI", 12F);
            lb_nomeRam.Location = new Point(535, 0);
            lb_nomeRam.Name = "lb_nomeRam";
            lb_nomeRam.Size = new Size(55, 28);
            lb_nomeRam.TabIndex = 5;
            lb_nomeRam.Text = "RAM";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ActiveBorder;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(pb_Gpu, 1, 1);
            tableLayoutPanel1.Controls.Add(lb_nomeCpu, 0, 0);
            tableLayoutPanel1.Controls.Add(lb_nomeGpu, 1, 0);
            tableLayoutPanel1.Controls.Add(lb_usoCpu, 0, 2);
            tableLayoutPanel1.Controls.Add(lb_usoGpu, 1, 2);
            tableLayoutPanel1.Controls.Add(pb_Cpu, 0, 1);
            tableLayoutPanel1.Controls.Add(lb_usoRam, 2, 2);
            tableLayoutPanel1.Controls.Add(pb_Ram, 2, 1);
            tableLayoutPanel1.Controls.Add(lb_nomeRam, 2, 0);
            tableLayoutPanel1.Location = new Point(0, 38);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(800, 79);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // pb_Gpu
            // 
            pb_Gpu.Dock = DockStyle.Fill;
            pb_Gpu.Location = new Point(269, 31);
            pb_Gpu.Name = "pb_Gpu";
            pb_Gpu.Size = new Size(260, 20);
            pb_Gpu.TabIndex = 7;
            // 
            // pb_Cpu
            // 
            pb_Cpu.Dock = DockStyle.Fill;
            pb_Cpu.Location = new Point(3, 31);
            pb_Cpu.Name = "pb_Cpu";
            pb_Cpu.Size = new Size(260, 20);
            pb_Cpu.TabIndex = 6;
            // 
            // pb_Ram
            // 
            pb_Ram.Dock = DockStyle.Fill;
            pb_Ram.Location = new Point(535, 31);
            pb_Ram.Name = "pb_Ram";
            pb_Ram.Size = new Size(262, 20);
            pb_Ram.TabIndex = 8;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlDarkDark;
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { abrirToolStripMenuItem, configuraçõesToolStripMenuItem });
            menuStrip1.Location = new Point(571, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(229, 36);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            abrirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gráficosToolStripMenuItem });
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(60, 32);
            abrirToolStripMenuItem.Text = "Exibir";
            // 
            // gráficosToolStripMenuItem
            // 
            gráficosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usoGeralToolStripMenuItem });
            gráficosToolStripMenuItem.Name = "gráficosToolStripMenuItem";
            gráficosToolStripMenuItem.Size = new Size(146, 26);
            gráficosToolStripMenuItem.Text = "Gráficos";
            // 
            // usoGeralToolStripMenuItem
            // 
            usoGeralToolStripMenuItem.CheckOnClick = true;
            usoGeralToolStripMenuItem.Name = "usoGeralToolStripMenuItem";
            usoGeralToolStripMenuItem.Size = new Size(156, 26);
            usoGeralToolStripMenuItem.Text = "Uso Geral";
            usoGeralToolStripMenuItem.CheckedChanged += usoGeralToolStripMenuItem_CheckedChanged;
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(118, 32);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            configuraçõesToolStripMenuItem.Click += configuraçõesToolStripMenuItem_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.ControlDarkDark;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.42857F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.5714283F));
            tableLayoutPanel2.Controls.Add(menuStrip1, 1, 0);
            tableLayoutPanel2.Controls.Add(lb_NomeForm, 0, 0);
            tableLayoutPanel2.Font = new Font("Segoe UI", 10F);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(800, 36);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // lb_NomeForm
            // 
            lb_NomeForm.Anchor = AnchorStyles.Left;
            lb_NomeForm.AutoSize = true;
            lb_NomeForm.Font = new Font("Segoe UI", 9.5F);
            lb_NomeForm.Location = new Point(3, 7);
            lb_NomeForm.Name = "lb_NomeForm";
            lb_NomeForm.Size = new Size(159, 21);
            lb_NomeForm.TabIndex = 8;
            lb_NomeForm.Text = "Monitor de Hardware";
            lb_NomeForm.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 117);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            TopMost = true;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lb_usoCpu;
        private Label lb_usoRam;
        private Label lb_usoGpu;
        private Label lb_nomeCpu;
        private Label lb_nomeGpu;
        private Label lb_nomeRam;
        private TableLayoutPanel tableLayoutPanel1;
        private ProgressBar pb_Gpu;
        private ProgressBar pb_Cpu;
        private ProgressBar pb_Ram;
        //private System.Windows.Forms.DataVisualization.Charting.Chart ch_usoCpu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch_Geral;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lb_NomeForm;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem gráficosToolStripMenuItem;
        private ToolStripMenuItem usoGeralToolStripMenuItem;
        private Button button1;
        public System.Windows.Forms.Timer tm_1;
    }
}
