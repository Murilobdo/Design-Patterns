# Implementação do Design Pattern State

## O Problema
  - Gerenciamento de estados de um objeto, que pode incluir lógica mais complexa e checagens baseado em seu estado.
  - Por exemplo, um pediudo delivery pode estar em estado aberto, onde aceita atualizações, como mensagens entre o cliente e o restaurante. Porém, não deveria permitir operações como avaliação!
  - Porém, caso o pedido esteja infalizado, algumas operações não deveriam ser permitidas, como alterar o pedido ou ate mesmo enviar mensagens para o restaurante. Já outras devem estar liberadas, como avaliação do pedido/entrega/restaurante.

## Sobre o State
  - Propõe a criação de uma classe State para cada um dos possíveis estados de um objeto.
  - Nesse caso, seriam extraídos os comportamentos específicos da classe original para cada um de seus States.
  - Além disso, também seria criada uma classe Context que mantém uma instância de classe State.

## Vamos para um exemplo 
  - Em nosso caso, vamos utilizar o seguinte exemplo:
    * Queremos movimentar os estados de um pedido durante o seu processamento entre Iniciado, SaiuEntrega e Entregue.
    * Alguns operaçõs como Adicionar produtos ao carrinho não pode ser feita após o pedido ser enviado.