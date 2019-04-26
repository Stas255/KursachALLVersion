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

        public void AddFunction(string name, List<Value> results)
        {
            this.Text = name;
            this.Size = new System.Drawing.Size(1000, 550);
            Series series = new Series(name);
            series.ChartType = SeriesChartType.Line;

            ListBox listBox1 = new ListBox();
            listBox1.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom);
            listBox1.Size = new System.Drawing.Size(340, 450);
            listBox1.Location = new System.Drawing.Point(10, 50);
            listBox1.Items.AddRange(results.Select(e => $"X = {e.x}, Y = {e.y}, Q = {e.q}").ToArray());
            this.Controls.Add(listBox1);
            
            Chart chart1 = new Chart();

            Legend legend1 = new Legend();
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);

            ChartArea chartArea1 = new ChartArea();
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            chart1.TabIndex = 1;
            chart1.Size = new System.Drawing.Size(620, 500);
            chart1.Location = new System.Drawing.Point(380, 10);
            results.ForEach(e => series.Points.AddXY(e.x, e.y));
            chart1.Series.Add(series);
            chart1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            this.Controls.Add(chart1);
            isInit = true;
            ShowDialog();
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
