# Criar uma branch e fazer pull request no git
Hoje vamos criar uma branch e fazer uma pull request.

## Baixar o Git Portable e extrair 
https://github.com/git-for-windows/git/releases/download/v2.43.0.windows.1/PortableGit-2.43.0-64-bit.7z.exe

## Fazer a atividade em dupla:
1. Cada um vai criar um repositório no github.com
1. Cada um vai adicionar o outro no seu projeto no github
2. Abrir o git-bash
3. Usem o comando `git clone`, um no repositório do outro.
1. Faça a configuração do git:

`git config --global/local user.name "[Seu nome]"`

`git config --global/local user.email "[Seu endereço de e-mail]"`

5. Quando forem trabalhar em conjunto no projeto, é assim que funciona:
6. Criar uma nova branch para trabalhar `git branch "nome-branch"` nome-branch pode ser o nome que quiser, geralmente está relacionado com a funcionalidade que será implementada
7. Agora, vamos mudar para a nova branch usando o comando ´git checkout nome-branch´
8. Se deu certo vai aparecer o texto "Switched to branch ..."
9. Crie um arquivo chamado "readme.md", é o arquivo "leia-me", geralmente tem instruções sobre o projeto e o repositório
10. Agora, vammos adicionar o arquivo criado para fazer um commit `git add readme.md`
11. Depois, vamos fazer o commit `adicionado arquivo leia-me`
12. Agora, vamos fazer o `push`, que será para a branch que a gente criou `git push origin nome-branch`
13. Faça a autenticação que se pede

## Criar um pull request
1. No github, entre no projeto, acesse pull requests
![image](https://github.com/giov8/uc-05/assets/77603677/2dce3eb8-80de-49dd-bacd-8b668c4252fd)
2. Clique em "New pull request", botão verde a esquerda
3. Selecione a branch que você criou
 ![image](https://github.com/giov8/uc-05/assets/77603677/db4f760f-90b0-4db7-835f-7102886d9f72)
4. Clique em "Create pull request"
5. Nos revisores "Reviewers", adicione o outro colega e confirme a criação do pull request
6. A outra pessoa vai entrar no pull request, aprovar e fazer o merge


