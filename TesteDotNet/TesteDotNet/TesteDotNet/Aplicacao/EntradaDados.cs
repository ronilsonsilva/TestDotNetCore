using System;
using System.Collections.Generic;
using System.Linq;

namespace TesteDotNet.Aplicacao
{
    public class EntradaDados
    {
        private String entradaExpressao;
        private Calculadora calculadora;

        public EntradaDados()
        {
            this.calculadora = new Calculadora();
        }

        public void Soma()
        {
            try
            {
                this.entradaExpressao = "";
                Console.WriteLine("================ SOMA ================", Console.ForegroundColor = ConsoleColor.Green);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Para realizar soma, forneça no mínimo 2 numeros separado por ';' ponto e vírgula:");
                this.entradaExpressao = Console.ReadLine();
                String expressaoValida = this.ValidarEntrada(this.entradaExpressao);
                if (!expressaoValida.Equals(""))
                    throw new Exception(expressaoValida);

                double[] numeros = entradaExpressao.Split(';').Select(x => double.Parse(x)).ToArray();
                double resultado = this.calculadora.Soma(numeros);
                Console.WriteLine($"Resultado da operação: {String.Join("+", numeros)} = {resultado}\n");
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Erro no método Soma. SISTEMA DIZ: {exception.Message} ", Console.ForegroundColor = ConsoleColor.Red);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void Subtracao()
        {
            try
            {
                this.entradaExpressao = "";
                Console.WriteLine("================ SUBTRAÇÃO ================", Console.ForegroundColor = ConsoleColor.Green);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Para realizar subtração, forneça exatamente 2 numeros separado por ';' ponto e vírgula:");
                this.entradaExpressao = Console.ReadLine();

                String expressaoValida = this.ValidarEntrada(this.entradaExpressao);
                if (!expressaoValida.Equals(""))
                    throw new Exception(expressaoValida);

                double[] numeros = entradaExpressao.Split(';').Select(x => double.Parse(x)).ToArray();
                double resultado = this.calculadora.Subtracao(numeros[0], numeros[1]);
                Console.WriteLine($"Resultado da operação: {String.Join("-", numeros)} = {resultado}\n");
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Erro no método Subtracao. SISTEMA DIZ: {exception.Message} ", Console.ForegroundColor = ConsoleColor.Red);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void Multiplicacao()
        {
            try
            {
                this.entradaExpressao = "";
                Console.WriteLine("================ MULTIPLICAÇÃO ================", Console.ForegroundColor = ConsoleColor.Green);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Para realizar multiplicação, forneça exatamente 2 numeros separado por ';' ponto e vírgula:");
                this.entradaExpressao = Console.ReadLine();

                String expressaoValida = this.ValidarEntrada(this.entradaExpressao);
                if (!expressaoValida.Equals(""))
                    throw new Exception(expressaoValida);

                double[] numeros = entradaExpressao.Split(';').Select(x => double.Parse(x)).ToArray();
                double resultado = this.calculadora.Multiplicacao(numeros[0], numeros[1]);
                Console.WriteLine($"Resultado da operação: {String.Join("*", numeros)} = {resultado}\n");
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Erro no método Multiplicacao. SISTEMA DIZ: {exception.Message} ", Console.ForegroundColor = ConsoleColor.Red);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void Divisao()
        {
            try
            {
                this.entradaExpressao = "";
                Console.WriteLine("================ DIVISÃO ================", Console.ForegroundColor = ConsoleColor.Green);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Para realizar divisão, forneça exatamente 2 numeros separado por ';' ponto e vírgula:");
                this.entradaExpressao = Console.ReadLine();

                String expressaoValida = this.ValidarEntrada(this.entradaExpressao);
                if (!expressaoValida.Equals(""))
                    throw new Exception(expressaoValida);

                double[] numeros = entradaExpressao.Split(';').Select(x => double.Parse(x)).ToArray();
                double resultado = this.calculadora.Divisao(numeros[0], numeros[1]);
                Console.WriteLine($"Resultado da operação: {String.Join("/", numeros)} = {resultado}\n");
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Erro no método Divisao. SISTEMA DIZ: {exception.Message} ", Console.ForegroundColor = ConsoleColor.Red);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void Media()
        {
            try
            {
                this.entradaExpressao = "";
                Console.WriteLine("================ MÉDIA ================", Console.ForegroundColor = ConsoleColor.Green);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Para realizar o cálculo da média, forneça um conjunto de numeros separado por ';' ponto e vírgula:");
                this.entradaExpressao = Console.ReadLine();

                String expressaoValida = this.ValidarEntrada(this.entradaExpressao);
                if (!expressaoValida.Equals(""))
                    throw new Exception(expressaoValida);

                double[] numeros = entradaExpressao.Split(';').Select(x => double.Parse(x)).ToArray();
                double resultado = this.calculadora.Media(numeros);
                Console.WriteLine($"Média de : [{String.Join(",", numeros)}] = {resultado}\n");
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Erro no método Media. SISTEMA DIZ: {exception.Message} ", Console.ForegroundColor = ConsoleColor.Red);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void MediaDosPares()
        {
            try
            {
                this.entradaExpressao = "";
                Console.WriteLine("================ MÉDIA DOS PARES ================", Console.ForegroundColor = ConsoleColor.Green);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Para realizar o cálculo da média, forneça um conjunto de numeros separado por ';' ponto e vírgula:");
                this.entradaExpressao = Console.ReadLine();

                String expressaoValida = this.ValidarEntrada(this.entradaExpressao);
                if (!expressaoValida.Equals(""))
                    throw new Exception(expressaoValida);

                double[] numeros = entradaExpressao.Split(';').Select(x => double.Parse(x)).ToArray();
                double resultado = this.calculadora.MediaDosPares(numeros);
                Console.WriteLine($"Média de : [{String.Join(",", numeros.Where(x => x%2 == 0).ToArray())}] = {resultado}\n");
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Erro no MediaDosPares. SISTEMA DIZ: {exception.Message} ", Console.ForegroundColor = ConsoleColor.Red);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        protected String ValidarEntrada(String texto)
        {
            try
            {
                String saida = "";


                if (String.IsNullOrEmpty(texto))
                    saida += $"Entrada inválida. Forneça os valores separado por ';' ponto e vírgula.\n";

                String[] array = texto.Split(';');
                if (array.Count() <= 1 )
                    saida += $"Entrada inválida. Forneça os valores separado por ';' ponto e vírgula.\n";
                for (int i = 0; i < array.Length; i++)
                {
                    double result = 0;
                    if(!Double.TryParse(array[i], out result))
                    {
                        saida += $"A cadeia de caracteres [{array[i]}] não representa um tipo numérico válido.";
                    }
                }

                return saida;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void LerArquivo()
        {
            try
            {
                this.entradaExpressao = "";
                Console.WriteLine("================ LER ARQUIVO 'dados.csv' ================", Console.ForegroundColor = ConsoleColor.Green);
                Console.ForegroundColor = ConsoleColor.White;

                Arquivo arquivo = new Arquivo();
                Dictionary<string, double> resultadoArquivo = arquivo.CarregarArquivo();
                Console.WriteLine(String.Join("\n", resultadoArquivo));
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Erro no método LerArquivo. SISTEMA DIZ: {exception.Message} ", Console.ForegroundColor = ConsoleColor.Red);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
