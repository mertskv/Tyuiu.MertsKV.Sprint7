namespace Tyuiu.MertsKV.Sprint7.Project.V13
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            textBox1 = new TextBox();
            buttonAboutOk_MKV = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.MediumSeaGreen;
            textBox1.Location = new Point(32, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(500, 627);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // buttonAboutOk_MKV
            // 
            buttonAboutOk_MKV.FlatStyle = FlatStyle.Popup;
            buttonAboutOk_MKV.ForeColor = SystemColors.ButtonFace;
            buttonAboutOk_MKV.Location = new Point(387, 645);
            buttonAboutOk_MKV.Name = "buttonAboutOk_MKV";
            buttonAboutOk_MKV.Size = new Size(116, 48);
            buttonAboutOk_MKV.TabIndex = 1;
            buttonAboutOk_MKV.Text = "Ок";
            buttonAboutOk_MKV.UseVisualStyleBackColor = true;
            buttonAboutOk_MKV.Click += buttonAboutOk_MKV_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(569, 705);
            Controls.Add(buttonAboutOk_MKV);
            Controls.Add(textBox1);
            ForeColor = Color.DodgerBlue;
            MaximizeBox = false;
            MaximumSize = new Size(587, 752);
            MinimumSize = new Size(587, 752);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button buttonAboutOk_MKV;
    }
}