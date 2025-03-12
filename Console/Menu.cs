namespace CadastrarUsuarios
{
    class Menu
    {
        public static void ExibirMenu()
        {
            Console.Clear();
            Console.WriteLine("===============================================");
            Console.WriteLine("        Gerenciamento de Usuários - CRUD");
            Console.WriteLine("===============================================");
            Console.WriteLine("\nEscolha uma das opções abaixo:\n1 - Cadastrar novo usuário\n2 - Deletar usuário existente\n3 - Listar todos os usuários\n4 - Sair");
        }
    }
}