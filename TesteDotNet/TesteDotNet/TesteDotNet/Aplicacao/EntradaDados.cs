using System;
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
                Console.WriteLine("================ SOMA ================");
                Console.WriteLine("Para realizar soma, forneça no mínimo 2 numeros separado por ';' ponto e vírgula:");
                this.entradaExpressao = Console.ReadLine();
                double[] numeros = entradaExpressao.Split(';').Select(x => double.Parse(x)).ToArray();
                double resultado = this.calculadora.Soma(numeros);
                Console.WriteLine($"Resultado da operação: {String.Join("+", numeros)} = {resultado}\n");
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void Subtracao()
        {
            try
            {
                this.entradaExpressao = "";
                Console.WriteLine("================ SUBTRAÇÃO ================");
                Console.WriteLine("Para realizar subtração, forneça exatamente 2 numeros separado por ';' ponto e vírgula:");
                this.entradaExpressao = Console.ReadLine();
                double[] numeros = entradaExpressao.Split(';').Select(x => double.Parse(x)).ToArray();
                double resultado = this.calculadora.Subtracao(numeros[0], numeros[1]);
                Console.WriteLine($"Resultado da operação: {String.Join("-", numeros)} = {resultado}\n");
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void Multiplicacao()
        {
            try
            {
                this.entradaExpressao = "";
                Console.WriteLine("================ MULTIPLICAÇÃO ================");
                Console.WriteLine("Para realizar multiplicação, forneça exatamente 2 numeros separado por ';' ponto e vírgula:");
                this.entradaExpressao = Console.ReadLine();
                double[] numeros = entradaExpressao.Split(';').Select(x => double.Parse(x)).ToArray();
                double resultado = this.calculadora.Multiplicacao(numeros[0], numeros[1]);
                Console.WriteLine($"Resultado da operação: {String.Join("*", numeros)} = {resultado}\n");
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void Divisao()
        {
            try
            {
                this.entradaExpressao = "";
                Console.WriteLine("================ DIVISÃO ================");
                Console.WriteLine("Para realizar divisão, forneça exatamente 2 numeros separado por ';' ponto e vírgula:");
                this.entradaExpressao = Console.ReadLine();
                double[] numeros = entradaExpressao.Split(';').Select(x => double.Parse(x)).ToArray();
                double resultado = this.calculadora.Divisao(numeros[0], numeros[1]);
                Console.WriteLine($"Resultado da operação: {String.Join("/", numeros)} = {resultado}\n");
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void Media()
        {
            try
            {
                this.entradaExpressao = "";
                Console.WriteLine("================ MÉDIA ================");
                Console.WriteLine("Para realizar o cálculo da média, forneça um conjunto de numeros separado por ';' ponto e vírgula:");
                this.entradaExpressao = Console.ReadLine();
                double[] numeros = entradaExpressao.Split(';').Select(x => double.Parse(x)).ToArray();
                double resultado = this.calculadora.Media(numeros);
                Console.WriteLine($"Média de : [{String.Join(",", numeros)}] = {resultado}\n");
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void MediaDosPares()
        {
            try
            {
                this.entradaExpressao = "";
                Console.WriteLine("================ MÉDIA DOS PARES ================");
                Console.WriteLine("Para realizar o cálculo da média, forneça um conjunto de numeros separado por ';' ponto e vírgula:");
                this.entradaExpressao = Console.ReadLine();
                double[] numeros = entradaExpressao.Split(';').Select(x => double.Parse(x)).ToArray();
                double resultado = this.calculadora.MediaDosPares(numeros);
                Console.WriteLine($"Média de : [{String.Join(",", numeros)}] = {resultado}\n");
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
