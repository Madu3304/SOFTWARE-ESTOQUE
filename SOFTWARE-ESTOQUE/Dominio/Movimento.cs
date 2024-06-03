//LUIZ FELIPE S. MARCON
//MARIA EDUARDA NUNES DE SOUZA

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Movimento
    {
        //campos

        private string entrada;
        private string saida;
        private int quantidade;
        private string valor_compra;
        private string data_entre;
        private string forne;
        private int nume_fatu;
        private string descri_motivo;
        private int identidade;
        private string custo_pro;
        private int codigo;

        public string Entrada { get => entrada; set => entrada = value; }
        public string Saida { get => saida; set => saida = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public string Valor_compra { get => valor_compra; set => valor_compra = value; }
        public string Data_entre { get => data_entre; set => data_entre = value; }
        public string Forne { get => forne; set => forne = value; }
        public int Nume_fatu { get => nume_fatu; set => nume_fatu = value; }
        public string Descri_motivo { get => descri_motivo; set => descri_motivo = value; }
        public int Identidade { get => identidade; set => identidade = value; }
        public string Custo_pro { get => custo_pro; set => custo_pro  = value; }
        public int Codigo { get => codigo; set => codigo = value; }


        public Movimento(string entrada, string saida, int quantidade, string valor_compra, string data_entre, string forne, int nume_fatu, string descri_motivo, int identidade, string custo_pro, int codigo, object )
        {

            if (string.IsNullOrEmpty(entrada)) throw new ArgumentException("Entrada inválido");
            if (string.IsNullOrEmpty(saida)) throw new ArgumentException("Saida inválido");
            if (quantidade<1) throw new ArgumentException("Quantidade inválido");
            if (string.IsNullOrEmpty(data_entre)) throw new ArgumentException("data_entre inválido");
            if (string.IsNullOrEmpty(forne)) throw new ArgumentException("Forne inválido");
            if (nume_fatu < 1) throw new ArgumentException("nume_fatu inválido");
            if (string.IsNullOrEmpty(descri_motivo)) throw new ArgumentException("descri_motivo inválido");
            if (identidade < 1) throw new ArgumentException("identidade inválido");
            if (string.IsNullOrEmpty(valor_compra)) throw new ArgumentException("Valor compra inválido");
            if (string.IsNullOrEmpty(custo_pro)) throw new ArgumentException("custo_pro inválido");
            if (codigo< 1) throw new ArgumentException("Código inválido");

            this.Codigo = codigo;
            this.Entrada = entrada;
            this.Saida = saida;
            this.Quantidade = quantidade;
            this.Valor_compra = valor_compra;
            this.Data_entre = data_entre;
            this.Forne = forne;
            this.Nume_fatu = nume_fatu;
            this.Descri_motivo = descri_motivo;
            this.Identidade = identidade;
            this.Custo_pro = custo_pro;

        }

        public Movimento(string entrada, string saida, int quantidade, string valor_compra, string data_entre, string forne, int nume_fatu, string descri_motivo, int identidade, string custo_pro, int codigo)
        {
            this.entrada = entrada;
            this.saida = saida;
            this.quantidade = quantidade;
            this.valor_compra = valor_compra;
            this.data_entre = data_entre;
            this.forne = forne;
            this.nume_fatu = nume_fatu;
            this.descri_motivo = descri_motivo;
            this.identidade = identidade;
            this.custo_pro = custo_pro;
            this.codigo = codigo;
        }
    }
}
