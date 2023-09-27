namespace Algoritmos.Recursivos;

public static class Multiplicacao
{
    public static int Calcular(int a, int b)
    {
        if (a == 0 || b == 0) return 0;

        if (b == 1)
        {
            return a;
        }
        else
        {
            a += Calcular(a, b - 1);
        }
        return a;
    }

}
