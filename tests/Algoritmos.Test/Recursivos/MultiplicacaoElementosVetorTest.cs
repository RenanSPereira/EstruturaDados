using Algoritmos.Recursivos;

namespace Algoritmos.Test.Recursivos;

public class MultiplicacaoElementosVetorTest
{
    [Fact(DisplayName = "Deve retornar o produto dos elementos do vetor")]
    public void Deve_Retornar_O_Produto_Dos_Elementos_Do_Vetor()
    {
        var vetor = new int[4] { 2, 2, 2, 2 };
        Assert.Equal(16, MultiplicacaoElementosVetor.Calcular(vetor, vetor.Length));
    }

    [Fact(DisplayName = "Deve retornar o produto dos elementos do vetor 0 caso um elemento seja 0")]
    public void Deve_Retornar_O_Produto_Dos_Elementos_Do_Vetor_0_Caso_Um_Elemento_Seja_0()
    {
        var vetor = new int[4] { 2, 2, 0, 2 };
        Assert.Equal(0, MultiplicacaoElementosVetor.Calcular(vetor, vetor.Length));
    }
}
