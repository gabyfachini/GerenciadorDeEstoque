using Gerenciado_de_Estoque;
using System.Security.AccessControl;

Listar_Produtos produtos = new Listar_Produtos();
while (true)
{
    Console.WriteLine("Escolha a opção desejada:");
    Console.WriteLine("1. Cadastrar produtos");
    Console.WriteLine("2. Cadastrar mais estoque");
    Console.WriteLine("3. Visualizar produtos e estoque");
    Console.WriteLine("4. Sair");
    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1": //Adiconar informações para o código do produto
            Console.WriteLine("Nome do produto: ");
            string name = Console.ReadLine();
            Console.WriteLine("Fornecedor: ");
            string fornecedor = Console.ReadLine();
            Console.WriteLine("Categoria: ");
            string categoria = Console.ReadLine();
            Console.WriteLine("Estoque atual: ");
            int quant = int.Parse(Console.ReadLine());
            produtos.Adicionar_Produtos(new Store(name, fornecedor, categoria, quant));
            Console.ReadKey();
            Console.Clear();
            break;
        case "2":
            Console.WriteLine("Qual o indice desejado: ");
            int indice = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um novo estoque: ");
            int cod = int.Parse(Console.ReadLine());
            produtos.AlterarQuantidades(indice, cod);
            Console.ReadKey();
            Console.Clear();
            break;
        case "3":
            produtos.Listar_Produto();
            Console.ReadKey();
            Console.Clear();
            break;
        case "4":
            Console.WriteLine("Finalizando programa...");
            return;

    }
}