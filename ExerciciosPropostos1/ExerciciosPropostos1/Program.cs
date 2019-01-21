using System;
using System.Globalization;

namespace ExerciciosPropostos1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercício 1
            void soma()
            {
                Console.WriteLine("Entre com o primeiro número:");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Entre com o segundo número:");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine(num1 + num2);
                return;
            }
            // soma();

            void area()
            {
                Console.WriteLine("Entre com o raio do círculo:");
                double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double a = Math.PI * Math.Pow(r, 2);
                string result = a.ToString("F4", CultureInfo.InvariantCulture);

                Console.WriteLine(result);
                return;
            }
            // area();

            void diferenca()
            {
                Console.WriteLine("Entre com o primeiro número:");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Entre com o segundo número:");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Entre com o terceiro número:");
                int c = int.Parse(Console.ReadLine());

                Console.WriteLine("Entre com o quarto número:");
                int d = int.Parse(Console.ReadLine());

                int dif = a * b - c * d;
                Console.WriteLine(dif);
            }
            // diferenca();

            void salario()
            {
                Console.WriteLine("Entre com o seu número de identificação:");
                int num = int.Parse(Console.ReadLine());

                Console.WriteLine("Entre com o número de horas trabalhadas:");
                int horas = int.Parse(Console.ReadLine());

                Console.WriteLine("Entre com o valor que recebe por hora:");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double result = horas * valor;

                Console.WriteLine($"Number = {num}");
                Console.WriteLine($"Salary = U$ {result.ToString("F2", CultureInfo.InvariantCulture)}");

                return;
            }
            // salario();

            void valorAPagar()
            {
                Console.WriteLine("Entre com o código da peça 1, número de peças 1 e o valor da peça 1 (mesma linha):");
                string[] vet1 = Console.ReadLine().Split();
                int cod1 = int.Parse(vet1[0]);
                int qtd1 = int.Parse(vet1[1]);
                double preco1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

                Console.WriteLine("Entre com o código da peça 2, número de peças 2 e o valor da peça 2 (mesma linha):");
                string[] vet2 = Console.ReadLine().Split();
                int cod2 = int.Parse(vet2[0]);
                int qtd2 = int.Parse(vet2[1]);
                double preco2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

                double total = qtd1 * preco1 + qtd2 * preco2;
                Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
                return;
            }
            // valorAPagar();

            void multipleAreas()
            {
                Console.WriteLine("Entre com os 3 valores (mesma linha):");
                string[] vet = Console.ReadLine().Split();
                double A = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double B = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double C = double.Parse(vet[2], CultureInfo.InvariantCulture);

                double areaTriangulo = (A * C) / 2;
                double areaCirculo = Math.PI * Math.Pow(C, 2);
                double areaTrapezio = ((A + B) * C) / 2;
                double areaQuadrado = Math.Pow(B, 2);
                double areaRetangulo = A * B;

                Console.WriteLine($"Triangulo: {areaTriangulo.ToString("F3", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Circulo: {areaCirculo.ToString("F3", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Trapezio: {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Quadrado: {areaQuadrado.ToString("F3", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Retangulo: {areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            }
            // multipleAreas();
        }
    }
}
