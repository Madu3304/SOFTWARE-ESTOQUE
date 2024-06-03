using Bogus;
using Bogus.Extensions.Brazil;
using Dominio;
using ExpectedObjects;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Xunit;


namespace Teste
{
    public class ProdutoTeste
    {
        //criando os campos
        private string _descricao;
        private int _codigo_barras;
        private string _preco_compra;
        private string _preco_venda;
        private int _codigo;
        private string _categoria_pro;
        private string _fornecedor_pro;
        private int _quanti_estoq;
        private string _valor_custo;

        // a seguir metodo contrutor luiz
        public ProdutoTeste()
        {
            Faker faker = new Faker();
            this._descricao = faker.Random.ToString();
            this._codigo_barras = faker.Random.Int();
            this._preco_compra = faker.Random.ToString();
            this._preco_venda = faker.Random.ToString();
            this._codigo = faker.Random.Int();
            this._categoria_pro = faker.Random.ToString();
            this._fornecedor_pro = faker.Random.ToString();
            this._quanti_estoq = faker.Random.Int();
            this._valor_custo = faker.Random.ToString();

        }

        //aqui vamos começar os testes: 

        [Fact]
        public void CriarObjetoProduto3()
        {
            // Arrange
            var produtoEsperado = new
            {
                Descricao = _descricao,
                Codigo_Barras = _codigo_barras,
                Preco_compra = _preco_compra,
                Preco_venda = _preco_venda,
                CodigoErrado = _codigo,
                Categoria_pro = _categoria_pro,
                Fornecedor_pro = _fornecedor_pro,
                Quanti_estoq = _quanti_estoq,
                Valor_custo = _valor_custo,

            };

            // Act
            Produto pro = new Produto(
                    produtoEsperado.Descricao,
                    produtoEsperado.Codigo_Barras,
                    produtoEsperado.Preco_compra,
                    produtoEsperado.Preco_venda,
                    produtoEsperado.CodigoErrado,
                    produtoEsperado.Categoria_pro,
                    produtoEsperado.Fornecedor_pro,
                    produtoEsperado.Quanti_estoq,
                    produtoEsperado.Valor_custo

                    );

            // Assert
            produtoEsperado.ToExpectedObject().ShouldMatch(pro);

        }



        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-234)]
        public void ProdutoCodigoInvalido(int codigoErrado)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ProdutoBuilder.Novo().ComCodigo(codigoErrado).Criar()
              );

            var mensagem =
            Assert.Throws<ArgumentException>(
               () => new Produto(_descricao, _codigo_barras, _preco_compra, _preco_venda, codigoErrado, _categoria_pro, _fornecedor_pro, _quanti_estoq, _valor_custo)
            ).Message;
            Assert.Equal("Código inválido", mensagem);

        }


        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void ProdutoDescricaoInvalido(string descricaoErrado)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ProdutoBuilder.Novo().ComDescricao(descricaoErrado).Criar()
              );

            var mensagem =
            Assert.Throws<ArgumentException>(
               () => new Produto(descricaoErrado, _codigo_barras, _preco_compra, _preco_venda, _codigo, _categoria_pro, _fornecedor_pro, _quanti_estoq, _valor_custo)
            ).Message;
            Assert.Equal("Descrção inválida", mensagem);

        }


        [Theory]
        [InlineData(0)]
        [InlineData(null)]
        public void ProdutoCodigo_barrasInvalido(int codigo_barrasErrado)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ProdutoBuilder.Novo().ComCodigo_Barras(codigo_barrasErrado).Criar()
              );

            var mensagem =
            Assert.Throws<ArgumentException>(
               () => new Produto(_descricao, codigo_barrasErrado, _preco_compra, _preco_venda, _codigo, _categoria_pro, _fornecedor_pro, _quanti_estoq, _valor_custo)
            ).Message;
            Assert.Equal("Codigo de Barras é inválida", mensagem);

        }


        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void ProdutoPreco_compraInvalido(string preco_compraErrado)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ProdutoBuilder.Novo().ComPreco_compra(preco_compraErrado).Criar()
              );

            var mensagem =
            Assert.Throws<ArgumentException>(
               () => new Produto(_descricao, _codigo_barras, preco_compraErrado, _preco_venda, _codigo, _categoria_pro, _fornecedor_pro, _quanti_estoq, _valor_custo)
            ).Message;
            Assert.Equal("Preço da compra é inválida", mensagem);

        }


        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void ProdutoPreco_vendaInvalido(string preco_vendaErrado)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ProdutoBuilder.Novo().ComPreco_venda(preco_vendaErrado).Criar()
              );

            var mensagem =
            Assert.Throws<ArgumentException>(
               () => new Produto(_descricao, _codigo_barras, _preco_compra, preco_vendaErrado, _codigo, _categoria_pro, _fornecedor_pro, _quanti_estoq, _valor_custo)
            ).Message;
            Assert.Equal("Preço da Venda é inválida", mensagem);

        }



        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void ProdutoCategoria_proInvalido(string categoria_proErrado)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ProdutoBuilder.Novo().ComCategoria_pro(categoria_proErrado).Criar()
                );

            var mensagem =
            Assert.Throws<ArgumentException>(
               () => new Produto(_descricao, _codigo_barras, _preco_compra, _preco_venda, _codigo, categoria_proErrado, _fornecedor_pro, _quanti_estoq, _valor_custo)
            ).Message;
            Assert.Equal("Categoria do Produto é inválida", mensagem);

        }


        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void ProdutoFornecedor_proInvalido(string fornecedor_proErrado)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ProdutoBuilder.Novo().ComFornecedor_pro(fornecedor_proErrado).Criar()
                );

            var mensagem =
            Assert.Throws<ArgumentException>(
               () => new Produto(_descricao, _codigo_barras, _preco_compra, _preco_venda, _codigo, _categoria_pro, fornecedor_proErrado, _quanti_estoq, _valor_custo)
            ).Message;
            Assert.Equal("Fornecedor do produto é inválida", mensagem);

        }


        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-234)]
        [InlineData(null)]
        public void ProdutoQuanti_proInvalido(int quanti_proErrado)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ProdutoBuilder.Novo().ComQuanti_estoq(quanti_proErrado).Criar()
              );

            var mensagem =
            Assert.Throws<ArgumentException>(
               () => new Produto(_descricao, _codigo_barras, _preco_compra, _preco_venda, _codigo, _categoria_pro, _fornecedor_pro, quanti_proErrado, _valor_custo)
            ).Message;
            Assert.Equal("Quantidade do protudo inválido", mensagem);

        }


        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void ProdutoValor_custoInvalido(string valor_custoErrado)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ProdutoBuilder.Novo().ComValor_custo(valor_custoErrado).Criar()
              );

            var mensagem =
            Assert.Throws<ArgumentException>(
               () => new Produto(_descricao, _codigo_barras, _preco_compra, _preco_venda, _codigo, _categoria_pro, _fornecedor_pro, _quanti_estoq, valor_custoErrado)
            ).Message;
            Assert.Equal("Fornecedor do produto é inválida", mensagem);

        }
    }
}
