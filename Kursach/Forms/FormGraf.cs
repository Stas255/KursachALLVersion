﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Kursach.Class;

namespace Kursach.Forms
{
     class FormGraf : FormBase, InterfaceRefresh
     {
         private List<Value> results;
         private int number;
         private Series series;
         private ListBox listBox1;
        public void AddFunction(int number, List<Value> results, Type type)
        {
            this.results = results;
            this.number = number;
            var name = number == 1 ? Lang.language.TextMenuF1 : Lang.language.TextMenuF2;
            this.Text = name;
            this.Size = new System.Drawing.Size(1000, 550);
            series = new Series(name);
            series.ChartType = SeriesChartType.Line;

            listBox1 = new ListBox();
            listBox1.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom);
            listBox1.Size = new System.Drawing.Size(300, 450);
            listBox1.Location = new System.Drawing.Point(10, 50);
            listBox1.Items.AddRange(results.Select(e => e.GetInfo()).ToArray());
            this.Controls.Add(listBox1);

            Chart chart1 = new Chart();
            Legend legend1 = new Legend();
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);

            ChartArea chartArea1 = new ChartArea();
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            chart1.TabIndex = 1;
            chart1.Size = new System.Drawing.Size(640, 520);
            chart1.Location = new System.Drawing.Point(360, 0);
            results.Where(e => e.error == -1).ToList().ForEach(e => series.Points.AddXY(e.x, e.y));
            chart1.Series.Add(series);
            chart1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            this.Controls.Add(chart1);

            Refresh();
        }

        public void Refresh()
        {
            var name = number == 1 ? Lang.language.TextMenuF1 : Lang.language.TextMenuF2;
            this.Text = name;
            series.Name = name;
            listBox1.Items.Clear();
            listBox1.Items.AddRange(results.Select(e => e.GetInfo()).ToArray());
        }
    }
}