# Padrão Adapter :electric_plug:

### Este padrão ele atua como uma ponte entre 2 interfaces independentes ou incompativeis permitindo sua colaboração entre elas.


![image](https://upload.wikimedia.org/wikipedia/commons/4/4e/Adapter_pattern.png)

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
  um conjunto de novas interfaces e classes.
  </li> 
</ul>
