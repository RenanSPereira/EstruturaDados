using EstruturasDados;

namespace Algoritmos.Iterativos;

public class ValidadorAberturaFechamentoEscopo
{
    private readonly string _texto;
    private int _contador = 0;
    private readonly Pilha<char> _pilha;
    private bool _valido;

    public ValidadorAberturaFechamentoEscopo(string texto)
    {
        _texto = texto;
        _contador = 0;
        _pilha = new Pilha<char>(texto.Length);
        _valido = true;
    }

    public bool Validar()
    {
        while (_contador < _texto.Length)
        {
            if (EncontrouAberturaEscopo()) _pilha.Empilhar(ObterSimboloAtual());

            if (EncontrouFechamentoEscopo())
            {
                if (_pilha.Vazia())
                {
                    _valido = false;
                }
                else
                {
                    var simboloRemovido = _pilha.Desempilhar();

                    if (!CorrespondenteSimboloAtual(simboloRemovido))
                    {
                        _valido = false;
                    }
                }
            }

            _contador++;
        }
        if (!_pilha.Vazia()) _valido = false;

        return _valido;
    }

    private bool CorrespondenteSimboloAtual(char simboloRemovido)
    {
        return simboloRemovido == '(' && ObterSimboloAtual() == ')'
        || simboloRemovido == '[' && ObterSimboloAtual() == ']'
        || simboloRemovido == '{' && ObterSimboloAtual() == '}';
    }

    private char ObterSimboloAtual()
    {
        return _texto[_contador];
    }

    private bool EncontrouFechamentoEscopo()
    {
        return _texto[_contador] == ')' || _texto[_contador] == ']' || _texto[_contador] == '}';
    }

    private bool EncontrouAberturaEscopo()
    {
        return _texto[_contador] == '(' || _texto[_contador] == '[' || _texto[_contador] == '{';
    }
}
