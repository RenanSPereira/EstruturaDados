using Algoritmos.Recursivos;

namespace Algoritmos.Test.Recursivos;

public class SomaTest
{
    [Fact(DisplayName = "2 + 2 = 4")]
    public void Dois_Mais_Dois_Igual_4()
    {
        Assert.Equal(4, Soma.Calcular(2, 2));
    }

    [Fact(DisplayName = "20 + 5 = 5")]
    public void Vinte_Mais_5_Igual_25()
    {
        Assert.Equal(25, Soma.Calcular(20, 5));
    }
}
