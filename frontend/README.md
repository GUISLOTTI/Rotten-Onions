# frontend — Angular SPA

O app Angular que **renderiza tudo**. O backend só entrega JSON; quem monta a tela é aqui.

## Criar (Sprint 1)
```powershell
cd C:\RottenOnions\frontend
npm install -g @angular/cli          # uma vez só (ou use npx)
ng new rotten-onions-web --routing --style=scss --ssr=false
```
Rodar: `cd rotten-onions-web` → `ng serve` → `http://localhost:4200`.

## Estrutura sugerida (dentro de rotten-onions-web/src/app)
- `core/` — services que falam com a API (`filme.service.ts`, `serie.service.ts`) usando `HttpClient`.
- `models/` — interfaces TypeScript espelhando os DTOs da API (`filme.model.ts`).
- `features/filmes/` — componentes de listagem/formulário/detalhe de filmes.
- `features/series/` — idem para séries.
- `shared/` — componentes reutilizáveis (o sininho 🔔 de notificações, etc.).

## Pontos de atenção
- **`environment.ts`** guarda a URL base da API (ex.: `http://localhost:5xxx/api`). Não hardcode espalhado.
- A primeira chamada vai **falhar por CORS** até você liberar `:4200` no `Program.cs` da API — é esperado.
- Um `model` TypeScript deve espelhar o **DTO** da API (não a entidade do EF).

> Detalhes de integração em [`docs/01-arquitetura.md`](../docs/01-arquitetura.md) e [`docs/03-convencoes.md`](../docs/03-convencoes.md).
