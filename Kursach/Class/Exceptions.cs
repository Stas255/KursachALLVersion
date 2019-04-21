using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.Class
{
    class Exceptions
    {
        public static void LogError(double x, double a)
        {
            Exception exception = new Exception();
            exception.label1.Text = "Ошибка при значені x=" + x.ToString() +" и значення а=" + a.ToString()+ " так як a+x = 0 неможливо вирахувати tag(a+x) ";
            exception.ShowDialog();
        }
        public static void SinError(double q)
        {
            Exception exception = new Exception();
            exception.label1.Text = "Ошибка при значені q=" + q.ToString() + " так як sin(q) = 0 неможливо вирахувати tag(a+x)/sin(q) ";
            exception.ShowDialog();
        }
        public static void EmptyError()
        {
            Exception exception = new Exception();
            exception.label1.Text = "Ошибка введіть всі значення ";
            exception.ShowDialog();
        }
        public static void XMinError(double xMin, double xMax)
        {
            Exception exception = new Exception();
            exception.label1.Text = "Ошибка при значені xMin = " + xMin.ToString() + " так як xMax = " + xMax.ToString() + " xMin < xMin";
            exception.ShowDialog();
        }
        public static void ConvertError()
        {
            Exception exception = new Exception();
            exception.label1.Text = "Ошибка при конвертації даних";
            exception.ShowDialog();
        }
    }
}
