using System;

namespace ExercicioProposto3
{
    class Program
    {

        static void Main(string[] args)
        {
            string senha()
            {
                int pass = int.Parse(Console.ReadLine());
                while (pass != 2002)
                {
                    Console.WriteLine("Senha inválida");
                    pass = int.Parse(Console.ReadLine());

                }
                return "Acesso Permitido";
            }

            void coord()
            {
                string[] valores = Console.ReadLine().Split();
                int x = int.Parse(valores[0]);
                int y = int.Parse(valores[1]);

                while (x != 0 || y != 0)
                {
                    if (x > 0 && y > 0) Console.WriteLine("primeiro");
                    else if (x > 0 && y < 0) Console.WriteLine("segundo");
                    else if (x < 0 && y < 0) Console.WriteLine("terceiro");
                    else Console.WriteLine("quarto");

                    valores = Console.ReadLine().Split();
                    x = int.Parse(valores[0]);
                    y = int.Parse(valores[1]);
                }
            }

            void abast()
            {
                int entry = int.Parse(Console.ReadLine());
                int alcool = 0;
                int gasolina = 0;
                int diesel = 0;

                while (entry != 4)
                {
                    if (entry == 1) alcool++;
                    else if (entry == 2) gasolina++;
                    else if (entry == 3) diesel++;
                    else Console.WriteLine("Código Inválido!");

                    entry = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("MUITO OBRIGADO");
                Console.WriteLine("Alcool: " + alcool);
                Console.WriteLine("Gasolina: " + gasolina);
                Console.WriteLine("Diesel: " + diesel);
            }
        }
    }
}
