using System.Collections.Generic;
using Microsoft.VisualBasic;
using System.Linq;
using Tyuiu.MertsKV.Sprint7.Project.V13.Lib;
using System.Windows.Forms;
using System.IO;
namespace Tyuiu.MertsKV.Sprint7.Project.V13
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
            SetupDataGridView();
            dataGridViewGeography_MKV.AutoGenerateColumns = true;
            dataGridViewGeography_MKV.AllowUserToAddRows = false;
            dataGridViewGeography_MKV.ReadOnly = false;
        }

        private void SetupDataGridView()
        {
            dataGridViewGeography_MKV.DataSource = ds.Countries;
            dataGridViewGeography_MKV.Columns["Name"].HeaderText = "Название страны";
            dataGridViewGeography_MKV.Columns["Capital"].HeaderText = "Столица";
            dataGridViewGeography_MKV.Columns["Area"].HeaderText = "Площадь (км²)";
            dataGridViewGeography_MKV.Columns["Population"].HeaderText = "Население";
            dataGridViewGeography_MKV.Columns["Population_density"].HeaderText = "Плотность ";
            dataGridViewGeography_MKV.Columns["MainNationality"].HeaderText = "Национальность";
            dataGridViewGeography_MKV.Columns["IsDeveloped"].HeaderText = "Развитая";

            //  ширину колонок
            dataGridViewGeography_MKV.Columns["Name"].Width = 120;
            dataGridViewGeography_MKV.Columns["Capital"].Width = 120;
            dataGridViewGeography_MKV.Columns["Area"].Width = 100;
            dataGridViewGeography_MKV.Columns["Population"].Width = 120;
            dataGridViewGeography_MKV.Columns["Population_density"].Width = 100;
            dataGridViewGeography_MKV.Columns["MainNationality"].Width = 150;
            dataGridViewGeography_MKV.Columns["IsDeveloped"].Width = 200;
        }

        private void SelectRow(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < dataGridViewGeography_MKV.Rows.Count)
            {
                dataGridViewGeography_MKV.ClearSelection();
                dataGridViewGeography_MKV.Rows[rowIndex].Selected = true;

            }
        }
        private void buttonOpenFile_MKV_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogProject_MKV.Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*";

                if (openFileDialogProject_MKV.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialogProject_MKV.FileName;

                    // проверка сущ файла
                    if (!System.IO.File.Exists(filePath))
                    {
                        MessageBox.Show($"Файл не найден:\n{filePath}",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    ds.LoadFromCsv(filePath);

                    MessageBox.Show($"Данные загружены успешно!\n" +
                                  $"Загружено записей: {ds.Countries.Count}",
                                  "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                
                string errorMessage = $"Ошибка при загрузке файла:\n\n" +
                                     $"Сообщение: {ex.Message}\n" +
                                     $"Тип ошибки: {ex.GetType().Name}\n";

                if (ex.InnerException != null)
                {
                    errorMessage += $"Внутренняя ошибка: {ex.InnerException.Message}\n";
                }

                MessageBox.Show(errorMessage +
                               $"\nПроверьте:\n" +
                               $"1. Файл должен быть в формате CSV\n" +
                               $"2. Разделитель - точка с запятой (;)\n" +
                               $"3. Должно быть 7 колонок данных",
                               "Ошибка загрузки", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeDataGridViewColumns_MKV()
        {
            // очищаем сущ колонки
            dataGridViewGeography_MKV.Columns.Clear();

            
            dataGridViewGeography_MKV.Columns.Add("ColumnName_MKV", "Название страны");
            dataGridViewGeography_MKV.Columns[0].Width = 150;

            dataGridViewGeography_MKV.Columns.Add("ColumnCapital_MKV", "Столица");
            dataGridViewGeography_MKV.Columns[1].Width = 120;

            dataGridViewGeography_MKV.Columns.Add("ColumnArea_MKV", "Площадь, км²");
            dataGridViewGeography_MKV.Columns[2].Width = 100;
            dataGridViewGeography_MKV.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewGeography_MKV.Columns.Add("ColumnPopulation_MKV", "Население");
            dataGridViewGeography_MKV.Columns[3].Width = 100;
            dataGridViewGeography_MKV.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewGeography_MKV.Columns.Add("ColumnDensity_MKV", "Плотность");
            dataGridViewGeography_MKV.Columns[4].Width = 80;
            dataGridViewGeography_MKV.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewGeography_MKV.Columns.Add("ColumnNationality_MKV", "Национальность");
            dataGridViewGeography_MKV.Columns[5].Width = 120;

            dataGridViewGeography_MKV.Columns.Add("ColumnDeveloped_MKV", "Развитая");
            dataGridViewGeography_MKV.Columns[6].Width = 70;
            dataGridViewGeography_MKV.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }




        private void buttonSearch_MKV_Click(object sender, EventArgs e)
        {
            // проверка загруж данных
            if (ds.Countries.Count == 0)
            {
                MessageBox.Show("Сначала загрузите данные из файла!", "Ошибка",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string searchText = textBoxOne_MKV.Text.Trim();

            
            if (dataGridViewGeography_MKV.DataSource != null)
            {
                dataGridViewGeography_MKV.DataSource = null;
            }

            dataGridViewGeography_MKV.Rows.Clear();

            List<Country> countriesToShow;

            if (string.IsNullOrEmpty(searchText))
            {
                countriesToShow = ds.Countries.ToList();
                this.Text = "География - Все страны";
            }
            else
            {
                countriesToShow = ds.SearchAll(searchText);
                this.Text = $"География - Найдено: {countriesToShow.Count}";

                if (countriesToShow.Count == 0)
                {
                    MessageBox.Show("Ничего не найдено", "Поиск",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // провека,создание колонок 
            if (dataGridViewGeography_MKV.Columns.Count == 0)
            {
                
                dataGridViewGeography_MKV.Columns.Add("colName_MKV", "Название");
                dataGridViewGeography_MKV.Columns.Add("colCapital_MKV", "Столица");
                dataGridViewGeography_MKV.Columns.Add("colArea_MKV", "Площадь (км²)");
                dataGridViewGeography_MKV.Columns.Add("colPopulation_MKV", "Население");
                dataGridViewGeography_MKV.Columns.Add("colDensity_MKV", "Плотность");
                dataGridViewGeography_MKV.Columns.Add("colNationality_MKV", "Национальность");
                dataGridViewGeography_MKV.Columns.Add("colDeveloped_MKV", "Развитая");
            }

            // таблица
            foreach (Country country in countriesToShow)
            {
                dataGridViewGeography_MKV.Rows.Add(
                    country.Name,
                    country.Capital,
                    country.Area.ToString("N0"),
                    country.Population.ToString("N0"),
                    country.Population_density.ToString("F1"),
                    country.MainNationality,
                    country.IsDeveloped ? "Да" : "Нет"
                );
            }
        }



        private void buttonDelete_MKV_Click(object sender, EventArgs e) 
        {
            try
            {
                // проверка нужно ли очищать табл
                if (dataGridViewGeography_MKV.Rows.Count > 0)
                {
                    
                    DialogResult result = MessageBox.Show(
                        $"Очистить таблицу и поле поиска?\n\nУдалено будет: {dataGridViewGeography_MKV.Rows.Count} записей",
                        "Подтверждение очистки",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        //очистка табл
                        dataGridViewGeography_MKV.Rows.Clear();

                        // очист поиска
                        textBoxOne_MKV.Clear();

                        //  сброс привязки данных, если  есть
                        dataGridViewGeography_MKV.DataSource = null;

                        //  очищаем список стран 
                        ds.Countries.Clear();

                        // обновл заголовок окна
                        this.Text = "География";

                        MessageBox.Show("Таблица и поле поиска очищены",
                                      "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    // если табл пуста, все равно очищаем  поиск
                    textBoxOne_MKV.Clear();
                    MessageBox.Show("Поле поиска очищено",
                                  "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при очистке:\n{ex.Message}",
                              "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveFile_MKV_Click(object sender, EventArgs e)
        {
            saveFileDialog_MKV.FileName = "страны.csv";
            saveFileDialog_MKV.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); 
            saveFileDialog_MKV.ShowDialog();

            string path = saveFileDialog_MKV.FileName;

            if (!string.IsNullOrEmpty(path))
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                int rows = dataGridViewGeography_MKV.RowCount;
                int columns = dataGridViewGeography_MKV.ColumnCount;
                string str = "";

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        str = str + dataGridViewGeography_MKV.Rows[i].Cells[j].Value;

                        if (j != columns - 1)
                        {
                            str = str + ";";
                        }
                    }
                    File.AppendAllText(path, str + Environment.NewLine);
                    str = "";
                }

                MessageBox.Show($"Файл сохранен на рабочем столе:\n{Path.GetFileName(path)}",
                 "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        

        private void buttonPlus_MKV_Click(object sender, EventArgs e)
        {
            if (textBoxInN_MKV.Text == "" || textBoxInC_MKV.Text == "")
            {
                MessageBox.Show("Заполните название и столицу");
                return;
            }

            try
            {
                Country country = new Country
                {
                    Name = textBoxInN_MKV.Text,
                    Capital = textBoxInC_MKV.Text,
                    Area = double.Parse(textBoxInA_MKV.Text),
                    Population = int.Parse(textBoxInP_MKV.Text),
                    Population_density = double.Parse(textBoxInPD_MKV.Text),
                    MainNationality = textBoxInNa_MKV.Text,
                    IsDeveloped = bool.Parse(textBoxInD_MKV.Text)
                };

                ds.Countries.Add(country);

                dataGridViewGeography_MKV.Rows.Add(
                    country.Name,
                    country.Capital,
                    country.Area.ToString("N0"),
                    country.Population.ToString("N0"),
                    country.Population_density.ToString("F1"),
                    country.MainNationality,
                    country.IsDeveloped ? "Да" : "Нет"
                );

                textBoxInN_MKV.Clear();
                textBoxInC_MKV.Clear();
                textBoxInA_MKV.Clear();
                textBoxInP_MKV.Clear();
                textBoxInPD_MKV.Clear();
                textBoxInNa_MKV.Clear();
                textBoxInD_MKV.Clear();
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода данных");
            }
        }


        // методы парсинга
        private double GetDouble(string text)
        {
            if (double.TryParse(text, out double result)) return result;
            return 0;
        }

        private int GetInt(string text)
        {
            if (int.TryParse(text, out int result)) return result;
            return 0;
        }

        private bool GetBool(string text)
        {
            return text.ToLower() == "true" || text == "1" || text.ToLower() == "да";
        }

        private void buttonDiag_MKV_Click(object sender, EventArgs e)
        {
            FormStatistics statForm = new FormStatistics();
            statForm.ShowDialog();

        }

        private void buttonDeleteCountry_MKV_Click(object sender, EventArgs e)
        {
            // проверка выделения строки
            if (dataGridViewGeography_MKV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите страну для удаления", "Информация",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // получаем выбранную строку
            DataGridViewRow selectedRow = dataGridViewGeography_MKV.SelectedRows[0];
            string countryName = selectedRow.Cells[0].Value?.ToString();

            if (string.IsNullOrEmpty(countryName))
            {
                MessageBox.Show("Не удалось определить название страны", "Ошибка",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //  подтверждение
            DialogResult result = MessageBox.Show(
                $"Вы уверены, что хотите удалить страну:\n\n{countryName}?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // находим страну в списке
                    Country countryToDelete = ds.Countries.FirstOrDefault(c => c.Name == countryName);

                    if (countryToDelete != null)
                    {
                        // удл
                        ds.Countries.Remove(countryToDelete);

                        // удл строку из таблицы
                        dataGridViewGeography_MKV.Rows.Remove(selectedRow);

                        MessageBox.Show($"Страна '{countryName}' удалена",
                                      "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Страна '{countryName}' не найдена в списке",
                                      "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении:\n{ex.Message}",
                                  "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }




        private void buttonHelp_MKV_Click(object sender, EventArgs e)
        {
            FormAbout aboutForm = new FormAbout();
            aboutForm.ShowDialog();
        }

        private void buttonInfo_MKV_Click(object sender, EventArgs e)
        {
            FormGuide GuideForm = new FormGuide();
            GuideForm.ShowDialog();

        }

        private void buttonSearch_MKV_MouseEnter(object sender, EventArgs e)
        {


        }

        private void buttonDelete_MKV_MouseEnter(object sender, EventArgs e)
        {

        }

        private void buttonOpenFile_MKV_MouseEnter(object sender, EventArgs e)
        {

        }

        private void buttonSaveFile_MKV_MouseEnter(object sender, EventArgs e)
        {

        }

        private void buttonDeleteCountry_MKV_MouseEnter(object sender, EventArgs e)
        {

        }

        private void buttonHelp_MKV_MouseEnter(object sender, EventArgs e)
        {


        }

        private void buttonInfo_MKV_MouseEnter(object sender, EventArgs e)
        {

        }
        private void UpdateDataGridView(List<Country> countries)
        {
            
            dataGridViewGeography_MKV.Rows.Clear();

           
            foreach (var country in countries)
            {
                dataGridViewGeography_MKV.Rows.Add(
                    country.Name,
                    country.Capital,
                    country.Area,
                    country.Population,
                    country.Population_density,
                    country.MainNationality,
                    country.IsDeveloped ? "Да" : "Нет"
                );
            }
        }

       
        private void buttonSortedArea_MKV_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (ds.Countries == null || ds.Countries.Count == 0)
                {
                    MessageBox.Show("Сначала загрузите данные из файла!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                var sortedCountries = ds.SortByArea(ds.Countries.ToList());

                
                UpdateDataGridView(sortedCountries);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сортировке: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDensity_MKV_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (ds.Countries == null || ds.Countries.Count == 0)
                {
                    MessageBox.Show("Сначала загрузите данные из файла!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                var sortedCountries = ds.SortByDensity(ds.Countries.ToList());

                
                UpdateDataGridView(sortedCountries);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сортировке: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       

        
    }
}
