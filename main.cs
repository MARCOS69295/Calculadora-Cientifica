using System;

namespace CalculadoraCientifica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Científica em C#");
            Console.WriteLine("Escolha a operação: \n1. Soma \n2. Subtração \n3. Multiplicação \n4. Divisão \n5. Potência \n6. Raiz Quadrada \n7. Seno \n8. Cosseno \n9. Logaritmo Natural");

            Console.Write("Opção: ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            double resultado = 0;
            double numero1, numero2;

            switch (opcao)
            {
                case 1: // Soma
                    (numero1, numero2) = LerDoisNumeros();
                    resultado = numero1 + numero2;
                    break;
                case 2: // Subtração
                    (numero1, numero2) = LerDoisNumeros();
                    resultado = numero1 - numero2;
                    break;
                case 3: // Multiplicação
                    (numero1, numero2) = LerDoisNumeros();
                    resultado = numero1 * numero2;
                    break;
                case 4: // Divisão
                    (numero1, numero2) = LerDoisNumeros();
                    resultado = numero1 / numero2;
                    break;
                case 5: // Potência
                    (numero1, numero2) = LerDoisNumeros();
                    resultado = Math.Pow(numero1, numero2);
                    break;
                case 6: // Raiz Quadrada
                    Console.Write("Digite o número: ");
                    numero1 = Convert.ToDouble(Console.ReadLine());
                    resultado = Math.Sqrt(numero1);
                    break;
                case 7: // Seno
                    Console.Write("Digite o ângulo em graus: ");
                    numero1 = Convert.ToDouble(Console.ReadLine());
                    resultado = Math.Sin(NumeroParaRadianos(numero1));
                    break;
                case 8: // Cosseno
                    Console.Write("Digite o ângulo em graus: ");
                    numero1 = Convert.ToDouble(Console.ReadLine());
                    resultado = Math.Cos(NumeroParaRadianos(numero1));
                    break;
                case 9: // Logaritmo Natural
                    Console.Write("Digite o número: ");
                    numero1 = Convert.ToDouble(Console.ReadLine());
                    resultado = Math.Log(numero1);
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Console.WriteLine($"Resultado: {resultado}");
            Console.ReadKey();
        }

        private static (double, double) LerDoisNumeros()
        {
            Console.Write("Digite o primeiro número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            return (numero1, numero2);
        }

        private static double NumeroParaRadianos(double numero)
        {
            return (Math.PI / 180) * numero;
        }
    }
}
