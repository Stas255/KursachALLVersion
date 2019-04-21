using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Kursach.Class
{
    struct Value{
        public double x, q, a;
    }
    class F1
    {
        FormF1 formF1;
        Value coordinate;
        int iteration;
        Series series = new Series("Function 1");
        double y;
        public F1() {
            formF1 = new FormF1();
            series.ChartType = SeriesChartType.Line;
            //formF1.Show();
            iteration = 0;
            coordinate = new Value();
        }
        public void Caculate(Value coordinate)
        {
            this.coordinate = coordinate;
            if (Check())
            {
                y = Math.Log10(coordinate.a + coordinate.x) / Math.Sin(coordinate.q);
                ADDInformation();
                iteration++;
            }
        } 
        bool Check()
        {
            if(coordinate.a + coordinate.x == 0)
            {
                Exceptions.LogError(coordinate.x, coordinate.a);
                return false;
            }
            if (Math.Sin(coordinate.q) == 0)
            {
                Exceptions.SinError(coordinate.q);
                return false;
            }
            return true;
        }
        public void ADDInformation()
        {
            formF1.ListBox.Items.Add("x=" + coordinate.x.ToString() + "  y=" + y.ToString() + "  q=" + coordinate.q.ToString());
            series.Points.AddXY(coordinate.x,y);
        }
        public void OutPutGrafic()
        {
            formF1.chart1.Series.Add(series);
        }
    }
}
