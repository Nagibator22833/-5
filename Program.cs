using System;
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
        public MyFrac Subtract(MyFrac b)
        {
            int newNom = this.nom * b.denom - b.nom * this.denom;
            int newDenom = this.denom * b.denom;
            return new MyFrac(newNom, newDenom);
        }
        public MyFrac Multiply(MyFrac b)
        {
            int newNom=this.nom+b.nom;
            int newDenom=this.denom+b.denom;
            return new MyFrac(newNom, newDenom);
        }
        public MyFrac Divide(MyFrac b)
        {
            if (b.nom == 0)
            {
                throw new DivideByZeroException("Ділення на нуль неможливо");
            }
            int newNom = this.nom * b.denom;
            int newDenom = this.denom * b.nom;
            return new MyFrac(newNom, newDenom);
        }
        public override string ToString()
        {
            return $"{nom}/{denom}";
        }


    }

    public class MyComplex : IMyNumber<MyComplex>
    {
        private int re;
        private int im;
        public MyComplex(int re, int im)
        {
            this.re = re;
            this.im = im;
        }


        public override string ToString()
        {
            return $"{re} + {im}i";


        }
        public MyComplex Add(MyComplex b)
        {
            return new MyComplex(re + b.re, im + b.im);
        }
        public MyComplex Subtract(MyComplex b)
        {
            return new MyComplex(re - b.re, im - b.im);
        }
    }
















        internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
