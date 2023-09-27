namespace Algoritmos.Recursivos;

public class ElementoMinimoVetor
{
    public static int Obter(int[] a, int tamanho, int indice = 0)
    {
        if (tamanho == 0)
        {
            return a[indice];
        }
        else
        {
            if (a[indice] > a[tamanho - 1])
            {
                return Obter(a, tamanho - 1, tamanho - 1);
            }
            else
            {
                return Obter(a, tamanho - 1, indice);
            }
        }
    }
}
