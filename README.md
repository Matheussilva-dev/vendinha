# Vendinha

Sistema simples para controle das contas (dívidas "penduradas") dos clientes de uma vendinha.
Aplicação desktop em **C# / .NET 10** com **Windows Forms**, **Entity Framework Core** e **PostgreSQL**.

## Funcionalidades

- CRUD de clientes: nome completo*, CPF* (válido e único), data de nascimento*, e-mail (validado se informado). A idade é calculada a partir da data de nascimento.
- Dívidas por cliente: valor, situação (paga ou em aberto), data de criação e data de pagamento.
- Regra: um cliente só pode ter **uma dívida em aberto**.
- Listagem de clientes ordenada do que mais deve para o que menos deve, paginada de 10 em 10, com busca por nome (texto contido), mostrando idade e total de dívidas.
- Listagem de dívidas por cliente, com cadastro de nova dívida e marcação de pagamento.
- Consulta de todas as dívidas (pagas e em aberto) com filtro por situação.

\* campos obrigatórios

## Estrutura

```
Vendinha/                  Biblioteca com a lógica do sistema
  Models/                  Cliente e Divida (com validações por atributos)
  Validacoes/              Validação de CPF
  Contexts/                VendinhaDbContext (Entity Framework Core)
  Services/                ClienteService (regras de negócio e acesso ao banco)
Vendinha.Desktop/          Interface Windows Forms
  Form1                    Menu principal
  Screens/                 ListarClientes, CadastrarCliente, DividasCliente e ListarDividas
db/schema.sql              Script de criação do banco (PostgreSQL)
```

## Como executar

Pré-requisitos: Windows, [.NET SDK 10](https://dotnet.microsoft.com/download) e PostgreSQL.

1. Crie o banco `vendinha`:
   ```sql
   CREATE DATABASE vendinha;
   ```
2. Conectado nesse banco (pelo DBeaver, por exemplo), execute o script [`db/schema.sql`](db/schema.sql).
3. Informe a conexão com o banco pela variável de ambiente `VENDINHA_CONNECTION`.
   Se não for definida, usa `Host=localhost;Port=5432;Database=vendinha;Username=postgres;Password=postgres`.
   Exemplo:
   ```powershell
   setx VENDINHA_CONNECTION "Host=localhost;Port=5432;Database=vendinha;Username=postgres;Password=SUASENHA"
   ```
   (feche e abra o terminal ou o Visual Studio depois do `setx`)
4. Execute:
   ```powershell
   dotnet build
   dotnet run --project Vendinha.Desktop
   ```

Ou abra `Vendinha.slnx` no Visual Studio e execute o projeto `Vendinha.Desktop`.

## Como usar

- **Cadastrar cliente:** informe nome, CPF, data de nascimento e e-mail (opcional). Dados inválidos ou CPF repetido mostram uma mensagem com o motivo.
- **Listar clientes:** mostra nome, idade e total de dívidas em aberto, do que mais deve para o que menos deve. Use o campo de busca para filtrar por parte do nome e os botões **Anterior** e **Próxima** para navegar entre as páginas (10 clientes por página).
  - **Editar:** altera os dados do cliente selecionado.
  - **Excluir:** remove o cliente selecionado e as suas dívidas (pede confirmação).
  - **Dívidas:** abre as dívidas do cliente selecionado.
- **Dívidas (menu principal):** lista as dívidas de todos os clientes, com filtro por situação (todas, em aberto ou pagas). As pagas aparecem em verde.
- **Dívidas:** lista as dívidas do cliente com situação e datas. **Nova dívida** cadastra um valor (só é permitida se não houver outra em aberto) e **Marcar como paga** registra o pagamento da dívida selecionada.

## Modelo de dados

- `clientes`: `id`, `nome`, `cpf` (único, somente dígitos), `data_nascimento`, `email`.
- `dividas`: `id`, `cliente_id`, `valor`, `paga`, `data_criacao`, `data_pagamento`.

A regra de "uma dívida em aberto por cliente" é validada no serviço e também garantida no banco por um índice único parcial (`ux_dividas_uma_em_aberto`).

## Status

- [x] Estrutura da solução
- [x] Modelos com validações (incluindo CPF)
- [x] Banco de dados: contexto EF Core e script SQL
- [x] Serviço de clientes e dívidas
- [x] Tela de listagem de clientes (ordenação, busca e paginação)
- [x] Tela de cadastro e edição de clientes
- [x] Exclusão de clientes
- [x] Tela de dívidas e pagamento
- [x] Documentação

FOI UTILIZADO CLAUDE CODE PARA CORREÇÃO DE BUGS ONDE EU NÃO CONSEGUI ACHAR A SOLUÇÃO, AUXILIO EM PEQUENOS ERROS DE SINTAXE E AJUDA NA CRIAÇÃO DO README PARA FICAR O MAIS COMPLETO POSSIVEL.