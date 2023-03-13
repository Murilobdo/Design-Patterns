# Padrão Iterator :handshake:

### Este padrão tem como objetivo as coleções Listas, Pilhas, Filas, Avores entre outras, o Iterator fornece uma maneira de percorrer os elementos sequencialmente sem expor a implementação/lógica da collection.


![image](https://jucimarjr.github.io/zelda/design_patterns/iterator/IteratorDP.png)

## Quando usar :question: 

<ul>
  <li>Quando sua coleção tiver uma estrutura de dados complexa e você deseja ocultar a complexidade dos clientes.</li>
  <li>Pode ser usada para reduzir a duplicidade do código para percorrer as coleções.</li>
  <li>Quando quiser que sua aplicação percorra diferentes tipos de dados ou quando o tipo da coleção </br>
  for desconhecida no momento.</li>
</ul>


## :heavy_check_mark: Vantagens 

<ul>
  <li>Fornece suporte a estruturas de dados onde a aplicação originalmente não a possui. :heavy_check_mark: </li> 
  <li>Permiti definir mais de um iterador. :heavy_check_mark: </li> 
  <li>Simplifica o código para acessar diferentes tipos de coleção. :heavy_check_mark: </li> 
</ul>

## :x: Desvantagens

<ul>
  <li>É menos eficiente ao percorrer elementos de algumas coleções especializadas diretamente, usando mais memória </br>
  do que fosse feito um acesso direto ao elemento. :x:
  </li> 
  <li>Não e recomendado para coleções simples. :x:
  </li> 
</ul>
