using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciado_de_Estoque
{
    public abstract class Estoque
    {
        public Estoque(string produto,string fornecedor,string categoria,int quantidade) //Método
        {
            Produto = produto;
            Fornecedor = fornecedor;
            Categoria = categoria;
            Quantidade = quantidade;
        }
        public string Produto { get; set; } //Propriedade
        public string Fornecedor { get; set; }
        public string Categoria { get; set; }
        public int Quantidade { get; set; }
        public abstract void AdicionarProdutos();
        public abstract void AlterarEstoque(int quant);
        /*{
            Quantidade += quant;
        }
        public void RemoverQuantidade(int quant)
        {
            if (Quantidade > 0)
            {
                Quantidade -= quant;
            } else
            {
                Console.WriteLine("Estoque zerado!");
            }
        }*/
    }
    public class Store : Estoque
    {
        public Store(string produto, string fornecedor, string categoria, int quantidade)
            : base(produto, fornecedor, categoria, quantidade) // Chama o construtor da classe base
        {
        }

        public override void AdicionarProdutos()
        {
            // Implementar a lógica para adicionar produtos
            Console.WriteLine($"Produto {Produto} adicionado ao estoque.");
        }

        public override void AlterarEstoque(int quant)
        {
            Quantidade = quant;
        }

        public override string ToString()
        {
            return $"Produto: {Produto} do Fornecedor {Fornecedor} e Categoria {Categoria} com {Quantidade} quantidade(s).";
        }
    }
    /*public class AdicionarEstoque : Estoque
    {
        public AlterarQuantidades (int quantidade) : base (quantidade) 
        {

        }
        public override string ToString()
        {
            return $"{Quantidade} quantidade(s) adicionadas no {Produto} da Categoria {Categoria}.";
        }
    }*/
}
