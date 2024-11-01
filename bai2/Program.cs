namespace bai2;

class Program
{
    static void Main(string[] args)
    {
        int Vo = 20;
        int cor = 30;
        int g = 10;
        Console.WriteLine("a, Thanh phan van toc ban dau: ");
        Console.WriteLine("Phuong ngang: ");
        double VoX = Vo * Math.Cos(Math.PI / 6);
        Console.WriteLine("VoX = "+ Math.Round(VoX,4)+"m/s");
        Console.WriteLine("Phuong doc: ");
        double VoY = Vo * Math.Sin(Math.PI / 6);
        Console.WriteLine("VoY = "+ Math.Round(VoY,4) +"m/s");
        
        Console.WriteLine("b,Tinh thoi gian vat len den diem cao nhat: ");
        double t = VoY / 10;
        Console.WriteLine("To = " + Math.Round(t,4)+"s");
        
        Console.WriteLine("c, Tinh chieu cao cuc dai ma vat dat duoc. ");
        double hmax = VoY * t - 0.5 * g * 1 * 1;
        Console.WriteLine("hmax = " + Math.Round(hmax,4)+"m");
        
        Console.WriteLine("d, Tong quang duong . ");
        double S = VoX * 2;
        Console.WriteLine("S = " + Math.Round(S,4)+"s");

    }
    
}