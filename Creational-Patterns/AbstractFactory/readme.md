# Padrão Abstract Factory - A Fábrica de fábricas de objetos :thinking:

## Basicamente que ele prove uma interface para criação de famílias de objetos relacionados sem especificar sua classe concreta (A Classe pai).

## Dessa maneira ele encapsula um grupo de fábricas individuais que possuem um tema em comum, abaixo um diagrama ER do padrão Abstract Factory

![image](https://user-images.githubusercontent.com/36682707/224127198-a8526c57-1faf-49cb-a2fc-fbd1396b117a.png)

## Quando usar :question: 

<ul>
  <li>Quando o sistema deve ser configurado para funcionar com famílias de produtos.</li>
  <li>Quando deseja criar um conjunto de objetos relacionados ou dependentes que devem ser usados juntos.</li>
  <li>Se por acaso o seu sistema precisa que os produtos sejam criados/manipulados de maneira diferente.</li>
  <li>Se você tiver uma bilbioteca de classes e quer revelar somente suas interfaces, não implementações</li>
</ul>


## :heavy_check_mark: Vantagens 

<ul>
  <li>Isola as classes concretas dos clientes. :heavy_check_mark: </li> 
  <li>Facilita a troca de familia de produtos. :heavy_check_mark: </li> 
  <li>Promove a consistência de produtos (Não mistura objetos de familias diferentes). :heavy_check_mark:</li> 
 
</ul>

## :x: Desvantagens

<ul>
   <li>Dificulta a criação de novos produtos ligeiramente diferentes (pois temos que modificar a </br>
  fabrica abstrata e todas as fabricas concretas)  :x: </li>
  <li>Se tivermos muitas familias de produtos teremos excesso de classes das fábrias concretas :x: </li>
</ul>
