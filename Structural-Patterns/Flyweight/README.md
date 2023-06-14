# Padrão Flyweight :leaves:

<h3>Usado para criar muitos objetos pequenos relacionados sem invocar muito trabalho de sobrecarga ao
fazer isso melhorando assim o desempenho e a capacidade de manutenção, pode permitir que os programas suportem
grandes quantidades de objetos mantendo baixo o consumo de memória.</h3>

<h3>Ele consegue isso compartilhamento partes do estado do objeto entre vários objetos, assim, ele economiza
memória armazenando em cache os mesmos dados usados por objetos diferentes.</h3>

<h4>Cada objeto Flyweight possui duas partes:</h4>
<ul>
    <li>O estado <b>Intrínseco(Interno)</b> que é constante e é armazenado com o próprio objeto Flyweight na memória.</li>
    <li>O estado <b>Extrínseco(Externo)</b> não é constante e precisa ser calculado em tempo de execução e
        não é armazenado na memória.</li>
</ul>

<h3>Diagrama UML do Padrão Flyweight </h3>

![image](https://www.dofactory.com/images/diagrams/net/flyweight.gif)

## Quando usar :question: 

<ul>
    <li>Quando muitos objetos semelhantes forem usados e o custo de armazenamento for alto.</li>
    <li>Quando pudermos compartilhar estado entre objetos.</li>
    <li>Quando preciarmos economizar memória.</li>
</ul>

## :heavy_check_mark: Vantagens 

<ul>
    <li>Reduz o uso de memória compartilhando objetos pesados. :heavy_check_mark: </li> 
    <li>Favorece o Cache de dados permitindo um maior tempo de resposta. :heavy_check_mark: </li> 
    <li>Aumenta o desempenho reduzindo o número de objetos pesados na memória. :heavy_check_mark: </li> 
</ul>

## :x: Desvantagens

<ul>
    <li>Os objetos flyweights pode introduzir custos de tempo de execução associados à trasnferência,
        localização e/ou ccomputação do estado extrínseco(Externo), especialmente se ele foi anteriormente
        foi anteriormente armazenado como estado intríseco(Interno). :x:
    </li> 
    <li>A aplicação do padrão possui um escopo reduzido e de acrdo com o Gof 5 condições devem ser consideradas
        para que os benefícios do padrão sejam tangíveis. :x:
    </li>
</ul>
