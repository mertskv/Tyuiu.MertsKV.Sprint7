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
using Tyuiu.MertsKV.Sprint7.Project.V13.Lib;


namespace Tyuiu.MertsKV.Sprint7.Project.V13
{


    public partial class FormStatistics : Form
    {
        private List<Country> countries;
        private DataService ds = new DataService();

        
        public FormStatistics()
        {
            InitializeComponent();

            
            this.countries = new List<Country>();

            // созд тестовых данных
            CreateTestData();

            // созд диаг
            CreateSimpleDoughnutChart();
        }

        
        public FormStatistics(List<Country> countries)
        {
            InitializeComponent();
            this.countries = countries;
            CreateSimpleDoughnutChart();
        }

        private void CreateTestData()
        {
            
            countries = new List<Country>();

            //  17 развитых стран
            for (int i = 1; i <= 17; i++)
            {
                countries.Add(new Country
                {
                    Name = $"Развитая страна {i}",
                    IsDeveloped = true
                });
            }

            //  13 развивающихся стран
            for (int i = 1; i <= 13; i++)
            {
                countries.Add(new Country
                {
                    Name = $"Развивающаяся страна {i}",
                    IsDeveloped = false
                });
            }
        }

        private void CreateSimpleDoughnutChart()
        {
            try
            {
                // проверка chartCountries_MKV существования
                if (chartCountries_MKV == null)
                {
                    MessageBox.Show("Chart контрол не найден на форме!", "Ошибка");
                    return;
                }

                // очистка диагр
                chartCountries_MKV.Series.Clear();
                chartCountries_MKV.Titles.Clear();
                chartCountries_MKV.ChartAreas.Clear(); 

                
                if (chartCountries_MKV.ChartAreas.Count == 0)
                {
                    ChartArea chartArea = new ChartArea();
                    chartArea.Name = "ChartArea1";
                    chartCountries_MKV.ChartAreas.Add(chartArea);
                }

                // заголовок
                chartCountries_MKV.Titles.Add("Распределение по экономическому развитию");
                chartCountries_MKV.Titles[0].Font = new Font("Arial", 14, FontStyle.Bold);
                chartCountries_MKV.Titles[0].ForeColor = Color.DarkBlue;

                // созд серии
                Series series = new Series();
                series.Name = "Экономическое развитие";
                series.ChartType = SeriesChartType.Doughnut;
                series.IsValueShownAsLabel = true;

                // исп данные из списка стран
                int developed = 0;
                int developing = 0;

                if (countries != null && countries.Count > 0)
                {
                    developed = countries.Count(c => c.IsDeveloped);
                    developing = countries.Count - developed;
                }
                else
                {
                    
                    developed = 17;
                    developing = 13;
                }

                int total = developed + developing;

                // добавляем данные
                series.Points.AddXY("Развитые", developed);
                series.Points.AddXY("Развивающиеся", developing);

                // настройка внеш вида
                series.Label = "#VALX\n#VALY (#PERCENT{P1})";
                series.Font = new Font("Arial", 9, FontStyle.Bold);
                series.LabelForeColor = Color.Black;

                
                series.Points[0].Color = Color.FromArgb(76, 175, 80); 
                series.Points[1].Color = Color.FromArgb(255, 255, 0); 

                // толщина кольца 
                series["DoughnutRadius"] = "50";

                // 3D эффект
                chartCountries_MKV.ChartAreas[0].Area3DStyle.Enable3D = true;
                chartCountries_MKV.ChartAreas[0].Area3DStyle.Inclination = 40;

                // добавляем на диаграмму
                chartCountries_MKV.Series.Add(series);

                // легенда
                Legend legend = new Legend();
                legend.Docking = Docking.Bottom;
                legend.Alignment = StringAlignment.Center;
                chartCountries_MKV.Legends.Add(legend);

                // обновление
                chartCountries_MKV.Update();
                chartCountries_MKV.Refresh();

                //инфо
                MessageBox.Show($"Диаграмма создана!\nРазвитые страны: {developed}\nРазвивающиеся страны: {developing}\nВсего: {total}",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании диаграммы: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // метод  обновления диаграммы
        private void buttonUpdateChart_MKV_Click(object sender, EventArgs e)
        {
            CreateSimpleDoughnutChart();
        }

       
        private void buttonOk_MKV_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void FormStatistics_Load(object sender, EventArgs e)
        {
            this.Text = $"Статистика стран";
        }
        
        
    }
}
