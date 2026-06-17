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
}