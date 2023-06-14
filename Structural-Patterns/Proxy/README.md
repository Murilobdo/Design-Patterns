# Padrão Proxy :leaves:

<h3>Tem a função de fornecer um objeto que atua como um substituto para um objeto de serviço real usado
por um cliente para controlar o acesso a ele. Permite também encapsular a instância de uma classe complexa
usando uma instanância de outra classe que possui a mesma interface.</h3>

<h3>Proxy significa 'no lugar de' ou 'em nome de'.</h3>

<h3>Existem 3 tipos de Proxy</h3>

<h3>Diagrama UML do Padrão Proxy </h3>
<ul>
    <li>
        <b>Proxy Virtual:</b> é um espaço reservado para objetos que consome muitos recursos para serem criados.
        Neste contexto o objeto real só é criado quando um cliente primeiro solicita ou acessa o objeto.
    </li>
    <li>
        <b>Proxy Remoto:</b> Fornce representação local para um objeto que reside em um espaço de endereço diferente.
    </li>
    <li>
        <b>Proxy de Proteção:</b> Controla o acesso a um objeto principal. Aqui o objeto proxy verifica se o chamador tem as permissões de acesso necessárias antes de encaminhar a solicitação.
    </li>
</ul>

![image](https://www.dofactory.com/images/diagrams/net/proxy.gif)

## Quando usar :question: 

<ul>
    <li>Quando precisamos criar objetos sob demanda quando suas operações forem solicitadas.</li>
    <li>Quando temos uma classe com dados sensíveis (que deveriam ser de acesso restrito) e é
        necessário fornecer o controle de acesso para o objeto atual.
    </li>
    <li>Quando temos que usar  classes onde a criação dos objetos é muito demorada e consome muitos recursos.</li>
    <li>Quando devemos permitir o acesso a um objeto remoto usando um objeto local(referenciando o objeto remoto).</li>
</ul>

## :heavy_check_mark: Vantagens 

<ul>
    <li>Evita a duplicação de objetos grandes e que usam muita memória. Isso aumenta o desempenho da aplicação
        através do uso de cache para acessar os objetos mais pesados. :heavy_check_mark: 
    </li> 
    <li>O Proxy remoto garante a segurança instalando o proxy de código local (stub) na máquina do cliente
        e acessando o servidor com a ajuda do código remoto. :heavy_check_mark:</li> 
</ul>

## :x: Desvantagens

<ul>
    <li>Ele introduz outra camada de abstração que às vezes pode ser um problema se o código do RealSubject
        for acessado por alguns dos clientes diretamente e alguns deles puderem acessar as classes Proxy. :x:</li>
</ul>
