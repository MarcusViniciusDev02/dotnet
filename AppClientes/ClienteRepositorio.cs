using System.Threading.Channels;
using Cadastro;

namespace Repositorio;

public class ClienteRepositorio
{
    //Lista baseada na classe dos clientes. 
    public List<Cliente> clientes = new List<Cliente>();

    //Método criado para cadastrar clientes através de um input.
    public void CadastrarCliente()
    {
        Console.Clear();
        Console.WriteLine("Nome do cliente");
        var nome = Console.ReadLine();
        Console.WriteLine(Environment.NewLine);

        Console.WriteLine("Data de nascimento");
        var dataDeNascimento = DateOnly.Parse(Console.ReadLine());
        Console.WriteLine(Environment.NewLine);

        Console.WriteLine("Desconto");
        var desconto = decimal.Parse(Console.ReadLine());
        Console.WriteLine(Environment.NewLine);

        var cliente = new Cliente();
        cliente.Id = clientes.Count + 1;
        cliente.Nome = nome;
        cliente.DataNascimento = dataDeNascimento;
        cliente.CadastradoEm = DateTime.Now;
        cliente.Desconto = desconto;
        clientes.Add(cliente);

        System.Console.WriteLine("Cliente cadastrado com sucesso.[Enter]");
        ImprimirCliente(cliente);
        Console.ReadKey();
    }

    //Imprimi os dados de um cliente específico.
    public void ImprimirCliente(Cliente cliente)
    {
        Console.WriteLine($"""
        Id:.............................{cliente.Id}
        Nome:.........................{cliente.Nome}
        Data de Nascimento: {cliente.DataNascimento}
        Cadastro:.............{cliente.CadastradoEm}
        Desconto:.................{cliente.Desconto}
        """);
    }

    //Exibe os dados de todos os clientes presentes na lista. 
    public void ExibirClientes()
    {
        foreach (var cliente in clientes)
        {
            Console.WriteLine(cliente);
        }
    }

    public void EditarCliente()
    {
        Console.Clear();
        Console.WriteLine("Informe o código do cliente: ");
        //Utilizo a variavel código para poder buscar o cliente através do IP.
        var codigo = Console.ReadLine();
        var cliente = clientes.FirstOrDefault(p => p.Id == int.Parse(codigo));

        if(cliente == null)
        {
            Console.WriteLine("Cliente não encontrado [Enter]");
            Console.ReadKey();
            return;
        }
        //Imprime cliente achado.
        ImprimirCliente(cliente);

        Console.WriteLine("Nome do Cliente: ");
        var nome = Console.ReadLine();
        Console.WriteLine(Environment.NewLine);

        Console.WriteLine("Data de Nascimento: ");
        var dataNascimento = DateOnly.Parse(Console.ReadLine());
        Console.WriteLine(Environment.NewLine);

        Console.WriteLine("Desconto: ");
        var desconto = decimal.Parse(Console.ReadLine());
        Console.WriteLine(Environment.NewLine);

        cliente.Id = clientes.Count + 1;
        cliente.Nome = nome;
        cliente.DataNascimento = dataNascimento;
        cliente.Desconto = desconto;
        cliente.CadastradoEm = DateTime.Now;
        
        //Adiciona o cliente editado a lista.
        clientes.Add(cliente);

        Console.WriteLine("Cliente alterado com sucesso [Enter]");

        //Imprime cliente editado. 
        ImprimirCliente(cliente);
        Console.ReadKey();
    }
}