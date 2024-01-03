# Implementação do Design Pattern Observer

## O Problema
  - Necessidade de notificar objetos sobre ocorrências importantes, como alteração de estado de outro objeto / execução de uma operação.
  - Por exemplo
    * Notificar usuários quando configuração de termo de uso ou ofertas do dia (Singleton) for alterada.
    * Enviar dados apra uma API de análise de dados quando o usuário adicionar um item ao carrinho (armazenado em memória, como Singleton), além de agendar um e-mail.

## Sobre o Observer
  - Propõe a criação de um objeto Subject e um ou mais Observer.
  - O Subject é responsável por notificar os objetos Observer que estão inscritos a ele.
  - Em nosso cenário, o objeto Subject manteria o estado das ofertas atuais, e os Observer serial classes que executariam código toda vez que a oferta atual fosse modificada, como notificações.

## Vamos para um exemplo 
  - Em nosso caso, vamos utilizar o seguinte exemplo:
    * Queremos notificar o usuário quando a lista de ofertas do dia for alterada. Ela está sendo armazenada como um objeto na memória.
    * Nesse caso, precisamos adicionar lógica quando ocorra a alteração. Por exemplo, inicialmente podemos notificar por e-mail, mas precisamos ter flexibilidade para adicionar novas operações de maneira isolada.