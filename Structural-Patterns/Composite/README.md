# Padrão Composite :chains:

<h3>Este padrão compõe objetos em estruturas semelhantes a uma árvore para representar
hierarquias parte-todo, permite que oos clientes tratem objetos individuais e composições de
objetos de maneira uniforme (como um único objeto)</h3>

<h3>Estrutura</h3>
<ul>
    <li>
        <b>Componente: </b> Um component é uma interface que descreve operações comuns a elementos simples ou complexos da árvore.
    </li>
    <li>
        <b>Leaf: </b> Um leaf é um único objeto, que não possui subelementos, um nó folha.
    </li>
    <li>
        <b>Composite: </b> Um composite é um objeto que possui subelementos (folhas ou outros objetos compostos).
    </li>
</ul>

<h3> Diagrama UML do Padrão Composite </h3>

![image](https://upload.wikimedia.org/wikipedia/commons/3/3d/CompositeBasic.gif)

## Quando usar :question: 

<ul>
    <li>Quando precisarmos criar uma estrutura em árvore para resolver um problema.</li>
    <li>Quando precisarmos representar hierarquias todo-parte de objetos.</li>
    <li>Quando queremos que os clientes ignorem a diferença entre composições de objetos e objetos individuais.</li>
</ul>


## :heavy_check_mark: Vantagens 

<ul>
    <li>Ajuda a alcançar a uniformidade (uso de funções semelhantes) em toda a hierarquia de objetos </br>
        que contém tipos de objetos primitivos e compostos. :heavy_check_mark: </li> 
    <li>Torna mais fácil para o cliente atingir a funcionalidade desejada sem se preocupar com o tipo </br>
        de objeto com qual esta lidando. :heavy_check_mark: </li> 
</ul>

## :x: Desvantagens

<ul>
  <li>Pode se tornar muito genérica devido a sua uniformidade, tornando assim dificil restringir objetos que </br>
  podem ser incluidos no objeto composto :x: </li> 
</ul>
