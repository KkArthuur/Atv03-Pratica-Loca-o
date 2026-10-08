Cliente cliente1 = new Cliente("Arthur", "49037363857");
Veiculo veiculo1 = new Veiculo("Seal", "BWID");
Locacao locacao1 = new Locacao(cliente1, veiculo1, new DateOnly(2026, 10, 1), 25);
locacao1.ExibirResumo();
