public class Cliente
{
    private string _nome = "";
    private string _cpf = "";

    public Cliente(string nome, string cpf)
    {
        Nome = nome;
        Cpf = nome;
    }

    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }

    public string Cpf
    {
        get { return _nome; }
        set { _cpf = value; }
    }
}