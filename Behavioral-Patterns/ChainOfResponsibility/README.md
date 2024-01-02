# Implementação do Design Pattern Chain of Responsability

## O Problema
  - Complexidade de código de execução uma sequência de passos para uma dada tarefa.


## Sobre o Mediator
  - Propõe a criação de um objeto Handler, que será responsável por definir os passos e executá-los na ordem correta, controlando o fluxo.
  - Basicamente, o Handler armazena o próximo objeto que pode executar a tarefa, executando sua tarefa, e analsiando cada resposta, invocando então o próximo da sequência.
  - Interrompe o processamento em caso de resposta de falha, que pode variar de cada implementação.

## Vamos para um exemplo 
  - Em nosso caso, vamos utilizar o seguinte exemplo:
    * Para aprovar um pedido, precisamos realizar uma série de passos.
    Por exemplo, precisamos confirmar o status do cliente (esta bloqueado?), o estoque do produto, e também realizar uma checagem para fraude com base nos dados do CPF e compra.
    * Em caso de falha no processo, não é necessário seguir.