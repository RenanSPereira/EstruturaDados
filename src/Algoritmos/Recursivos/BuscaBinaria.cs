namespace Algoritmos.Recursivos;

public static class BuscaBinaria
{
    public static int Buscar(int[] a, int numero, int indiceInicio, int indiceFim)
    {
        if (indiceInicio > indiceFim) return -1;

        var indiceMeio = (indiceInicio + indiceFim) / 2;

        if (numero == a[indiceMeio]) return a[indiceMeio];

        if (numero < a[indiceMeio])
        {
            return Buscar(a, numero, indiceInicio, indiceMeio - 1);
        }
        else
        {

            return Buscar(a, numero, indiceMeio + 1, indiceFim);
        }
    }
}
