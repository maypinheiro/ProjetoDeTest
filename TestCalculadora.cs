using System;
using Xunit;

namespace ProjetoDeTest
{
    public class TestCalculadora
    {
        [Fact]
        public void Calculadora_Somar_DeveRetornarValorSoma()
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.Somar(2, 2);
            Assert.Equal(4, resultado);
        }
        
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(8, 1, 9)]
        public void Calculadora_Somar_DeveRetornarValoresSomaCorretos(double v1, double v2, double total)
        {
            var calculadora= new Calculadora();
            var resultado = calculadora.Somar(v1, v2);
            Assert.Equal(total,resultado);

        }

    }
}
