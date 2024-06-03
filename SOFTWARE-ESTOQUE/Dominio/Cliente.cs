//LUIZ FELIPE S. MARCON
//MARIA EDUARDA NUNES DE SOUZA


namespace Dominio
{
    public class Cliente
    {
        // campos
        private int codigo;
        private string nome;
        private string endereco;
        private string telefone;
        private string cpf;
        private string email;
        private string rg;
        private int codigoErrado;

        // propriedades
        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Email { get => email; set => email = value; }
        public string Rg { get => rg; set => rg = value; }

        public Cliente(int codigo, string nome, string endereco, string telefone, string cpf, string email, string rg)
        {
           
            if (codigo < 1) throw new ArgumentException("Código inválido");
            if (string.IsNullOrEmpty(nome)) throw new ArgumentException("Nome inválido");
            if (string.IsNullOrEmpty(endereco)) throw new ArgumentException("Endereço inválido");
            if (string.IsNullOrEmpty(telefone)) throw new ArgumentException("Telefone inválido");
            if (string.IsNullOrEmpty(cpf) || !CPFcorreto(cpf)) throw new ArgumentException("CPF inválido");
            if (string.IsNullOrEmpty(email)) throw new ArgumentException("Email inválido");


            this.Codigo = codigo;
            this.Nome = nome;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Cpf = cpf;
            this.Email = email;
            this.Rg = rg;

        }

        public Cliente(int codigo, string nome, string endereco, string telefone, string cpf, string email)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.endereco = endereco;
            this.telefone = telefone;
            this.cpf = cpf;
            this.email = email;
        }

        public Cliente(int codigoErrado, string nome, string endereco, string telefone)
        {
            this.codigoErrado = codigoErrado;
            this.nome = nome;
            this.endereco = endereco;
            this.telefone = telefone;
        }

        public bool CPFcorreto(string cpf)
        {
            bool result = false;

            //
            // algum codigo
            //
            if (cpf == "123.456.789-00") result = true;



            return result;
        }
    }
}