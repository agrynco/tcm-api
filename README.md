# TCM API

**Train Component Management API** — enterprise-level solution for managing railway components and their relationships.

This project demonstrates a clean and scalable .NET backend architecture with strong principles of modularity, maintainability, and testability.

## 📖 Introduction

- [Requirements Document](https://docs.google.com/document/d/1EuYAo8UXv4JQIpaK34dFbNe_RgtjSSzSJ4dgKAL-bs4/edit?pli=1)
- [Issues Tracking](https://github.com/users/agrynco/projects/6)
- [Source Code Repository](https://github.com/agrynco/tcm-api)

## 🛠️ Tech Stack

- **.NET 8**, ASP.NET Core Web API
- **Entity Framework Core** (Code First Migrations)
- **Clean Architecture** (Domain / Application / Infrastructure / API layers)
- **Docker** (development & production-ready configurations)
- **SlimMessageBus** for internal request dispatching
- **Serilog** for structured logging
- **Swagger/OpenAPI** for API documentation
- **GitHub Actions** for CI/CD automation

## 📦 Solution Structure

- `Domain/` — Core business models (`TrainComponent`, `TrainComponentContext`, `TrainComponentRelation`)
- `Services/` — Application-level services (handling requests and business logic)
- `DAL.Abstract/` — Persistence abstractions (Repository Interfaces)
- `DAL.EF/` — Entity Framework Core implementations and migrations
- `Web.API/` — API layer with controllers, Serilog, SlimMessageBus and Swagger integration
- `Common/` — Utilities for console applications, configuration management, and common helpers
- `DI/` — Dependency Injection setup

## 🚀 Main Features

- Fully dockerized setup for local and production environments
- Configurable via environment-specific `appsettings.json`
- Structured and centralized error handling
- Easy extension for additional services and controllers
- Automated database migrations tool (`DAL.EF.Migrator.Console`)

## 🧪 Development

To start the API locally:

```bash
docker-compose -f docker/development/docker-compose.yml up --build
```

Stop the services with `Ctrl+C` or by running:

```bash
docker-compose -f docker/development/docker-compose.yml down
```
