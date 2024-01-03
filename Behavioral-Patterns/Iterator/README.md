# Implementação do Design Pattern Iterator

## O Problema
  - Acoplamento com método de travessia de coleções diferentes.
  - Quando precisamos percorrer uma coleção, muitas vezes ocorre o acoplamente com o método de travessia, ja que cada coleção tem sua própria maneira de percorrer, como em Fila, Pilha, estruturas de Árvore, entre outras.

## Sobre o Iterator
  - Propõe que a criação de um objeto *Iterator* (ou a extensão da classe que contém a estrutura de dados atual) para permitir a travessia de seus objetos sem expor a implementação interna.
  - Por exemplo, com isso seria possível percorrer os dados de um dicionário interno de um objeto sem precisar conhecer sua implementação interna, percorrendo como se fosse uma lista. 

## Vamos para um exemplo 
  - Em nosso caso, vamos utilizar o seguinte exemplo:
    * Precisamos percorrer uma lista de clientes bloqueados e realizar uma certa ação, como notificar seus e-mails.
    * Porém, para isso, não podemos expor a estrutura interna de um moedlo que ja estamos utilizando. No caso, estamos internamente utilizando um dicionário para armazenar os clientes e seus e-mails.