using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.MertsKV.Sprint7.Project.V13
{
    public partial class FormGuide : Form
    {
        public FormGuide()
        {
            InitializeComponent();
        }

        private void buttonGuideOk_MKV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
