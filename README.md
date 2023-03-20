<h1 align = "center">
  Delivery Driver
</h1>

## 📄 About
<p>Primeiro projeto do <a href="https://www.udemy.com/course/unitycourse/">curso de desenvolvedor de jogos 2D em Unity e C#</a>. Esse projeto tem como objetivo ensinar os básicos da ferramenta Unity. Deste modo, foi realizado um jogo simples, com um carro que realizará entregas. </p> 

## 🛣️ Imagem
![Delivery Driver](https://user-images.githubusercontent.com/57302703/226485402-c2e93082-bef4-428a-993d-04207be27dd1.gif)

## 🖥️ Scripts
Em resumo, o que foi ensinado em relação à código pode ser resumido nesses três scripts:
+ <a href="https://github.com/felipecomarques/delivery-driver/blob/main/Assets/Delivery.cs">Delivery.cs</a> - responsável pela lógica da entrega dos pacotes
+ <a href="https://github.com/felipecomarques/delivery-driver/blob/main/Assets/Driver.cs">Driver.cs</a> - responsável pela lógica do movimento do carro
+ <a href="https://github.com/felipecomarques/delivery-driver/blob/main/Assets/FollowCamera.cs">FollowCamera.cs</a> - responsável pela câmera seguir o carro


## 📖 Aprendizados detalhados deste módulo
Explicando de maneira detalhada, neste módulo foram aplicados diversos conhecimentos, dentre eles:
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
+ Criar Tag: tag é uma marcação que pode ser aplicada a um objeto para facilitar sua identificação. São úteis para organizar e gerenciar objetos em uma cena. Assim, será criado e adionado tags para o Package e o Costumer.
+ Estrutura condicional: adicionado uma condição para saber em qual tag foi ativado, usando, por exemplo: `collision.tag == "Package"`
+ Variável bool: Para impossibilitar o jogador de entregar a encomenda ser ter pego a encomenda é criado uma variável booleana. Assim, quando pega a encomenda ela é verdadeira, e quando entrega ela é falsa. É aplicado essa lógica a estrutura condicional.
+ Destruir Objetos: Há vários pacotes, quando pegar um deles, é necessário destrui-lós da cena. Deste modo, será usado `Destroy(parâmetroDoMétodo.gameObject, delay)` na estrutura condicional. É possível adicionar um delay, que será uma variável que poderá ser alterada posteriormente. Adicionado condição que impede que múltiplas encomendas sejam pegas ao mesmo tempo.
+ Mudar cor do carro quando há ou não encomenda: é criado duas variáveis do tipo `Color32`, cada uma para um estado do carro. Então é criado mais uma variável para referenciar o renderizador de sprite, do tipo `SpriteRenderer`. Então, no método Start(), é variável atribuída ao componente "SpriteRenderer" por meio do método `GetComponent<SpriteRenderer>()`. Em seguida, é alterada as cores nas estruturas condicinais.
+ Boost e bump: será criado um objeto para aumentar a velocidade. Além disso, toda vez que colidir com um obstaculo, irá diminuir a velocidade. Para isso, são criadas variáveis no script Driver que irão armazenar estas velocidades. São criados métodos `OnCollisionEnter2D`, onde a velocidade atual recebe punição, enquanto a `OnTriggerEnter2D` recebe recompensa. Na segunda, há o uso da tag Boost para não ativar em outros OnTrigger, como as encomendas.
