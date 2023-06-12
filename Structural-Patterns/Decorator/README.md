# Padrão Decorator :bookmark_tabs:

<h3>Ele se encarrega de atribuir responsabilidades adicionais a um objeto de forma dinâmica sem afetar o comportamento <br>
de outros objetos da mesma classe, fornece uma alternativa flexível á herança para estender uma funcionalidade.
</h3>

<h3> Diagrama UML do Padrão Decorator </h3>

![image](https://www.thiengo.com.br/img/post/normal/h7es79md3qmktitpnk4rngie9575459cb5996eed4c8fa60cfa16c95312.jpg)

## Quando usar :question: 

<ul>
    <li>Quando houver necessidade de anexar ou remover comportamentos de apenas algumas instâncias <br>
        de uma classe, em vez de todas as instâncias da classe.
    </li>
    <li>Quando a extensão através da herança for impraticável (Explosão de Classes) ai uma agregação viria a servir.</li>
    <li>Quando temos uma classe que não pode ser herdada por estarmos herdando de uma outra classe qualquer.</li>
</ul>


## :heavy_check_mark: Vantagens 

<ul>
  <li>É mais flexível que a herança pois adiciona responsabilidades em tempo de execução e não em tempo de compilação. :heavy_check_mark: </li> 
  <li>Estende a funcionalidade de objetos sem afetar outros objetos da mesma classe :heavy_check_mark: </li> 
  <li>Ele favorece o principio Aberto-Fechado ou seja aberto para extensão e fechado para modificação :heavy_check_mark: </li> 
</ul>

## :x: Desvantagens

<ul>
  <li>Manutenção de código em numero de objetos a ser mantidos :x: </li> 
</ul>
