using System;
using System.Collections.Generic;

namespace MediaLista
{
    public class Lista
    {
        public static int Media(int n1, int n2, int n3, int n4, int n5)
        {
            List<int> inteiros = new List<int>();
            inteiros.Add(n1);
            inteiros.Add(n2);
            inteiros.Add(n3);
            inteiros.Add(n4);
            inteiros.Add(n5);

            int contagem = 0;
            int soma = 0;

            foreach (int obj in inteiros)
            {
                contagem++;
                soma += obj; 
            }

            return soma / contagem;

        }
    }
}
