using Cadastro;
using Repositorio;

namespace AppClientes;

class Program
{
    static ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
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
        SelecionarFuncao();
    }

    static void SelecionarFuncao()
    {
        Console.WriteLine("Escolha uma opção: ");
        var opcao = Console.ReadLine();
        
        switch (int.Parse(opcao))
        {
            case 1: 
            clienteRepositorio.CadastrarCliente();
            Menu();
            break;
            case 2:
            clienteRepositorio.ExibirClientes();
            Menu();
            break;
            case 3: 
            clienteRepositorio.EditarCliente();
            Menu();
            break;
            case 4:
            clienteRepositorio.ExcluirCliente();
            Menu();
            break;
            case 5:
            Environment.Exit(0);
            break;
            default:
            Console.WriteLine("Opção inválida!");
            break;

        }

    }
}

