namespace Algoritmos.Recursivos;

public static class Fibonacci
{
    public static int Calcular(int numero)
    {
        if (numero <= 1) return numero;
        return Calcular(numero - 1) + Calcular(numero -2);
    }
}