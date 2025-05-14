public class PessoaJuridica : Pessoa
{
    public string? cnpj { get; set;}
  
    public override void Logar()
    {
        Console.WriteLine("Validando CNPJ.....");
        Console.WriteLine("Logado!");
    }
}