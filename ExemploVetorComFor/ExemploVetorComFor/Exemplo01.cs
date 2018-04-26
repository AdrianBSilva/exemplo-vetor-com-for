using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploVetorComFor
{
    class Exemplo01
    {
        public Exemplo01()
        {
            string[] mortesDoFilme = new string[5];
            // FORMA OLD
            // mortesDoFilme = "Tony Stark";

            // ARMAZENA AS IMFORMÇÔES NO VETOR
            for (int i = 0; i < mortesDoFilme.Length; i++)
			{
	            Console.Write("Digite o nome da pessoa: ");
		        mortesDoFilme[i] = Console.ReadLine();
			}
            Console.Clear();
            Console.WriteLine("Pessoas cadastradas: ");
            // APRESENTAR AS IMFORMAÇÕES DO VETOR
            for (int i = 0; i < mortesDoFilme.Length; i++)
            {
                Console.WriteLine("nome: " + mortesDoFilme[i]);
            }
        }
    }
}
