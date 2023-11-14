# Atividade Presencial SA5 - Criação de uma classe

## Objetivo:
Criar uma classe em C# para guardar o personagem de um jogo de cartas para dois jogadores.
Cada jogador possui um personagem com vida, força, defesa e uma lista cartas.
As cartas podem ser de alguns tipos específicos. 

## Passo a passo
### 1. Criar um ENUM para os tipos de cartas.
- Carta de Cura: Aumenta a vida do personagem que usar a carta
- Carta de Força: Aumenta a força do personagem que usar a carta
- Carta de Defesa: Aumenta a defesa do personagem que usar a carta
- Carta de Vida máxima: Aumenta a vida máxima
  
### 2. Criar uma classe em C# para o personagem, contendo os atributos:
- Vida máxima - inteiro que guarda a vida máxima do personagem. No ínicio do jogo, a vida máxima é igual a vida do personagem.
- Vida - inteiro que guarda a vida do personagem
- Força - inteiro que guarda a vida do personagem
- Defesa - inteiro que guarda a vida do personagem
- Cartas - lista que representam as cartas que o jogador possui. Será utilizado o Enum que foi criado.

### 3. Criar a função principal
Na função principal:
- Criar dois personagens
- Solicitar do usuário o nome para o personagem utilizando ReadLine(), (documentaçao abaixo)
- 

## Material de apoio
Como material de apoio poderá ser utilizado a documentação do C# abaixo:
- https://learn.microsoft.com/pt-br/dotnet/csharp/

Para fazer a leitura do teclado, será usada o método ReadLine(), exemplo abaixo:
- https://caffeinealgorithm.com/blog/funcao-readline-em-csharp


## Entrega
Enviar o arquivo **.CS** no AVA, em Avaliações > Atividade Presencial da SA5. **Até o intervalo (20h)** de hoje 17/11/2023!!


# Continuação do projeto
O projeto poderá ser continuado (em casa)

Criar uma classe em C# para guardar o personagem de um jogo de cartas para dois jogadores.
Cada jogador possui um personagem com vida, força, defesa e cartas. A cada rodada, um jogador pesca uma carta.
Na sua vez, o jogador pode usar uma carta ou atacar o adversário.
Quando um usuário ataca outro, perde pontos de vida.
Não é possivel atacar o adversário E usar um item na mesma jogada.

Criar um jogo de cartas para dois jogadores.
Cada jogador possui um personagem com vida, força, defesa e cartas. A cada rodada, um jogador pesca uma carta.
Na sua vez, o jogador pode usar uma carta ou atacar o adversário.
Quando um usuário ataca outro, perde pontos de vida.
Não é possivel atacar o adversário E usar um item na mesma jogada.

#### 3. Criar construtores para o personagem

# Algoritmo do jogo
* O jogo acontece da seguinte forma:
- O jogador 1 informa o nome do seu personagem
- O jogador 2 informa o nome do seu personagem

* Enquanto a vida dos dois personagens for maior que 0, repita:
- Jogador 1 escolhe entre (1) Pescar uma carta (2) Atacar adversário
- Se o jogador escolheu (1) Pescar uma carta
-- Utilizar a função rand() para sortear uma das 3 cartas 

- Se o jogador escolheu (2) Atacar adversário:
  O sistema verifica se a força do jogador atacante é maior que a defesa do jogador atacado.
  Se a força for maior que a defesa,  

Ataque:
Quando um usuário ataca outro, perde pontos de vida.
Não é possivel atacar o adversário e usar um item na mesma jogada.


Existem quatro tipos de carta:
- Item de Cura: Recupera/Aumenta pontos de vida (HP)
- Aumenta a força do jogador
- Aumenta a defesa do jogador
- Aumenta a vida permanente (máxima)
