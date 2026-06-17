namespace Cadastro;

public class Cliente
{
    public int Id { get; set; }
    public string? Nome { get; set; }//Nullable type "?"
    public DateOnly DataNascimento { get; set; }//Suporte apenas data
    public DateTime CadastradoEm { get; set; } //Suporta data e hora
    public decimal Desconto { get; set; } //Decimal é utilizado para dinheiro.

   
}