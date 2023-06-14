

using Proxy.Models;
using Proxy.Proxy;

Funcionario funcionario = new("João", "123", "CEO");
PastaCompartilhadaProxy proxy = new(funcionario);

proxy.OperacaoDeLeituraGravacao();