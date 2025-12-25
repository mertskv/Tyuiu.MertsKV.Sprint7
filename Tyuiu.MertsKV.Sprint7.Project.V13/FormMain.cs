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

            // Настраиваем ширину колонок
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

                    // Проверяем, что файл существует
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
                // Показываем полную информацию об ошибке
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



        private void buttonSearch_MKV_Click(object sender, EventArgs e)
        {
            string searchText = textBoxOne_MKV.Text.Trim();

            dataGridViewGeography_MKV.Rows.Clear();

            List<Country> countriesToShow;

            if (string.IsNullOrEmpty(searchText))
            {
                // Показываем все страны
                countriesToShow = ds.Countries.ToList();
                this.Text = "География - Все страны";
            }
            else
            {
                // Поиск по всем полям
                countriesToShow = ds.SearchAll(searchText);
                this.Text = $"География - Найдено: {countriesToShow.Count}";

                if (countriesToShow.Count == 0)
                    MessageBox.Show("Ничего не найдено", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            foreach (Country country in countriesToShow)
            {
                dataGridViewGeography_MKV.Rows.Add(
                    country.Name,
                    country.Capital,
                    country.Area.ToString("N0"),
                    country.Population.ToString("N0"),
                    country.MainNationality,
                    country.IsDeveloped ? "Да" : "Нет"
                    
                );
            }
        }

       
        
        private void buttonDelete_MKV_Click(object sender, EventArgs e) ///???
        {
            if (dataGridViewGeography_MKV.SelectedRows.Count == 0)
            {
                return;
            }

            // Получаем выбранную строку
            DataGridViewRow selectedRow = dataGridViewGeography_MKV.SelectedRows[0];
            int rowIndex = selectedRow.Index;

            // Получаем данные страны (первая колонка - название страны)
            string countryName = selectedRow.Cells[0].Value?.ToString() ?? "";

            if (string.IsNullOrEmpty(countryName))
            {
                return;
            }

            try
            {
                // Находим страну в списке по названию
                Country countryToDelete = ds.Countries.FirstOrDefault(c => c.Name == countryName);

                if (countryToDelete != null)
                {
                    // Удаляем из списка
                    ds.Countries.Remove(countryToDelete);

                    // Обновляем DataGridView
                    dataGridViewGeography_MKV.Rows.RemoveAt(rowIndex);

                    // Обновляем привязку данных
                    dataGridViewGeography_MKV.DataSource = null;
                    dataGridViewGeography_MKV.DataSource = ds.Countries;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении: {ex.Message}",
                               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveFile_MKV_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogProject_MKV.Filter = "Значения, разделенные точкой с запятой(*.csv)|*.csv|Все файлы(*.*)|*.*";
                if (openFileDialogProject_MKV.ShowDialog() == DialogResult.OK)
                {
                    ds.LoadFromCsv(openFileDialogProject_MKV.FileName);
                    MessageBox.Show("Данные загружены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void buttonPlus_MKV_Click(object sender, EventArgs e)
        {

        }

        private void buttonDiag_MKV_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteCountry_MKV_Click(object sender, EventArgs e)
        {

        }

        private void buttonApplyFilter_MKV_Click(object sender, EventArgs e)
        {

        }

        private void buttonApplySorted_MKV_Click(object sender, EventArgs e)
        {

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
    }
}
