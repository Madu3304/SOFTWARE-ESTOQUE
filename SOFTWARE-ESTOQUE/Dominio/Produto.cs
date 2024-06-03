//LUIZ FELIPE S. MARCON
//MARIA EDUARDA NUNES DE SOUZA

using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Produto
    {
        //dados
        private string descricao;
        private int codigo_barras;
        private string preco_compra;
        private string preco_venda;
        private int codigo;
        private string categoria_pro;
        private string fornecedor_pro;
        private int quanti_estoq;
        private string valor_custo;

        // a seguir propriedades

        public string Descricao { get => descricao; set => descricao = value; }
        public int Codigo_barras { get => codigo_barras; set => codigo_barras = value; }
        public string Preco_compra { get => preco_compra; set => preco_compra = value; }
        public string Preco_venda { get => preco_venda; set => preco_venda = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public string Categoria_pro { get => categoria_pro; set => Categoria_pro = value; }
        public string Fornecedor_pro { get => fornecedor_pro; set => fornecedor_pro = value; }
        public int Quanti_estoq { get => quanti_estoq; set => quanti_estoq = value; }
        public string Valor_custo { get => valor_custo; set => valor_custo = value; }


        public Produto(string descricao, int codigo_barras, string preco_compra, string preco_venda, int codigo, string categoria_pro, string fornecedor_pro, int quanti_estoq, string valor_custo, int codigo_barra)
        {
            if (string.IsNullOrEmpty(preco_compra)) throw new ArgumentException("Preço da Compra inválido");
            if (codigo< 1) throw new ArgumentException("Código inválido");
            if (string.IsNullOrEmpty(descricao)) throw new ArgumentException("Descrição inválido");
            if (codigo_barras < 1) throw new ArgumentException("Codigo de Barras inválido");
            if (string.IsNullOrEmpty(preco_compra)) throw new ArgumentException("Preço da Compra inválido");
            if (string.IsNullOrEmpty(preco_venda)) throw new ArgumentException("Preço da Venda inválido");
            if (string.IsNullOrEmpty(fornecedor_pro)) throw new ArgumentException("Fornecedor do Produto inválido");
            if (string.IsNullOrEmpty(categoria_pro)) throw new ArgumentException("Categoria do Produto inválido");
            if (string.IsNullOrEmpty(valor_custo)) throw new ArgumentException("Valor do Custo do Produto inválido");
            if (quanti_estoq < 1) throw new ArgumentException("Quantidade do Estoque inválido");


            this.Codigo = codigo;
            this.Descricao = descricao;
            this.Preco_compra = preco_compra;
            this.Preco_venda = preco_venda;
            this.Categoria_pro = categoria_pro;
            this.Fornecedor_pro = fornecedor_pro;
            this.Quanti_estoq = quanti_estoq;
            this.Valor_custo = valor_custo;
            this.codigo_barras = codigo_barra;
        }

        public Produto(string descricao, int codigo_barras, string preco_compra, string preco_venda, int codigo, string categoria_pro, string fornecedor_pro, int quanti_estoq, string valor_custo)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.Preco_compra = preco_compra;
            this.Preco_venda = preco_venda;
            this.Categoria_pro = categoria_pro;
            this.Fornecedor_pro = fornecedor_pro;
            this.Quanti_estoq = quanti_estoq;
            this.Valor_custo = valor_custo;
           

        }
    }
}
