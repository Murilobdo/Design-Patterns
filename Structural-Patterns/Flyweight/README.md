# Implementação do Design Pattern Flyweight

## O Problema
  - Uso grande de memória para alocação de objetos que contém dados comuns entre as requisições.
  - Exemplos:
    * Componentes de um jogo como características de personagens e armas, que não mudam de um usuário para outro.
      - Caso utilizem instâncias diferentes, muita memória pode ser consumida.


## Sobre o Flyweight
  - Propõe a criação de uma classe Factory que seria a responsável por garantir que as instanciâs de objetos comuns de uso não sejam criadas de maneira desnecessária e repetitiva.
  - Vemos aqui uma similaridade com outro Design Pattern: Singleton
    * Enquanto o Singletonm se refere a um único objeto, o Flyweight se refere a vários. Inclusive, o objeto Factory do Flyweight pode ser criado através do padrão Singleton!

## Vamos para um exemplo 
  - Em nosso caso, vamos utilizar o seguinte exemplo:
    * Precisamos retornar um objeto que contém dados a respeito de formas de pagamento de um pedido, tendo como opções:
      - Boleto
      - Cartão de Crédito
      - Paypal
    * Como é um objeto frequentemente requisitado, acabmoas tendo que criar diversas instâncias, uma para cada requisição ao servidor.