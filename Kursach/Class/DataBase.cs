using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.Class
{
     class DataBase
    {
        public List<Value> Funtion1 { get; private set; }
        public List<Value> Funtion2 { get; private set; }

        public DataBase()
        {
            Funtion1 = new List<Value>();
            Funtion2 = new List<Value>();
        }

        public void AddFuntion1(Value coordinate)
        {
            Funtion1.Add(coordinate);
        }
        public void AddFuntion2(Value coordinate)
        {
            Funtion2.Add(coordinate);
        }
    }
}
