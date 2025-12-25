namespace Tyuiu.MertsKV.Sprint7.Project.V13
{
    partial class FormGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            buttonGuideOk_MKV = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = SystemColors.HotTrack;
            textBox1.Location = new Point(249, 46);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(423, 250);
            textBox1.TabIndex = 1;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 217);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // buttonGuideOk_MKV
            // 
            buttonGuideOk_MKV.BackColor = SystemColors.ScrollBar;
            buttonGuideOk_MKV.FlatStyle = FlatStyle.Flat;
            buttonGuideOk_MKV.ForeColor = SystemColors.Desktop;
            buttonGuideOk_MKV.Location = new Point(507, 312);
            buttonGuideOk_MKV.Name = "buttonGuideOk_MKV";
            buttonGuideOk_MKV.Size = new Size(104, 44);
            buttonGuideOk_MKV.TabIndex = 3;
            buttonGuideOk_MKV.Text = "Ок";
            buttonGuideOk_MKV.UseVisualStyleBackColor = false;
            buttonGuideOk_MKV.Click += buttonGuideOk_MKV_Click;
            // 
            // FormGuide
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 368);
            Controls.Add(buttonGuideOk_MKV);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            ForeColor = SystemColors.ControlLight;
            MaximizeBox = false;
            MaximumSize = new Size(718, 415);
            MinimumSize = new Size(718, 415);
            Name = "FormGuide";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Справка";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Button buttonGuideOk_MKV;
    }
}