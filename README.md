# CashFlow

**CashFlow** é um projeto em desenvolvimento focado no controle de despesas, aplicando conceitos de DDD (Domain Driven Design), validação, tratamento de erros, localização, testes, banco de dados, injeção de dependência, geração de relatórios e boas práticas de arquitetura .NET.

## 🚧 Status do Projeto

> **Em desenvolvimento**  
> Funcionalidades estão sendo implementadas e aprimoradas.

---

## 📚 Funcionalidades e Roadmap

- **DDD e Estruturação**
  - Organização do projeto por camadas (API, Application, Domain, Infrastructure)
  - Separação de responsabilidades e aplicação de boas práticas

- **API de Despesas**
  - Endpoint para cadastro de despesas
  - Validação de dados com FluentValidation
  - Tratamento de erros e respostas amigáveis
  - Filtro global de exceções

- **Localização**
  - Mensagens localizadas via arquivos de resource
  - Middleware para seleção de idioma via header `Accept-Language`

- **Testes**
  - Planejamento e implementação de testes unitários com xUnit, Bogus e FluentAssertions

- **Banco de Dados**
  - Estruturação inicial para uso de MySQL e Entity Framework
  - Planejamento para repositórios, contextos e injeção de dependência

- **Relatórios**
  - Planejamento para geração de relatórios em Excel e PDF

---

## 🛠️ Tecnologias Utilizadas

- .NET 9 / C# 13
- ASP.NET Core Web API
- FluentValidation
- Entity Framework Core (planejado)
- MySQL (planejado)
- xUnit, Bogus, FluentAssertions (planejado para testes)
- AutoMapper (planejado)
- Localização com arquivos `.resx`

---

## 📦 Estrutura do Projeto
src/
 ├── CashFlow.API/           # Camada de apresentação (controllers, middlewares)
 ├── CashFlow.Application/   # Casos de uso, validações, DTOs
 ├── CashFlow.Domain/        # Entidades e regras de negócio
 └── CashFlow.Infrastructure/# Persistência e integrações externas

---

## 🚀 Como executar

> **Pré-requisitos:**  
> - .NET 9 SDK  
> - Visual Studio 2022 ou superior

1. Clone o repositório
2. Abra a solução no Visual Studio
3. Execute o projeto `CashFlow.API`

---

## 📈 Próximos Passos

- Finalizar middleware de localização e testes
- Implementar testes unitários
- Estruturar banco de dados e repositórios
- Implementar geração de relatórios (Excel/PDF)
- Aplicar princípios SOLID e refinar arquitetura

---

## 🤝 Contribuição

Este projeto é de estudo e evolução contínua. Sugestões e colaborações são bem-vindas!

