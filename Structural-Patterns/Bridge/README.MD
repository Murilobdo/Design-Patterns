# Implementação do Design Pattern Bridge

## O Problema
  - Hierarquias complexas de classes relacionadas que tornam a extensão delas e suas combinações uma tarefa complexa.


## Sobre o Bridge
  - Permite simplificar hierarquias de classes em complexas.
  - Ao invés de criar classes que representem cada uma das diferentes combinações, um item pode utilizar uma interface de Unidade, que poderá ter as implementações dos seus diferentes tipos.
  - Logo, teríamos as hierarquias
    * Item
    * Unidade
  - Com isso, respeitamos o Open-Closed Principle (OCP) do SOLID.

## Vamos para um exemplo 
  - Em nosso caso, vamos utilizar o seguinte exemplo:
    * Temos 2 tipos de itens em um mercado: Produto e Comida.
    * Cada produto ou comida pode variar em sua unidade de medida, podendo ser por Kg ou quantidade.
    * Para isso, acabamos criando 4 classes: ProdutoPorKg, ProdutoPorQuantidade, ComidaPorKg e ComidaPorQuantidade.
  - Se for adicionar uma nova unidade de medida (como litro), vai acabar tendo que criar um para cada tipo de produto, tornando a hierarquia de classes mais complexa e pouco flexível.
  - Em resumo: existem diversos tipos de itens, e os itens podem utilizar uma de diversas unidades de medida.
    * São duas características independentes, mas que podem gerar código complexo (com muitos condicionais) ao passo que crescem suas combinações.