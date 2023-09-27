using Algoritmos.Iterativos;

namespace Algoritmos.Test.Iterativos;

public class MultiplicacaoTest
{
    [Fact(DisplayName = "6 X 1 = 6")]
    public void Seis_X_1_Igual_6_Iterativo()
    {
        Assert.Equal(6, Multiplicacao.Calcular(6, 1));
    }

    [Fact(DisplayName = "6 X 3 = 18")]
    public void Seis_X_3_Igual_18_Iterativa()
    {
        Assert.Equal(18, Multiplicacao.Calcular(6, 3));
    }
}
