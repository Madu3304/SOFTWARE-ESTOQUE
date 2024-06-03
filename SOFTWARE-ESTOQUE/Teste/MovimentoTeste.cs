using Bogus;
using Dominio;
using ExpectedObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Teste
{
    public class MovimentoTeste
    {

        private string _entrada;
        private string _saida;
        private int _quantidade;
        private string _valor_compra;
        private string _data_entre;
        private string _forne;
        private int _nume_fatu;
        private string _descri_motivo;
        private int _identidade;
        private string _custo_pro;
        private int _codigo;


        public MovimentoTeste()
        {
            Faker faker = new Faker();
            _codigo = faker.Random.Int(1, 100);
            _entrada = faker.Random.String();
            _saida = faker.Random.String();
            _quantidade = faker.Random.Int(1, 100);
            _valor_compra = faker.Random.String();
            _data_entre = faker.Random.String();
            _forne = faker.Random.String();
            _nume_fatu = faker.Random.Int(1, 100);
            _descri_motivo = faker.Random.String();
            _identidade = faker.Random.Int(1, 100);
            _custo_pro = faker.Random.String();
            
        }


        [Fact]
        public void CriarObjetoCliente3()
        {
            // Arrange
            var movimentoEsperado = new
            {
                Entrada = _entrada,
                Saida = _saida,
                Quantidade = _quantidade,
                Valor_compra = _valor_compra,
                Data_entre = _data_entre,
                Forne = _forne,
                Nume_fatu = _nume_fatu,
                Descri_motivo = _descri_motivo,
                Identidade = _identidade,
                Custo_pro = _custo_pro,
                Codigo = _codigo,
        };

            // Act
            Movimento movi = new Movimento(
                    movimentoEsperado.Entrada,
                    movimentoEsperado.Saida,
                    movimentoEsperado.Quantidade,
                    movimentoEsperado.Valor_compra,
                    movimentoEsperado.Data_entre,
                    movimentoEsperado.Forne,
                    movimentoEsperado.Nume_fatu,
                    movimentoEsperado.Descri_motivo,
                    movimentoEsperado.Identidade,
                    movimentoEsperado.Custo_pro,
                    movimentoEsperado.Codigo
                    );

            // Assert
            movimentoEsperado.ToExpectedObject().ShouldMatch(movi);

        }


        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-234)]
        public void MovimentoCodigoInvalido(int codigoErrado)
        {
            Assert.Throws<ArgumentException>(
                () => 
                MovimentoBuilder.Novo().ComCodigo(codigoErrado).Criar()
                );

            var mensagem =
            Assert.Throws<ArgumentException>(
               () => new Movimento(_entrada, _saida, _quantidade, _valor_compra, _data_entre, _forne, _nume_fatu, _descri_motivo, _identidade, _custo_pro, codigoErrado)
            ).Message;
            Assert.Equal("Código inválido", mensagem);

        }


        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void MovimentoEntradaInvalido(string entradaErrado)
        {
            Assert.Throws<ArgumentException>(
                () =>
                MovimentoBuilder.Novo().ComEntrada(entradaErrado).Criar()
                );

            var mensagem =
           Assert.Throws<ArgumentException>(
              () => new Movimento(entradaErrado, _saida, _quantidade, _valor_compra, _data_entre, _forne, _nume_fatu, _descri_motivo, _identidade, _custo_pro, _codigo)
           ).Message;
            Assert.Equal("Entrada inválido", mensagem);

        }


        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void MovimentoSaiaInvalido(string saidaErrado)
        {
            Assert.Throws<ArgumentException>(
                () =>
                MovimentoBuilder.Novo().ComEntrada(saidaErrado).Criar()
                );

            var mensagem =
           Assert.Throws<ArgumentException>(
              () => new Movimento(_entrada, saidaErrado, _quantidade, _valor_compra, _data_entre, _forne, _nume_fatu, _descri_motivo, _identidade, _custo_pro, _codigo)
           ).Message;
            Assert.Equal("Saida inválido", mensagem);

        }


        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-234)]
        [InlineData(null)]
        public void MovimentoQuantidadeInvalido(int quantidadeErrado)
        {
            Assert.Throws<ArgumentException>(
                () =>
                MovimentoBuilder.Novo().ComQuantidade(quantidadeErrado).Criar()
                );

            var mensagem =
           Assert.Throws<ArgumentException>(
              () => new Movimento(_entrada, _saida, quantidadeErrado, _valor_compra, _data_entre, _forne, _nume_fatu, _descri_motivo, _identidade, _custo_pro, _codigo)
           ).Message;
            Assert.Equal("Quantidade inválido", mensagem);

        }


        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void MovimentoValor_compraInvalido(string valor_compraErrado)
        {
            Assert.Throws<ArgumentException>(
                () =>
                MovimentoBuilder.Novo().ComValor_compra(valor_compraErrado).Criar()
                );

            var mensagem =
           Assert.Throws<ArgumentException>(
              () => new Movimento(_entrada, _saida, _quantidade, valor_compraErrado, _data_entre, _forne, _nume_fatu, _descri_motivo, _identidade, _custo_pro, _codigo)
           ).Message;
            Assert.Equal("valor da compra inválido", mensagem);

        }


        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void MovimentoData_entreInvalido(string data_entreErrado)
        {
            Assert.Throws<ArgumentException>(
                () =>
                MovimentoBuilder.Novo().ComData_entre(data_entreErrado).Criar()
                );

            var mensagem =
           Assert.Throws<ArgumentException>(
              () => new Movimento(_entrada, _saida, _quantidade, _valor_compra, data_entreErrado, _forne, _nume_fatu, _descri_motivo, _identidade, _custo_pro, _codigo)
           ).Message;
            Assert.Equal("Data entrega inválido", mensagem);

        }


        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void MovimentoForneInvalido(string forneErrado)
        {
            Assert.Throws<ArgumentException>(
                () =>
                MovimentoBuilder.Novo().ComForne(forneErrado).Criar()
                );

            var mensagem =
           Assert.Throws<ArgumentException>(
              () => new Movimento(_entrada, _saida, _quantidade, _valor_compra, _data_entre, forneErrado, _nume_fatu, _descri_motivo, _identidade, _custo_pro, _codigo)
           ).Message;
            Assert.Equal("Fornecedor inválido", mensagem);

        }


        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-234)]
        [InlineData(null)]
        public void MovimentoNnume_fatuInvalido(int nume_fatuErrado)
        {
            Assert.Throws<ArgumentException>(
                () =>
                MovimentoBuilder.Novo().ComNume_fatu(nume_fatuErrado).Criar()
                );

            var mensagem =
           Assert.Throws<ArgumentException>(
              () => new Movimento(_entrada, _saida, _quantidade, _valor_compra, _data_entre, _forne, nume_fatuErrado, _descri_motivo, _identidade, _custo_pro, _codigo)
           ).Message;
            Assert.Equal("Número da fatura inválido", mensagem);

        }


        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void MovimentoDescri_motivoInvalido(string descri_motivoErrado)
        {
            Assert.Throws<ArgumentException>(
                () =>
                MovimentoBuilder.Novo().ComDescri_motivo(descri_motivoErrado).Criar()
                );

            var mensagem =
           Assert.Throws<ArgumentException>(
              () => new Movimento(_entrada, _saida, _quantidade, _valor_compra, _data_entre, _forne, _nume_fatu, descri_motivoErrado, _identidade, _custo_pro, _codigo)
           ).Message;
            Assert.Equal("Descrição do motivo inválido", mensagem);

        }


        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-234)]
        [InlineData(null)]
        public void MovimentoIdentidadeInvalido(int identidadeErrado)
        {
            Assert.Throws<ArgumentException>(
                () =>
                MovimentoBuilder.Novo().ComIdentidade(identidadeErrado).Criar()
                );

            var mensagem =
           Assert.Throws<ArgumentException>(
              () => new Movimento(_entrada, _saida, _quantidade, _valor_compra, _data_entre, _forne, _nume_fatu, _descri_motivo, identidadeErrado, _custo_pro, _codigo)
           ).Message;
            Assert.Equal("Identidade inválido", mensagem);

        }


        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void MovimentoCusto_proInvalido(string custo_proErrado)
        {
            Assert.Throws<ArgumentException>(
                () =>
                MovimentoBuilder.Novo().ComCusto_pro(custo_proErrado).Criar()
                );

            var mensagem =
           Assert.Throws<ArgumentException>(
              () => new Movimento(_entrada, _saida, _quantidade, _valor_compra, _data_entre, _forne, _nume_fatu, _descri_motivo, _identidade, custo_proErrado, _codigo)
           ).Message;
            Assert.Equal("Custo do produtosinválido", mensagem);

        }


    }
}
