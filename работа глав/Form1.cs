using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace работа_глав
{
    public partial class Form1 : Form
    {
        pod h = new pod();
        string pt = "", pt2 = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "Файлы txt|*.txt";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                pt = OPF.FileName;
                textBox5.Text = OPF.SafeFileName;
            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pt != "")
            {

                textBox1.Text = h.v(pt);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pt != "")
            {
                string pr = pt;
                FileInfo file = new FileInfo(pr);
                string text = "";
                if (file.Exists)
                {
                    text = textBox1.Text;
                    File.WriteAllText(pr, text);

                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pt != "")
            {
                textBox3.Text = h.z1(pt);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pt != "")
            {
                int d = 20;
                int a = h.a(pt), b = h.b(pt);
                if (a != 0 && b != 0)
                {
                    int w = (panel1.Width - 4 * d) / 3;
                    int ed = panel1.Height / (a + b);

                    Graphics gPanel = panel1.CreateGraphics();

                    Rectangle rect1 = new Rectangle(5, panel1.Height - a * ed, w, ed * a);
                    Rectangle rect2 = new Rectangle(w + d, panel1.Height - b * ed, w, ed * b);
                    SolidBrush redBrush = new SolidBrush(Color.Green);
                    gPanel.FillRectangle(redBrush, rect1);
                    SolidBrush redBrush2 = new SolidBrush(Color.Red);
                    gPanel.FillRectangle(redBrush2, rect2);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pt != "")
            {
                textBox4.Text = h.yh(pt);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            File.WriteAllText(pt2 + "\\new_file.txt", h.prip(pt));

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                pt2 = FBD.SelectedPath;
                textBox2.Text = FBD.SelectedPath;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            File.WriteAllText(pt2 + "\\new_file.txt", h.rus(pt));
            textBox6.Text = h.rus(pt);

            
                int d = 20;
                int a = h.a1(pt), b = h.b1(pt);
            if(a!=0&&b!=0){
                int w = (panel1.Width - 4 * d) / 3;
                int ed = panel1.Height / (a + b);

                Graphics gPanel = panel1.CreateGraphics();

                Rectangle rect1 = new Rectangle(5, panel1.Height - a * ed, w, ed * a);
                Rectangle rect2 = new Rectangle(w + d, panel1.Height - b * ed, w, ed * b);
                SolidBrush redBrush = new SolidBrush(Color.Green);
                gPanel.FillRectangle(redBrush, rect1);
                SolidBrush redBrush2 = new SolidBrush(Color.Red);
                gPanel.FillRectangle(redBrush2, rect2);}
            

        }
    }
}

