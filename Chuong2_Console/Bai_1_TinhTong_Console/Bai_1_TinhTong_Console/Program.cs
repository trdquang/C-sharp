using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, tong = 0;
            do{
                Console.Write("Nhap so nguyen duong n = ");
                n = int.Parse(Console.ReadLine());
                if(n <= 0)
                    Console.WriteLine("Nhap sai. Nhap lai");
            }while(n <= 0);

            for (int i = 1; i <= n; i++)
                tong += i;
            Console.WriteLine("Tong cac so tu 1 den {0} = {1}", n, tong);
            Console.ReadKey();
        }
    }
}
