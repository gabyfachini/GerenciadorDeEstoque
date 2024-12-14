using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciado_de_Estoque
{
    internal class Listar_Produtos
    {
        private List<Estoque> estoques = new List<Estoque>(); //armazena diversos valores de mesmo tipo
        
        public void Adicionar_Produtos(Estoque estoque)
        {
            estoques.Add(estoque);
            Console.WriteLine("Produto adicionado com sucesso!");
        }
        public void Listar_Produto()
        {
            if (!estoques.Any())
            {
                Console.WriteLine("Não há estoques cadastrados!");
                return;
            }
            for (int i = 0; i < estoques.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {estoques[i]}");
            }

    }
        public void AlterarQuantidades(int indice, int quant)
        {
            if (indice >= 0 && indice < estoques.Count)
            {
                estoques[indice].AlterarEstoque(quant);
                Console.WriteLine("Estoque alterado!");
            }
            else
            {
                Console.WriteLine("Índice inválido!");
            }
        }

    }
}
