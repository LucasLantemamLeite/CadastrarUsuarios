namespace CadastrarUsuarios
{
    class Selecionar
    {
        public static void EscolhaMenu()
        {
            Console.Clear();
            Menu.ExibirMenu();

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out var escolhaUsuario) && escolhaUsuario > 0 && escolhaUsuario <= 5)
                {
                    switch (escolhaUsuario)
                    {
                        case 1:
                            CadastrarUsuarios.CRUD.Insert.AdicionarUsuario();
                            break;

                        case 2:
                            CadastrarUsuarios.CRUD.Delete.DeletarUsuario();
                            break;

                        case 3:
                            CadastrarUsuarios.CRUD.Select.ListarUsuarios();
                            break;

                        case 5:
                            Console.WriteLine("Saindo...");
                            Thread.Sleep(500);
                            System.Environment.Exit(0);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Digite uma opção válida do Menu!");
                    Thread.Sleep(1000);
                    Menu.ExibirMenu();
                }
            }
        }
    }
}