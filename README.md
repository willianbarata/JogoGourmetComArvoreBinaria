## Explicação do Sistema:
O sistema apresentado é um jogo de adivinhação de pratos, utilizando uma estrutura de dados chamada árvore binária. A árvore é composta por nós, cada um representando um prato. Cada nó pode ter no máximo dois filhos: um à esquerda e outro à direita.

## Funcionalidades do Sistema:

### Adicionar um novo prato:

O usuário informa o nome do prato e a classificação do mesmo (ex: "Lasanha" é "Massa").
O sistema cria um novo nó na árvore e o insere na posição correta, de acordo com a classificação.

### Adivinhar o prato:

O sistema faz perguntas ao usuário para determinar o prato que ele está pensando.
A cada pergunta, o sistema direciona o usuário para um ramo diferente da árvore, de acordo com a resposta.
Se o usuário responder "sim" à pergunta, o sistema segue para o filho direito do nó atual.
Se o usuário responder "não", o sistema segue para o filho esquerdo do nó atual.
O processo continua até que o sistema chegue a um nó que não possui filhos (folha na nomenclatura da arvore).
Se o sistema adivinhar o prato corretamente, ele informa ao usuário e pergunta se ele deseja jogar novamente.
Se o sistema não adivinhar o prato corretamente, ele pede ao usuário para fornecer o nome do prato correto e a sua classificação.
O sistema então cria um novo nó na árvore com o nome do prato correto e a classificação fornecida pelo usuário.
Estrutura de Dados:

NodeClassificaPratos: Classe que representa um nó na árvore.

Valor: String que representa o nome do prato.
PratoFilhoEsquerdo: Nó que representa o filho esquerdo do nó atual.
PratoFilhoDireito: Nó que representa o filho direito do nó atual.
ClassificacaoDosPratos: Classe que representa a árvore binária.

Raiz: Nó que representa a raiz da árvore.
Adicionar: Método que adiciona um novo nó na árvore.
EstaVazia: Método que verifica se a árvore está vazia.

## Exemplo de Uso:

O usuário informa que está pensando em um prato.
O sistema pergunta ao usuário se o prato é "Massa".
O usuário responde "sim".
O sistema pergunta ao usuário se o prato é "Lazanha".
O usuário responde "sim".
O sistema adivinhou o prato corretamente e informa ao usuário.
O usuário pergunta se deseja jogar novamente.
Observações:

O sistema é implementado em C# 8.
O sistema utiliza uma interface gráfica para interagir com o usuário.
O sistema pode ser facilmente adaptado para adivinhar outros tipos de objetos, além de pratos.

### Porque escolhi esse algoritmo
A árvore binária permite uma busca eficiente por um determinado prato. A cada pergunta feita ao usuário, o sistema elimina metade dos pratos da árvore,
reduzindo o número de comparações necessárias para encontrar o prato correto. Em média, o sistema precisa fazer apenas log(n) comparações, 
onde n é o número de pratos na árvore. 


