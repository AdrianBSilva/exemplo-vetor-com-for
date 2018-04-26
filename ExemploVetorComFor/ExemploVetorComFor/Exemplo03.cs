using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploVetorComFor
{
    class Exemplo03
    {
        public Exemplo03()
        {
            Console.Write("Digite a quantidade de registro que deseja cadastrar: ");
            int quantidadedeRegistros = Convert.ToInt32(Console.ReadLine());

            string[] fazendas = new string[quantidadedeRegistros];
            int[] quantidadedePorcos = new int[quantidadedeRegistros];

            for (int i = 0; i < fazendas.Length; i++)
            {
                Console.Write("Nome da Fazenda: ");
                fazendas[i] = Console.ReadLine();
                Console.Write("Quantidade de suinos: ");
                quantidadedePorcos[i] = Convert.ToInt32(Console.ReadLine());
            }
            // Fazenda com a maior quantidade de suínos
            int maiorQuantidadeSuinos = int.MinValue;
            string fazendaMaiorQuantidadedeSuinos = "";
            for (int i = 0; i < quantidadedePorcos.Length; i++)
            {
                if (quantidadedePorcos[i] > maiorQuantidadeSuinos)
                {
                    maiorQuantidadeSuinos = quantidadedePorcos[i];
                    fazendaMaiorQuantidadedeSuinos = fazendas[i];
                }
            }
            Console.WriteLine("Fazenda com maior quantidades de porcos: " + fazendaMaiorQuantidadedeSuinos
                + " contém " + maiorQuantidadeSuinos);


            //Fazenda com menor nome
            string menorNome = "";
            for (int i = 0; i < 1000; i++)
            {
                if (i % 2 == 0)
                {
                    menorNome = menorNome + "a";
                }
                else
                {
                    menorNome = menorNome + "e";
                }
            }
            for (int i = 0; i < fazendas.Length; i++)
            {
                if (fazendas[i].Length < menorNome.Length)
                {
                    menorNome = fazendas[i];
                }
            }
            Console.WriteLine("Fazenda com o menor nome: " + menorNome);

        }
    }
}
