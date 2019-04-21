using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kursach.Class;

namespace Kursach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreatePicture();
        }
        public void CreatePicture()
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\stast\\Desktop\\123.png");
        }

        public bool Check()
        {
            if(string.IsNullOrWhiteSpace(textBoxXMin.Text) || string.IsNullOrWhiteSpace(textBoxXMax.Text) || string.IsNullOrWhiteSpace(textBoxDx.Text))
            {
                Exceptions.EmptyError();
                return false;
            }
            if (Convert.ToDouble(textBoxXMin.Text) > Convert.ToDouble(textBoxXMax.Text))
            {
                Exceptions.XMinError(Convert.ToDouble(textBoxXMin.Text), Convert.ToDouble(textBoxXMax.Text));
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double q;
            Random random = new Random();
            Value coordinate = new Value();
            F1 f1;
            F2 f2;
            if (Check())
            {
                f1 = new F1();
                f2 = new F2();
                double xMin = Convert.ToDouble(textBoxXMin.Text);
                double xMax = Convert.ToDouble(textBoxXMax.Text);
                double dx = Convert.ToDouble(textBoxDx.Text);
                double a = Convert.ToDouble(textBoxA.Text);
                progressBar.Step = (int)((xMax - xMin) / dx);
                for (double i = xMin; i < xMax; i += dx)
                {
                    q = random.NextDouble();
                    coordinate = new Value() { x = i, q = q, a = a };
                    if (q > 0 && q <= 0.7)
                    {
                        f1.Caculate(coordinate);
                    }
                    else
                    {
                        f2.Caculate(coordinate);
                    }
                    System.Threading.Thread.Sleep(1000);
                    progressBar.PerformStep();
                }
                f1.OutPutGrafic();
                f2.OutPutGrafic();
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != ',' && number != '-')
            {
                e.Handled = true;
            }

            if(number == ',' && ((sender as TextBox).Text.IndexOf(',')) > -1) {
                e.Handled = true;
            }
            if (number == '-' && ((sender as TextBox).Text.IndexOf('-')) > -1)
            {
                e.Handled = true;
            }
        }
    }
}
