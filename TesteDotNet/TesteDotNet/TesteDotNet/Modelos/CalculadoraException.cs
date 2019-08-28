using System;

namespace TesteDotNet.Modelos
{
    /// <summary>
    /// Classe derivada de System.Exception, para emitir exceções na Calculadora.
    /// </summary>
    public class CalculadoraException : Exception
    {
        public CalculadoraException(String mensage)
            :base(mensage)
        {

        }
    }
}
