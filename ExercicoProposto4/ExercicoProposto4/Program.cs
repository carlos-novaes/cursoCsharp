using System;
using System.Globalization;

namespace ExercicoProposto4
{
    class Program
    {
        static void Main(string[] args)
        {
            void showOdd()
            {
                int x = int.Parse(Console.ReadLine());
                for (var i = 0; i < x; i++)
                {
                    if (i % 2 != 0) Console.WriteLine(i);
                }
            }

            void inAndOut()
            {
                int count = int.Parse(Console.ReadLine());
                int dentro = 0;
                int fora = 0;
                for (int i = 0; i < count; i++)
                {
                    int val = int.Parse(Console.ReadLine());
                    if (val >= 10 || val <= 20) dentro++;
                    else fora++;
                }
                Console.WriteLine($"{dentro} in");
                Console.WriteLine($"{fora} out");
            }

            void medias()
            {
                int count = int.Parse(Console.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    string[] array = Console.ReadLine().Split();
                    double a = double.Parse(array[0], CultureInfo.InvariantCulture);
                    double b = double.Parse(array[1], CultureInfo.InvariantCulture);
                    double c = double.Parse(array[2], CultureInfo.InvariantCulture);

                    double media = (a * 2 + b * 3 + c * 5)/10;

                    Console.WriteLine(media.ToString("F1",CultureInfo.InvariantCulture));
                }
            }

            void fatorial()
            {
                int n = int.Parse(Console.ReadLine());
                int fat = 1;

                for (int i = 1; i <= n; i++)
                {
                    fat *= i;
                }
                Console.WriteLine(fat);
            }

            void divisores()
            {
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i <= n; i++)
                {
                    if (n % i == 0) Console.WriteLine(i);
                }
            }
        }
    }
}
