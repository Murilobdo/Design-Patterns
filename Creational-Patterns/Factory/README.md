<h1>Padrão Factory :factory_worker:	</h1>

<h3>O padrão <b>Factory</b> tem como principal objetivo nos auxiliar a reduzir acoplamento em nosso software, ou seja, ele vai manter dependências flexiveis e para isto, fazendo com que as dependências deixem de ser explicítas </h3>



## Diagrama UML do padrão Builder
![image](https://i.stack.imgur.com/N3mC1.png)

## Quando usar :question: 

<ul>
  <li>Quando precisar ter mais controle sobre os passos de criação do objeto complexo.</li>
  <li>quando a instacia do objeto exige muitos paramêtros no construtor.</li>
  <li>Quando você quiser esconder os detalhes no processo de ciração do objeto..</li>
</ul>


## :heavy_check_mark: Vantagens 

<ul>
  <li>As subclasses <b>Factory</b> possuem controle total sobre o processo de criação dos objetos podendo retornar 
  o tipo desejado ou uma subclasse. :heavy_check_mark:</li>
  <li>Remoçao do forte acoplamento entre as classes. :heavy_check_mark:</li>
  <li>Facilita a manutenção do código. :heavy_check_mark:</li>
</ul>

## :x: Desvantagens

<ul>
   <li>Complexidade: O <b>Factory</b> Method Pattern pode adicionar complexidade ao código, especialmente em aplicativos pequenos :x: </li>
</ul>
