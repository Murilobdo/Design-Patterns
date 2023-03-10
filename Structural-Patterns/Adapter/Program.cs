


using Adapter.Adapter;
using Adapter.Target;

ITarget target = new AlunoAdapter();

string[,] alunosArray = new string[5,4]
{
    {"101", "Maria", "Artes", "1200"},
    {"102", "Pedro", "Engenharia", "2000"},
    {"103", "Bianca", "Veterinária", "2850"},
    {"104", "Pamela", "Moda", "900"},
    {"105", "Sergio", "Desenho", "850"},
};

target.ProcessaCalculoMensalidade(alunosArray);


