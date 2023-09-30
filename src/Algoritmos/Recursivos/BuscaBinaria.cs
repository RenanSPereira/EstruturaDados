namespace Algoritmos.Recursivos;

public class BuscaBinaria
{
    private readonly int[] _a;
    private readonly int _numero;

    public BuscaBinaria(int[] a, int numero)
    {
        _a = a;
        _numero = numero;
    }

    public int Buscar(int inicio, int fim)
    {
        if (inicio > fim) return -1;

        var meio = (inicio + fim) / 2;

        if (_numero == _a[meio]) return _a[meio];

        if (_numero < _a[meio])
        {
            return Buscar(inicio, meio - 1);
        }
        else
        {
            return Buscar(meio + 1, fim);
        }
    }
}
