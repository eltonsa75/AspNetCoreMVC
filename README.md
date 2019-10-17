# AspNet Core MVC
ASP.NET Core MVC é um Framework de código aberto para construção de aplicações conectadas pela internet 

#Dicas Importante para ser utilizada nas Views

TempData

O TemData é um recurso útil qundo se deseja armazenar um valor em uma curta sessão de tempo, entre requisições. A princípio, cria-se uma chave e armazena-se nela um valor.
Este valor ficará disponivel até que ele seja recuperado.

No momento de recuperá-lo, ele fica marcado para ser removido ao final da requisição. Você pode dar uma olhada nos métodos Peek() e Keep() de TempData para ver como evitar este comportamento.


Virtual

A virtual é uma palavra-chave usada para modificar uma declaração de método, propriedade, indexador ou evento, e permitir que ele seja sobrecrito em uma classe derivada. Para mais informações, recomendo a leitura do artigo Virtual vc Override vs New Keyword in C#.


IColletion

A escolha da interface ICOLLETION para ropriedade deve-se ao fato de que, com ela, é possivel iterar(navegar) nos objetos recuperados e modificá-los. Existe ainda a possibilidade de utilizar IEnumerable apenas para navegar, e IList quando precisar de recursos a mais, como uma classificação dos elementos.


SelectList()

O SelectList() representa uma lista de itens da qual o usuário pode selecionar um item. em nosso caso, os itens serão expostos em um DropDownList.


Partial View

Partial Views são visões que contêm código (HTML e/ou Razor) e são projetadas para serem renderizadas como parte de uma visão. elas não possuem layouts, como as visões, e podem ser "inseridas" dentro de diversas visões, como fossem um componente ou controle.



