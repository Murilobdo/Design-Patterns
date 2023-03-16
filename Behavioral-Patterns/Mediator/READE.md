# Padrão Mediator :sunglasses:

<h3>O padrão Mediator tem como finalidade permitir que um grupo de objetos se cominiquem entre si sem que haja </br>
um acoplamento entre eles através de um objeto mediador.</h3>

<h3> Diagrama UML do Padrão Mediator</h3>

![image](https://www.dofactory.com/images/diagrams/net/mediator.gif)

## Quando usar :question: 

<ul>
  <li>Quando acontece uma mudança no estado de um objeto que acaba afetando outros objetos.</li>
  <li>Quando o grande número de interconxeões entre objetos torna o sitema pesado e dificil de mudar.</li>
  <li>Quando você deseja alterar as partes de um sistema independentemente umas das outras</li>
</ul>


## :heavy_check_mark: Vantagens 

<ul>
  <li>Realiza o desacoplamento entre os objetos. :heavy_check_mark: </li> 
  <li>O fluxo de comunicação esta centralizado, com isso, alterações no mediador não afetam seus ouvintes. :heavy_check_mark: </li> 
  <li>Simplifica o código para acessar diferentes tipos de coleção. :heavy_check_mark: </li> 
  <li>Eliminações de relacionamentos muitos para muitos (substituindo por um para muitos). :heavy_check_mark: </li> 
</ul>

## :x: Desvantagens

<ul>
  <li>A centralização pode ser uma fonte de gargalo de desempenho de risco para o sistema em caso de falha. :x:</li> 
  <li>Na prática os mediadores tendem a ser tornarem mais complexos. :x: </li> 
</ul>
