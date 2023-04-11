# Padrão Bridge :bridge_at_night:

<h3>O padrão Bridge ele desacopla uma abstração de sua implementação para que as duas possam variar de forma independente.</h3>
<h3>Divide a logica de negocio em hierarquias de classes separadas que podem ser desenvolvidas independentemente. </h3>

<h3> Diagrama UML do Padrão Bridge </h3>

![image](https://wiki.cdot.senecacollege.ca/w/imgs/Bridge.gif)

## Quando usar :question: 

<ul>
  <li>Quando queremos ocultar os detalhes da implementação do cliente. </br>
  <li>Quando precisamos alterar uma implementação sem compilar a abstração. </br>
  <li>Quando queremos compartilhar uma implementaçao entre varios objetos e isso deve ser escondido do cliente.</li>
</ul>


## :heavy_check_mark: Vantagens 

<ul>
  <li>Estimula a implementação de um codigo fracamente acoplado. :heavy_check_mark: </li> 
  <li>Aumenta a capacidade de manutenção e reutilização do código e reduz a duplicação de código. :heavy_check_mark: </li> 
  <li>Ajuda a promover o principio <b>Aberto-Fechado</b>. :heavy_check_mark: </li> 
</ul>

## :x: Desvantagens

<ul>
  <li>Aumenta a complexidade no código. :x: </li> 
</ul>
