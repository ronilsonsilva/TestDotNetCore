using System;
using System.Linq;
using TesteDotNet.Modelos;

namespace TesteDotNet.Aplicacao
{
    /// <summary>
    /// Representa uma calculadora simples, usando apenas as 4 operações matemática.
    /// </summary>
    public class Calculadora
    {
        /// <summary>
        /// Realizar a operação de soma.
        /// </summary>
        /// <param name="dados"></param>
        /// <returns></returns>
        public double Soma(params double[] dados)
        {
            try
            {
                double saida = 0;
                int quantidadeParametros = dados.Length;
                if (quantidadeParametros < 2)
                {
                    throw new CalculadoraException("Não foi possível seguir com a operação de SOMA. É necessário no mínimo 2 fatores para realizar a operação.");
                }
                for (int i = 0; i < quantidadeParametros; i++)
                {
                    saida += double.Parse(dados[i].ToString());
                }
                return saida;
            }
            catch (Exception exception)
            {
                throw new Exception($"Erro ao realizar operação de soma. {exception.Message}");
            }
        }
        
        

        /// <summary>
        /// Realizar operação de subtração.
        /// </summary>
        /// <param name="dados"></param>
        /// <returns></returns>
        public double Subtracao(double numA, double numB)
        {
            try
            {
                double resultado = numA - numB;
                return resultado;
            }   
            catch (Exception exception)
            {
                throw new Exception($"Erro ao realizar operação de subtração. {exception.Message}");
            }
        }

        /// <summary>
        /// Realizar operação de Multiplicação.
        /// </summary>
        /// <param name="dados"></param>
        /// <returns></returns>
        public double Multiplicacao(double numA, double numB)
        {
            try
            {
                double resultado = numA * numB;
                return resultado;
            }   
            catch (Exception exception)
            {
                throw new Exception($"Erro ao realizar operação de multiplicação. {exception.Message}");
            }
        }

        /// <summary>
        /// Realizar operação de Divisão.
        /// </summary>
        /// <param name="dados"></param>
        /// <returns></returns>
        public double Divisao(double dividendo, double divisor)
        {
            try
            {
                if (divisor == 0)
                    throw new CalculadoraException($"O campo divisor = {divisor} deve ser diferente de 0.");
                double resultado = dividendo / divisor;
                return resultado;
            }
            catch (Exception exception)
            {
                throw new Exception($"Erro ao realizar operação de divisão. {exception.Message}");
            }
        }

        /// <summary>
        /// Calcula a média aritmética de todos números passado por parâmetro.
        /// </summary>
        /// <param name="dados"></param>
        /// <returns></returns>
        public double Media(params double[] dados)
        {
            try
            {
                double media = 0;
                if(dados.Length == 0)
                {
                    throw new CalculadoraException("Não é possível realizar o cálculo da média. É necessário no mínimo um número real válido");
                }
                if (dados.Length > 1)
                {
                    double somaNumeros = this.Soma(dados);
                    media = somaNumeros / dados.Length;
                }
                else if (dados.Length == 1)
                {
                    media = double.Parse(dados[0].ToString());
                }
                return media;
            }
            catch (Exception exception)
            {
                throw new Exception($"Erro ao calular média. {exception.Message}");
            }
        }
        
        
        /// <summary>
        /// Calcula a média aritmética somente dos números pares passado por parâmetro.
        /// </summary>
        /// <param name="dados"></param>
        /// <returns></returns>
        public double MediaDosPares(params double[] dados)
        {
            try
            {
                double media = 0;
                if(dados.Length == 0)
                {
                    throw new CalculadoraException("Não é possível realizar o cálculo da média. É necessário no mínimo um número real válido");
                }
                if (dados.Length > 1)
                {
                    double[] numerosPares = (from double numero in dados
                                             where this.NumeroPar(numero) 
                                             select numero
                                             ).ToArray();

                    double somaNumeros = this.Soma(numerosPares);
                    media = somaNumeros / numerosPares.Length;
                }
                else if (dados.Length == 1)
                {
                    double numero = double.Parse(dados[0].ToString());
                    media = this.NumeroPar(numero) ? numero : 0;
                }
                return media;
            }
            catch (Exception exception)
            {
                throw new Exception($"Erro ao calular média. {exception.Message}");
            }
        }

        /// <summary>
        /// Retorna true se o número passado por parâmetro é par.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        private Boolean NumeroPar(Double numero)
        {
            try
            {
                return (numero % 2 == 0 || numero == 0);
            }
            catch (Exception exception)
            {
                throw new Exception($"Erro ao definir número PAR. {exception.Message}");
            }
        }
    }
}
