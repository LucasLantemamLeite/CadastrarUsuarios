using Dapper;
using Microsoft.Data.SqlClient;

namespace CadastrarUsuarios.CRUD
{
    class Delete : StringConexao
    {
        public static void DeletarUsuario()
        {
            Console.Clear();
            Console.WriteLine("===================");
            Console.WriteLine("  Deletar Usuário");
            Console.WriteLine("===================");
            Console.WriteLine("Digite o Id que deseja remover:  ");
            var id = Console.ReadLine();

            while (string.IsNullOrEmpty(id))
            {
                Console.WriteLine("O id não pode estar em branco, por favor preencha-o:  ");
            }

            try
            {
                using (var conexao = new SqlConnection(STRING_CONEXAO))
                {

                    var deleteSQL = @"DELETE FROM [Usuarios] 
                    WHERE [Id] = @Id";

                    var linhas = conexao.Execute(deleteSQL, new { Id = id });


                    if (linhas > 0)
                    {
                        Console.WriteLine($"{linhas} linha(s) deletadas");
                    }
                    else
                    {
                        Console.WriteLine("Não existe nenhum usuário com o Id mencionado");
                    }

                    Thread.Sleep(1500);
                    Menu.ExibirMenu();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Falha ao se conctar ao banco de dados\nCódigo de Erro: {e.Message}");
                Console.WriteLine("\nPressione qualquer tecla para continuar");
                Menu.ExibirMenu();
            }
        }
    }
}