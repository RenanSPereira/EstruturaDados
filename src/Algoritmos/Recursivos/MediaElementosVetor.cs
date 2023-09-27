namespace Algoritmos.Recursivos;

public static class MediaElementosVetor
{
    public static float Obter(int[] a, int tamanho, int soma)
    {
        if (tamanho == 0)
        {
            return soma * 1.0f  / a.Length;
        }
        else
        {
            return  Obter(a, tamanho - 1, soma += a[tamanho -1]);
        }
    }
}
