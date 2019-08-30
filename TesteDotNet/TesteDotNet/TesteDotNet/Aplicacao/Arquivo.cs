using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TesteDotNet.Aplicacao
{
    public class Arquivo
    {
        public Dictionary<string, double> CarregarArquivo()
        {
            try
            {
                Dictionary<string, double> saida = new Dictionary<string, double>();
                StreamReader reader = new StreamReader(File.OpenRead(@"dados.csv"));

                while (!reader.EndOfStream)
                {
                    string linha = reader.ReadLine();
                    if (!String.IsNullOrWhiteSpace(linha))
                    {
                        string[] valores = linha.Split(';');
                        if (valores.Length > 3)
                        {
                            double resultado = 0;
                            Calculadora calculadora = new Calculadora();
                            String operacao = valores[1];
                            String nome = valores[0];
                            switch (operacao)
                            {
                                case "Soma":
                                    int quantideNumeros = valores.Length - 2;
                                    string[] expressao = new string[quantideNumeros];
                                    Array.Copy(valores, 2, expressao, 0, quantideNumeros);
                                    double[] numeros = expressao.Select(x => double.Parse(x)).ToArray();
                                    resultado = calculadora.Soma(numeros);
                                    break;
                                case "Subtração":
                                    resultado = calculadora.Subtracao(double.Parse(valores[2]), double.Parse(valores[3]));
                                    break;
                                case "Multiplicacao":
                                    resultado = calculadora.Multiplicacao(double.Parse(valores[2]), double.Parse(valores[3]));
                                    break;
                                case "Divisão":
                                    resultado = calculadora.Divisao(double.Parse(valores[2]), double.Parse(valores[3]));
                                    break;
                            }
                            saida.Add(nome, resultado);
                        }
                    }
                }

                return saida;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
