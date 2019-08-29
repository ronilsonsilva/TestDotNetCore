using System;
using System.Threading;
using TesteDotNet.Aplicacao;

namespace TesteDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Testes
            //Console.WriteLine("Seja bem vindo!");

            //Calculadora calculadora = new Calculadora();
            //////Teste soma
            //Console.WriteLine("Teste SOMA");
            //double resultado = calculadora.Soma(4, 7, 8, 9, 10, 15);
            //Console.WriteLine($"Soma: 4+7+8+9+10+15 = {resultado}");
            //resultado = calculadora.Soma(2.5, 4.666, 0.666, 2, 6, 10000, 12345);
            //Console.WriteLine($"Soma: 2.5+4.666+0.666+2+6+10000+12345 = {resultado}");
            //resultado = calculadora.Soma(5, -8, 12, -95, -0.8884);
            //Console.WriteLine($"Soma: 5+-8+12+-95+-0.8884 = {resultado}");

            ////Teste Subtração
            //Console.WriteLine("Teste SUBTRAÇÃO");
            //resultado = calculadora.Subtracao(100, 10);
            //Console.WriteLine($"Subtração: 100-10 = {resultado}");

            ////Teste Multiplicação
            //Console.WriteLine("Teste Multiplicação");
            //resultado = calculadora.Multiplicacao(2, 4);
            //Console.WriteLine($"Multiplicação: 2*4 = {resultado}");

            ////Teste Divisão
            //Console.WriteLine("Teste Divisão");
            //resultado = calculadora.Divisao(100,10);
            //Console.WriteLine($"Expressão: 100/10 = {resultado}");

            ////Teste calcular média
            //Console.WriteLine("Teste cálculo de média");
            //resultado = calculadora.Media(8, 5, 6, 12, 45, 9);
            //Console.WriteLine($"Média de [8, 5, 6, 12, 45, 9] = {resultado}");


            ////Teste calcular media somente de números pares
            //Console.WriteLine("Teste calcular media somente de numeros pares");
            //resultado = calculadora.MediaDosPares(8, 5, 6, 12, 45, 9);
            //Console.WriteLine($"Média de [8, 5, 6, 12, 45, 9] = {resultado}");

            //ConsoleKeyInfo consoleKey;

            //Console.WriteLine("Pressione (Esc) para encerrar: \n");
            //do
            //{
            //    consoleKey = Console.ReadKey();
            //} while (consoleKey.Key != ConsoleKey.Escape);
            #endregion

            EntradaDados entradaDados = new EntradaDados();


            Console.WriteLine("============= Seja bem vindo! =============");
            

            ConsoleKeyInfo consoleKey;
            

            do
            {
                ExibirMenu();
                consoleKey = Console.ReadKey(true);
                String entrada = consoleKey.KeyChar.ToString();
                switch (entrada)
                {
                    case "1":
                        entradaDados.Soma();
                        break;
                    case "2":
                        entradaDados.Subtracao();
                        break;
                    case "3":
                        entradaDados.Multiplicacao();
                        break;
                    case "4":
                        entradaDados.Divisao();
                        break;
                    case "5":
                        entradaDados.Media();
                        break;
                    case "6":
                        entradaDados.MediaDosPares();
                        break;
                    default:
                        Console.WriteLine("Entrada inválida. Para prosseguir escolha uma das opção do menu.");
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para continuar ou ESC para sair...\n");
                consoleKey = Console.ReadKey(true);
            } while (consoleKey.Key != ConsoleKey.Escape);

            Console.WriteLine("Obrigado por utilizar nossa calculadora...");
            Thread.Sleep(2000);
            return;
        }

        private static void ExibirMenu()
        {
            try
            {
                Console.WriteLine("Selecione a operação que deseja realizar:");
                Console.WriteLine("\t1 - SOMA");
                Console.WriteLine("\t2 - SUBTRAÇÃO");
                Console.WriteLine("\t3 - MULTIPLICAÇÃO");
                Console.WriteLine("\t4 - DIVISÃO");
                Console.WriteLine("\t5 - MÉDIA");
                Console.WriteLine("\t6 - MÉDIA DOS PARES");
                Console.WriteLine("\tESC - ENCERRAR");
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
        
    }
}
