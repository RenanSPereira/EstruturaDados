
namespace Exercicios;

public static class Recursividade
{








    public static int ElementoMinimoVetor(int[] a, int tamanho, int indice = 0)
    {
        if (tamanho == 0)
        {
            return a[indice];
        }
        else
        {
            if (a[indice] > a[tamanho - 1])
            {
                return ElementoMinimoVetor(a, tamanho - 1, tamanho - 1);
            }
            else
            {
                return ElementoMinimoVetor(a, tamanho - 1, indice);
            }
        }
    }

    public static int SomaElementosVetor(int[] a, int tamanho)
    {
        if (tamanho == 0)
        {
            return 0;
        }
        else
        {
            return a[tamanho - 1] + SomaElementosVetor(a, tamanho - 1);
        }
    }

    public static int MultiplicacaoElementosVetor(int[] a, int tamanho)
    {
        if (tamanho == 0)
        {
            return 1;
        }
        else
        {
            return a[tamanho - 1] * MultiplicacaoElementosVetor(a, tamanho - 1);
        }
    }

    public static int Media(int[] a, int tamanho)
    {
        if (tamanho == 0)
        {
            return 0;
        }
        else
        {
            return (a[tamanho - 1] + SomaElementosVetor(a, tamanho - 1)) / a.Length;
        }
    }
}
