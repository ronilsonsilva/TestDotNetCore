using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TesteDotNet.Modelos
{
    public class Arquivo
    {
        public String Nome { get; set; }
        public String Operacao { get; set; }
        public object[] expressao { get; set; }

        public List<Arquivo> CarregarArquivo()
        {
            try
            {
                List<Arquivo> saida = new List<Arquivo>();

                StreamReader reader = new StreamReader(File.OpenRead(@"dados.csv"));

                while (!reader.EndOfStream)
                {
                    string linha = reader.ReadLine();
                    if (!String.IsNullOrWhiteSpace(linha))
                    {
                        string[] valores = linha.Split(';');
                        if (valores.Length > 2)
                        {
                            Arquivo arquivo = new Arquivo()
                            {
                            };
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
