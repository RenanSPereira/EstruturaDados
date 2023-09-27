using Algoritmos.Recursivos;

namespace Algoritmos.Test.Recursivos;

public class ElementoMaximoVetorTest
{
    [Fact(DisplayName = "Deve retornar o elemento maximo de um vetor de inteiros")]
    public void Deve_Retornar_Elemento_Maximo_De_Um_Vetor_De_Inteiros()
    {
        var vetor = new int[4] { 100, 2000, 4500, 2 };
        Assert.Equal(4500, ElementoMaximoVetor.Obter(vetor, vetor.Length));
    }
}
