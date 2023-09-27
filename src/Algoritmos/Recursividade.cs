
namespace Exercicios;

public static class Recursividade
{














    public static int Media(int[] a, int tamanho)
    {
        if (tamanho == 0)
        {
            return 0;
        }
        else
        {
            return (a[tamanho - 1] + Media(a, tamanho - 1)) / a.Length;
        }
    }
}
