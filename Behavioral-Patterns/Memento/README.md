# Implementação do Design Pattern Memento

## O Problema
  - Dificuldade em gerenciar estados anteriores de um objeto, atráves de operações como restaurar ou desfazer.
  - Exemplo:
    * Documento de texto
    * Navegação de browser

## Sobre o Memento
  - Propõe a criação de alguns objetos para permitir o gerenciamento do estadu atual e de acesso aos anteriores, permitinddo operações como "restaurar" e "desfazer".
    * Originador: contém o estado atual, e pode criar snapshots e restaurar o estado.
    * Memento: representa um estado em um certo momento.
    * Caretaker: armazena o histórico de estados através de uma coleção interna, e interage com o Originator.

## Vamos para um exemplo 
  - Em nosso caso, vamos utilizar o seguinte exemplo:
    * Precisamos permitir que o usuário contrua um carrinha de compras simples.
    * É necessário disponibilizar um registro deos estados anteriores do carrinho, e permitir desfazer uma operação, além de permitir restaurar um estado anterior.