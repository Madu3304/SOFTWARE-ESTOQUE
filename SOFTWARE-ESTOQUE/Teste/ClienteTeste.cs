using Bogus;
using Bogus.Extensions.Brazil;
using Dominio;
using ExpectedObjects;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Xunit;

namespace Teste
{

    public class ClienteTeste
    {
        //criando os campos
        private int _codigo;
        private string _nome;
        private string _endereco;
        private string _telefone;
        private string _cpf;
        private string _email;

        //a seguir metodo construtor

        public ClienteTeste()
        {
            Faker faker = new Faker();
            this._codigo = faker.Random.Int();
            this._nome = faker.Person.FirstName;
            this._endereco = faker.Random.Words();
            this._telefone = faker.Phone.ToString();
            this._cpf = faker.Person.Cpf().ToString();
            this._email = faker.Person.Email.ToString();

        }

        [Fact]
        public void CriarObjetoCliente3()
        {
            // Arrange
            var clienteEsperado = new
            {
                Codigo = _codigo,
                Nome = _nome,
                Endereco = _endereco,
                Telefone = _telefone,
                Cpf = _cpf,
                Email = _email
            };

            // Act
            Cliente cli = new Cliente(
                    clienteEsperado.Codigo,
                    clienteEsperado.Nome,
                    clienteEsperado.Endereco,
                    clienteEsperado.Telefone,
                    clienteEsperado.Cpf,
                    clienteEsperado.Email

                    );

            // Assert
            clienteEsperado.ToExpectedObject().ShouldMatch(cli);

        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-234)]
        public void ClienteCodigoInvalido(int codigoErrado)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ClienteBuilder.Novo().ComCodigo(codigoErrado).Criar()
                );
            Assert.Throws<ArgumentException>(
              () => new Cliente(codigoErrado, _nome, _endereco, _telefone)
           );

            var mensagem =
            Assert.Throws<ArgumentException>(
               () => new Cliente(codigoErrado, _nome, _endereco, _telefone, _cpf, _email)
            ).Message;
            Assert.Equal("Código inválido", mensagem);

        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void ClienteNomeInvalido(string nomeErrado)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ClienteBuilder.Novo().ComNome(nomeErrado).Criar()
                );

            var mensagem =
                 Assert.Throws<ArgumentException>(
                   () => new Cliente(_codigo, nomeErrado, _endereco, _telefone, _cpf, _email)
                    ).Message;
            Assert.Equal("Nome inválido", mensagem);
        }


        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void ClienteEnderecoInvalido(string enderecoErrado)
        {
            Assert.Throws<ArgumentException>(
                () => ClienteBuilder.Novo().ComEndereco(enderecoErrado).Criar());


            var mensagem =
                         Assert.Throws<ArgumentException>(
                           () => new Cliente(_codigo, _nome, enderecoErrado, _telefone, _cpf, _email)
                            ).Message;
            Assert.Equal("Endereco inválido", mensagem);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("1122-3344")]
        public void ClientetelefoneInvalido(string TelefoneErrado)
        {

            Assert.Throws<ArgumentException>(
               () =>
               ClienteBuilder.Novo().ComTelefone(TelefoneErrado).Criar()
            );

            var mensagem =
           Assert.Throws<ArgumentException>(
              () => new Cliente(_codigo, _nome, _endereco, TelefoneErrado, _cpf, _email)
           ).Message;
            Assert.Equal("Telefone inválido", mensagem);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("111.2222.333-44")]
        public void ClienteCpfInvalido(string cpfErrado)
        {

            var mensagem =
            Assert.Throws<ArgumentException>(
               () => new Cliente(_codigo, _nome, _endereco, _telefone, cpfErrado, _email)
            ).Message;
            Assert.Equal("CPF inválido", mensagem);

            Assert.Throws<ArgumentException>(
               () =>
               ClienteBuilder.Novo().ComCpf(cpfErrado).Criar()
            );
        }


        [Theory]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("zoro@gmail.com")]
        public void ClienteemailInvalido(string emailErrado)
        {

            var mensagem =
            Assert.Throws<ArgumentException>(
               () => new Cliente(_codigo, _nome, _endereco, _telefone, _cpf, emailErrado)
            ).Message;
            Assert.Equal("Email inválido", mensagem);

            Assert.Throws<ArgumentException>(
               () =>
               ClienteBuilder.Novo().ComEmail(emailErrado).Criar()
            );
        }

    }
}
