public class PessoaFisica : Pessoa
{
    public string? cpf { get; set;}

    public override void Logar()
    {
        Console.WriteLine("Validando CPF.....");
        Console.WriteLine("Logado!");
    }
}