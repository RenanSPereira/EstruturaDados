namespace Algoritmos.Recursivos;

public static class MediaElementosVetor
{
    public static int Obter(int[] a, int tamanho)
    {
        if (tamanho == 0)
        {
            return 0;
        }
        else
        {
            return (a[tamanho - 1] + Obter(a, tamanho - 1)) / a.Length;
        }
    }
}
