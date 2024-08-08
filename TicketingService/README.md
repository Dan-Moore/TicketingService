# TicketingService

REST api of a basic ticketing system.

## dotnet CLI

Creating a webapi and adding EF and Postgres packages.

```bash
dotnet new webapi -n ticket-service-csharp-api
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 8.0.4
```

Running app via CLI
```bash
dotnet build
```

Running app via podman or docker
```bash
podman compose up -d
# docker compose up -d
```