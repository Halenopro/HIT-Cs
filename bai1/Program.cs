using System;
namespace week2;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Ve hinh chu nhat: ");
        Console.WriteLine("Nhap chieu rong: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap chieu dai: ");
        int y = int.Parse(Console.ReadLine());

        for (int t = 0; t < x; t++)
        {
            for (int j = 0; j < y; j++)
            {
                if (t == 0 || t == x - 1 || j == 0 || j == y - 1)
                {
                    Console.Write("*");
                }

                else
                {
                    Console.Write(" ");
                    ;
                }
            }

            Console.WriteLine();
        }

        int a, b;
        Console.WriteLine("Ve hinh tam giac can: ");
        Console.WriteLine("Nhap do dai canh ben: ");
        int n = int.Parse(Console.ReadLine());

        for (int k = 1; k <= n-1; k++)
        {
            Console.Write(" ");//In dong dau
        }
        Console.Write("*\n");
        int i = 2;
        while (i <= n - 1)
        {
            a = n - i;
            for (int k=1 ; k <= a; k++)
            {
                Console.Write(" ");
            }
            Console.Write("*");

            b = 2 * i - 3;
            for (int k = 1; k <= b; k++)
            {
                Console.Write(" ");
            }
            Console.Write("*\n");
            i++;

        }

        for (int k = 1; k <= 2 * n - 1; k++)
        {
            Console.Write("*");
        }
    }
}   