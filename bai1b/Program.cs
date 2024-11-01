using System.Text;
using System.Threading.Tasks;
namespace bai1b;

class Program
{
    static void Main(string[] args)
    {
        double x;
        Console.Write("Enter t: ");
        double t = double.Parse(Console.ReadLine());
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        
        x =a*double.Cos(b*Math.PI*t + Math.PI/2);
        Console.WriteLine("t = " + t+"s");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("x = " + Math.Round(x, 4)+"cm");
    }
}