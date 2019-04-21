using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Kursach.Class;

namespace Kursach
{
    partial class FormBase : Form
    {
        private static bool isInit = false;
        public FormBase()
        {
            InitializeComponent();
        }

        public void AddFunction(string name, List<Value> Funtions)
        {
            this.Name = name;
            this.Size = new System.Drawing.Size(1000, 640);

            ListBox listBox1 = new ListBox();
            listBox1.Size = new System.Drawing.Size(340, 290);
            listBox1.Location = new System.Drawing.Point(10, 50);
            foreach (var Funtion in Funtions)
            {
                listBox1.Items.Add($"X = {Funtion.x}, Y = {Funtion.y}, Q = {Funtion.q}");
            }
            this.Controls.Add(listBox1);
            //??неясно як буду передавать параметри
            
            Chart chart1 = new Chart();
            chart1.Size = new System.Drawing.Size(340, 290);
            chart1.Location = new System.Drawing.Point(366, 0);
            Series series = new Series();
            foreach (var Funtion in Funtions)
            {
                //series.
                //listBox1.Items.Add($"X = {Funtion.x}, Y = {Funtion.y}, Q = {Funtion.q}");
            }
            this.Controls.Add(chart1);

            isInit = true;
        }

        public void AddPicture(string name)
        {
            this.Name = name;
            this.Size = new System.Drawing.Size(400, 180);

            PictureBox pictureBox1 = new PictureBox();
            //??неясно як буду передавать параметри
            pictureBox1.Size = new System.Drawing.Size(380, 140);
            pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.Controls.Add(pictureBox1);

            isInit = true;
        }
    }
}
