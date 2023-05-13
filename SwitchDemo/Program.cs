using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Nhap vao phep tinh ban muon thuc hien:");
            Console.WriteLine("1: Phep cong");
            Console.WriteLine("2: Phep tru");
            Console.WriteLine("3: Phep nhan");
            Console.WriteLine("4: Phep chia");

            i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1: Console.WriteLine("Phep cong"); break; 
                case 2: Console.WriteLine("Phep tru"); break;
                case 3: Console.WriteLine("Phep nhan"); break;
                case 4: Console.WriteLine("Phep chia"); break;
                default: Console.WriteLine($"Khong co chuc nang so {i}"); break;

            }

            Console.ReadLine();

        }
    }
}
