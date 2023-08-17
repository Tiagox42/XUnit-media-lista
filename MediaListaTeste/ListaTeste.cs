using MediaLista;
using System;
using Xunit;
using System.Collections.Generic;

namespace MediaListaTeste
{
    public class ListaTeste
    {
        [Fact]
        public void Media()
        {
            List<int> inteiros = new List<int> { 10, 20, 2, 5, 23 };
            Assert.Equal(12, Lista.Media(inteiros));
        }
    }
}
