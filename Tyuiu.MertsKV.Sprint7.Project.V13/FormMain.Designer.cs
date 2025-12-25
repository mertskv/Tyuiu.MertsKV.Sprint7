
namespace Tyuiu.MertsKV.Sprint7.Project.V13
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            splitContainer_MKV = new SplitContainer();
            groupBoxInfo_MKV = new GroupBox();
            buttonInfo_MKV = new Button();
            buttonHelp_MKV = new Button();
            groupBoxFilter_MKV = new GroupBox();
            buttonApplySorted_MKV = new Button();
            buttonApplyFilter_MKV = new Button();
            comboBoxSorted_MKV = new ComboBox();
            comboBoxFilter_MKV = new ComboBox();
            textBoxS_MKV = new TextBox();
            textBoxF_MKV = new TextBox();
            groupBoxTable_MKV = new GroupBox();
            buttonDeleteCountry_MKV = new Button();
            buttonDiag_MKV = new Button();
            groupBoxThree_MKV = new GroupBox();
            buttonPlus_MKV = new Button();
            textBoxInD_MKV = new TextBox();
            textBoxInNa_MKV = new TextBox();
            textBoxInPD_MKV = new TextBox();
            textBoxInP_MKV = new TextBox();
            textBoxInA_MKV = new TextBox();
            textBoxInC_MKV = new TextBox();
            textBoxInN_MKV = new TextBox();
            textBoxIsDeveloped_MKV = new TextBox();
            textBoxNationality_MKV = new TextBox();
            textBoxPopulationDensity_MKV = new TextBox();
            textBoxPopulation_MKV = new TextBox();
            textBoxArea_MKV = new TextBox();
            textBoxCapital_MKV = new TextBox();
            textBoxName_MKV = new TextBox();
            groupBoxTwo_MKV = new GroupBox();
            buttonSaveFile_MKV = new Button();
            buttonOpenFile_MKV = new Button();
            groupBoxOne_MKV = new GroupBox();
            buttonDelete_MKV = new Button();
            buttonSearch_MKV = new Button();
            textBoxOne_MKV = new TextBox();
            dataGridViewGeography_MKV = new DataGridView();
            openFileDialogProject_MKV = new OpenFileDialog();
            toolTip_MKV = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer_MKV).BeginInit();
            splitContainer_MKV.Panel1.SuspendLayout();
            splitContainer_MKV.Panel2.SuspendLayout();
            splitContainer_MKV.SuspendLayout();
            groupBoxInfo_MKV.SuspendLayout();
            groupBoxFilter_MKV.SuspendLayout();
            groupBoxTable_MKV.SuspendLayout();
            groupBoxThree_MKV.SuspendLayout();
            groupBoxTwo_MKV.SuspendLayout();
            groupBoxOne_MKV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGeography_MKV).BeginInit();
            SuspendLayout();
            // 
            // splitContainer_MKV
            // 
            splitContainer_MKV.Dock = DockStyle.Fill;
            splitContainer_MKV.Location = new Point(0, 0);
            splitContainer_MKV.Name = "splitContainer_MKV";
            // 
            // splitContainer_MKV.Panel1
            // 
            splitContainer_MKV.Panel1.Controls.Add(groupBoxInfo_MKV);
            splitContainer_MKV.Panel1.Controls.Add(groupBoxFilter_MKV);
            splitContainer_MKV.Panel1.Controls.Add(groupBoxTable_MKV);
            splitContainer_MKV.Panel1.Controls.Add(groupBoxThree_MKV);
            splitContainer_MKV.Panel1.Controls.Add(groupBoxTwo_MKV);
            splitContainer_MKV.Panel1.Controls.Add(groupBoxOne_MKV);
            // 
            // splitContainer_MKV.Panel2
            // 
            splitContainer_MKV.Panel2.Controls.Add(dataGridViewGeography_MKV);
            splitContainer_MKV.Size = new Size(1324, 695);
            splitContainer_MKV.SplitterDistance = 520;
            splitContainer_MKV.TabIndex = 0;
            // 
            // groupBoxInfo_MKV
            // 
            groupBoxInfo_MKV.Controls.Add(buttonInfo_MKV);
            groupBoxInfo_MKV.Controls.Add(buttonHelp_MKV);
            groupBoxInfo_MKV.Dock = DockStyle.Bottom;
            groupBoxInfo_MKV.Location = new Point(0, 625);
            groupBoxInfo_MKV.Name = "groupBoxInfo_MKV";
            groupBoxInfo_MKV.Size = new Size(520, 70);
            groupBoxInfo_MKV.TabIndex = 5;
            groupBoxInfo_MKV.TabStop = false;
            groupBoxInfo_MKV.Text = "Информация ";
            // 
            // buttonInfo_MKV
            // 
            buttonInfo_MKV.FlatStyle = FlatStyle.Flat;
            buttonInfo_MKV.ForeColor = SystemColors.ActiveCaption;
            buttonInfo_MKV.Image = (Image)resources.GetObject("buttonInfo_MKV.Image");
            buttonInfo_MKV.Location = new Point(327, 17);
            buttonInfo_MKV.Name = "buttonInfo_MKV";
            buttonInfo_MKV.Size = new Size(81, 46);
            buttonInfo_MKV.TabIndex = 1;
            toolTip_MKV.SetToolTip(buttonInfo_MKV, "Дополнительная информаци о приложении");
            buttonInfo_MKV.UseVisualStyleBackColor = true;
            buttonInfo_MKV.Click += buttonInfo_MKV_Click;
            buttonInfo_MKV.MouseEnter += buttonInfo_MKV_MouseEnter;
            // 
            // buttonHelp_MKV
            // 
            buttonHelp_MKV.FlatStyle = FlatStyle.Flat;
            buttonHelp_MKV.Font = new Font("Segoe UI", 9F);
            buttonHelp_MKV.ForeColor = Color.Blue;
            buttonHelp_MKV.Image = (Image)resources.GetObject("buttonHelp_MKV.Image");
            buttonHelp_MKV.Location = new Point(163, 17);
            buttonHelp_MKV.Name = "buttonHelp_MKV";
            buttonHelp_MKV.Size = new Size(91, 46);
            buttonHelp_MKV.TabIndex = 0;
            toolTip_MKV.SetToolTip(buttonHelp_MKV, "Просмотреть данные о руководстве");
            buttonHelp_MKV.UseVisualStyleBackColor = true;
            buttonHelp_MKV.Click += buttonHelp_MKV_Click;
            buttonHelp_MKV.MouseEnter += buttonHelp_MKV_MouseEnter;
            // 
            // groupBoxFilter_MKV
            // 
            groupBoxFilter_MKV.Controls.Add(buttonApplySorted_MKV);
            groupBoxFilter_MKV.Controls.Add(buttonApplyFilter_MKV);
            groupBoxFilter_MKV.Controls.Add(comboBoxSorted_MKV);
            groupBoxFilter_MKV.Controls.Add(comboBoxFilter_MKV);
            groupBoxFilter_MKV.Controls.Add(textBoxS_MKV);
            groupBoxFilter_MKV.Controls.Add(textBoxF_MKV);
            groupBoxFilter_MKV.Dock = DockStyle.Top;
            groupBoxFilter_MKV.Location = new Point(0, 539);
            groupBoxFilter_MKV.Name = "groupBoxFilter_MKV";
            groupBoxFilter_MKV.Size = new Size(520, 86);
            groupBoxFilter_MKV.TabIndex = 4;
            groupBoxFilter_MKV.TabStop = false;
            groupBoxFilter_MKV.Text = "Фильтр и сортировка данных";
            // 
            // buttonApplySorted_MKV
            // 
            buttonApplySorted_MKV.BackColor = Color.LightGreen;
            buttonApplySorted_MKV.Location = new Point(336, 51);
            buttonApplySorted_MKV.Name = "buttonApplySorted_MKV";
            buttonApplySorted_MKV.Size = new Size(138, 29);
            buttonApplySorted_MKV.TabIndex = 2;
            buttonApplySorted_MKV.Text = "Применить";
            buttonApplySorted_MKV.UseVisualStyleBackColor = false;
            buttonApplySorted_MKV.Click += buttonApplySorted_MKV_Click;
            // 
            // buttonApplyFilter_MKV
            // 
            buttonApplyFilter_MKV.BackColor = Color.LightGreen;
            buttonApplyFilter_MKV.Location = new Point(336, 20);
            buttonApplyFilter_MKV.Name = "buttonApplyFilter_MKV";
            buttonApplyFilter_MKV.Size = new Size(138, 29);
            buttonApplyFilter_MKV.TabIndex = 2;
            buttonApplyFilter_MKV.Text = "Применить";
            buttonApplyFilter_MKV.UseVisualStyleBackColor = false;
            buttonApplyFilter_MKV.Click += buttonApplyFilter_MKV_Click;
            // 
            // comboBoxSorted_MKV
            // 
            comboBoxSorted_MKV.FormattingEnabled = true;
            comboBoxSorted_MKV.Location = new Point(131, 52);
            comboBoxSorted_MKV.Name = "comboBoxSorted_MKV";
            comboBoxSorted_MKV.Size = new Size(151, 28);
            comboBoxSorted_MKV.TabIndex = 1;
            // 
            // comboBoxFilter_MKV
            // 
            comboBoxFilter_MKV.FormattingEnabled = true;
            comboBoxFilter_MKV.Location = new Point(131, 20);
            comboBoxFilter_MKV.Name = "comboBoxFilter_MKV";
            comboBoxFilter_MKV.Size = new Size(151, 28);
            comboBoxFilter_MKV.TabIndex = 1;
            // 
            // textBoxS_MKV
            // 
            textBoxS_MKV.BorderStyle = BorderStyle.FixedSingle;
            textBoxS_MKV.Location = new Point(6, 53);
            textBoxS_MKV.Name = "textBoxS_MKV";
            textBoxS_MKV.ReadOnly = true;
            textBoxS_MKV.Size = new Size(103, 27);
            textBoxS_MKV.TabIndex = 0;
            textBoxS_MKV.Text = "Сортировка -";
            // 
            // textBoxF_MKV
            // 
            textBoxF_MKV.BorderStyle = BorderStyle.FixedSingle;
            textBoxF_MKV.Location = new Point(6, 20);
            textBoxF_MKV.Name = "textBoxF_MKV";
            textBoxF_MKV.ReadOnly = true;
            textBoxF_MKV.Size = new Size(103, 27);
            textBoxF_MKV.TabIndex = 0;
            textBoxF_MKV.Text = "Фильтр -";
            // 
            // groupBoxTable_MKV
            // 
            groupBoxTable_MKV.Controls.Add(buttonDeleteCountry_MKV);
            groupBoxTable_MKV.Controls.Add(buttonDiag_MKV);
            groupBoxTable_MKV.Dock = DockStyle.Top;
            groupBoxTable_MKV.Location = new Point(0, 427);
            groupBoxTable_MKV.Name = "groupBoxTable_MKV";
            groupBoxTable_MKV.Size = new Size(520, 112);
            groupBoxTable_MKV.TabIndex = 3;
            groupBoxTable_MKV.TabStop = false;
            groupBoxTable_MKV.Text = "Работа с данными";
            // 
            // buttonDeleteCountry_MKV
            // 
            buttonDeleteCountry_MKV.FlatStyle = FlatStyle.Flat;
            buttonDeleteCountry_MKV.Image = (Image)resources.GetObject("buttonDeleteCountry_MKV.Image");
            buttonDeleteCountry_MKV.Location = new Point(310, 26);
            buttonDeleteCountry_MKV.Name = "buttonDeleteCountry_MKV";
            buttonDeleteCountry_MKV.Size = new Size(137, 80);
            buttonDeleteCountry_MKV.TabIndex = 0;
            toolTip_MKV.SetToolTip(buttonDeleteCountry_MKV, "Удалить страну");
            buttonDeleteCountry_MKV.UseVisualStyleBackColor = true;
            buttonDeleteCountry_MKV.Click += buttonDeleteCountry_MKV_Click;
            buttonDeleteCountry_MKV.MouseEnter += buttonDeleteCountry_MKV_MouseEnter;
            // 
            // buttonDiag_MKV
            // 
            buttonDiag_MKV.FlatStyle = FlatStyle.Flat;
            buttonDiag_MKV.Image = (Image)resources.GetObject("buttonDiag_MKV.Image");
            buttonDiag_MKV.Location = new Point(144, 26);
            buttonDiag_MKV.Name = "buttonDiag_MKV";
            buttonDiag_MKV.Size = new Size(121, 80);
            buttonDiag_MKV.TabIndex = 0;
            toolTip_MKV.SetToolTip(buttonDiag_MKV, "Просмотреть диаграму о странах");
            buttonDiag_MKV.UseVisualStyleBackColor = true;
            buttonDiag_MKV.Click += buttonDiag_MKV_Click;
            // 
            // groupBoxThree_MKV
            // 
            groupBoxThree_MKV.Controls.Add(buttonPlus_MKV);
            groupBoxThree_MKV.Controls.Add(textBoxInD_MKV);
            groupBoxThree_MKV.Controls.Add(textBoxInNa_MKV);
            groupBoxThree_MKV.Controls.Add(textBoxInPD_MKV);
            groupBoxThree_MKV.Controls.Add(textBoxInP_MKV);
            groupBoxThree_MKV.Controls.Add(textBoxInA_MKV);
            groupBoxThree_MKV.Controls.Add(textBoxInC_MKV);
            groupBoxThree_MKV.Controls.Add(textBoxInN_MKV);
            groupBoxThree_MKV.Controls.Add(textBoxIsDeveloped_MKV);
            groupBoxThree_MKV.Controls.Add(textBoxNationality_MKV);
            groupBoxThree_MKV.Controls.Add(textBoxPopulationDensity_MKV);
            groupBoxThree_MKV.Controls.Add(textBoxPopulation_MKV);
            groupBoxThree_MKV.Controls.Add(textBoxArea_MKV);
            groupBoxThree_MKV.Controls.Add(textBoxCapital_MKV);
            groupBoxThree_MKV.Controls.Add(textBoxName_MKV);
            groupBoxThree_MKV.Dock = DockStyle.Top;
            groupBoxThree_MKV.Location = new Point(0, 168);
            groupBoxThree_MKV.Name = "groupBoxThree_MKV";
            groupBoxThree_MKV.Size = new Size(520, 259);
            groupBoxThree_MKV.TabIndex = 2;
            groupBoxThree_MKV.TabStop = false;
            groupBoxThree_MKV.Text = "Добавление страны ";
            // 
            // buttonPlus_MKV
            // 
            buttonPlus_MKV.BackColor = SystemColors.Menu;
            buttonPlus_MKV.FlatStyle = FlatStyle.Flat;
            buttonPlus_MKV.ForeColor = Color.LimeGreen;
            buttonPlus_MKV.Image = (Image)resources.GetObject("buttonPlus_MKV.Image");
            buttonPlus_MKV.Location = new Point(406, 158);
            buttonPlus_MKV.Name = "buttonPlus_MKV";
            buttonPlus_MKV.Size = new Size(94, 92);
            buttonPlus_MKV.TabIndex = 2;
            toolTip_MKV.SetToolTip(buttonPlus_MKV, "Добавить новую страну");
            buttonPlus_MKV.UseVisualStyleBackColor = false;
            buttonPlus_MKV.Click += buttonPlus_MKV_Click;
            // 
            // textBoxInD_MKV
            // 
            textBoxInD_MKV.BorderStyle = BorderStyle.FixedSingle;
            textBoxInD_MKV.Location = new Point(213, 223);
            textBoxInD_MKV.Name = "textBoxInD_MKV";
            textBoxInD_MKV.Size = new Size(169, 27);
            textBoxInD_MKV.TabIndex = 1;
            // 
            // textBoxInNa_MKV
            // 
            textBoxInNa_MKV.BorderStyle = BorderStyle.FixedSingle;
            textBoxInNa_MKV.Location = new Point(213, 190);
            textBoxInNa_MKV.Name = "textBoxInNa_MKV";
            textBoxInNa_MKV.Size = new Size(169, 27);
            textBoxInNa_MKV.TabIndex = 1;
            // 
            // textBoxInPD_MKV
            // 
            textBoxInPD_MKV.BorderStyle = BorderStyle.FixedSingle;
            textBoxInPD_MKV.Location = new Point(213, 157);
            textBoxInPD_MKV.Name = "textBoxInPD_MKV";
            textBoxInPD_MKV.Size = new Size(169, 27);
            textBoxInPD_MKV.TabIndex = 1;
            // 
            // textBoxInP_MKV
            // 
            textBoxInP_MKV.BorderStyle = BorderStyle.FixedSingle;
            textBoxInP_MKV.Location = new Point(213, 124);
            textBoxInP_MKV.Name = "textBoxInP_MKV";
            textBoxInP_MKV.Size = new Size(169, 27);
            textBoxInP_MKV.TabIndex = 1;
            // 
            // textBoxInA_MKV
            // 
            textBoxInA_MKV.BorderStyle = BorderStyle.FixedSingle;
            textBoxInA_MKV.Location = new Point(213, 91);
            textBoxInA_MKV.Name = "textBoxInA_MKV";
            textBoxInA_MKV.Size = new Size(169, 27);
            textBoxInA_MKV.TabIndex = 1;
            // 
            // textBoxInC_MKV
            // 
            textBoxInC_MKV.BorderStyle = BorderStyle.FixedSingle;
            textBoxInC_MKV.Location = new Point(213, 58);
            textBoxInC_MKV.Name = "textBoxInC_MKV";
            textBoxInC_MKV.Size = new Size(169, 27);
            textBoxInC_MKV.TabIndex = 1;
            // 
            // textBoxInN_MKV
            // 
            textBoxInN_MKV.BorderStyle = BorderStyle.FixedSingle;
            textBoxInN_MKV.Location = new Point(213, 25);
            textBoxInN_MKV.Name = "textBoxInN_MKV";
            textBoxInN_MKV.Size = new Size(169, 27);
            textBoxInN_MKV.TabIndex = 1;
            // 
            // textBoxIsDeveloped_MKV
            // 
            textBoxIsDeveloped_MKV.BorderStyle = BorderStyle.FixedSingle;
            textBoxIsDeveloped_MKV.Location = new Point(12, 223);
            textBoxIsDeveloped_MKV.Name = "textBoxIsDeveloped_MKV";
            textBoxIsDeveloped_MKV.ReadOnly = true;
            textBoxIsDeveloped_MKV.Size = new Size(195, 27);
            textBoxIsDeveloped_MKV.TabIndex = 0;
            textBoxIsDeveloped_MKV.Text = "Развитая";
            // 
            // textBoxNationality_MKV
            // 
            textBoxNationality_MKV.BorderStyle = BorderStyle.FixedSingle;
            textBoxNationality_MKV.Location = new Point(12, 191);
            textBoxNationality_MKV.Name = "textBoxNationality_MKV";
            textBoxNationality_MKV.ReadOnly = true;
            textBoxNationality_MKV.Size = new Size(195, 27);
            textBoxNationality_MKV.TabIndex = 0;
            textBoxNationality_MKV.Text = "Национальность";
            // 
            // textBoxPopulationDensity_MKV
            // 
            textBoxPopulationDensity_MKV.BorderStyle = BorderStyle.FixedSingle;
            textBoxPopulationDensity_MKV.Location = new Point(12, 158);
            textBoxPopulationDensity_MKV.Name = "textBoxPopulationDensity_MKV";
            textBoxPopulationDensity_MKV.ReadOnly = true;
            textBoxPopulationDensity_MKV.Size = new Size(195, 27);
            textBoxPopulationDensity_MKV.TabIndex = 0;
            textBoxPopulationDensity_MKV.Text = "Плотность населения";
            // 
            // textBoxPopulation_MKV
            // 
            textBoxPopulation_MKV.BorderStyle = BorderStyle.FixedSingle;
            textBoxPopulation_MKV.Location = new Point(12, 125);
            textBoxPopulation_MKV.Name = "textBoxPopulation_MKV";
            textBoxPopulation_MKV.ReadOnly = true;
            textBoxPopulation_MKV.Size = new Size(195, 27);
            textBoxPopulation_MKV.TabIndex = 0;
            textBoxPopulation_MKV.Text = "Количество населения";
            // 
            // textBoxArea_MKV
            // 
            textBoxArea_MKV.BorderStyle = BorderStyle.FixedSingle;
            textBoxArea_MKV.Location = new Point(12, 92);
            textBoxArea_MKV.Name = "textBoxArea_MKV";
            textBoxArea_MKV.ReadOnly = true;
            textBoxArea_MKV.Size = new Size(195, 27);
            textBoxArea_MKV.TabIndex = 0;
            textBoxArea_MKV.Text = "Площадь";
            // 
            // textBoxCapital_MKV
            // 
            textBoxCapital_MKV.BorderStyle = BorderStyle.FixedSingle;
            textBoxCapital_MKV.Location = new Point(12, 59);
            textBoxCapital_MKV.Name = "textBoxCapital_MKV";
            textBoxCapital_MKV.ReadOnly = true;
            textBoxCapital_MKV.Size = new Size(195, 27);
            textBoxCapital_MKV.TabIndex = 0;
            textBoxCapital_MKV.Text = "Столица";
            // 
            // textBoxName_MKV
            // 
            textBoxName_MKV.BorderStyle = BorderStyle.FixedSingle;
            textBoxName_MKV.Location = new Point(12, 26);
            textBoxName_MKV.Name = "textBoxName_MKV";
            textBoxName_MKV.ReadOnly = true;
            textBoxName_MKV.Size = new Size(195, 27);
            textBoxName_MKV.TabIndex = 0;
            textBoxName_MKV.Text = "Название";
            // 
            // groupBoxTwo_MKV
            // 
            groupBoxTwo_MKV.Controls.Add(buttonSaveFile_MKV);
            groupBoxTwo_MKV.Controls.Add(buttonOpenFile_MKV);
            groupBoxTwo_MKV.Dock = DockStyle.Top;
            groupBoxTwo_MKV.Location = new Point(0, 78);
            groupBoxTwo_MKV.Name = "groupBoxTwo_MKV";
            groupBoxTwo_MKV.Size = new Size(520, 90);
            groupBoxTwo_MKV.TabIndex = 1;
            groupBoxTwo_MKV.TabStop = false;
            groupBoxTwo_MKV.Text = "Работа с файлом";
            // 
            // buttonSaveFile_MKV
            // 
            buttonSaveFile_MKV.FlatStyle = FlatStyle.Flat;
            buttonSaveFile_MKV.ForeColor = Color.Goldenrod;
            buttonSaveFile_MKV.Image = (Image)resources.GetObject("buttonSaveFile_MKV.Image");
            buttonSaveFile_MKV.Location = new Point(310, 16);
            buttonSaveFile_MKV.Name = "buttonSaveFile_MKV";
            buttonSaveFile_MKV.Size = new Size(108, 66);
            buttonSaveFile_MKV.TabIndex = 1;
            toolTip_MKV.SetToolTip(buttonSaveFile_MKV, "Сохранить выбранный файл ");
            buttonSaveFile_MKV.UseVisualStyleBackColor = true;
            buttonSaveFile_MKV.Click += buttonSaveFile_MKV_Click;
            buttonSaveFile_MKV.MouseEnter += buttonSaveFile_MKV_MouseEnter;
            // 
            // buttonOpenFile_MKV
            // 
            buttonOpenFile_MKV.FlatStyle = FlatStyle.Flat;
            buttonOpenFile_MKV.ForeColor = Color.Goldenrod;
            buttonOpenFile_MKV.Image = (Image)resources.GetObject("buttonOpenFile_MKV.Image");
            buttonOpenFile_MKV.Location = new Point(144, 16);
            buttonOpenFile_MKV.Name = "buttonOpenFile_MKV";
            buttonOpenFile_MKV.Size = new Size(110, 66);
            buttonOpenFile_MKV.TabIndex = 0;
            toolTip_MKV.SetToolTip(buttonOpenFile_MKV, "Открыть нужный файл с данными");
            buttonOpenFile_MKV.UseVisualStyleBackColor = true;
            buttonOpenFile_MKV.Click += buttonOpenFile_MKV_Click;
            buttonOpenFile_MKV.MouseEnter += buttonOpenFile_MKV_MouseEnter;
            // 
            // groupBoxOne_MKV
            // 
            groupBoxOne_MKV.Controls.Add(buttonDelete_MKV);
            groupBoxOne_MKV.Controls.Add(buttonSearch_MKV);
            groupBoxOne_MKV.Controls.Add(textBoxOne_MKV);
            groupBoxOne_MKV.Dock = DockStyle.Top;
            groupBoxOne_MKV.Location = new Point(0, 0);
            groupBoxOne_MKV.Name = "groupBoxOne_MKV";
            groupBoxOne_MKV.Size = new Size(520, 78);
            groupBoxOne_MKV.TabIndex = 0;
            groupBoxOne_MKV.TabStop = false;
            groupBoxOne_MKV.Text = "Поиск страны:";
            // 
            // buttonDelete_MKV
            // 
            buttonDelete_MKV.BackColor = SystemColors.Menu;
            buttonDelete_MKV.FlatStyle = FlatStyle.Flat;
            buttonDelete_MKV.ForeColor = Color.Brown;
            buttonDelete_MKV.Image = (Image)resources.GetObject("buttonDelete_MKV.Image");
            buttonDelete_MKV.Location = new Point(431, 14);
            buttonDelete_MKV.Name = "buttonDelete_MKV";
            buttonDelete_MKV.Size = new Size(69, 58);
            buttonDelete_MKV.TabIndex = 1;
            toolTip_MKV.SetToolTip(buttonDelete_MKV, "Удалить");
            buttonDelete_MKV.UseVisualStyleBackColor = false;
            buttonDelete_MKV.Click += buttonDelete_MKV_Click;
            buttonDelete_MKV.MouseEnter += buttonDelete_MKV_MouseEnter;
            // 
            // buttonSearch_MKV
            // 
            buttonSearch_MKV.FlatStyle = FlatStyle.Flat;
            buttonSearch_MKV.ForeColor = SystemColors.ControlDarkDark;
            buttonSearch_MKV.Image = (Image)resources.GetObject("buttonSearch_MKV.Image");
            buttonSearch_MKV.Location = new Point(336, 14);
            buttonSearch_MKV.Name = "buttonSearch_MKV";
            buttonSearch_MKV.Size = new Size(72, 58);
            buttonSearch_MKV.TabIndex = 1;
            toolTip_MKV.SetToolTip(buttonSearch_MKV, "Выберите, чтобы осуществить поиск");
            buttonSearch_MKV.UseVisualStyleBackColor = true;
            buttonSearch_MKV.Click += buttonSearch_MKV_Click;
            buttonSearch_MKV.MouseEnter += buttonSearch_MKV_MouseEnter;
            // 
            // textBoxOne_MKV
            // 
            textBoxOne_MKV.BackColor = SystemColors.Control;
            textBoxOne_MKV.BorderStyle = BorderStyle.FixedSingle;
            textBoxOne_MKV.Cursor = Cursors.IBeam;
            textBoxOne_MKV.ForeColor = SystemColors.Desktop;
            textBoxOne_MKV.Location = new Point(12, 26);
            textBoxOne_MKV.Multiline = true;
            textBoxOne_MKV.Name = "textBoxOne_MKV";
            textBoxOne_MKV.Size = new Size(284, 38);
            textBoxOne_MKV.TabIndex = 0;
            // 
            // dataGridViewGeography_MKV
            // 
            dataGridViewGeography_MKV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGeography_MKV.Dock = DockStyle.Fill;
            dataGridViewGeography_MKV.Location = new Point(0, 0);
            dataGridViewGeography_MKV.Name = "dataGridViewGeography_MKV";
            dataGridViewGeography_MKV.RowHeadersWidth = 51;
            dataGridViewGeography_MKV.Size = new Size(800, 695);
            dataGridViewGeography_MKV.TabIndex = 0;
            // 
            // openFileDialogProject_MKV
            // 
            openFileDialogProject_MKV.FileName = "openFileDialog_MKV";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1324, 695);
            Controls.Add(splitContainer_MKV);
            MinimumSize = new Size(1111, 694);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "География ";
            splitContainer_MKV.Panel1.ResumeLayout(false);
            splitContainer_MKV.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_MKV).EndInit();
            splitContainer_MKV.ResumeLayout(false);
            groupBoxInfo_MKV.ResumeLayout(false);
            groupBoxFilter_MKV.ResumeLayout(false);
            groupBoxFilter_MKV.PerformLayout();
            groupBoxTable_MKV.ResumeLayout(false);
            groupBoxThree_MKV.ResumeLayout(false);
            groupBoxThree_MKV.PerformLayout();
            groupBoxTwo_MKV.ResumeLayout(false);
            groupBoxOne_MKV.ResumeLayout(false);
            groupBoxOne_MKV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGeography_MKV).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private SplitContainer splitContainer_MKV;
        private GroupBox groupBoxOne_MKV;
        private GroupBox groupBoxTwo_MKV;
        private TextBox textBoxOne_MKV;
        private Button buttonSaveFile_MKV;
        private Button buttonOpenFile_MKV;
        private GroupBox groupBoxThree_MKV;
        private TextBox textBoxPopulationDensity_MKV;
        private TextBox textBoxPopulation_MKV;
        private TextBox textBoxArea_MKV;
        private TextBox textBoxCapital_MKV;
        private TextBox textBoxName_MKV;
        private TextBox textBoxIsDeveloped_MKV;
        private TextBox textBoxNationality_MKV;
        private TextBox textBoxInD_MKV;
        private TextBox textBoxInNa_MKV;
        private TextBox textBoxInPD_MKV;
        private TextBox textBoxInP_MKV;
        private TextBox textBoxInA_MKV;
        private TextBox textBoxInC_MKV;
        private TextBox textBoxInN_MKV;
        private Button buttonPlus_MKV;
        private GroupBox groupBoxTable_MKV;
        private Button buttonDeleteCountry_MKV;
        private Button buttonDiag_MKV;
        private GroupBox groupBoxFilter_MKV;
        private GroupBox groupBoxInfo_MKV;
        private TextBox textBoxS_MKV;
        private TextBox textBoxF_MKV;
        private Button buttonInfo_MKV;
        private Button buttonHelp_MKV;
        private Button buttonApplySorted_MKV;
        private Button buttonApplyFilter_MKV;
        private ComboBox comboBoxSorted_MKV;
        private ComboBox comboBoxFilter_MKV;
        private Button buttonDelete_MKV;
        private Button buttonSearch_MKV;
        private ToolTip toolTip_MKV;
        private OpenFileDialog openFileDialogProject_MKV;
        private DataGridView dataGridViewGeography_MKV;
    }
}
