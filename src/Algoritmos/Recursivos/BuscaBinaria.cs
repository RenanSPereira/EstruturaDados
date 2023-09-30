namespace Algoritmos.Recursivos;

public class BuscaBinaria
{
    private int[] a;
    private int numero;

    public BuscaBinaria(int[] a, int numero)
    {
        this.a = a;
        this.numero = numero;
    }

    public int Buscar(int inicio, int fim)
    {
        if (inicio > fim) return -1;

        var meio = (inicio + fim) / 2;

        if (numero == a[meio]) return a[meio];

        if (numero < a[meio])
        {
            return Buscar(inicio, meio - 1);
        }
        else
        {
            return Buscar(meio + 1, fim);
        }
    }
}
