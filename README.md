Cadastro de Usuário - Console App
Descrição
Aplicativo de console simples para gerenciar o cadastro de usuários, utilizando .NET Core e Dapper para interação com o banco de dados SQL Server e simulando com Docker.

Funcionalidades
Cadastrar novo usuário 📝: Adiciona um novo usuário com nome e data de nascimento.
Deletar usuário existente ❌: Exclui um usuário pelo ID.
Listar todos os usuários 👥: Exibe todos os usuários cadastrados.
Alterar dados existentes: Altera um campo de dados de um usuário por ID.
Sair 🚪: Encerra o programa.
Tecnologias
.NET Core
Dapper (Micro ORM)
SQL Server
Instalação
Clone o repositório e acesse a pasta do projeto.
Instale o pacote Dapper e o ADO.NET utilizando os seguintes comandos:
bash
Copiar
Editar
dotnet add package Dapper
dotnet add package System.Data.SqlClient
Configure a string de conexão no arquivo "CRUD/Conexao" para o seu banco de dados.
Crie a tabela de usuários no banco de dados com o seguinte comando SQL:
sql
Copiar
Editar
CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(100) NOT NULL,
    BirthDate DATE NOT NULL
);
Execute a aplicação com o comando:
bash
Copiar
Editar
dotnet run
