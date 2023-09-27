namespace Algoritmos.Recursivos;

public static class SomaElementosVetor
{
        public static int Calcular(int[] a, int tamanho)
    {
        if (tamanho == 0)
        {
            return 0;
        }
        else
        {
            return a[tamanho - 1] + Calcular(a, tamanho - 1);
        }
    }
}
