using System.Collections;
using Algoritmos.Iterativos;

namespace Exercicios.Test;

public class TestDataGenerator : IEnumerable<object[]>
{
    private readonly List<object[]> _data = new List<object[]>
    {
        new object[] {"()", true},
        new object[]{"(", false},
        new object[]{")", false},
        new object[]{"()(", false},
        new object[]{"())", false},
        new object[]{"[]", true},
        new object[]{"([])", true},
        new object[]{"([)", false},
        new object[]{"{}", true},
        new object[]{"([{}])", true},
        new object[]{"(A + B})", false},
        new object[]{"{[A + B] - [(C - D)]", false},
        new object[]{"(A + B)-{C + D}-[F+ G]", true},
        new object[]{"((H) * {([J + K])})", true},
        new object[]{"(((A))))", false}
    };

    public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

}

public class ValidadorAberturaFechamentoEscopoTest
{
    [Theory(DisplayName = "Abertura E Fechamento De Escopo Deve Estar Valida")]
    [ClassData(typeof(TestDataGenerator))]
    public void Abertura_E_Fechamento_De_Escopo_Deve_Estar_Valida(string valor, bool esperado)
    {
        var validador = new ValidadorAberturaFechamentoEscopo(valor);
        Assert.Equal(esperado, validador.Validar());
    }
}
