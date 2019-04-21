using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Kursach.Class
{
    struct Value
    {
        public double y, x, q, a;
    }
    static class BaseFunction
    {
        public static void CaculateFun1(ref Value coordinate)
        {

            if (CheckFun1(coordinate))
            {
                coordinate.y = Math.Log10(coordinate.a + coordinate.x) / Math.Sin(coordinate.q);
            }
        }
        public static void CaculateFun2(ref Value coordinate)
        {
                coordinate.y = Math.Pow(Math.Abs(coordinate.q * Math.Tan(coordinate.x)), 1.0 / 3);
                if (coordinate.q * Math.Tan(coordinate.x) < 0)
                {
                    coordinate.y = -coordinate.y;
                }
        }
        //??Error not include
        private static bool CheckFun1(Value coordinate)
        {
            if (coordinate.a + coordinate.x == 0)
            {
                //Exceptions.LogError(coordinate.x, coordinate.a);
                return false;
            }
            if (Math.Sin(coordinate.q) == 0)
            {
                //Exceptions.SinError(coordinate.q);
                return false;
            }
            return true;
        }
    }
}
