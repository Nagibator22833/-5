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
    }




















    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
