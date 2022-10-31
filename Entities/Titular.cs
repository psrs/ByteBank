using System.Text;

namespace ByteBank.Entities
{
    public class Titular
    {
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string Profissao { get; private set; }

        public Titular(string nome, string cpf, string profissao)
        {
            Nome = nome;
            Cpf = cpf;
            Profissao = profissao;
        }
    }
}