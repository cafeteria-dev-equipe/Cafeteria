# ☕ Cafeteria Dev

**Checkpoint 2 — FIAP | Desenvolvimento em C# com Windows Forms**

## 📌 Sobre o projeto

O **Cafeteria Dev** é uma aplicação desktop desenvolvida em C# com Windows Forms e .NET, com o objetivo de simular um sistema de vendas de uma cafeteria.

O projeto foi desenvolvido em dupla, utilizando Git e GitHub para organização das tarefas, versionamento do código e integração das funcionalidades.

## 🚀 Funcionalidades

- **Tela Splash:** apresentação inicial da aplicação.
- **Menu Principal:** navegação entre as funcionalidades.
- **Registro de Vendas:** seleção do café e da quantidade desejada.
- **Cálculo Automático:** cálculo do valor total de cada pedido.
- **Relatório de Vendas:** visualização dos pedidos registrados e do faturamento acumulado.

### ☕ Cardápio

| Produto | Preço |
|---|---:|
| Expresso | R$ 5,00 |
| Cappuccino | R$ 8,00 |
| Latte | R$ 10,00 |

## 🛠️ Tecnologias utilizadas

- C#
- .NET 10
- Windows Forms
- Visual Studio
- Git
- GitHub

## 📂 Estrutura do projeto

```text
Cafeteria/
├── Cafeteria/
│   ├── Models/
│   │   ├── Venda.cs
│   │   └── VendaRepository.cs
│   ├── FormSplash.cs
│   ├── FormMenu.cs
│   ├── FormVenda.cs
│   ├── FormRelatorio.cs
│   └── Program.cs
├── integrantes.txt
├── .gitignore
└── README.md
```

## ▶️ Como executar

1. Clone o repositório:

```bash
git clone https://github.com/cafeteria-dev-equipe/Cafeteria.git
```

2. Abra a solução do projeto no Visual Studio.
3. Verifique se o SDK do .NET 10 e o suporte a Windows Forms estão instalados.
4. Compile e execute a aplicação pressionando `F5`.

## 🔄 Fluxo de funcionamento

1. A aplicação apresenta a tela Splash.
2. O usuário é direcionado ao Menu Principal.
3. Na tela de vendas, seleciona um café e informa a quantidade.
4. O sistema calcula o valor e registra o pedido.
5. No relatório, é possível consultar as vendas e o faturamento total.

**Observação:** as vendas são armazenadas em memória durante a execução. Ao encerrar o aplicativo, os registros não são preservados.

## 🌿 Organização do Git

O desenvolvimento foi realizado utilizando branches específicas para cada funcionalidade.

| Branch | Finalidade |
|---|---|
| `main` | Versão principal e entrega final |
| `dev` | Integração das funcionalidades |
| `feature/telas-iniciais` | Desenvolvimento da Splash e do Menu |
| `feature/vendas-relatorio` | Desenvolvimento das vendas e do relatório |
| `feature/integracao-final` | Integração das telas e ajustes finais |

As contribuições foram registradas por meio de commits semânticos e integradas utilizando Pull Requests.

## 👥 Integrantes

| Integrante | Responsabilidade |
|---|---|
| Musashi | Tech Lead, telas iniciais e integração final |
| Felipe | Modelo de vendas, formulário de vendas e relatório |

Os nomes completos e RMs estão disponíveis no arquivo `integrantes.txt`.

## 🎓 Contexto acadêmico

Projeto desenvolvido para o **Checkpoint 2 da FIAP**, com foco na aplicação prática de programação orientada a objetos, desenvolvimento de interfaces desktop e colaboração utilizando Git e GitHub.

---

**Repositório:** https://github.com/cafeteria-dev-equipe/Cafeteria
