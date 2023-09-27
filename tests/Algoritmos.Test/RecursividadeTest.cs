using Algoritmos.Recursivos;

namespace Exercicios.Test;

public class RecursividadeTest
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

    [Fact(DisplayName = "6 X 1 = 6")]
    public void Seis_X_1_Igual_6()
    {
        Assert.Equal(6, Recursividade.Multiplicacao(6, 1));
    }

    [Fact(DisplayName = "6 X 0 = 0")]
    public void Seis_X_0_Igual_0()
    {
        Assert.Equal(0, Recursividade.Multiplicacao(6, 0));
    }

    [Fact(DisplayName = "6 X 3 = 18")]
    public void Seis_X_3_Igual_18()
    {
        Assert.Equal(18, Recursividade.Multiplicacao(6, 3));
    }

    [Fact(DisplayName = "2 + 2 = 4")]
    public void Dois_Mais_Dois_Igual_4()
    {
        Assert.Equal(4, Recursividade.Soma(2, 2));
    }

    [Fact(DisplayName = "20 + 5 = 5")]
    public void Vinte_Mais_5_Igual_25()
    {
        Assert.Equal(25, Recursividade.Soma(20, 5));
    }

    [Fact(DisplayName = "Deve retornar o elemento maximo de um vetor de inteiros")]
    public void Deve_Retornar_Elemento_Maximo_De_Um_Vetor_De_Inteiros()
    {
        var vetor = new int[4] { 100, 2000, 4500, 2 };
        Assert.Equal(4500, Recursividade.ElementoMaximoVetor(vetor, vetor.Length));
    }

    [Fact(DisplayName = "Deve retornar o elemento minimo de um vetor de inteiros")]
    public void Deve_Retornar_Elemento_Minimo_De_Um_Vetor_De_Inteiros()
    {
        var vetor = new int[4] { 100, 2000, 4500, 2 };
        Assert.Equal(2, Recursividade.ElementoMinimoVetor(vetor, vetor.Length));
    }

    [Fact(DisplayName = "Deve somar todos os elementos de um vetor")]
    public void Deve_Somar_Todos_Elementos_De_Um_Vetor()
    {
        var vetor = new int[4] { 100, 2000, 4500, 2 };
        Assert.Equal(6602, Recursividade.SomaElementosVetor(vetor, vetor.Length));
    }

    [Fact(DisplayName = "Deve retornar o produto dos elementos do vetor")]
    public void Deve_Retornar_O_Produto_Dos_Elementos_Do_Vetor()
    {
        var vetor = new int[4] { 2, 2, 2, 2 };
        Assert.Equal(16, Recursividade.MultiplicacaoElementosVetor(vetor, vetor.Length));
    }

    [Fact(DisplayName = "Deve retornar o produto dos elementos do vetor 0 caso um elemento seja 0")]
    public void Deve_Retornar_O_Produto_Dos_Elementos_Do_Vetor_0_Caso_Um_Elemento_Seja_0()
    {
        var vetor = new int[4] { 2, 2, 0, 2 };
        Assert.Equal(0, Recursividade.MultiplicacaoElementosVetor(vetor, vetor.Length));
    }

    [Fact(DisplayName = "Deve retornar a media dos elementos do vetor")]
    public void Deve_Retornar_A_Media_Dos_Elementos_Do_Vetor()
    {
        var vetor = new int[4] { 2, 5, 2, 2 };
        Assert.Equal(2, Recursividade.Media(vetor, vetor.Length));
    }
}
