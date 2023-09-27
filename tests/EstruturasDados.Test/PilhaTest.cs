using System.Threading.Channels;

namespace EstruturasDados.Test;

public class PilhaTest
{
    [Fact(DisplayName = "Ao criar uma pilha ela deve estar vazia")]
    public void Ao_Criar_Uma_Pilha_Ela_Deve_Estar_Vazia()
    {
        var pilha = new Pilha<string>(2);
        Assert.True(pilha.Vazia());
    }

    [Fact(DisplayName = "Deve lançar exceção ao tentar desempilhar pilha vazia")]
    public void Deve_Lancar_Excecao_Ao_Tentar_Desempilhar_Pilha_Vazia()
    {
        var pilha = new Pilha<string>(2);

        var ex = Assert.Throws<Exception>(() => pilha.Desempilhar());
        Assert.Equal("Não é Possível desempilhar pilha vazia", ex.Message);
    }

    [Fact(DisplayName = "Deve remover o ultimo item da pilha o mesmo deve ser retornado")]
    public void Deve_Remover_O_Ultimo_Item_Da_Pilha_O_Mesmo_Deve_Ser_Retornado()
    {
        var pilha = new Pilha<string>(2);

        pilha.Empilhar("Renan");
        pilha.Empilhar("Vanessa");

        var itemRemovido = pilha.Desempilhar();

        Assert.Equal("Vanessa", itemRemovido);
        Assert.Equal("Renan", pilha.ObterUltimoElemento());
    }

    [Fact(DisplayName = "Deve Retornar exceção ao tentar empilhar acima da capacidade")]
    public void Deve_Retornar_Excecao_Ao_Tentar_Empilhar_Acima_Da_Capacidade()
    {
        var pilha = new Pilha<decimal>(2);

        pilha.Empilhar(100m);
        pilha.Empilhar(200m);

        var ex = Assert.Throws<Exception>(() => pilha.Empilhar(300m));
        Assert.Equal("Pilha atingiu sua capacidade", ex.Message);
    }

    [Fact(DisplayName = "Deve retornar o último elemento da pilha sem removelo")]
    public void TestName()
    {
        var pilha = new Pilha<string>(2);

        pilha.Empilhar("Renan");
        pilha.Empilhar("Vanessa");

        Assert.Equal("Vanessa", pilha.ObterUltimoElemento());
        Assert.Equal("Vanessa", pilha.ObterUltimoElemento());
    }

    [Fact(DisplayName = "Deve retornar excecao ao tentar obter ultimo elemento pilha vazia")]
    public void Deve_Retornar_Excecao_Ao_Tentar_Obter_Ultimo_Elemento_Pilha_Vazia()
    {
        var pilha = new Pilha<float>(0);

        var ex = Assert.Throws<Exception>(() => pilha.ObterUltimoElemento());
        Assert.Equal("Não é Possível obter último elemento, pilha vazia", ex.Message);
    }
}
