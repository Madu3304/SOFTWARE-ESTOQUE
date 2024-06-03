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
    public class ProdutoBuilder
    {
        //CAMPOS
        private string _descricao = "Prato Granlho grelhado no alho";
        private int _codigo_barras = 335577;
        private string _preco_compra = "39,98";
        private string _preco_venda = "69,75";
        private int _codigo = 2;
        private string _categoria_pro = "Prato saida";
        private string _fornecedor_pro = "Frango Fil";
        private int _quanti_estoq = 8;
        private string _valor_custo = "4,90";


        public static ProdutoBuilder Novo()
        {
            return new ProdutoBuilder();
        
        }


        public Produto Criar()
        {
            return new Produto(_codigo, _descricao, _codigo_barras, _preco_compra, _preco_venda, _categoria_pro, _fornecedor_pro, _quanti_estoq, _valor_custo);
        }


        public ProdutoBuilder Popular()
        {
            Faker faker = new Faker();
            _codigo = faker.Random.Int(1, 100);
            _descricao = faker.Random.String();
            _codigo_barras = faker.Random.Int(1, 100);
            _preco_compra = faker.Random.String();
            _preco_venda = faker.Random.String();
            _categoria_pro = faker.Random.String();
            _fornecedor_pro = faker.Random.String();
            _quanti_estoq = faker.Random.Int(1, 100);
            _valor_custo = faker.Random.String();

            return this;
        }


        public ProdutoBuilder ComCodigo(int codigo)
        {
            _codigo = codigo;
            return this;
        }

        public ProdutoBuilder ComDescricao(string descricao)
        {
            _descricao = descricao;
            return this;
        }

        public ProdutoBuilder ComCodigo_Barras(int codigo_barras)
        {
            _codigo_barras = codigo_barras;
            return this;
        }

        public ProdutoBuilder ComPreco_compra(string preco_compra)
        {
            _preco_compra = preco_compra;
            return this;
        }

        public ProdutoBuilder ComPreco_venda(string preco_venda)
        {
            _preco_venda = preco_venda;
            return this;
        }
        
         public ProdutoBuilder ComCategoria_pro(string categoria_pro)
        {
            _categoria_pro = categoria_pro;
            return this;
        }

        public ProdutoBuilder ComFornecedor_pro(string fornecedor_pro)
        {
            _fornecedor_pro = fornecedor_pro;
            return this;
        }

        public ProdutoBuilder ComQuanti_estoq(int quanti_estoq)
        {
            _quanti_estoq = quanti_estoq;
            return this;
        }


        public ProdutoBuilder ComValor_custo(string valor_custo)
        {
            _valor_custo = valor_custo;
            return this;
        }

    }
}
