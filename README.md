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
+ Colisão: adicionado um objeto círculo. São adicionados componentes de colisão 2D e os componentes Rigidbody para os objetos. Assim, o primeiro permite que seja detectado colisões entre objetos em um ambiente 2D. O segundo seja permite que permite que objetos sejam afetados pela física (é necessário zerar a gravidade para os objetos não caírem da tela). Deste modo, o carro pode empurrar o círculo.
+ Realizar algo quando colidir: criado novo script, com apenas um métodos chamado `OnCollisionEnter2D`. Irá imprimir uma mensagem no console quando colidir
+ Realizar algo quando atravessar: é possível que você queria que apenas realizar quando atravessar, sem interagir fisicamente com o objeto. É criado um retângulo e adicionado componente de colisão 2D. É marcado a opção `Is Trigger`, deste modo, poderá ser atravessado. É adicionado o método `OnTriggerEnter2D` no script anterior com uma mensagem no console.
+ Adicionado assets: é necessário alterar `Pixel Per Unit` para deixar os assets uniformes. Quanto menor, maior o objeto e vice-versa. Assim, basta adicionar o assets no Sprite Renderer. Deste modo, será criado o layout do jogo.
+ Câmera seguir jogador: para a câmera seguir o jogador, é necessário criar um novo script. Esse scipt será adicionado à câmera. Será criado uma variável com SerializeField, do tipo `GameObject`. O método `Update()` será alterado para `LastUpdate()`, porque precisa garantir que o objeto tenha se movido completamente antes que a câmera o siga. Assim, a câmera irá receber `objeto.transform.position + new Vector3 (0, 0, -10)`. É necessário adicionar -10 na posição Z para que a câmera não fique dentro ou atravesse o layout do jogo.
