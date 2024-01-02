# Implementação do Design Pattern Decorator

## O Problema
  - Adição de novos comportamentos a objetos sem alterar o comportamento original, mantendo a sepração de responsabilidades.
  - Exemplo:
    * Toda vez que realizarmos uma ação (ou conjunto delas), precisamos enviar uma notificação.
    * Toda vez que processamos um pedido notificamos um software CRM (Customer Relationship Management) para cadastrar o cliente, contendo dados da compra.


## Sobre o Decorator
  - Propõe a criação de uma classe (Decorator) que vai "envelopar" a classe a ser estendida, através de composição.
  - O Decorator implementa a mesma interface que a classe original, adicionando comportamento antes  ou depois da chamada do método original desejado.

## Vamos para um exemplo 
  - Em nosso caso, vamos utilizar o seguinte exemplo:
    * Toda vez que processamos um pedido notificamos um software CRM para cadastrar o cliente, contendo dados da compra.
    * Não queremos alterar cada implementação de IPaymentService para realizar a chamada.