using System;

namespace ExerciciosPropostos2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isItPos()
            {
                Console.WriteLine("Entre com um numero:");
                int a = int.Parse(Console.ReadLine());

                if (a >= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

                // return (a > 0);
                // return (a > 0) ? true : false;
            }
            // Console.WriteLine(isItPos());

            string evenOrOdd()
            {
                Console.WriteLine("Digite um numero:");
                int n = int.Parse(Console.ReadLine());

                if (n % 2 == 0)
                {
                    return "Par";
                }
                else
                {
                    return "Impar";
                }

                // return (n % 2 == 0) ? "Par" : "Impar";
            }
            // evenOrOdd();

            string multiplos()
            {
                Console.WriteLine("Entre com dois números (mesma linha):");
                string[] vet = Console.ReadLine().Split();

                int a = int.Parse(vet[0]);
                int b = int.Parse(vet[1]);

                if (a % b == 0 || b % a == 0)
                {
                    return "São Multiplos";
                }
                else
                {
                    return "Não são múltiplos";
                }
            }
            //multiplos();

            string duracao()
            {
                Console.WriteLine("Insira hora de inicio:");
                int begin = int.Parse(Console.ReadLine());

                Console.WriteLine("Insira hora de término:");
                int end = int.Parse(Console.ReadLine());

                int total = 0;

                if (begin < end)
                {
                    total = end - begin;
                }
                else if (end < begin)
                {
                    total = 24 - begin + end;
                } else
                {
                    return ($"O jogo durou 24 horas");
                }

                return ($"O jogo durou {total} horas");
            }
            // Console.WriteLine(duracao());
        }
    }
}
