using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kursach.Class
{
    /// <summary>
    /// Клас для зберігання всих данних
    /// </summary>
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

        /// <summary>
        /// Початок роботи класа
        /// </summary>
        public void Start(ProgressBar progressBar)
        {
            ErrorCout = 0;
            progressBar.Value = 0;
            progressBar.Maximum = 100;
            int iteration = 0;
            if (xMin > xMax)
            {
                for (double x = xMin; x >= xMax; x += dx)
                {
                    CalculateRand(x);
                    progressBar.Value = (int)Math.Abs(iteration * 100 / ((xMin + Math.Abs(xMax)) / dx));
                    iteration++;
                }
            }
            else
            {
                for (double x = xMin; x <= xMax; x += dx)
                {
                    CalculateRand(x);
                    progressBar.Value = (int)Math.Abs(iteration * 100 / ((xMax - xMin) / dx));
                    iteration++;
                }
            }
            progressBar.Value = progressBar.Maximum;
        }

        /// <summary>
        /// Визиває обчислення рандомної функції 
        /// </summary>
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

        /// <summary>
        /// Повертає об'єкт List&lt;Value&gt; для поточного класа
        /// </summary>
        public List<Value> GetResult(Type type)
        {
            if (funtion1.GetType() == type)
                return funtion1.ValueList;
            return funtion2.ValueList;
        }
    }
}
