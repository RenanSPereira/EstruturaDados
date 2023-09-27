using Algoritmos.Recursivos;

namespace Algoritmos.Test.Recursivos;

public class SomaElementosVetorTest
{
    [Fact(DisplayName = "Deve somar todos os elementos de um vetor")]
    public void Deve_Somar_Todos_Elementos_De_Um_Vetor()
    {
        var vetor = new int[4] { 100, 2000, 4500, 2 };
        Assert.Equal(6602, SomaElementosVetor.Calcular(vetor, vetor.Length));
    }
}
