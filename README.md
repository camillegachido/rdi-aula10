# 🍔 Sistema de Rede de Fast Food (POO)
## Grupo: Fernanda Worm, Gabriela Miranda e Priscilla Trevizan


Este projeto consiste no desenvolvimento de um **sistema orientado a objetos** que simula o funcionamento básico de uma **rede de fast food**.  
O sistema permite o **cadastro de produtos**, a **realização de pedidos** e o **controle de estoque**, aplicando conceitos fundamentais de **Programação Orientada a Objetos (POO)**.

---

## 🎯 Objetivo

Aplicar conceitos de POO como:

- Classes e Objetos  
- Encapsulamento  
- Composição  
- Reuso de código  
- Interação entre classes  

---

## 🧩 Estrutura do Sistema
O sistema é composto pelas seguintes classes:

---

## 👤 Classe `Usuario`

Representa o cliente que realiza pedidos no restaurante.

### Atributos
- `Nome` → Nome do usuário  
- `Telefone` → Telefone do usuário (utilizado como identificador)  
- `Pedidos` → Lista de pedidos realizados pelo usuário  

### Métodos
- `FazerPedido(Restaurante restaurante, Pedido pedido)`  
  - Associa o pedido ao usuário  
  - Adiciona o pedido à lista de pedidos do restaurante  

- `VerPedidosAnteriores()`  
  - Exibe todos os pedidos já realizados pelo usuário  

---

## 🍟 Classe `Produto`

Representa um item disponível para venda no restaurante.

### Atributos
- `Id` → Identificador do produto  
- `Nome` → Nome do produto  
- `Valor` → Preço unitário do produto  
- `QtdEstoque` → Quantidade disponível em estoque  

---

## 🧾 Classe `Pedido`

Representa um pedido realizado por um usuário.

### Atributos
- `Id` → Identificador do pedido  
- `Hora` → Data e hora do pedido  
- `Usuario` → Usuário que realizou o pedido  
- `Produtos` → Lista de produtos do pedido  

### Métodos
- `AdicionarProduto(Produto produto, int quantidade)`  
  - Adiciona um produto à lista de produtos do pedido  

- `CalcularTotal()`  
  - Calcula e retorna o valor total do pedido  

- `FinalizarPedido()`  
  - Confirma o pedido e exibe um resumo (produtos + total)  

⚠️ **Observação:**  
Um pedido **só pode ser finalizado** se possuir **pelo menos um produto**.

---

## 🏪 Classe `Restaurante`

Representa o restaurante da rede de fast food.

### Atributos
- `Produtos` → Lista de produtos disponíveis para venda  
- `Pedidos` → Lista de pedidos realizados  

### Métodos
- `CadastrarProduto(Produto produto)`  
  - Inclui um novo produto disponível no restaurante  

- `BuscarProdutoPorId(int id)`  
  - Retorna um produto pelo seu identificador  

- `ListarProdutosDisponiveis()`  
  - Exibe todos os produtos com estoque maior que zero  

---

## 🖥️ Fluxo da Interface do Sistema

Após a criação das classes, o sistema deverá possuir uma **interface interativa** que funcione da seguinte forma:

1. Exibir uma mensagem de boas-vindas  
   - Exemplo: **“Bem-vindo ao Pônei Donald!”**
2. Solicitar o cadastro do usuário  
3. Exibir um menu com as opções:
   - **1** → Fazer um novo pedido  
   - **2** → Ver pedidos anteriores  
   - **3** → Sair  
4. Caso o usuário escolha **fazer um novo pedido**:
   - Exibir todos os itens disponíveis no cardápio  
   - O usuário seleciona um produto  
   - O sistema pergunta se deseja:
     - Finalizar o pedido  
     - Adicionar um novo produto  
   - Esse processo se repete até a finalização do pedido  
5. Ao finalizar:
   - O sistema exibe um **resumo do pedido**
   - Informa que o pedido estará pronto em breve  
6. O sistema retorna ao menu inicial, permitindo:
   - Fazer um novo pedido  
   - Visualizar pedidos anteriores  
