namespace Algoritmos.Iterativos;

public static class Fatorial
{
    public static int Calcular(int numero)
    {
        if (numero == 0) return 1;

        for (int i = numero; i > 1 - 1; i--)
        {
            var numeroAnterior = i - 1 == 0 ? 1 : i - 1;
            numero *= numeroAnterior;
        }
        return numero;
    }
}
