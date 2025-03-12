using CadastrarUsuarios.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace CadastrarUsuarios.CRUD
{

    class Select : StringConexao
    {
        public static void ListarUsuarios()
        {

            Console.Clear();
            Console.WriteLine("=====================");
            Console.WriteLine("   Listar Usuários");
            Console.WriteLine("=====================");

            using (var conexao = new SqlConnection(STRING_CONEXAO))
            {
                try
                {
                    var usuarios = conexao.Query<Usuario>("SELECT [Id], [NomeCompleto], [Nascimento], [Ativo] FROM [Usuarios]");

                    Console.WriteLine("===========================");

                    if (usuarios.Count() > 0)
                    {
                        foreach (var usuario in usuarios)
                        {
                            Console.WriteLine($"Id: {usuario.Id}\nNome: {usuario.NomeCompleto}\nData Nascimento: {usuario.Nascimento.ToString("dd/MM/yyyy")}\nStatus: {usuario.Ativo}");
                            Console.WriteLine("===========================");
                        }

                        Console.WriteLine("\nPressione qualquer tecla para continuar!");
                        Console.ReadLine();
                        Menu.ExibirMenu();
                    }
                    else
                    {
                        Console.WriteLine("Não há nenhum usuário cadastrado no momento!");
                        Thread.Sleep(2000);
                        Menu.ExibirMenu();

                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine($"Não foi possível se conectar ao banco de dados\nCódigo de Erro {e.Message}");
                    Thread.Sleep(1500);
                    Menu.ExibirMenu();
                }
            }

        }
    }

}