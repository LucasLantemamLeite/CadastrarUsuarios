#nullable disable

namespace CadastrarUsuarios.Models
{
    class Usuario
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public DateTime Nascimento { get; set; }
        public bool Ativo { get; set; } = true;

        public Usuario() { }

        public Usuario(string nome_completo, DateTime data_nascimento)
        {
            NomeCompleto = nome_completo;

            Nascimento = data_nascimento;
        }
    }
}