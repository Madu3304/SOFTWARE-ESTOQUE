using Bogus;
using Bogus.Extensions.Brazil;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class FornecedorBuilder
    {
        private string _nome_empresa = "Restaurante do Sanji";
        private string _endereco = "Rua jardim da luz";
        private string _telefone = "5589985623";
        private string _email = "sanji20@gmail.com";
        private string _pagamento = "Pagamento com cartao de crédito";
        private int _codigo = 369;

        public static FornecedorBuilder Novo()
        {
            return new FornecedorBuilder();
        }

        public Fornecedor Criar()
        {
            return new Fornecedor(_nome_empresa, _endereco, _telefone, _email, _pagamento, _codigo);
        }

        public FornecedorBuilder Popular()
        {
            Faker faker = new Faker();
            _codigo = faker.Random.Int(1, 100);
            _nome_empresa = faker.Person.FullName;
            _endereco = faker.Person.Address.Street;
            _telefone = faker.Person.Phone;
            _email = faker.Person.Email;
            _pagamento = faker.Random.String();
            return this;
        }

        public FornecedorBuilder ComNome_empresa(string nome_empresa)
        {
            _nome_empresa = nome_empresa;
            return this;
        }


        public FornecedorBuilder ComEndereco(string endereco)
        {
            _endereco = endereco;
            return this;
        }

        public FornecedorBuilder ComTelefone(string telefone)
        {
            _telefone = telefone;
            return this;
        }

        public FornecedorBuilder ComEmail(string email)
        {
            _email = email;
            return this;
        }

        public FornecedorBuilder ComPagamento(string pagamento)
        {
            _pagamento = pagamento;
            return this;
        }


        public FornecedorBuilder ComCodigo(int Codigo)
        {
            _codigo = Codigo;
            return this;
        }
    }
}
