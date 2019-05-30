﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.Class
{
    /// <summary>
    /// Зберігає координати і ошибки
    /// </summary>
    public class Value
    {
        public double x, y, q, a;
        public int error = -1;
        /// <summary>
        /// Зберігає координати в яких немає ошибки
        /// </summary>
        public Value(double x, double y, double q)
        {
            this.x = x;
            this.y = y;
            this.q = q;
        }

        /// <summary>
        /// Зберігає координати і номер ошибки
        /// </summary>
        public Value(int error, double x, double q, double a)
        {
            this.a = a;
            this.q = q;
            this.x = x;
            this.error = error;
        }

        /// <summary>
        /// Виводить інформацію про координату з ошибкой
        /// </summary>
        public string GetInfo()
        {
            if (error == -1) return GetInforNotError();
            return $"{Lang.language.ErrorDiscribe} X = {Math.Round(x, 7)}, Q = {Math.Round(q, 7)}, A = {Math.Round(a, 7)}. {Lang.language.Errors.Split(',')[error]}";
        }
        /// <summary>
        /// Виводить інформацію про координату яка немає ошибки
        /// </summary>
        public string GetInforNotError()
        {
            if (error != -1) return String.Empty;
            return $"X = {Math.Round(x, 7)}, Y = {Math.Round(y, 7)}, Q = {Math.Round(q, 7)}";
        }
    }

    /// <summary>
    /// Базовий клас з всіми координатами
    /// </summary>
    abstract class BaseFuntion
    {
        protected double A { set; get; }
        public List<Value> ValueList {protected set; get; }
        protected BaseFuntion(double a)
        {
            ValueList = new List<Value>();
            this.A = a;
        }
        /// <summary>
        /// Робить обчислення
        /// </summary>
        abstract public void Calculate(double x, double q);
    }

    /// <summary>
    /// Клас функції 1
    /// </summary>
    class Funtion1 : BaseFuntion
    {
        public Funtion1(double a): base(a){}
        public override void Calculate(double x, double q)
        {
            int check = Check(x, q);
            if (check == -1)
            {
                double y = Math.Log10(A + x) / Math.Sin(q);
                ValueList.Add(new Value(x, y, q));
            }
            else
            {
                DataBase.ErrorCout++;
                ValueList.Add(new Value(check,x,q,A));
            }

        }

        /// <summary>
        /// Робить перевірку на ОДЗ
        /// </summary>
        private int Check(double x, double q)
        {
            if (A + x == 0)
            {
                return 1;
            }
            if (Math.Sin(q) == 0)
            {
                return 0;
            }
            return -1;
        }
    }
    /// <summary>
    /// Клас функції 2
    /// </summary>
    class Funtion2 : BaseFuntion
    {
        public Funtion2(double a) : base(a) { }
        public override void Calculate(double x, double q)
        {
            int i = q * Math.Tan(x) < 0 ? -1 : 1;
            double y = i * Math.Pow(Math.Abs(q * Math.Tan(x)), 1.0 / 3);
            ValueList.Add(new Value(x, y, q));
        }
    }

}
