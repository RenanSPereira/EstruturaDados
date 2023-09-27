using Algoritmos.Recursivos;

namespace Algoritmos.Test.Recursivos;

public class MultiplicacaoTestTest
{
    [Fact(DisplayName = "6 X 1 = 6")]
    public void Seis_X_1_Igual_6()
    {
        Assert.Equal(6, Multiplicacao.Calcular(6, 1));
    }

    [Fact(DisplayName = "6 X 0 = 0")]
    public void Seis_X_0_Igual_0()
    {
        Assert.Equal(0, Multiplicacao.Calcular(6, 0));
    }

    [Fact(DisplayName = "6 X 3 = 18")]
    public void Seis_X_3_Igual_18()
    {
        Assert.Equal(18, Multiplicacao.Calcular(6, 3));
    }
}
