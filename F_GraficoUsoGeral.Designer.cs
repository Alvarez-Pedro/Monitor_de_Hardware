namespace WinFormsApp1
{
    partial class F_GraficoUsoGeral
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            ch_UsoGeral = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tm_1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)ch_UsoGeral).BeginInit();
            SuspendLayout();
            // 
            // ch_UsoGeral
            // 
            ch_UsoGeral.BackColor = Color.Gray;
            ch_UsoGeral.BorderlineColor = Color.Gray;
            chartArea1.Name = "ChartArea1";
            ch_UsoGeral.ChartAreas.Add(chartArea1);
            ch_UsoGeral.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            ch_UsoGeral.Legends.Add(legend1);
            ch_UsoGeral.Location = new Point(0, 0);
            ch_UsoGeral.Name = "ch_UsoGeral";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            ch_UsoGeral.Series.Add(series1);
            ch_UsoGeral.Size = new Size(800, 140);
            ch_UsoGeral.TabIndex = 0;
            ch_UsoGeral.Text = "chart1";
            // 
            // tm_1
            // 
            tm_1.Tick += tm_1_Tick;
            // 
            // F_GraficoUsoGeral
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 140);
            Controls.Add(ch_UsoGeral);
            FormBorderStyle = FormBorderStyle.None;
            Name = "F_GraficoUsoGeral";
            Text = "F_GraficoUsoGeral";
            TopMost = true;
            Load += F_GraficoUsoGeral_Load;
            ((System.ComponentModel.ISupportInitialize)ch_UsoGeral).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ch_UsoGeral;
        private System.Windows.Forms.Timer tm_1;
    }
}