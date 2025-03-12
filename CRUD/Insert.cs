using System.Globalization;
using CadastrarUsuarios.Models;
using Dapper;
using Microsoft.Data.SqlClient;
namespace CadastrarUsuarios.CRUD
{
    class Insert : StringConexao
    {
        public static void AdicionarUsuario()
        {
            Console.Clear();
            Console.WriteLine("==============================");
            Console.WriteLine("    Adicionar Novo Usuário");
            Console.WriteLine("==============================");
            Console.WriteLine("Digite o nome do novo usuário");
            var nome = Console.ReadLine();

            while (string.IsNullOrEmpty(nome))
            {
                Console.WriteLine("Nome não pode estar em branco, por favor preencha-o:");
                nome = Console.ReadLine();
            }

            Console.WriteLine("Digite a data de nascimento: ");
            var input = Console.ReadLine();
            DateTime dataNascimento;

            while (!DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataNascimento))
            {
                Console.WriteLine("Data no formato incorreto, digite novamente: [dd/MM/yyyy] ");
                input = Console.ReadLine();
            }

            var usuario = new Usuario(nome, dataNascimento);
            using (var conexao = new SqlConnection(STRING_CONEXAO))
            {
                var insertSQL = @"INSERT INTO [Usuarios] ([NomeCompleto], [Nascimento])
                VALUES (@NomeCompleto, @Nascimento)";

                try
                {
                    var linhas = conexao.Execute(insertSQL, usuario);
                    Console.WriteLine($"'{nome}' Adicionado com sucesso!");
                    Thread.Sleep(1000);
                    Menu.ExibirMenu();
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Falha ao inserir dados\nCódigo de erro: {e.Message}");
                    Console.WriteLine("\nPrecione qualquer tecla para voltar");
                    Console.ReadLine();
                    Menu.ExibirMenu();
                }
            }
        }
    }
}