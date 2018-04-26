using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploVetorComFor
{
    class Exemplo02
    {
        public Exemplo02()
        {
            int[] levelNoLOL = new int[3];
            for (int i = 0; i < levelNoLOL.Length; i++)
            {
                Console.Write("Digite seu level no lol: ");
                levelNoLOL[i] = Convert.ToInt32(Console.ReadLine());
            }
            int somaLevels = 0;
            for (int i = 0; i < levelNoLOL.Length; i++)
            {
                somaLevels = levelNoLOL[i] + somaLevels;
            }
            double media = somaLevels / levelNoLOL.Length;
            Console.WriteLine("Média: " + media);

        }
    }
}
