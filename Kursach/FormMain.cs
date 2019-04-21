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
    public partial class FormMain : Form
    {
        private DataBase dataBase;
        public FormMain()
        {
            InitializeComponent();
            //CreatePicture();
        }
        public void CreatePicture()
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\stast\\Desktop\\123.png");
        }

        public bool Check()
        {
            if(string.IsNullOrWhiteSpace(textBoxXMin.Text) || string.IsNullOrWhiteSpace(textBoxXMax.Text) || string.IsNullOrWhiteSpace(textBoxDx.Text))
            {
                return false;
            }
            if (Convert.ToDouble(textBoxXMin.Text) > Convert.ToDouble(textBoxXMax.Text))
            {
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double q;
            Random random = new Random();
            Value coordinate;
            dataBase = new DataBase();
            if (Check())
            {
                double xMin = Convert.ToDouble(textBoxXMin.Text);
                double xMax = Convert.ToDouble(textBoxXMax.Text);
                double dx = Convert.ToDouble(textBoxDx.Text);
                double a = Convert.ToDouble(textBoxA.Text);
                progressBar.Value = 0;
                progressBar.Maximum = (int)((xMax - xMin)/dx);
                for (double i = xMin; i <= xMax; i += dx)
                {
                    q = random.NextDouble();
                    coordinate = new Value() { x = i, q = q, a = a };
                    if (q > 0 && q <= 0.7)
                    {
                        BaseFunction.CaculateFun1(ref coordinate);
                        dataBase.AddFuntion1(coordinate);
                    }
                    else
                    {
                        BaseFunction.CaculateFun2(ref coordinate);
                        dataBase.AddFuntion2(coordinate);
                    }
                    System.Threading.Thread.Sleep(1000);
                    progressBar.Value++;
                }
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

        private void grafictToolStripMenuItemGraph1_Click(object sender, EventArgs e)
        {
            FormBase formBase = new FormBase();
            if (dataBase != null)
            {
                formBase.AddFunction("Funtion 1", dataBase.Funtion1);
            }
        }
    }
}
