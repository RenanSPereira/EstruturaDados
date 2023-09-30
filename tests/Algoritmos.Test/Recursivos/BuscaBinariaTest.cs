using Algoritmos.Recursivos;

namespace Algoritmos.Test.Recursivos;

public class BuscaBinariaTest
{
    private readonly int[] _vetor = new int[9] { 1, 3, 7, 15, 21, 36, 78, 95, 106 };

    [Theory(DisplayName = "Deve Encontrar O Numero")]
    [InlineData(1, 1)]
    [InlineData(36, 36)]
    public void Deve_Encontrar_O_Numero(int entrada, int resultado)
    {
        Assert.Equal(resultado, BuscaBinaria.Buscar(_vetor, entrada, 0, _vetor.Length -1));
    }
    [Fact(DisplayName = "Deve retornar -1 para valor nao encontrado")]
    public void Deve_Retornar_Menos_Um_Para_Valor_Nao_Encontrado()
    {
        Assert.Equal(-1, BuscaBinaria.Buscar(_vetor, 20, 0, _vetor.Length -1));
    }
}
