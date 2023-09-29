namespace Algoritmos.Recursivos;

public static class BuscaBinaria
{
    public static int Buscar(int[] a, int numero, int inicio, int fim)
    {
        if (inicio > fim) return -1;

        var meio = (inicio + fim) / 2;

        if (numero == a[meio]) return a[meio];

        if (numero < a[meio])
        {
            return Buscar(a, numero, inicio, meio - 1);
        }
        else
        {

            return Buscar(a, numero, meio + 1, fim);
        }
    }
}
