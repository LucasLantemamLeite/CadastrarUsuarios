**Cadastro de Usuário - Console App**
Descrição
Aplicativo de console simples para gerenciar o cadastro de usuários, utilizando .NET Core e Dapper para interação com o banco de dados **SQL Server** e simulando com **docker**.

Funcionalidades: 
**Cadastrar novo usuário 📝:** Adiciona um novo usuário com nome e data de nascimento.
**Deletar usuários existente ❌:** Exclui um usuário pelo ID.
**Listar todos os usuários 👥:** Exibe todos os usuários cadastrados.
**Alterar dados existentes:** Alterar um campo por um Id.
**Sair 🚪:** Encerra o programa.

**Tecnologias:**
- .NET Core
- Dapper (Micro ORM)
- SQL Server

Instalação: 
Clone o repositório e acesse a pasta do projeto.
Instale o pacote **Dapper** e o **ADO.NET** utilizando o comando dotnet add package Dapper e dotnet add package System.Data.SqlClient.
Configure a string de conexão no arquivo "CRUD/Conexao" para o seu banco de dados.

Crie a tabela de usuários no banco de dados com o seguinte comando SQL:
**CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(100) NOT NULL,
    BirthDate DATE NOT NULL
);**

Execute a aplicação com o comando dotnet run.
