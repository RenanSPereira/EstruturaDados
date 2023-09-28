namespace Algoritmos.Iterativos;

public static class Fibonacci
{
    public static int calcular(int numero)
    {
        if (numero <= 1)
            return numero;

        var menorFib = 0;
        var maiorFib = 1;

        for (var i = 2; i <= numero; i++)
        {
            var calculo = menorFib;
            menorFib = maiorFib;
            maiorFib = calculo + menorFib;
        }

        return maiorFib;
    }
}
