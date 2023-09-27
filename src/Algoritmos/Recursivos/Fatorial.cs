namespace Algoritmos.Recursivos;

public static class Fatorial
{
    public static int Calcular(int numero)
    {
        if (numero == 0)
        {
            return 1;
        }
        else
        {
            numero *= Calcular(numero - 1);
        }
        return numero;
    }
}
