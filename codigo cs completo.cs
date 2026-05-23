using System;

class Program
{
    static void Main()
    {
        //REGISTRO DE CLIENTE
        Console.WriteLine("=== PASSO 1: CADASTRO DE CLIENTE ONIEX ===");
        
        Console.Write("Nome do Cliente: ");
        string nome = Console.ReadLine();
        
        Console.Write("E-mail: ");
        string email = Console.ReadLine();

        Console.WriteLine("\nCadastro realizado! Pressione Enter para ir ao estoque...");
        Console.ReadLine();


        //CONTROLE DE ESTOQUE
        int estoqueCamiseta = 10;
        int estoqueMoletom = 5;
        int estoqueCalca = 8;

        Console.WriteLine("=== PASSO 2: CONTROLE DE ESTOQUE ONIEX ===");
        Console.WriteLine("Cliente atual: " + nome);
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("1 - Comprar Camiseta Street");
        Console.WriteLine("2 - Comprar Moletom Oversized");
        Console.WriteLine("3 - Comprar Calca Cargo");
        Console.Write("\nEscolha uma opcao: ");

        string escolha = Console.ReadLine();

        if (escolha == "1")
        {
            estoqueCamiseta = estoqueCamiseta - 1;
            Console.WriteLine("\nVenda concluida para " + nome);
            Console.WriteLine("Estoque atual de Camisetas: " + estoqueCamiseta);
        }
        else if (escolha == "2")
        {
            estoqueMoletom = estoqueMoletom - 1;
            Console.WriteLine("\nVenda concluida para " + nome);
            Console.WriteLine("Estoque atual de Moletons: " + estoqueMoletom);
        }
        else if (escolha == "3")
        {
            estoqueCalca = estoqueCalca - 1;
            Console.WriteLine("\nVenda concluida para " + nome);
            Console.WriteLine("Estoque atual de Calcas: " + estoqueCalca);
        }
        else
        {
            Console.WriteLine("\nOpcao invalida.");
        }

        Console.WriteLine("\nFim do atendimento. Pressione Enter para fechar.");
        Console.ReadLine();
    }
}