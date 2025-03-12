namespace CadastrarUsuarios.CRUD
{
    abstract class StringConexao
    {
        protected const string STRING_CONEXAO = "Server=localhost, 1433; database = [Nome do Banco]; User Id = [Id do Banco]; Password = [Senha do Banco]; TrustServerCertificate=True";
    }
}