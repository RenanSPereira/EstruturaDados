using Algoritmos.Iterativos;

namespace Algoritmos.Test.Iterativos;

public class FatorialTest
{
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
