using System;

namespace DioOne.Exemplos //nome da pasta onde ta inserido
{
    public class Pilha //pilha é a classe declarada(ultimo q entra é o 1 q sai
    {
        Posicao primeiro; //posicao é uma propriedade

        public void Empilha(object item)
        {
            primeiro = new Posicao(primeiro, item);
        }

        public object Desempilha()
        {
            if (primeiro == null)
            {
                throw new InvalidOperationException("A pilha está vazia!");
            }

            object resultado = primeiro.item;
            primeiro = primeiro.proximo;
            return resultado;
        }

        class Posicao
        {
            public Posicao proximo;

            public object item;

            public Posicao(Posicao proximo, object item)
            {
                this.proximo = proximo;
                this.item = item;
            }
        }

    }
}
