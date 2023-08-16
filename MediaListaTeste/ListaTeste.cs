using MediaLista;
using System;
using Xunit;

namespace MediaListaTeste
{
    public class ListaTeste
    {
        [Fact]
        public void Media()
        {
            Assert.Equal(12, Lista.Media(10, 20, 2, 5, 23));
        }
    }
}
