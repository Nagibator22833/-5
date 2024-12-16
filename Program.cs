﻿using System;
using System.Numerics;
namespace Лаба5
{
    public interface IMyNumber<T> where T : IMyNumber<T>
    {
        T Add(T b);
        T Subtract(T b);
        T Multiply(T b);
        T Divide(T b);

    }
    public class MyFrac : IMyNumber<MyFrac>
    {
        private int nom;
        private int denom;
        public MyFrac(int nom, int denom)
        {
            if (denom == 0)
            {
                throw new ArgumentException("Знаменник не може бути 0");
                this.nom = nom;
                this.denom = denom;
            }
        }
     public void Simplify()
     {
            int gcd = GCD(nom, denom); 
            nom /= gcd;
            denom /= gcd;
            if (denom < 0) 
            {
                nom = -nom;
                denom = -denom;
            }
     }
      public int GCD(int a, int b)
        {
            while (b != 0)
            {
               
                int remainder = a % b;
                
                a = b;
                b = remainder;
            }
            return Math.Abs(a);
        }
        public MyFrac Add(MyFrac b)
        {
            int newNom = this.nom * b.denom + b.nom * this.denom;
            int newDenom = this.denom * b.denom;
            return new MyFrac(newNom, newDenom);
        }





    }




















    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
