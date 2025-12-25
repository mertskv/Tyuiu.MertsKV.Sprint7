namespace Tyuiu.MertsKV.Sprint7.Project.V13
{
    partial class FormStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartDiag_MKV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartDiag_MKV).BeginInit();
            SuspendLayout();
            // 
            // chartDiag_MKV
            // 
            chartArea1.Name = "ChartArea1";
            chartDiag_MKV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartDiag_MKV.Legends.Add(legend1);
            chartDiag_MKV.Location = new Point(102, 30);
            chartDiag_MKV.Name = "chartDiag_MKV";
            chartDiag_MKV.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDiag_MKV.Series.Add(series1);
            chartDiag_MKV.Size = new Size(558, 508);
            chartDiag_MKV.TabIndex = 0;
            chartDiag_MKV.Text = "chart1";
            // 
            // FormStatistics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 618);
            Controls.Add(chartDiag_MKV);
            Name = "FormStatistics";
            Text = "Диаграммы";
            Load += FormStatistics_Load;
            ((System.ComponentModel.ISupportInitialize)chartDiag_MKV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_MKV;
    }
}