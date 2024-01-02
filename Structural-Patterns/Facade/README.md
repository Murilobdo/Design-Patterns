# Implementação do Design Pattern Facade

## O Problema
  - Utilização de bibliotecas, frameworks ou conjunto complexo de classes.
  - Nesses casos, a utilização é dificultada por conta de configuração e inicialização de objetos, chamadas de métodos, tratamento de retornos, entre outras atividades.
  - Exmeplos:
    * Chamadas HTTP a APIs terceiras, como serviços de computação em Nuvem e integração entre sistemas.
    * Bibliotecas ou frameworks no ggeral que tenham interfaces complexas.

## Sobre o Facade
  - Propõe que seja criada uma interface simplificada para uma biblioteca, framework ou conjunto complexo de classes.
  - Com isso, apesar de se ter funcionalidades limitadas quando comparado ao acesso direto, ela simplifica o uso das funcionalidades ao conter apenas as necessárias, realizando uma adaptação de interfaces (opa, Adapter ?) quando necessário.

## Vamos para um exemplo 
  - Em nosso caso, vamos utilizar o seguinte exemplo:
    * Precisamos enviar dados para uma API terceira de detecção de fraude, com dados como documento do cliente e total do pedido.