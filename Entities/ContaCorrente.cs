using System.Globalization;
using System.Text;

namespace ByteBank.Entities
{
    public class ContaCorrente
    {
        public int NumeroAgencia { get; private set; }
        public string Conta { get; private set; }
        public Titular Titular { get; private set; }
        public double Saldo { get; private set; }
        public static int TotalDeContasCriadas { get; private set; }

        public ContaCorrente(int numeroAgencia, string conta, Titular titular)
        {
            NumeroAgencia = numeroAgencia;
            Conta = conta;
            Titular = titular;

            TotalDeContasCriadas++;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
        }

        public bool Sacar(double valor)
        {
            if (valor <= 0)
            {
                return false;
            }

            if (valor < Saldo)
            {
                Saldo -= valor;
                return true;
            }

            return false;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (contaDestino == null)
            {
                return false;
            }

            if (this.Sacar(valor))
            {
                contaDestino.Depositar(valor);
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine("***************************************");
            sb.AppendLine($"Agência: {NumeroAgencia}");
            sb.AppendLine($"Conta: {Conta}");
            sb.AppendLine($"Titular: {Titular.Nome}");
            sb.AppendLine($"Cpf: {Titular.Cpf}");
            sb.AppendLine($"Profissão: {Titular.Profissao}");
            sb.AppendLine($"Saldo: R$ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
            sb.AppendLine("***************************************");
            return sb.ToString();
        }
    }
}