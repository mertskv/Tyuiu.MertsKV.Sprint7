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
        public FormStatistics()
        {
            InitializeComponent();
        }

        private void FormStatistics_Load(object sender, EventArgs e)
        {

        }
        private void buttonOk_MKV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
