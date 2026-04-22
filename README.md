# 💰 FinanceSystem

Sistema de gestão financeira pessoal desenvolvido em **.NET 10**, utilizando uma arquitetura escalável conectada à nuvem (**AWS RDS**).

## 🚀 Sobre o Projeto
O **FinanceSystem** é uma API desenhada para gerenciar receitas e despesas. O foco do projeto é aplicar conceitos de infraestrutura Cloud, persistência de dados com Entity Framework Core e segurança de dados através de identificadores globais.

## 🛠️ Tecnologias e Infraestrutura
* **Backend:** ASP.NET Core (Web API) em .NET 10.
* **Banco de Dados:** SQL Server hospedado no **AWS RDS** (instância em São Paulo).
* **ORM:** Entity Framework Core.
* **Ferramentas:** VS Code, Git, Terminal (Mac).

## 📂 Estrutura do Repositório
Conforme a organização atual do projeto:
* `Finance.Api/`: Projeto principal da API com Controllers, Models e Contexto de dados.
* `Finance.Worker/`: Serviço de processamento em segundo plano.
* `FinanceSystem.sln`: Arquivo de solução que agrupa os projetos.

## 📊 Progresso do Projeto

### **O que já foi feito** ✅
- [x] Configuração da instância **SQL Server na AWS (RDS)**.
- [x] Liberação de segurança (Inbound Rules) para acesso remoto ao banco.
- [x] Criação do banco de dados `FinanceDB` e tabela `Transactions`.
- [x] Implementação do suporte a **multi-usuário** com a coluna `UserId`.
- [x] Configuração da **Connection String** e injeção de dependência no `Program.cs`.
- [x] Mapeamento das classes C# (`Models`) sincronizadas com o banco.

### **Próximos Passos** ⏳
- [ ] Criar o `TransactionsController` para operações de CRUD (Create, Read, Update, Delete).
- [ ] Implementar a lógica de busca de dados filtrada por `UserId`.
- [ ] Adicionar autenticação (JWT) para proteger os endpoints.
- [ ] Desenvolver lógica de saldo e resumos mensais no `Finance.Worker`.

## ⚙️ Como Executar
1. Certifique-se de ter o **.NET 10 SDK** instalado.
2. Navegue até a pasta da API:
   ```bash
   cd Finance.Api