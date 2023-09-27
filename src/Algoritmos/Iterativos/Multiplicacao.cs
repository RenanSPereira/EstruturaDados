namespace Algoritmos.Iterativos;

public static class Multiplicacao
{
     public static int Calcular(int a, int b)
    {
        var resultado = 0;
        for (int i = 0; i < b; i++)
        {
            resultado += a;
        }
        return resultado;
    }
}
