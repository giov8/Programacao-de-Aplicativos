# Atividade Presencial SA5 - Criação de uma classe

## Objetivo:
Criar uma classe em C# para guardar o personagem de um jogo de cartas para dois jogadores.
Cada jogador possui um personagem com vida, força, defesa e uma lista cartas.
As cartas podem ser de alguns tipos específicos. 

## Passo a passo
Você pode criar o programa do zero ou utilizar o esqueleto **programa.cs** para implementar os passos a seguir:

### 1. Criar um ENUM para os tipos de cartas.
- Carta de Cura: Aumenta a vida do personagem que usar a carta
- Carta de Força: Aumenta a força do personagem que usar a carta
- Carta de Defesa: Aumenta a defesa do personagem que usar a carta
- Carta de Vida máxima: Aumenta a vida máxima
  
### 2. Criar uma classe em C# para o personagem, contendo os atributos:
- Nome - string que guarda o nome do personagem
- Vida máxima - inteiro que guarda a vida máxima do personagem. No ínicio do jogo, a vida máxima é igual a vida do personagem.
- Vida - inteiro que guarda a vida do personagem
- Força - inteiro que guarda a vida do personagem
- Defesa - inteiro que guarda a vida do personagem
- Cartas - lista que representam as cartas que o jogador possui. Será utilizado o Enum que foi criado.

### 3. Criar a função principal
Na função principal:
- Criar dois personagens
- Solicitar do usuário o nome para o personagem. Para isso você pode utilizar a função ReadLine(). A documentação está abaixo.
- Criar dois personagens e adicionar o nome a eles

#### Desafio
Melhorar o código implementando um **construtor** para a classe Personagem
- https://acervolima.com/c-construtores/
- https://www-w3schools-com.translate.goog/cs/cs_constructors.php?_x_tr_sl=auto&_x_tr_tl=pt&_x_tr_hl=pt-BR&_x_tr_pto=wapp

## Material de apoio
Como material de apoio poderá ser utilizado a documentação do C# abaixo:
- https://learn.microsoft.com/pt-br/dotnet/csharp/

Para fazer a leitura do teclado, será usada o método ReadLine(), exemplo abaixo:
- https://caffeinealgorithm.com/blog/funcao-readline-em-csharp


## Entrega
Enviar o arquivo **.CS** no AVA, em Avaliações > Atividade Presencial da SA5. **Até o intervalo (20h)** de hoje 17/11/2023!!


# Continuação do projeto
O projeto poderá ser continuado (em casa) para ser apresentado no dia 23/11/2023, que é a última aula da disciplina.

## Definição do projeto 
Criar um jogo de cartas para dois jogadores.
Cada jogador possui um personagem com vida, força, defesa e cartas. A cada rodada, um jogador pesca uma carta.
Na sua vez, o jogador pode usar uma carta ou atacar o adversário.
Quando um usuário ataca outro, perde pontos de vida.
Não é possivel atacar o adversário e usar um item na mesma jogada.

## Algoritmo do jogo
O jogo acontece da seguinte forma:
- O jogador 1 informa o nome do seu personagem
- O jogador 2 informa o nome do seu personagem

**Enquanto a vida dos dois personagens for maior que 0, repita:**
- O jogador da vez recebe uma carta aleatória
- O jogador da vez escolhe entre (1) Usar uma carta (2) Atacar adversário
  
- Se o jogador escolheu (1) Usar uma carta
  - Imprimir a lista de cartas disponíveis para o uso
  - O jogador escolhe uma carta para usar e o efeito da carta será aplicado como descrito acima 

- Se o jogador escolheu (2) Atacar adversário:
  - O sistema verifica se a força do jogador atacante é maior que a defesa do jogador atacado.
  - Se a força for maior que a defesa, o jogador atacado perde vida.
  - Se a força não for maior que a defesa, nada acontece.

 - Agora é vez do outro jogador
