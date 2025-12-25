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


        private void buttonSearch_MKV_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void buttonDelete_MKV_Click(object sender, EventArgs e)
        {

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
