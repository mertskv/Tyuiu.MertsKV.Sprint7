
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
            chartCountries_MKV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBoxName_MKV = new TextBox();
            textBoxCapital_MKV = new TextBox();
            textBoxArea_MKV = new TextBox();
            textBoxPopulation_MKV = new TextBox();
            textBoxDensity_MKV = new TextBox();
            textBoxNationality_MKV = new TextBox();
            textBoxDeveloped_MKV = new TextBox();
            textBoxCountRes_MKV = new TextBox();
            textBoxAvgPop_MKV = new TextBox();
            textBoxMinAreaRes_MKV = new TextBox();
            textBoxMaxAreaRes_MKV = new TextBox();
            textBoxDevRes_MKV = new TextBox();
            textBoxDevingRes_MKV = new TextBox();
            textBoxDS_MKV = new TextBox();
            buttonOk_MKV = new Button();
            ((System.ComponentModel.ISupportInitialize)chartCountries_MKV).BeginInit();
            SuspendLayout();
            // 
            // chartCountries_MKV
            // 
            chartArea1.Name = "ChartArea1";
            chartCountries_MKV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartCountries_MKV.Legends.Add(legend1);
            chartCountries_MKV.Location = new Point(515, 39);
            chartCountries_MKV.Name = "chartCountries_MKV";
            chartCountries_MKV.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartCountries_MKV.Series.Add(series1);
            chartCountries_MKV.Size = new Size(558, 508);
            chartCountries_MKV.TabIndex = 0;
            chartCountries_MKV.Text = "chart1";
            // 
            // textBoxName_MKV
            // 
            textBoxName_MKV.BorderStyle = BorderStyle.FixedSingle;
            textBoxName_MKV.Location = new Point(22, 39);
            textBoxName_MKV.Name = "textBoxName_MKV";
            textBoxName_MKV.ReadOnly = true;
            textBoxName_MKV.Size = new Size(192, 27);
            textBoxName_MKV.TabIndex = 1;
            textBoxName_MKV.Text = "Количество стран:";
            // 
            // textBoxCapital_MKV
            // 
            textBoxCapital_MKV.BorderStyle = BorderStyle.FixedSingle;
            textBoxCapital_MKV.Location = new Point(22, 96);
            textBoxCapital_MKV.Multiline = true;
            textBoxCapital_MKV.Name = "textBoxCapital_MKV";
            textBoxCapital_MKV.ReadOnly = true;
            textBoxCapital_MKV.Size = new Size(192, 46);
            textBoxCapital_MKV.TabIndex = 1;
            textBoxCapital_MKV.Text = "Среднее количество населения:";
            // 
            // textBoxArea_MKV
            // 
            textBoxArea_MKV.BorderStyle = BorderStyle.FixedSingle;
            textBoxArea_MKV.Location = new Point(22, 180);
            textBoxArea_MKV.Multiline = true;
            textBoxArea_MKV.Name = "textBoxArea_MKV";
            textBoxArea_MKV.ReadOnly = true;
            textBoxArea_MKV.Size = new Size(192, 48);
            textBoxArea_MKV.TabIndex = 1;
            textBoxArea_MKV.Text = "Минимальная площадь территории:";
            // 
            // textBoxPopulation_MKV
            // 
            textBoxPopulation_MKV.BorderStyle = BorderStyle.FixedSingle;
            textBoxPopulation_MKV.Location = new Point(22, 264);
            textBoxPopulation_MKV.Multiline = true;
            textBoxPopulation_MKV.Name = "textBoxPopulation_MKV";
            textBoxPopulation_MKV.ReadOnly = true;
            textBoxPopulation_MKV.Size = new Size(192, 44);
            textBoxPopulation_MKV.TabIndex = 1;
            textBoxPopulation_MKV.Text = "Максимальная площадь территории:";
            // 
            // textBoxDensity_MKV
            // 
            textBoxDensity_MKV.BorderStyle = BorderStyle.FixedSingle;
            textBoxDensity_MKV.Location = new Point(22, 344);
            textBoxDensity_MKV.Multiline = true;
            textBoxDensity_MKV.Name = "textBoxDensity_MKV";
            textBoxDensity_MKV.ReadOnly = true;
            textBoxDensity_MKV.Size = new Size(192, 44);
            textBoxDensity_MKV.TabIndex = 1;
            textBoxDensity_MKV.Text = "Количество развитых стран:";
            // 
            // textBoxNationality_MKV
            // 
            textBoxNationality_MKV.BorderStyle = BorderStyle.FixedSingle;
            textBoxNationality_MKV.Location = new Point(22, 421);
            textBoxNationality_MKV.Multiline = true;
            textBoxNationality_MKV.Name = "textBoxNationality_MKV";
            textBoxNationality_MKV.ReadOnly = true;
            textBoxNationality_MKV.Size = new Size(192, 49);
            textBoxNationality_MKV.TabIndex = 1;
            textBoxNationality_MKV.Text = "Количество развивающихся стран:";
            // 
            // textBoxDeveloped_MKV
            // 
            textBoxDeveloped_MKV.BorderStyle = BorderStyle.FixedSingle;
            textBoxDeveloped_MKV.Location = new Point(22, 500);
            textBoxDeveloped_MKV.Multiline = true;
            textBoxDeveloped_MKV.Name = "textBoxDeveloped_MKV";
            textBoxDeveloped_MKV.ReadOnly = true;
            textBoxDeveloped_MKV.Size = new Size(192, 47);
            textBoxDeveloped_MKV.TabIndex = 1;
            textBoxDeveloped_MKV.Text = "Общая плотность населения данных стран:";
            // 
            // textBoxCountRes_MKV
            // 
            textBoxCountRes_MKV.BorderStyle = BorderStyle.FixedSingle;
            textBoxCountRes_MKV.Location = new Point(264, 39);
            textBoxCountRes_MKV.Name = "textBoxCountRes_MKV";
            textBoxCountRes_MKV.ReadOnly = true;
            textBoxCountRes_MKV.Size = new Size(142, 27);
            textBoxCountRes_MKV.TabIndex = 2;
            textBoxCountRes_MKV.Text = "30";
            // 
            // textBoxAvgPop_MKV
            // 
            textBoxAvgPop_MKV.BorderStyle = BorderStyle.FixedSingle;
            textBoxAvgPop_MKV.Location = new Point(264, 96);
            textBoxAvgPop_MKV.Multiline = true;
            textBoxAvgPop_MKV.Name = "textBoxAvgPop_MKV";
            textBoxAvgPop_MKV.ReadOnly = true;
            textBoxAvgPop_MKV.Size = new Size(142, 46);
            textBoxAvgPop_MKV.TabIndex = 2;
            textBoxAvgPop_MKV.Text = "194,728,205 человек";
            // 
            // textBoxMinAreaRes_MKV
            // 
            textBoxMinAreaRes_MKV.BorderStyle = BorderStyle.FixedSingle;
            textBoxMinAreaRes_MKV.Location = new Point(264, 180);
            textBoxMinAreaRes_MKV.Multiline = true;
            textBoxMinAreaRes_MKV.Name = "textBoxMinAreaRes_MKV";
            textBoxMinAreaRes_MKV.ReadOnly = true;
            textBoxMinAreaRes_MKV.Size = new Size(142, 48);
            textBoxMinAreaRes_MKV.TabIndex = 2;
            textBoxMinAreaRes_MKV.Text = "30,528 км²";
            // 
            // textBoxMaxAreaRes_MKV
            // 
            textBoxMaxAreaRes_MKV.BorderStyle = BorderStyle.FixedSingle;
            textBoxMaxAreaRes_MKV.Location = new Point(264, 263);
            textBoxMaxAreaRes_MKV.Multiline = true;
            textBoxMaxAreaRes_MKV.Name = "textBoxMaxAreaRes_MKV";
            textBoxMaxAreaRes_MKV.ReadOnly = true;
            textBoxMaxAreaRes_MKV.Size = new Size(142, 44);
            textBoxMaxAreaRes_MKV.TabIndex = 2;
            textBoxMaxAreaRes_MKV.Text = "7,125,191 км²";
            // 
            // textBoxDevRes_MKV
            // 
            textBoxDevRes_MKV.BorderStyle = BorderStyle.FixedSingle;
            textBoxDevRes_MKV.Location = new Point(264, 343);
            textBoxDevRes_MKV.Multiline = true;
            textBoxDevRes_MKV.Name = "textBoxDevRes_MKV";
            textBoxDevRes_MKV.ReadOnly = true;
            textBoxDevRes_MKV.Size = new Size(142, 45);
            textBoxDevRes_MKV.TabIndex = 2;
            textBoxDevRes_MKV.Text = "17";
            // 
            // textBoxDevingRes_MKV
            // 
            textBoxDevingRes_MKV.BorderStyle = BorderStyle.FixedSingle;
            textBoxDevingRes_MKV.Location = new Point(264, 420);
            textBoxDevingRes_MKV.Multiline = true;
            textBoxDevingRes_MKV.Name = "textBoxDevingRes_MKV";
            textBoxDevingRes_MKV.ReadOnly = true;
            textBoxDevingRes_MKV.Size = new Size(142, 50);
            textBoxDevingRes_MKV.TabIndex = 2;
            textBoxDevingRes_MKV.Text = "13";
            // 
            // textBoxDS_MKV
            // 
            textBoxDS_MKV.BorderStyle = BorderStyle.FixedSingle;
            textBoxDS_MKV.Location = new Point(264, 500);
            textBoxDS_MKV.Multiline = true;
            textBoxDS_MKV.Name = "textBoxDS_MKV";
            textBoxDS_MKV.ReadOnly = true;
            textBoxDS_MKV.Size = new Size(142, 47);
            textBoxDS_MKV.TabIndex = 2;
            textBoxDS_MKV.Text = "168.4 чел/км²";
            // 
            // buttonOk_MKV
            // 
            buttonOk_MKV.FlatStyle = FlatStyle.Popup;
            buttonOk_MKV.Location = new Point(767, 570);
            buttonOk_MKV.Name = "buttonOk_MKV";
            buttonOk_MKV.Size = new Size(172, 55);
            buttonOk_MKV.TabIndex = 3;
            buttonOk_MKV.Text = "Ок";
            buttonOk_MKV.UseVisualStyleBackColor = true;
            buttonOk_MKV.Click += buttonOk_MKV_Click;
            // 
            // FormStatistics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 637);
            Controls.Add(buttonOk_MKV);
            Controls.Add(textBoxDS_MKV);
            Controls.Add(textBoxDevingRes_MKV);
            Controls.Add(textBoxDevRes_MKV);
            Controls.Add(textBoxMaxAreaRes_MKV);
            Controls.Add(textBoxMinAreaRes_MKV);
            Controls.Add(textBoxAvgPop_MKV);
            Controls.Add(textBoxCountRes_MKV);
            Controls.Add(textBoxPopulation_MKV);
            Controls.Add(textBoxArea_MKV);
            Controls.Add(textBoxCapital_MKV);
            Controls.Add(textBoxDensity_MKV);
            Controls.Add(textBoxNationality_MKV);
            Controls.Add(textBoxDeveloped_MKV);
            Controls.Add(textBoxName_MKV);
            Controls.Add(chartCountries_MKV);
            MaximizeBox = false;
            MaximumSize = new Size(1116, 684);
            MinimumSize = new Size(1116, 684);
            Name = "FormStatistics";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Диаграммы";
            Load += FormStatistics_Load;
            ((System.ComponentModel.ISupportInitialize)chartCountries_MKV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartCountries_MKV;
        private TextBox textBoxName_MKV;
        private TextBox textBoxCapital_MKV;
        private TextBox textBoxArea_MKV;
        private TextBox textBoxPopulation_MKV;
        private TextBox textBoxDensity_MKV;
        private TextBox textBoxNationality_MKV;
        private TextBox textBoxDeveloped_MKV;
        private TextBox textBoxCountRes_MKV;
        private TextBox textBoxAvgPop_MKV;
        private TextBox textBoxMinAreaRes_MKV;
        private TextBox textBoxMaxAreaRes_MKV;
        private TextBox textBoxDevRes_MKV;
        private TextBox textBoxDevingRes_MKV;
        private TextBox textBoxDS_MKV;
        private Button buttonOk_MKV;
    }
}