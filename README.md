# FinanceFlow

A personal finance dashboard portfolio project built with **ASP.NET Core MVC (.NET 10)**.

## Current status

**Dashboard UI MVP:** responsive layout, fictional balance/income/expense cards, recent transactions and sample budget progress. No database, authentication or transaction persistence is implemented yet.

## Run locally

Requires the .NET 10 SDK.

```bash
dotnet run --project FinanceFlow.Web
```

Open the local URL shown in Terminal.

## Planned work

- EF Core persistence and data models
- ASP.NET Core Identity authentication
- Transaction and budget management
- Live dashboard calculations and charts
- Automated tests, CI/CD and Azure deployment

**Security:** Never commit credentials or actual financial data.
