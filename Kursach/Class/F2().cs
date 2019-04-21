using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Kursach.Class
{
    class F2
    {
        FormF2 formF2;
        Value coordinate;
        Series series = new Series("Function 2");
        int iteration;
        double y;
        public F2()
        {
            formF2 = new FormF2();
            series.ChartType = SeriesChartType.Line;
            //formF2.Show();
            iteration = 0;
            coordinate = new Value();
        }
        public void Caculate(Value coordinate)
        {
            this.coordinate = coordinate;
            if (Check())
            {
                y = Math.Pow(Math.Abs(coordinate.q * Math.Tan(coordinate.x)), 1.0/3);
                if (coordinate.q * Math.Tan(coordinate.x) < 0)
                {
                    y = -y;
                }
                ADDInformation();
                iteration++;
            }
        }
        bool Check()
        {
            return true;
        }
        public void ADDInformation()
        {
            formF2.ListBox.Items.Add("x=" + coordinate.x.ToString() + "  y=" + y.ToString() + "  q=" + coordinate.q.ToString());
            series.Points.AddXY(coordinate.x, y);
        }
        public void OutPutGrafic()
        {
            formF2.chart2.Series.Add(series);
        }
    }
}

