using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhThue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double thuNhap, thue;
            Console.WriteLine("Nhap vao thu nhap (dv Trieu Dong");
            thuNhap = double.Parse(Console.ReadLine());

            //if (thuNhap < 9)
            //{
            //    thue = 0;
            //    Console.WriteLine($"So thue can dong la {thue}");
            //}

            //if (thuNhap >= 9 && thuNhap < 15)
            //{
            //    thue = thuNhap * 0.1;
            //    Console.WriteLine($"So thue can dong la {thue}");
            //}


            if (thuNhap < 9)
            {
                thue = 0;
                Console.WriteLine($"So thue can dong la {thue}");
            }
            else if (thuNhap >= 9 && thuNhap < 15)
            {
                thue = thuNhap * 0.1;
                Console.WriteLine($"So thue can dong la {thue}");
            }


            //if (thuNhap >= 15 && thuNhap < 30)
            //{
            //    thue = thuNhap * 0.15;
            //    Console.WriteLine($"So thue can dong la {thue}");
            //}else if (thuNhap >= 30)
            //{
            //    thue = thuNhap * 0.2;
            //    Console.WriteLine($"So thue can dong la {thue}");
            //}
            Console.ReadLine();

        }
    }
}
