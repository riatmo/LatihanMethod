using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int hasil;


            //Overloading Method (membuat Objek)
            Calculator hitung = new Calculator();

            //Method jumlah - Overloading Method
            hasil = hitung.Penjumlahan(10, 2);
            CetakHasil("Hasil Penjumlahan: " + hasil);

            //Method jumlah - Overloading Method
            hasil = hitung.Penjumlahan(10, 2, 3);
            CetakHasil("Hasil Penjumlahan: " + hasil);

            //method pengurangan - Overloading Method
            hasil = hitung.Pengurangan(10, 2);
            CetakHasil("Hasil Pengurangan: " + hasil);

            //Static method
            hasil = Calculator.Perkalian(10, 2);
            CetakHasil("Hasil Perkalian: " + hasil);

            Console.ReadKey();

            

        }

        static void CetakHasil(string hasil)
        {
            Console.WriteLine(hasil);
        } 
    }
}
