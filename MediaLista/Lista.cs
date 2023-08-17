using System;
using System.Collections.Generic;

namespace MediaLista
{
    public class Lista
    {
        public static double Media(List<int> inteiros)
        {

            int contagem = inteiros.Count;
            int soma = 0;

            foreach (int obj in inteiros)
            {
                soma += obj; 
            }

            double resultado = soma / contagem;

            return resultado;

        }
    }
}
