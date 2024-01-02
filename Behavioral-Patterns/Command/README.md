# Implementação do Design Pattern Command

## O Problema
  - Chamadas de métodos com múltiplos parâmetros ou necessidade de armazenamento de parâmetros de uma dada operação para posterior execução.


## Sobre o Command
  - Propõe a transformação de parâmetros de uma chamada em um objeto que contém todas suas informações sobre ela.
  - Com isso, é possível armazenar esse objeto para posterior processamento da chamada, por exemplo via fila ou agendamento, e também armazenar em logs.

## Vamos para um exemplo 
  - Em nosso caso, vamos utilizar o seguinte exemplo:
    * Atualmente passamos os parâmetros diretamente ao nosso método de checagem, que é basicamente um *Façade* para um serviço externo.
    * Temos a necessidade de realizar a chamada de checagem de fraude na criação de pedido de maneira assíncrona, via mensageria.