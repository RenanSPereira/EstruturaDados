namespace Algoritmos.Recursivos;

public static class Soma
{
    public static int Calcular(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }
        return Calcular(++a, --b);
    }
}
