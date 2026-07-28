# 🧅 Rotten Onions

> Catálogo pessoal de **filmes** e **séries** para rankear, comentar, marcar o que já viu / quer ver, e **ser notificado quando um filme que você quer ver estreia**.

Projeto de estudo com um objetivo claro: **tirar a cabeça do MVC legado e pensar como empresa moderna** — tudo separado em **API (só JSON)** + **SPA Angular** + **fila RabbitMQ** + **Worker assíncrono** + **testes xUnit** + **Docker**.

O domínio é simples de propósito. O valor não está na regra de negócio ser complexa — está em você internalizar o **encanamento novo**.

---

## 🎯 O que este projeto te ensina (as "viradas de chave")

| Você vinha do MVC legado... | Aqui você aprende... |
|---|---|
| Servidor devolve HTML (Razor/View) | Backend **nunca** devolve HTML, só **JSON** |
| Status code você ignorava | `201 Created`, `204 No Content`, `404`, `409` são o **contrato** |
| Expunha a entidade direto na tela | **DTO ≠ entidade** — contrato de API é separado do domínio |
| Web.config + global.asax | `appsettings.json` + **Injeção de Dependência nativa** |
| Tudo síncrono na requisição | **Evento assíncrono** — nem toda tarefa acontece durante o HTTP |
| Testar? Talvez nunca | **xUnit** testando *regra de negócio*, não o banco |

---

## 🗂️ Estrutura do repositório

```
RottenOnions/
├── backend/
│   ├── RottenOnions.sln              (criado no Sprint 0)
│   ├── src/
│   │   ├── RottenOnions.Api/            → Web API: controllers, DTOs, Program.cs, DI
│   │   ├── RottenOnions.Domain/         → Entidades, enums e REGRAS de negócio (puro)
│   │   ├── RottenOnions.Application/    → Services / casos de uso + interfaces
│   │   ├── RottenOnions.Infrastructure/ → EF Core, DbContext, repositórios, RabbitMQ
│   │   ├── RottenOnions.Contracts/      → Contratos de eventos (compartilhados Api↔Worker)
│   │   └── RottenOnions.Worker/         → Worker Service: BackgroundService + consumidor
│   └── tests/
│       └── RottenOnions.UnitTests/     → xUnit + Moq
├── frontend/
│   └── rotten-onions-web/               → Angular SPA (criado no Sprint 1)
├── docs/                                → Arquitetura, convenções, decisões (ADRs), setup
├── docker-compose.yml                  → RabbitMQ (e SQL Server opcional)
├── .editorconfig / .gitignore / .env.example
└── README.md                           → você está aqui
```

> ⚠️ As pastas dos projetos `.csproj` estão **vazias de propósito**. Gerá-las é a **primeira tarefa** do cronograma (você aprende a "fiação" da solution na mão). Cada pasta tem um `README.md` dizendo o que mora ali e o comando que a preenche.

---

## 🚀 Por onde começar

1. Leia [`docs/00-visao-geral.md`](docs/00-visao-geral.md) — o mapa geral.
2. Leia [`docs/01-arquitetura.md`](docs/01-arquitetura.md) — as camadas e por que existem.
3. Siga [`docs/02-setup-ambiente.md`](docs/02-setup-ambiente.md) — comandos exatos para montar tudo.
4. Trabalhe pelo **cronograma** (o artefato/quadro de tarefas). Uma task por vez, em ordem.
5. Antes de cada entrega, confira a **Definition of Done** em [`docs/05-como-trabalhar.md`](docs/05-como-trabalhar.md).

## 📚 Documentação

| Doc | Para quê |
|---|---|
| [`00-visao-geral.md`](docs/00-visao-geral.md) | Visão do produto e das 3 fases |
| [`01-arquitetura.md`](docs/01-arquitetura.md) | Camadas, grafo de dependências, o "porquê" |
| [`02-setup-ambiente.md`](docs/02-setup-ambiente.md) | Todos os comandos para criar a solution e o Angular |
| [`03-convencoes.md`](docs/03-convencoes.md) | Nomes, DTOs, status codes, commits, branches |
| [`04-modelo-de-dominio.md`](docs/04-modelo-de-dominio.md) | Entidades, enums, relacionamentos e regras |
| [`05-como-trabalhar.md`](docs/05-como-trabalhar.md) | Fluxo de trabalho, Definition of Done, como usar IA |
| [`adr/`](docs/adr/) | Registros das decisões de arquitetura (ótimo papo de entrevista) |

## 🧰 Stack

- **.NET 8** (LTS) — ASP.NET Core Web API + Worker Service
- **Entity Framework Core** + **SQL Server 2022** (você já tem local)
- **RabbitMQ** (via Docker) para mensageria
- **Angular** (SPA) consumindo a API via `HttpClient`
- **xUnit + Moq** para testes de unidade
- **TMDB API** (externa, gratuita) para puxar data de estreia dos filmes
