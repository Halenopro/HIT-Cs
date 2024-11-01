using System;

namespace BTVN_1;

class Program
{
    static void Main(string[] args)
    {
        double t= 2.125D;
        double x;
        // Console.WriteLine("Nhap t= ");
        // string nhap = Console.ReadLine();
        //
        // t = Convert.ToDouble(nhap);
         x =Math.Abs(9*double.Cos(5*Math.PI*t + Math.PI/2));
        Console.WriteLine("t = " + t+"s");
        Console.WriteLine("x = " + Math.Round(x, 4)+"cm");
        
        
        
    }
}