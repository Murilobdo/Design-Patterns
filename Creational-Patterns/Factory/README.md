# Implementação do Design Pattern Factory Method

## O Problema
  - Uso demasiado de estruturas condicionais para a criação de objetos.
  - Seu código precisa utilizar muito estruturas condicionais para decidir qual instância de classe utilizar.
  - Exemplos:
    * Tipo de notificação (e-mail, SMS, etc)
    * Meios de Pagamentos (Cartão, Boleto, Saldo em conta digital, etc)
  - Ou seja, a cada nova classe a ser utilizada, mais uma condicional sera adicionada, ea classe ficará cada vez maior e complexa.

## Sobre o Factory Method
  - Disponibiliza uma interface para criar objetos em uma *superclasse*, o chamado Factory, deixando ela a cargo de decidir o tipo de objeto a ser criado.
  - A cada novo objeto a ser inserido na lógica da aplicação, a superclasse sera atualziada e não impactara as classes ja existentes.

## Vamos para um exemplo 
  - Em nosso caso, vamos utilizar o seguinte exemplo:
    * Temos uma startup com um E-commerce, e processamos pagamentos ao receber pedidos, extraindo os dados e decidindo como proceder.
    * Porém, temos uma série de complexidades nesse processo em nosso código... O primeiro deles, e que como estamos em grande crescimento, preciamos frequentemente adicionar novos modos de pagamento.