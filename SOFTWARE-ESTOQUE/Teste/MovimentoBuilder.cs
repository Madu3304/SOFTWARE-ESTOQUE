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
    public class MovimentoBuilder
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


            public static MovimentoBuilder Novo()
            {
                return new MovimentoBuilder();
            }


            public Movimento Criar()
            {
                return new Movimento(_entrada, _saida, _quantidade, _valor_compra, _data_entre, _forne, _nume_fatu, _descri_motivo, _identidade, _custo_pro, _codigo);
            }


            public MovimentoBuilder Popular()
            {
                Faker faker = new Faker();
                _codigo = faker.Random.Int(1, 100);
                _entrada = faker.Random.String();
                _saida= faker.Random.String();
                _quantidade= faker.Random.Int(1, 100);
                _valor_compra = faker.Random.String();
                _data_entre = faker.Random.String();
                _forne = faker.Random.String();
                _nume_fatu = faker.Random.Int(1, 100);
                _descri_motivo = faker.Random.String();
                _identidade = faker.Random.Int(1, 100);
                _custo_pro = faker.Random.String();
            return this;
            }


            public MovimentoBuilder ComCodigo(int codigo)
            {
                _codigo = codigo;
                return this;
            }

            public MovimentoBuilder ComEntrada(String entrada)
            {
                _entrada = entrada;
                return this;
            }

            public MovimentoBuilder ComSaida(String saida)
            {
               _saida = saida;
                return this;
            }


            public MovimentoBuilder ComQuantidade(int quantidade)
            {
                _quantidade = quantidade;
                return this;
            }


            public MovimentoBuilder ComValor_compra(String valor_compra)
            {
                _valor_compra = valor_compra;
                return this;
            }


            public MovimentoBuilder ComData_entre(String data_entre)
            {
                _data_entre = data_entre;
                return this;
            }


            public MovimentoBuilder ComForne(String forne)
            {
                _forne = forne;
                return this;
            }

            public MovimentoBuilder ComNume_fatu(int nume_fatu)
            {
                _nume_fatu = nume_fatu;
                return this;
            }



            public MovimentoBuilder ComDescri_motivo(String descri_motivo)
                {
                    _descri_motivo = descri_motivo;
                    return this;
                }

            public MovimentoBuilder ComIdentidade(int identidade)
            {
                _identidade = identidade;
                return this;
            }

    }
}
