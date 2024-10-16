using System;
using System.Threading;

class Program
{
    static void Main()
    {
        float A = 0, B = 0, i, j;
        int k;
        float[] z = new float[1760];
        char[] b = new char[1760];

        string text = "Pera";

        while (!(Console.KeyAvailable && Console.ReadKey(false).Key == ConsoleKey.Escape))
        {
            Console.CursorVisible = false;
            Array.Clear(z);
            Array.Fill(b, ' '); 

            for (j = 0; j < 6.28; j += (float)0.07)
            {
                for (i = 0; i < 6.28; i += (float)0.02)
                {
                    float c = (float)Math.Sin(i),
                          d = (float)Math.Cos(j),
                          e = (float)Math.Sin(A),
                          f = (float)Math.Sin(j),
                          g = (float)Math.Cos(A);
                    float h = d + 2, D = 1 / (c * h * e + f * g + 5);
                    float l = (float)Math.Cos(i),
                          m = (float)Math.Cos(B),
                          n = (float)Math.Sin(B);
                    float t = c * h * g - f * e;
                    int x = (int)(40 + 30 * D * (l * h * m - t * n));
                    int y = (int)(12 + 15 * D * (l * h * n + t * m));
                    int o = x + 80 * y;

                    if (22 > y && y > 0 && x > 0 && 80 > x && D > z[o])
                    {
                        z[o] = D;
                        b[o] = text[(o % text.Length)]; 
                    }
                }
            }

            Console.SetCursorPosition(0, 0); 
            for (k = 0; k < 1760; k++)
            {
                Console.Write(k % 80 != 0 ? b[k] : '\n');
            }
            A += (float)0.04;
            B += (float)0.02;
            Thread.Sleep(20); // speed
        }
    }
}
