using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Kursach.Class;

namespace Kursach.Forms
{
     class FormGraf : FormBase, InterfaceRefresh
     {
         private List<Value> results;
         private Type type;
         private Series series;
         private ListBox listBox1;
         private Label labelInformation;
        public void AddFunction(Type type, List<Value> results)
        {
            this.results = results;
            this.type = type;
            var name = type == typeof(Funtion1) ? Lang.language.TextMenuF1 : Lang.language.TextMenuF2;
            this.Text = name;
            this.Size = new System.Drawing.Size(1000, 550);
            series = new Series(name);
            series.ChartType = SeriesChartType.Line;

            listBox1 = new ListBox();
            listBox1.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom);
            listBox1.Size = new System.Drawing.Size(300, 470);
            listBox1.Location = new System.Drawing.Point(10, 40);
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

            labelInformation = new Label();
            labelInformation.Text = Lang.language.TextInformationGraf;
            labelInformation.Size = new System.Drawing.Size(350, 40);
            labelInformation.Location = new System.Drawing.Point(10,0);
            this.Controls.Add(labelInformation);

            Refresh();
        }

        public void Refresh()
        {
            var name = type == typeof(Funtion1) ? Lang.language.TextMenuF1 : Lang.language.TextMenuF2;
            this.Text = name;
            series = new Series(name);
            listBox1.Items.Clear();
            listBox1.Items.AddRange(results.Select(e => e.GetInfo()).ToArray());
            labelInformation.Text = Lang.language.TextInformationGraf;
        }
    }
}
