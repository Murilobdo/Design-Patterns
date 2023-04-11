# Padrão Bridge :bridge_at_night:

<h3>O padrão Bridge ele desacopla uma abstração de sua implementação para que as duas possam variar de forma independente.</h3>
<h3>Divide a logica de negocio em hierarquias de classes separadas que podem ser desenvolvidas independentemente. </h3>

<h3> Diagrama UML do Padrão Bridge </h3>

![image](https://wiki.cdot.senecacollege.ca/w/imgs/Bridge.gif)

## Quando usar :question: 

<ul>
  <li>Por exemplo em uma situação onde você tem uma API que trabalha em JSON mas precisa consumir dados de uma outra api de terceiros </br>
  que trabalha no formato XML, você poderia usar um Adapter para fazer que com as 2 APIs se conversem entre si.
  </li>
</ul>


## :heavy_check_mark: Vantagens 

<ul>
  <li>Possibilidade de converter uma interface em outra. :heavy_check_mark: </li> 
  <li>Introduzir um componente legado em um novo sistema. :heavy_check_mark: </li> 
</ul>

## :x: Desvantagens

<ul>
  <li>A complexidade geral do código aumenta porque você precisa introduzir </br>
  um conjunto de novas interfaces e classes. :x:
  </li> 
</ul>
