using Cadastro;
using Repositorio;

namespace AppClientes;

class Program
{
    static ClienteRepositorio _clienteRepositorio = new ClienteRepositorio();
    static void Main(string[] args)
    {
        _clienteRepositorio.LerDadosClientes();
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
            _clienteRepositorio.CadastrarCliente();
            Menu();
            break;
            case 2:
            _clienteRepositorio.ExibirClientes();
            Menu();
            break;
            case 3: 
            _clienteRepositorio.EditarCliente();
            Menu();
            break;
            case 4:
            _clienteRepositorio.ExcluirCliente();
            Menu();
            break;
            case 5:
            _clienteRepositorio.GravarDadosCliente();
            Environment.Exit(0);
            break;
            default:
            Console.WriteLine("Opção inválida!");
            break;

        }

    }
}

