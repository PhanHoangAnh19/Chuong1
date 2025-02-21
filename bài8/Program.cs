// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int i_101, n_101;
        double S_101 = 0;

        do
        {
            Console.Write("Bai so 8");
            Console.Write("\nNhap n_101: ");
            n_101 = int.Parse(Console.ReadLine());

            if (n_101 < 1)
            {
                Console.WriteLine("\nN_101 phai lon hon hoac bang 1. Xin nhap lai !");
            }
        } while (n_101 < 1);

        for (i_101 = 0; i_101 < n_101; i_101++)
        {
            S_101 += 1.0 / (2 *( i_101 + 1));
        }

        Console.WriteLine("tong la: {0}", S_101);

        Console.ReadKey();
    }
}

