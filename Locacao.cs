public class Locacao
{
    private Cliente _cliente;
    private Veiculo _veiculo;
    private DateOnly _dataRetirada;
    private int _quantidadeDias;
    private decimal _valorDiaria;

    public Locacao(Cliente cliente, Veiculo veiculo, DateOnly dataRetirada, decimal valorDiaria)
    {
        Cliente = cliente;
        Veiculo = veiculo;
        DataRetirada = dataRetirada;
        ValorDiaria = valorDiaria;
    }
    public Cliente Cliente
    {
        get { return _cliente; }
        set { _cliente = value; }
    }
    public Veiculo Veiculo
    {
        get { return _veiculo; }
        set { _veiculo = value; }
    }
    public DateOnly DataRetirada
    {
        get { return _dataRetirada; }
        set { _dataRetirada = value; }
    }
    public int QuantidadeDias()
    {
        DateOnly dataAtual = DateOnly.FromDateTime(DateTime.Now);
        int _quantidadeDias = dataAtual.DayNumber - _dataRetirada.DayNumber;
        return _quantidadeDias;
    }
    public decimal ValorDiaria
    {
        get { return _valorDiaria; }
        set { _valorDiaria = value; }
    }
    public decimal CalcularValorBruto()
    {
        decimal valor = QuantidadeDias() * ValorDiaria;
        return valor;
    }
    public decimal CalcularDesconto()
    {
        if (QuantidadeDias() < 7 || QuantidadeDias() < 0)
        {
            return 0;
        }
        else if (QuantidadeDias() >= 7 && QuantidadeDias() < 15)
        {
            return CalcularValorBruto() * 0.1m;
        }
        else
        {
            return CalcularValorBruto() * 0.15m;
        }
    }

    public decimal CalcularValorFinal()
    {
        return CalcularValorBruto() - CalcularDesconto();
    }

    public void ExibirResumo()
    {
        Console.WriteLine($"=== Locação ===");
        Console.WriteLine($"Nome do Cliente: {Cliente.Nome}");
        Console.WriteLine($"CPF: {Cliente.Cpf}");
        Console.WriteLine($"Modelo do veículo: {Veiculo.Modelo}");
        Console.WriteLine($"Marca: {Veiculo.Marca}");
        Console.WriteLine($"Dia em que foi retirado: {DataRetirada}");
        Console.WriteLine($"Dias passados: {QuantidadeDias()}");
        Console.WriteLine($"Valor da Diária: {ValorDiaria}");
        Console.WriteLine($"Valor do Desconto: {CalcularDesconto()}");
        Console.WriteLine($"=== Valor Final ===");
        Console.WriteLine($"R${CalcularValorFinal()}");

    }
}