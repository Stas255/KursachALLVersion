using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach.Class
{
     class DataBase
     {
         private BaseFuntion funtion1;
         private BaseFuntion funtion2;
         private double xMin, xMax, dx;
        public DataBase(double a, double xMax, double xMin, double dx)
        {
            funtion1 = new Funtion1(a);
            funtion2 = new Funtion2(a);
            this.xMax = xMax;
            this.xMin = xMin;
            this.dx = dx;
        }

         public void Start(ProgressBar progressBar)
         {
             double q;
             Random random = new Random();
            progressBar.Value = 0;
             progressBar.Maximum = (int)(((xMax - xMin) / dx) + dx) + 1;
             for (double x = xMin; x <= xMax; x += dx)
             {
                 q = random.NextDouble();
                 if (q > 0 && q <= 0.7)
                 {
                     funtion1.Calculate(x,q);
                 }
                 else
                 {
                     funtion2.Calculate(x,q);
                 }
                 //System.Threading.Thread.Sleep((int)(1000 / (xMax - xMin)));
                 progressBar.Value++;
             }
            progressBar.Value = progressBar.Maximum;
         }

         public List<Value> GetResult(Type type)
         {
             if (funtion1.GetType() == type)
                 return funtion1.ValueList;
             return funtion2.ValueList;
         }
    }
}
