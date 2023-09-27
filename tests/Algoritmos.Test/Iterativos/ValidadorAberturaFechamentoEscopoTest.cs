using System.Collections;
using Algoritmos.Iterativos;

namespace Algoritmos.Test.Iterativos;

public class ValidadorAberturaFechamentoEscopoTest
{
    [Theory(DisplayName = "Deve validar")]
    [ClassData(typeof(TestDataGenerator))]
    public void Deve_Validar(string valor, bool esperado)
    {
        var validador = new ValidadorAberturaFechamentoEscopo(valor);
        Assert.Equal(esperado, validador.Validar());
    }
}

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