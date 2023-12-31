# Implementação do Design Pattern Prototype

## O Problema
  - Criar cópia exata de um objeto, tendo que ir de propriedade a propriedade atribuindo ao novo objeto.
    * Porém, algumas propriedades/campos podem ser privados o que impossibilita a criação de cópia exata externamente.
    * Também exige que o contexto do código tenha uma dependência na classe a ser copiada, ja que precisará lidar com ela diretamente.

## Sobre o Prototype
  - Propõe que o código de criação da cópia esteja dentro da classe a ser clonada.
  - Definição de uma interface para todos objetos que tenha suportam a operação suportem essa clonagem.

## Vamos para um exemplo 
  - Em nosso caso, vamos utilizar o seguinte exemplo
    * Precisamos criar uma cópia dos dados de Cliente, em um Pedido sendo feito, para trabalhar em um outro contexto sem que a referência atrapalhe.