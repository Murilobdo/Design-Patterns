# Implementação do Design Pattern Builder

## O Problema
  - inicialização de objetos complexos, que envolvam muitos dados e agrupamentos de objetos.
  - Exemplos:
    * Montar um objeto de boleto, que contém diversos paramêtros.  

## Sobre o Builder
  - Propõe que o código de criação de objetos seja movido para fora da classe.
  - São definidos passos para a construção do objeto, de maneira a deixar o processo mais legível e simplificado.
  - Em alguns conários será necessário criar diferentes implementações de um Builder, para tipos diferentes de objeto. 
   
## Vamos para um exemplo 
  - Em nosso caso, vamos utilizar o seguinte exemplo:
    * Precisamos intanciar um objeto de Boleto.
    * Ele contém dados de diversos agrupamentos de dados, com Dados de Recebedor, Pagador, além dos próprios dados do boleto, como o numero, valor do documento, entre outros.