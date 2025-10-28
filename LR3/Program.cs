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
        int t = 0, N = 1;
        double X, Y, Z=0;

        t = Convert.ToInt32(Console.ReadLine());
        N = Convert.ToInt32(Console.ReadLine());
        X = Convert.ToDouble(Console.ReadLine());
        Y = Convert.ToDouble(Console.ReadLine());


        // for
        if (t == 0)
        {
            for (int i = 0; i < N; i++)
            {
                int powx, powy;
                if (i != 0)
                {
                    powx = 2 + 4 * (i / 2);
                    powy = 4 * ((i + 1) / 2);
                }
                else
                {
                    powx = 1;
                    powy = 2;
                }

                double temp_Z = Math.Pow(X, powx) * Math.Pow(Y, powy);
                if (i % 2 == 0) // четный плюс 
                {
                    Z += temp_Z / (powy + powx);
                }
                else // нечетный минус
                {
                    Z -= temp_Z / (powx - powy);
                }


            }


        }
        // while
        else if (t == 1)
        {
            int i = 0;
            while (i < N)
            {
                int powx, powy;
                if (i != 0)
                {
                    powx = 2 + 4 * (i / 2);
                    powy = 4 * ((i + 1) / 2);
                }
                else
                {
                    powx = 1;
                    powy = 2;
                }

                double temp_Z = Math.Pow(X, powx) * Math.Pow(Y, powy);

                if (i % 2 == 0)
                {
                    Z += temp_Z / (powy + powx);
                }
                else
                {
                    Z -= temp_Z / (powx - powy);
                }

                i++; // обязательно увеличиваем i
            }
        }

        // do while  
        else if (t == 2)
        {
            int i = 0;
            do
            {
                int powx, powy;
                if (i != 0)
                {
                    powx = 2 + 4 * (i / 2);
                    powy = 4 * ((i + 1) / 2);
                }
                else
                {
                    powx = 1;
                    powy = 2;
                }

                double temp_Z = Math.Pow(X, powx) * Math.Pow(Y, powy);

                if (i % 2 == 0)
                {
                    Z += temp_Z / (powy + powx);
                }
                else
                {
                    Z -= temp_Z / (powx - powy);
                }

                i++;
            } while (i < N);
        }

        Console.WriteLine(Z);


        Console.SetOut(save_out);
        Console.SetIn(save_in);

        new_out?.Close();
        new_in?.Close();        


    }
}