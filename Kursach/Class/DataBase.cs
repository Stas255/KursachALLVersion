using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kursach.Class
{
     class DataBase
     {
         Random random = new Random();
        static public int ErrorCout = 0;
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
            ErrorCout = 0;
            progressBar.Value = 0;
            if (xMin == xMax)
            {
                CalculateRand(xMin);
            }
            else if (xMin < xMax)
             {
                 progressBar.Maximum = (int)Math.Abs(((xMax - xMin) / dx) + dx + 1);
                for (double x = xMin; x <= xMax; x += dx)
                 {
                     CalculateRand(x);
                     progressBar.Value++;
                 }
             }
             else
             {
                 progressBar.Maximum = (int)Math.Abs(((xMax - xMin) / dx) - dx + 1);
                for (double x = xMin; x >= xMax; x += dx)
                 {
                     CalculateRand(x);
                     progressBar.Value++;
                 }
            }

             progressBar.Value = progressBar.Maximum;
         }

         private void CalculateRand(double x)
         {
             double q = random.NextDouble();
             if (q > 0 && q <= 0.7)
             {
                 funtion1.Calculate(x, q);
             }
             else
             {
                 funtion2.Calculate(x, q);
             }
        } 

         public List<Value> GetResult(Type type)
         {
             if (funtion1.GetType() == type)
                 return funtion1.ValueList;
             return funtion2.ValueList;
         }
    }
}
