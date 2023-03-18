<h1 align = "center">
  Delivery Driver
</h1>

## 📄 About
<p>Primeiro projeto do curso de desenvolvedor de jogos 2D em Unity e C# <a href="https://www.udemy.com/course/unitycourse/">[Link]</a>. Esse projeto tem como objetivo ensinar os básicos da ferramenta Unity. Deste modo, foi realizado um jogo simples, com um carro que realizará entregas. </p> 

## 🖥 Imagem
<p>Sem imagem ainda...</p>

## 📖 Aprendizados desse módulo
Neste módulo foram aplicados diversos conhecimentos, dentre eles:
+ Criação de objetos: criação do carro e do script em C#.
+ Métodos iniciais: `transform.Rotate(x, y, z)` para alterar rotação do carro, `transform.Translate(a, b, c)` para alterar posição do carro.
+ Varíaveis: criação de variáveis para conseguir alterar a rotação e posição do carro.
+ SerializeField: um atributo usado para permitir que variáveis privadas sejam exibidas no editor do Unity e possam ser editadas por lá.
+ InputSystem antigo: criação de duas variáveis, `steerAmount` e `moveAmount` em update (pois irá mudar a cada frame). Irá receber `Input.GetAxis("Horizontal") * steerSpeed` e `Input.GetAxis("Vertical") * moveSpeed`.
+ Independência de Framerate: computadores diferentes irão rodar o jogo em framerates diferentes. Assim, haveria comportamentos distintos em diversos computadores, já que há atualizações a cada frame. Assim, iremos multiplicar o valor que `steerAmount` e `moveAmount` recebem por `Time.deltaTime`. Também será necessário alterar as variáveis de velocidade para adpatar a mudança.