using System;

namespace DiamanteDoAlfabeto.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Digite a letra limite do diamante: ");

            // Declaração de variaveis

            char letraInicial = 'A';//sempre será o A
            char letraAtual = 'F';
            int quantidadeDeEspacos = (letraAtual - letraInicial);
            int quantidadeEspacosInternos = 1;
            


            for (int espaco = 65; espaco <= letraAtual-1;  espaco++)
            {
                for (int i = quantidadeDeEspacos; i > 0; i--)// incrementa espaço
                {
                    Console.Write(" ");
                }

                    letraInicial = Convert.ToChar(espaco);
                    Console.Write(letraInicial);

                if (espaco > 65) {
                    
                    for (int i = 0; i < quantidadeEspacosInternos; i++)//espacos internos
                    {
                        Console.Write(" ");

                    }
                    Console.Write(letraInicial);
                    quantidadeEspacosInternos += 2;
                }
                    
                Console.WriteLine("\n");
                quantidadeDeEspacos--;
                
            }

            //parte Inferior


            for (int espaco = letraAtual; espaco >= 65; espaco--)
            {
                for (int i = quantidadeDeEspacos; i > 0; i--)// incrementa espaço
                {
                    Console.Write(" ");
                }

                letraInicial = Convert.ToChar(espaco);
                Console.Write(letraInicial);

                if (espaco > 65 )
                {

                    for (int i = 0; i < quantidadeEspacosInternos; i++)//espacos internos
                    {
                        Console.Write(" ");

                    }
                    Console.Write(letraInicial);
                 
                }
                quantidadeEspacosInternos -= 2;
                Console.WriteLine("\n");
                quantidadeDeEspacos++;

            }
            Console.ReadLine();
        }
    }
}
