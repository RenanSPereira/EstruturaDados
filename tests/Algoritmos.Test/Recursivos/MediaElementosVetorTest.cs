using Algoritmos.Recursivos;

namespace Algoritmos.Test.Recursivos;

public class MediaElementosVetorTest
{
    [Fact(DisplayName = "Deve retornar a media dos elementos do vetor")]
    public void Deve_Retornar_A_Media_Dos_Elementos_Do_Vetor()
    {
        var vetor = new int[4] { 2, 5, 2, 2 };
        Assert.Equal(2.75f, MediaElementosVetor.Obter(vetor, vetor.Length, 0));
    }

    [Fact(DisplayName = "Deve retornar a media dos elementos do vetor com valor 0 caso tamanho seja 0")]
    public void Deve_Retornar_A_Media_Dos_Elementos_Do_Vetor_Com_Valor_0_Caso_Tamnho_Seja_0()
    {
        var vetor = new int[4] { 2, 5, 2, 2 };
        Assert.Equal(0, MediaElementosVetor.Obter(vetor, 0, 0));
    }
}
