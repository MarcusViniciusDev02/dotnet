using Cadastro;

namespace AppClientes;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Menu();
            Console.ReadKey();
        }
    }
    //Método criado para a exibição de um menu.
    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Cadastro Cliente");
        Console.WriteLine("--------------------");
        Console.WriteLine("1 - Cadastrar");
        Console.WriteLine("2 - Exibir");
        Console.WriteLine("3 - Editar");
        Console.WriteLine("4 - Excluir");
        Console.WriteLine("5 - Sair");
        Console.WriteLine("--------------------");
        
    }

}

