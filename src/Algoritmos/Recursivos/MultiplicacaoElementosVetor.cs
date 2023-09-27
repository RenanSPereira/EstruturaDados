namespace Algoritmos.Recursivos;

public static class MultiplicacaoElementosVetor
{
    public static int Calcular(int[] a, int tamanho)
    {
        if (tamanho == 0)
        {
            return 1;
        }
        else
        {
            return a[tamanho - 1] * Calcular(a, tamanho - 1);
        }
    }
}
