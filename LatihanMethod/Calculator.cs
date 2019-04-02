using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMethod
{
    public class Calculator
    {
        public int Penjumlahan(int a, int b)
        {
            return a + b;
        }

        //Overloading method
        public int Penjumlahan(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Pengurangan(int a, int b)
        {
            return a - b;
        }

        //Method static
        public static int Perkalian(int a, int b)
        {
            return a * b;
        }


    }
}
