# Implementação do Design Pattern Proxy

## O Problema
  - Controle de acesso a um objeto.
  - Exemplos de operações de controle a um objeto:
    * Lazy Loading
    * Caching
    * Autorização

## Sobre o Proxy
  - Propõe a criação de um objeto proxy, que controla o acesso ao objeto original.
  - O objeto Proxy pode realizar validações e operações antes ou depois do acesso ao objeto original.
  - Similar ao padrão Decorator em sua implementação, mas bem diferente conceitualmente
    * O Proxy controla o acesso.
    * o Decorator estende novos comportamentos.

## Vamos para um exemplo 
  - Em nosso caso, vamos utilizar o seguinte exemplo:
    * Precisamos controlar o acesso a uma lista de clientes bloqueados, obtida de um repositório.
    * Porem, temos algumas restrições aqui:
        - Para acessar suas informações, precisamos acessar o banco de dados na primeira execução, realizando o caching dos dados.
        - Alem disso precisamos garanto que o usuário seja do tipo Admin para realizar a consulta.