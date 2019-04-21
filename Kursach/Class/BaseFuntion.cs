using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.Class
{
    struct Value
    {
        public double x, y, q;

        public Value(double x, double y, double q)
        {
            this.x = x;
            this.y = y;
            this.q = q;
        }
    }

    abstract class BaseFuntion
    {
        protected double A { set; get; }
        public List<Value> ValueList {protected set; get; }
        protected BaseFuntion(double a)
        {
            ValueList = new List<Value>();
            this.A = a;
        }
        abstract public void Calculate(double x, double q);
    }

    class Funtion1 : BaseFuntion
    {
        public Funtion1(double a): base(a){}
        public override void Calculate(double x, double q)
        {
            if (!Check(x,q)) return;
            double y = Math.Log10(A + x) / Math.Sin(q);
            ValueList.Add(new Value(x, y, q));

        }
        private bool Check(double x, double q)
        {
            if (A + x == 0)
            {
                return false;
            }
            if (Math.Sin(q) == 0)
            {
                return false;
            }
            return true;
        }
    }

    class Funtion2 : BaseFuntion
    {
        public Funtion2(double a) : base(a) { }
        public override void Calculate(double x, double q)
        {
            int i = q * Math.Tan(x) < 0 ? -1 : 1;
            double y = i * Math.Pow(Math.Abs(q * Math.Tan(x)), 1.0 / 3);
        }
    }

}
