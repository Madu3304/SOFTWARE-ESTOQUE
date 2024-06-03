using Bogus;
using Bogus.Extensions.Brazil;
using Dominio;
using ExpectedObjects;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Xunit;


namespace Teste
{
    public class FornecedorTeste
    {

        private string _nome_empresa;
        private string _endereco;
        private string _telefone;
        private string _email;
        private string _pagamento;
        private int _codigo;

        // a seguir metodo construtor duda: 

        public FornecedorTeste()
        {
            Faker faker = new Faker();
            this._nome_empresa = faker.Person.FirstName;
            this._endereco = faker.Random.Words();
            this._telefone = faker.Phone.ToString();
            this._email = faker.Person.Email.ToString();
            this._pagamento = faker.Random.ToString();
            this._codigo = faker.Random.Int();
        }

        [Fact]
        public void CriarObjetoFornecedor()
        {
            // Arrange
            var fornecedorEsperado = new
            {
                
                Nome_empresa = _nome_empresa,
                Endereco = _endereco,
                Telefone = _telefone,
                Email = _email,
                Pagamento = _pagamento,
                Codigo = _codigo,
            };

            // Act
             Fornecedor forne = new(
                    fornecedorEsperado.Codigo,
                    fornecedorEsperado.Nome_empresa,
                    fornecedorEsperado.Endereco,
                    fornecedorEsperado.Telefone,
                    fornecedorEsperado.Email,
                    fornecedorEsperado.Pagamento
                    );

            // Assert
            fornecedorEsperado.ToExpectedObject().ShouldMatch(forne);

        }


        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void FornecedorNomeInvalido(string nome_empresaErrado)
        {
            Assert.Throws<ArgumentException>(
                () =>
                FornecedorBuilder.Novo().ComNome_empresa(nome_empresaErrado).Criar()
                );

            var mensagem =
                 Assert.Throws<ArgumentException>(
                   () => new Fornecedor(_codigo, nome_empresaErrado, _endereco, _telefone, _email, _pagamento)
                    ).Message;
            Assert.Equal("Nome de Empresa inválido", mensagem);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void FornecedorEnderecoInvalido(string enderecoErrado)
        {
            Assert.Throws<ArgumentException>(
                () => FornecedorBuilder.Novo().ComEndereco(enderecoErrado).Criar());


            var mensagem =
                         Assert.Throws<ArgumentException>(
                           () => new Fornecedor(_codigo, _nome_empresa, enderecoErrado, _telefone, _email, _pagamento)
                            ).Message;
            Assert.Equal("Endereco inválido", mensagem);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("1122-3344")]
        public void FornecedortelefoneInvalido(string TelefoneErrado)
        {

            Assert.Throws<ArgumentException>(
               () =>
               FornecedorBuilder.Novo().ComTelefone(TelefoneErrado).Criar()
            );

            var mensagem =
           Assert.Throws<ArgumentException>(
              () => new Fornecedor(_codigo, _nome_empresa, _endereco, TelefoneErrado, _email, _pagamento)
           ).Message;
            Assert.Equal("Telefone inválido", mensagem);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("zoro@gmail.com")]
        public void FornecedorInvalido(string emailErrado)
        {

            var mensagem =
            Assert.Throws<ArgumentException>(
               () => new Fornecedor(_codigo, _nome_empresa, _endereco, _telefone, emailErrado, _pagamento)
            ).Message;
            Assert.Equal("Email inválido", mensagem);

            Assert.Throws<ArgumentException>(
               () =>
               FornecedorBuilder.Novo().ComEmail(emailErrado).Criar()
            );
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void fornecedorpagamentoInvalido(string pagamentoErrado)
        {
            
            var mensagem =
            Assert.Throws<ArgumentException>(
               () => new Fornecedor(_codigo, _nome_empresa, _endereco, _telefone, _email, pagamentoErrado)
            ).Message;
            Assert.Equal("Pagamento inválido", mensagem);

            Assert.Throws<ArgumentException>(
               () =>
               FornecedorBuilder.Novo().ComPagamento(pagamentoErrado).Criar()
            );
        }


































    }
}
