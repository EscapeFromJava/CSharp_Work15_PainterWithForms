using System;
using System.Drawing;
using System.Windows.Forms;

namespace CSharp_Work15_PainterWithForms
{
    public partial class Form1 : Form
    {
        private static int _size1;
        private static int _size2;
        private static string _ss;
        public Form1()
        {
            InitializeComponent();
        }

        public void DrawMap(Graphics g)
        {
            Pen p = new Pen (Color.Black, 1);
            for (int i = 0; i < _size1; i++)
            {
                for (int j = 0; j < _size2; j++)
                {
                    g.DrawRectangle(p, i * 50, j * 50, 50, 50);
                }
            }
        }

        public void DrawRectangles(int x1, int y1, int x2, int y2)
        {
            Graphics g = pictureBox1.CreateGraphics();
            SolidBrush b = new SolidBrush(Color.Green);
            g.FillRectangle(b, x1, y1, x2, y2);
        }

        

        private void Cleaning()
        {
            _ss = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.DarkGray);
            labelResult.Text = "Свободных клеток: ";
            textBoxMain.Text = "";
        }

        private void MainCode(string ss)
        {
            Graphics g = pictureBox1.CreateGraphics();

            string[] words = ss.Split(' ', '\n', '\r');
            int[] newWords = new int[words.Length];

            for (int i = 0, j = 0; i < words.Length; i++)
            {
                bool flag = int.TryParse(words[i], out var number);
                if (flag)
                {
                    newWords[j] = number;
                    j++;
                }
            }
            _size1 = newWords[0];
            _size2 = newWords[1];
            
            var arr = new int[_size1, _size2];
            var num = newWords[2];
            int value = 3;

            while (num != 0)
            {
                var x1 = newWords[value];
                var y1 = newWords[value + 1];
                var x2 = newWords[value + 2];
                var y2 = newWords[value + 3];
                DrawRectangles(x1 * 50, y1 * 50, (x2 - x1) * 50, (y2 - y1) * 50);
                for (int j = x1; j < x2; j++)
                {
                    for (int k = y1; k < y2; k++)
                    {
                        arr[j, k] = 1;
                    }
                }
                value += 4;
                num--;
            }

            DrawMap(g);

            int count = 0;
            for (int i = 0; i < _size1; i++)
            {
                for (int j = 0; j < _size2; j++)
                {
                    if (arr[i, j] == 0)
                        count++;
                }
            }

            labelResult.Text = "Свободных клеток: " + count;
        }

        
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            _ss = "5 5\r\n2\r\n1 1 3 3\r\n2 2 4 4";
            textBoxMain.Text = _ss;
            MainCode(_ss);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            _ss = "6 7\r\n3\r\n0 0 5 5\r\n1 1 4 4\r\n2 2 3 3";
            textBoxMain.Text = _ss;
            MainCode(_ss);
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            try
            {
                _ss = textBoxMain.Text;
                MainCode(_ss);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void buttonLoadFile_Click(object sender, EventArgs e)
        {
            Cleaning();
            string filePath = "";
            try
            {
                OpenFileDialog fd = new OpenFileDialog();
                fd.InitialDirectory = @"С:\";
                if (fd.ShowDialog() == DialogResult.OK)
                    filePath = fd.FileName;
                _ss = System.IO.File.ReadAllText(filePath);
                textBoxMain.Text = _ss;
                MainCode(_ss);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Cleaning();
        }


    }
}
