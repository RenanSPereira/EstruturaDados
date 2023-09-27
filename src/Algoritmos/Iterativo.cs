namespace Exercicios;

public static class Iterativo
{
    public static int Fatorial(int numero)
    {
        if (numero == 0) return 1;

        for (int i = numero; i > 1 - 1; i--)
        {
            var numeroAnterior = i - 1 == 0 ? 1 : i - 1;
            numero *= numeroAnterior;
        }
        return numero;
    }

    public static int Multiplicacao(int a, int b)
    {
        var resultado = 0;
        for (int i = 0; i < b; i++)
        {
            resultado += a;
        }
        return resultado;
    }
}
