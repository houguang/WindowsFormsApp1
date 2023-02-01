using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(textPort.Text, "端口",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MessageBox.Show("确定");
            }
            else
            {
                MessageBox.Show("取消");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = textList.Text.Trim();
            listBox.Items.Add(name);
            textList.Text = "";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void btnStartForm2_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
            radioFemale.Checked = true;

            foreach(var ctr in groupBoxSetFont.Controls)
            {
                if(ctr is RadioButton)
                {
                    (ctr as RadioButton).CheckedChanged += SetForm1Font;
                }
            }

            //生成字体大小选项
            for(var i = 12; i < 20; i++)
            {
                comboBoxFontSize.Items.Add(i.ToString());
            }
        }

        string fontName = "宋体";
        private void SetForm1Font(object sender, EventArgs e)
        {
            foreach (var ctr in groupBoxSetFont.Controls)
            {
                if (ctr is RadioButton && (ctr as RadioButton).Checked)
                {
                    fontName= (ctr as RadioButton).Text;
                    this.Font = new Font(fontName, fontSize);
                    break;
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int count = 0;
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem == 退出ToolStripMenuItem) { count++; }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;

                notifyIcon1.BalloonTipTitle = "注意";
                notifyIcon1.BalloonTipText = "双击打开窗口";
                notifyIcon1.ShowBalloonTip(1000);

                this.Hide();
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            

            this.Show();
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
           // toolStripStatusLabel1.Text = e.X.ToString() + "," + e.Y.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void btnOpenForm2_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            form.ShowDialog(this);
        }

        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {
            lableGender.Text = "女";
        }

        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {
            lableGender.Text = "男";
        }

        float fontSize = 12;
        private void comboBoxFontSize_SelectedIndexChanged(object sender, EventArgs e) 
        {
            fontSize = float.Parse(comboBoxFontSize.Text);
            this.Font = new Font(fontName, fontSize);
        }

        private void btnOpenImg_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                var img = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(img);
            }
        }
    }
}
