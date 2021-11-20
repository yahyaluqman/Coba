using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coba
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double hasilTambah = obj.Tambah(1, 2);
            Console.WriteLine("1 + 2 = " + hasilTambah);
            double hasilKurang = obj.Kurang(3, 2);
            Console.WriteLine("3 - 2 = " + hasilKurang);
            double hasilKali = obj.Kali(2, 2);
            Console.WriteLine("2 x 2 = " + hasilKali);
            double hasilBagi = obj.Bagi(2, 2);
            Console.WriteLine("2 / 2 = " + hasilBagi);
            Console.ReadLine();
           
        }
    }
}
