# Padrão Facade :chains:

<h3>Este padrão fornece uma interface unificada para um conjunto de interfaces em um subsistema, é definida
uma interface de nivel superior (no topo de um grupo de  subsistemas) para maior facilidade na hora de usar.</h3>

<h3> Diagrama UML do Padrão Facade </h3>

![image](https://arquivo.devmedia.com.br/artigos/Higor_Medeiros/PadraoFacade_Java/PadraoFacade_Java1.jpg)

## Quando usar :question: 

<ul>
    <li>Quando queremos simplificar uma sequência de operações complexas.</li>
    <li>Quando queremos simplificar a interface com o usuário.</li>
    <li>Quando queremos fornecer uma interface única de uniforme para as diversas 
        funcionalidades de um subsistema.
    </li>
    <li>Quando queremos criar um sistema em camadas. Um Facade provê o ponto de entrada
        para cada camada do subsistema.
    </li>
</ul>


## :heavy_check_mark: Vantagens 

<ul>
    <li>Facilita a portabilidade do sistema e sua interação com o subsistema. :heavy_check_mark: </li> 
    <li>Isola os clientes dos componentes do subsistema reduzindo o número de 
        objetos com os aquias o cliente tem que lidar. :heavy_check_mark: </li> 
    <li>Promove um acoplamente fraco entre  o subsistema e seus clientes. :heavy_check_mark: </li> 
</ul>

## :x: Desvantagens

<ul>
    <li>Introduzr uma camada adicional entre o cliente e o subsistema, o que contribui para
        a complexibilidade do código. :x: </li> 
    <li>Cria uma depêndencia entre vários subsistemas, pois vários métodos são chamados a partir deles
        para servir ao cliente. :x: </li> 
    <li>As APIs específicas do cliente precisam ser introduzidas na classe Facade, e isso requer manutenção adicional. :x: </li> 
</ul>
