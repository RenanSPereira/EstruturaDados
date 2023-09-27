using Algoritmos.Recursivos;

namespace Algoritmos.Test.Recursivos;

public class ElementoMinimoVetorTest
{
    [Fact(DisplayName = "Deve retornar o elemento minimo de um vetor de inteiros")]
    public void Deve_Retornar_Elemento_Minimo_De_Um_Vetor_De_Inteiros()
    {
        var vetor = new int[4] { 100, 2000, 4500, 2 };
        Assert.Equal(2, ElementoMinimoVetor.Obter(vetor, vetor.Length));
    }
}
