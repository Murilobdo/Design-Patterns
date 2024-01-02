# Implementação do Design Pattern Adapter

## O Problema
  - Colaboração entre objetos com interfaces incompatíveis entre si.
  - Exemplos:
    * Integração com sistemas terceiros, que podem trabalhar com interfaces e até formatos diferentes (XML, por exemplo), com sua aplicação trabalhando primariamente com JSON.


## Sobre o Adapter
  - Propõe que a criação de um objeto Adapter (ou Adaptador), que será responsável por converter a interface de um objeto para outro.
  - Ele funciona como um Wrapper, internamente delegando a chamada para o objeto existente, mas retornando uma interface desejada pela aplicação.

## Vamos para um exemplo 
  - Em nosso caso, vamos utilizar o seguinte exemplo:
    * Precisamos invocar um serviço terceiro para obter os dados de Boleto.
    * Porém, o modelo retornado pelo serviço é incompatível com nosso modelo, especificamente nos dados de boleto, com estruturas e nomenclaturas diferentes.
    * Por conta disso, temos uma interface de integração com o sistema terceiro *IExternalPaymentSlipService*
    e queremos usar noss o IPaymentSlipService para retornar os dados usando nosso modelo.