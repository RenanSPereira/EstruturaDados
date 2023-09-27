using Algoritmos.Iterativos;

namespace Exercicios.Test;

public class AlgoritmosIterativosTest
{
    [Fact(DisplayName = "6 X 1 = 6")]
    public void Seis_X_1_Igual_6_Iterativo()
    {
        Assert.Equal(6, Iterativo.Multiplicacao(6, 1));
    }

    [Fact(DisplayName = "6 X 3 = 18")]
    public void Seis_X_3_Igual_18_Iterativa()
    {
        Assert.Equal(18, Iterativo.Multiplicacao(6, 3));
    }

    [Fact(DisplayName = "Fatorial de 0 deve ser 1")]
    public void Fatorial_De_0_Deve_Ser_1()
    {
        Assert.Equal(1, Fatorial.Calcular(0));
    }

    [Fact(DisplayName = "Fatorial de 1 deve ser 1")]
    public void Fatorial_De_1_Deve_Ser_1()
    {
        Assert.Equal(1, Fatorial.Calcular(1));
    }

    [Fact(DisplayName = "Fatorial de 5 deve ser 120")]
    public void Fatorial_De_5_Deve_Ser_120()
    {
        Assert.Equal(120, Fatorial.Calcular(5));
    }
}
