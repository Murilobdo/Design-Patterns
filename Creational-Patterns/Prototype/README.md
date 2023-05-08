<h1>Padrão Prototype </h1>

<h3>O padrão <b>Prototype</b> tem um unico objetivo que seria uma maneira de clonar um objeto sem necessariamente criar uma nova instância do mesmo. </h3>



## Diagrama UML do padrão Builder
![image](https://upload.wikimedia.org/wikipedia/commons/e/e5/Prototype_UML_%28padr%C3%A3o%29.png)

## Quando usar :question: 

<ul>
  <li>Quando a criação de novos objetos tem um grande custo e leva muito tempo.</li>
  <li>Evitar criar um novo objeto utilizando a palavra 'new' que diminui o custo de memoria.</li>
  <li>Quando existir a necessade de clonar, criar copias de um objeto.</li>

</ul>


## :heavy_check_mark: Vantagens 

<ul>
  <li>O padrão elimina a possivel sobrecarga custosa de inicializar um objeto. :heavy_check_mark:</li>
  <li>Ajuda na otimização do caso de uso em que vários objetos do mesmo tipo têm dados quase semelhantes. :heavy_check_mark:</li>
  <li>fornece uma alternativa para herança quando o objeto tem predefinições de configuração para objetos complexos. :heavy_check_mark:</li>
</ul>

## :x: Desvantagens

<ul>
   <li>Implementar o padrão em uma hierarquia de classes ja existente pode ser dificil, pois eles devem implementar <br>
   o metodo clone(), e alguns objetos podem estar usando objetos internos que não suportam cópia ou podem ter referência circular. :x: </li>

   <li>O uso excessivo do padrão pode afetar o desempenho, ja que  o próprio objeto de protótipo precisaria ser instanciado se você usar <br>
   um registro de protótipos :x:</li>
</ul>
 