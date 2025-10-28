using System;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        // переопределение вывода и ввода
        TextWriter save_out = Console.Out;
        TextReader save_in = Console.In;
        var new_out = new StreamWriter(@"output.txt");
        var new_in = new StreamReader(@"input.txt");
        Console.SetOut(new_out);
        Console.SetIn(new_in);

        // используемые переменные
        double a, b, c, d, e;
        double s, k;

        a = Convert.ToDouble(Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());
        c = Convert.ToDouble(Console.ReadLine());
        d = Convert.ToDouble(Console.ReadLine());
        e = Convert.ToDouble(Console.ReadLine());

        // расчет s
        if (c+b-e > 0)
        {
            s = b / (Math.Sqrt(c + b - e) + 1);
            Console.WriteLine(Math.Round(s, 4));
        }
        else
        {
            Console.WriteLine("Error");
        }

        // расчеть k
        if (a >= 0)
        {
            k = Math.Sqrt(c + Math.Sqrt(b - a)) / Math.Sqrt(a);
            Console.WriteLine(Math.Round(k, 4));
        }
        else
        {
            Console.WriteLine("Error");
        }


        Console.SetOut(save_out);
        Console.SetIn(save_in);

        new_out?.Close();
        new_in?.Close();        

    }
}