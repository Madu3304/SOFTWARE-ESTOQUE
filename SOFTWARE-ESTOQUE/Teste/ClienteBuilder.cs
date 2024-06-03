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
    public class ClienteBuilder
    {
        private int _codigo = 1;
        private string _nome = "Roronoa Zoro";
        private string _endereco = "Rua joão sem fim";
        private string _telefone = "3426-3698";
        private string _cpf = "123.456.789-02";
        private string _email = "zoro@gmail.com";
        

        public static ClienteBuilder Novo()
        {
            return new ClienteBuilder();
        }


        public Cliente Criar()
        {
            return new Cliente(_codigo, _nome, _endereco, _telefone,
                _cpf, _email);
        }


        public ClienteBuilder Popular()
        {
            Faker faker = new Faker();
            _codigo = faker.Random.Int(1, 100);
            _nome = faker.Person.FullName;
            _endereco = faker.Person.Address.Street;
            _telefone = faker.Person.Phone;
            _cpf = faker.Person.Cpf();
            _email = faker.Person.Email;
            return this;
        }


        public ClienteBuilder ComCodigo(int codigo)
        {
            _codigo = codigo;
            return this;
        }


        public ClienteBuilder ComNome(string nome)
        {
            _nome = nome;
            return this;
        }

        public ClienteBuilder ComEndereco(string endereco)
        {
            _endereco = endereco;
            return this;
        }


        public ClienteBuilder ComTelefone(string telefone)
        {
            _telefone = telefone;
            return this;
        }

        public ClienteBuilder ComCpf(string cpf)
        {
            _cpf = cpf;
            return this;
        }


        public ClienteBuilder ComEmail(string email)
        {
            _email = email;
            return this;
        }
        
    }
}
