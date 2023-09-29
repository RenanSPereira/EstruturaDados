namespace Algoritmos.Iterativos;

public static class BuscaBinaria
{
    public static int Buscar(int[] a, int numero)
    {
        var fim = a.Length;
        var meio = a.Length / 2;

        for (int inicio = 0; inicio <= meio; inicio++)
        {
            if (inicio > fim) return -1;
            
            if (numero == a[meio]) return a[meio];

            if (numero < a[meio])
            {
                fim--;
                meio = ((inicio + fim) / 2) - 1;
                inicio--;
                continue;
            }
            else
            {
                inicio = meio;
                fim++;
                meio = (inicio + fim) / 2;
            }
        }
        return a[meio];
    }
}
