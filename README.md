# Vendinha

Sistema simples para controle das contas (dívidas "penduradas") dos clientes de uma vendinha.
Aplicação desktop em **C# / .NET 10** com **Windows Forms**, **Entity Framework Core** e **PostgreSQL**.

> Projeto em desenvolvimento. A seção [Status](#status) mostra o que já foi feito.

## Funcionalidades (requisitos)

- CRUD de clientes: nome completo*, CPF* (válido e único), data de nascimento*, e-mail (validado se informado). Idade calculada.
- Dívidas por cliente: valor, situação (paga ou não), data de criação e data de pagamento.
- Regra: um cliente só pode ter **uma dívida em aberto**.
- Listagem de clientes ordenada do que mais deve para o que menos deve, paginada de 10 em 10, com busca por nome (texto contido), mostrando idade e total de dívidas.
- Listagem de dívidas por cliente com marcação de pagamento.

## Estrutura

```
Vendinha/            Biblioteca com a lógica do sistema
  Models/            Cliente e Divida (com validações por atributos)
  Validacoes/        Validação de CPF
  Contexts/          VendinhaDbContext (Entity Framework Core)
  Services/          ClienteService (regras de negócio e acesso ao banco)
Vendinha.Desktop/    Interface Windows Forms
db/schema.sql        Script de criação do banco (PostgreSQL)
```

## Como executar

Pré-requisitos: Windows, [.NET SDK 10](https://dotnet.microsoft.com/download) e PostgreSQL.

1. Crie o banco `vendinha` e execute o script [`db/schema.sql`](db/schema.sql) (pelo DBeaver, por exemplo).
2. Informe a conexão com o banco pela variável de ambiente `VENDINHA_CONNECTION`.
   Se não for definida, usa `Host=localhost;Port=5432;Database=vendinha;Username=postgres;Password=postgres`.
3. Execute:

```powershell
dotnet build
dotnet run --project Vendinha.Desktop
```

Ou abra `Vendinha.slnx` no Visual Studio e execute o projeto `Vendinha.Desktop`.

## Status

- [x] Estrutura da solução
- [x] Modelos com validações (incluindo CPF)
- [x] Banco de dados: contexto EF Core e script SQL
- [x] Serviço de clientes e dívidas
- [ ] Tela de listagem de clientes (ordenação, busca e paginação)
- [ ] Tela de cadastro e edição de clientes
- [ ] Tela de dívidas e pagamento
- [ ] Documentação final
