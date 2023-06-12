# Padrão Singleton - Uma unica instancia :point_up:

<h3>Usado principalmente para controlar as intâncias no caso obtem somente 1 para todas as vezes que for instanciada,
sempre sera a mesma instância usado para controlar conexões com banco de dados, arquivos, HTTP.</h3>

<h3>Diagrama UML do padrão Abstract Singleton</h3>

![image](https://arquivo.devmedia.com.br/artigos/Higor_Medeiros/PadraoSingleton/PadraoSingleton_Java1.jpg)

## Quando usar :question: 

<ul>
  <li>Pode ser usado para controlar a concorrencia de recursos compartilhados.</li>
  <li>Quando a Classe e usada por varias partes do sistema e não gerencia nenhum estado da aplicação <br>
  como por exemplo Logs da aplicação.</li>
  <li>Compartilhamento de dados, como por exemplo dados do appsettings.json</li>
</ul>

## :x: Desvantagens

<ul>
   <li>Não e seguro para processos multi thread pois e bem possivel que o singleton seja criado mais de 1 vez :x: </li>
</ul>