using Algoritmos.Recursivos;

namespace Algoritmos.Test.Recursivos;

public class FibonacciTest
{
    [Theory(DisplayName = "Deve calcular o numero de fibonacci")]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(2, 1)]
    [InlineData(3, 2)]
    [InlineData(5, 5)]
    [InlineData(10, 55)]
    public void Deve_Calcular_O_Numero_De_Fibonacci(int entrada, int resultado)
    {
        Assert.Equal(resultado, Fibonacci.Calcular(entrada));
    }
}
