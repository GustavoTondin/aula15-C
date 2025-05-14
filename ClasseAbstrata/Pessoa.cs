public abstract class Pessoa
{
    public string? nome { get; set; }
    public int id { get; set; }
    
    public abstract void Logar();
}