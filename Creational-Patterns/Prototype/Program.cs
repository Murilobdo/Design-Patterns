
using Prototype.models;

Soldado soldado1 = new();
soldado1.Nome = "Soldado 1";
soldado1.Arma = "Fuzil HK";
soldado1.Acessorio.Nome = "Granda";

Soldado soldado2 = (Soldado)soldado1.Clone();
soldado1.Nome = "Soldado 2";
soldado1.Arma = "Fuzil AK 47";
soldado1.Acessorio.Nome = "C4";

soldado1.Mostra();
soldado2.Mostra();
