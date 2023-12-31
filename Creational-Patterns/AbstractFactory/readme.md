# Implementação do Design Pattern Abstract Factory

## O Problema
  - Uso demasiado de estruturas condicionais para a criação de conjuntos de objetos, especificos para cada condição.
  - Exemplo:
    * Cálculo de diferentes impostos (FGTS, IR) dependendo do salário de funcionário podem virar diferentes classes, uma por imposto, mas com implementações especificas para cada faixa.

## Sobre o Factory Method
   - Disponibiliza uma interface para criar um conjunto de objetos em uma *superclasse*, o chamado Abstract Factory, deixando o cargo de decidir a gamília de objetos a ser criada.
   - A cada nova "familia" a ser inserida na lógica da aplicação, a *superclasse* sera atualizada sem imapcatar nas demais classes criadas.
   
## Vamos para um exemplo 
  - Em nosso caso, vamos utilizar o seguinte exemplo:
    * Ainda com o exemplo da Startup de E-Commerce, surgiu a necessidade de restringir o pagamento e envio dependendo se a compra e internacional ou não.
      - Se for internacional, o pagamento e só por cartão de crédito.
      - Se for nacional, o pagamento pode ser feito por cartão ou boleto.
      - Ambas têm maneiras distintas de processar o envio.
    * Se no futuro quisermos adicionar mais uma condição sobre essa familia de objetos relacionado a pagamento e envio e (e possivelmente outras mais!), precisaremoos adicionar maios uma condicionar, que pode se tornar complexa.