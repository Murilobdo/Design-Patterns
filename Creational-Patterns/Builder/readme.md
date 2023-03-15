# Padrão Builder :building_construction:

## O Objetivo do padrão Builder e simplificar a construção de um objeto complexo tornando possivel que o mesmo objeto 
## crie representações diferentes, ele separa o código que cria o objeto do que usa o objeto.

# O que seria um objeto complexo ?
Pode ser considerado um objeto complexo aquele que tem um construtor muito grande com varios paramêtros ou que </br>
possui muitos objetos atrelados a ele

## Diagrama UML do padrão Builder
![image]([https://user-images.githubusercontent.com/36682707/224127198-a8526c57-1faf-49cb-a2fc-fbd1396b117a.png](https://www.dofactory.com/images/diagrams/net/builder.gif))

## Quando usar :question: 

<ul>
  <li>Quando precisar ter mais controle sobre os passos de criação do objeto complexo.</li>
  <li>quando a instacia do objeto exige muitos paramêtros no construtor.</li>
  <li>Quando você quiser esconder os detalhes no processo de ciração do objeto..</li>
</ul>


## :heavy_check_mark: Vantagens 

<ul>
  <li>Permite esconder os detalhes de como os objetos são criados. :heavy_check_mark:</li>
  <li>Permite uma grande variedade de representações internas do objeto a ser contruído. :heavy_check_mark:</li>
  <li>Fornce um grande controle sobre o processo de criação do objeto complexo. :heavy_check_mark:</li>
  <li>Cada Builder e independente dos outros builders e do restante da aplicação. :heavy_check_mark:</li>
</ul>

## :x: Desvantagens

<ul>
   <li>O número de linhas de código aumenta conforme a complexidade do objeto e os tipos de objetos que vamos </br>
   construir podendo haver duplicação de parte do código :x: </li>
  <li>Requer a criação de um ConcreteBuilder separado para cada tipo de produto :x: </li>
</ul>
