public class Veiculo
{
    private string _modelo = "";
    private string _marca = "";

    public Veiculo(string modelo, string marca)
    {
        Modelo = modelo;
        Marca = marca;
    }
    public string Modelo
    {
        get { return _modelo; }
        set { _modelo = value; }
    }
    public string Marca
    {
        get { return _marca; }
        set { _marca = value; }
    }
}