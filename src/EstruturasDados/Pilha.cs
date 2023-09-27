namespace EstruturasDados;

public class Pilha<T>
{
    public int Tamanho
    {
        get
        {
            return Elementos.Length;
        }
    }

    private readonly T[] Elementos;
    private int _topo;

    public Pilha(int tamanho)
    {
        Elementos = new T[tamanho];
        _topo = -1;
    }

    public bool Vazia() => _topo == -1;

    ///<summary>
    ///Adiciona elementos no fim da pilha.
    ///</summary>
    ///<exception cref="Exception">É gerada ao tentar empilhar mais elementos que o suportado</exception>

    public void Empilhar(T item)
    {
        if (_topo == Tamanho -1) throw new Exception("Pilha atingiu sua capacidade");
        Elementos[++_topo] = item;
    }

    ///<summary>
    ///Remove e retorna o último elemento.
    ///</summary>
    ///<exception cref="Exception">É gerada ao tentar desempilhar com zero elementos</exception>

    public T Desempilhar()
    {
        if (Vazia()) throw new Exception("Não é Possível desempilhar pilha vazia");

        var ultimoElemento = ObterUltimoElemento();

        RemoveUltimoElemento();

        return ultimoElemento;
    }

    private void RemoveUltimoElemento()
    {
        Elementos[_topo--] = default!;
    }

    public T ObterUltimoElemento()
    {
        if (Vazia()) throw new Exception("Não é Possível obter último elemento, pilha vazia");

        return Elementos[_topo];
    }

}
