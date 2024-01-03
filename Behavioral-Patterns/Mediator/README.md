# Implementação do Design Pattern Mediator

## O Problema
  - Estrutura e fluxo similiar entre implementações, existindo um forte acoplamento com componentes (interfaces e implementações) similares.
  - Exemplo:
    * Comum de se encontrar em aplicações que utilizam abstrações para caso de uso, como serviços de camada de aplicação (Arquitetura Limpa), CQRS, entre outros.
      - O problema é que a Action do ASP.NET Core, precisa saber qual classe/interface e método especifico precisa invocar.


## Sobre o Mediator
  - Propõe a criação de um objeto Mediator, que será responsável por delegar para o componente correspondente, removendo as comunicações diretas.
  - Um contra desse padrão e a alta concentração de responsabilidade e acoplamento ao mediator.

## Vamos para um exemplo 
  - Em nosso caso, vamos utilizar o seguinte exemplo:
    * Queremos utilizar o padrão CQRS em nosso projeto (poderia ser a Arquitetura Hexagonal, com UseCases).
    * As Actions do nosso ProductsController precisam saber qual Handler instanciar, e chamar o método Handle dele para conseguir o resultado desejado, hjavendo a comunicação direta..
    * Isso acopla nosso Controller com cada um dos Handlers, tendo que sempre saber qual método executar dependendo do Command ou Query.