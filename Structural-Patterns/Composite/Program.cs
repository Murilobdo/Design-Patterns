

using Composite.Composite;
using Composite.Leaf;

Organizacao organizacao = new() { Nome = "Softwares Elitegate" };


Organizacao departamentoDev = new() { Nome = "Desenvolvedores" };
Organizacao departamentoDesign = new() { Nome = "Design UX/UI" };

departamentoDev.Add(new Funcionario() { Nome = "João", Horas = 15 });
departamentoDev.Add(new Funcionario() { Nome = "Maria", Horas = 18 });

departamentoDesign.Add(new Funcionario() { Nome = "José", Horas = 20 });
departamentoDesign.Add(new Funcionario() { Nome = "Ana", Horas = 7 });

organizacao.Add(departamentoDev);
organizacao.Add(departamentoDesign);

Console.WriteLine($"Total de horas trabalhadas: {organizacao.GetHoraTrabalhada()}");
Console.ReadLine();