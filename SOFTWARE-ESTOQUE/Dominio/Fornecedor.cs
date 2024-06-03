//LUIZ FELIPE S. MARCON
//MARIA EDUARDA NUNES DE SOUZA

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Fornecedor
    {
        private int codigoErrado;

        //vou usar
        private string nome_empresa;
        private string endereco;
        private string telefone;
        private string email;
        private string pagamento;
        private int codigo;


        // propriedades
        public int Codigo { get => codigo; set => codigo = value; }
        public string Pagamento { get => pagamento; set => pagamento = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Nome_empresa { get => nome_empresa; set => nome_empresa = value; }

        public Fornecedor(int Codigo, string Pagamento, string Email, string Teleone, string Endereco)
        {
            if (codigo < 1) throw new ArgumentException("Código inválido");
            if (string.IsNullOrEmpty(nome_empresa)) throw new ArgumentException("Nome de empresa inválido");
            if (string.IsNullOrEmpty(endereco)) throw new ArgumentException("Endereço inválido");
            if (string.IsNullOrEmpty(telefone)) throw new ArgumentException("Telefone inválido");
            if (string.IsNullOrEmpty(email)) throw new ArgumentException("Email inválido");
            if (string.IsNullOrEmpty(pagamento)) throw new ArgumentException("Pagamento inválido");

            this.Codigo = codigo;
            this.Nome_empresa = nome_empresa;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Email = email;
            this.Pagamento = pagamento;

        }

        public Fornecedor(string nome_empresa, string endereco,  string Telefone, string email, string pagamento, int codigo)
        {
            this.codigo = codigo;
            this.nome_empresa = nome_empresa;
            this.endereco = endereco;
            this.telefone = telefone;
            this.email = email;
            this.pagamento = pagamento;

        }

        public Fornecedor(int codigoErrado, string nome_empresa, string endereco, string telefone, string email, string pagamento)
        {
            this.codigoErrado = codigoErrado;
            this.nome_empresa = nome_empresa;
            this.endereco = endereco;
            this.telefone = telefone;
        }


    }
}
