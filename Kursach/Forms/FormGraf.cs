using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Kursach.Class;
using System.Drawing;

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
            this.Size = new Size(1000, 550);

            series = new Series(name); //Являє точку даних і атрибути серії для зберігання
            series.ChartType = SeriesChartType.Line;

            listBox1 = CreateListBox(new Point(10, 40), new Size(300, 470));
            listBox1.Items.AddRange(results.Select(e => e.GetInfo()).ToArray());
            this.Controls.Add(listBox1);

            Chart chart1 = CreateChart(new Point(360, 0), new Size(640, 520));
            results.Where(e => e.error == -1).ToList().ForEach(e => series.Points.AddXY(e.x, e.y));
            chart1.Series.Add(series);
            this.Controls.Add(chart1);

            labelInformation = CreateLabel(new Point(10, 0), new Size(350, 40), Lang.language.TextInformationGraf);
            this.Controls.Add(labelInformation);

            Refresh();
        }

        public void Refresh()
        {
            var name = type == typeof(Funtion1) ? Lang.language.TextMenuF1 : Lang.language.TextMenuF2;
            this.Text = name;
            series.Name = name;
            listBox1.Items.Clear();
            listBox1.Items.AddRange(results.Select(e => e.GetInfo()).ToArray());
            labelInformation.Text = Lang.language.TextInformationGraf;
        }
    }
}
