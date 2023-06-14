
using Facade.Facade;
using Facade.Subsistemas;

CreditoFacade facade = new();
Cliente cliente = new("João");

bool resultado = facade.ConcederEmprestimo(cliente, 1000);

Console.WriteLine($"O empréstimo foi {(resultado ? "concedido" : "negado")}.");