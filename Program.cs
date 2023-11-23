
using SRP.Classes;

var pedido = new OrdemPedido();

pedido.Adiciona(new Pedido() { IdPedido = 1, Nome = "Chocolate", Descricao = "Chocolate com Pimenta"});
pedido.Adiciona(new Pedido() { IdPedido = 2, Nome = "Frango Frito", Descricao = "Balde de Tulipas"});
pedido.Adiciona(new Pedido() { IdPedido = 3, Nome = "Suco", Descricao = "Suco de Laranja"});

var estoque = new OrdemEstoque();

estoque.Adiciona(new Estoque() { IdProduto = 1, Nome = "Frango", Descricao = "Frango Congelado", Quantidade = 5, DataEntrada = DateTime.Now.AddDays(2) });
estoque.Adiciona(new Estoque() { IdProduto = 1, Nome = "Laranjas", Descricao = "Laranjas Lima", Quantidade = 6, DataEntrada = DateTime.Now.AddDays(5) });
estoque.Adiciona(new Estoque() { IdProduto = 1, Nome = "Suco", Descricao = "Suco em Lata", Quantidade = 5, DataEntrada = DateTime.Now.AddDays(4) });

Console.WriteLine(pedido.ToString());
Console.WriteLine(estoque.ToString());

var arquivo = new GeraArquivo();

arquivo.SalvaArquivoJson("Pedidos", pedido.Lista());
arquivo.SalvaArquivoJson("ProdutosEstoque", estoque.Lista());

