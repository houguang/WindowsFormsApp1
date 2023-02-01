using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSetForm1Title_Click(object sender, EventArgs e)
        {
            string title = text1.Text;
            (this.Owner as Form1).label1.Text = title;
        }

        private void text1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxForm1StatusBar_CheckedChanged(object sender, EventArgs e)
        {
            (this.Owner as Form1).statusStrip1.Visible = checkBoxForm1StatusBar.Checked;
        }
    }
}
