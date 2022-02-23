using System;

namespace lab6._1.___
{
    class Program
    {
        static void Stopnie()
        {
            Double[,] tab = new Double[10,2];
            for (int a = 0; a < 10; a++)
            {
                for (int b = 0; b <= 2; b++)
                {
                    if (b == 0)
                    {
                        Double x = ((a* 10) * (2 * Math.PI)) / 360;
                        Double Sin = Math.Round(Math.Sin(x), 5);
                        tab[a,b] = Sin;
                        Console.WriteLine($"Sinus {a * 10}° = " + tab[a,b]);
                    }
                    else
                    {
                        Double x = ((a * 10) * (2 * Math.PI)) / 360;
                        Double Cos = Math.Round(Math.Cos(x), 5);
                        tab[a,1] = Cos;
                        Console.SetCursorPosition(25, a);
                        Console.WriteLine($"Cosinus {a * 10}° = " + tab[a,1]);
                    }
                }
            }
            
        }
        static void Main(string[] args)
        {
            Stopnie();
            Console.ReadLine();
        }
    }
}
