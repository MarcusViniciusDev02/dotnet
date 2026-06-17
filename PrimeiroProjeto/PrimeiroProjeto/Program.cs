namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Menu();
                Console.ReadKey();
            }
        }
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de Clientes");
            Console.WriteLine("---------------------");
            Console.WriteLine("1- Cadastrar cliente");
            Console.WriteLine("2- Exibir cliente");
            Console.WriteLine("3- Editar cliente");
            Console.WriteLine("4- Excluir cliente");
            Console.WriteLine("5- Sair");
            Console.WriteLine("---------------------");
        }
    }
}
