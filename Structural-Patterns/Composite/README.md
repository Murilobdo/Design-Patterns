# Implementação do Design Pattern Composite

## O Problema
  - Representar o modelo através de uma estrutura de árvore, fazendo sentido para estruturas hierárquicas.
  - Exemplos:
    * Funcionários e hierarquias de cargos em empresas.

## Sobre o Composite
  - Padrão estrutural que permite modelar objetos em uma estrutura de árvore.
  - É composto:
    * Componente (a interface dos itens da árvore).
    * Folha (estrutura simples que realiza algum trabalho).
    * Composite (estrutura mais complexa que contém um conjunto de componentes, que podem ser folha ou outros composistes).

## Vamos para um exemplo 
  - Em nosso caso, vamos utilizar o seguinte exemplo:
    * Precisamos modelar a estrutura de funcionários e gerentes, e permitir que calculemos os gastos corporativos deles. No caso de um gerente o gasto deverá ser o dele próprio + o da sua esquipe.