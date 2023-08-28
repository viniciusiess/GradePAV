using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gui_cadastro
{
    public class TabelaPessoa : DataTable
    {
        private const String COLUNA_NOME = "Nome";
        private const String COLUNA_TELEFONE = "Telefone";

        public TabelaPessoa()
        {
            criarColunas();
        }

        private DataColumn criarColuna(string titulo, string nome, Type tipo)
        {
            DataColumn coluna = new DataColumn();

            coluna.Caption = titulo;
            coluna.ColumnName = nome;
            coluna.DataType = tipo;

            return coluna;
        }

        private void criarColunas()
        {
            Columns.Add(criarColuna("Nome", COLUNA_NOME, typeof(string)));
            Columns.Add(criarColuna("Telefone", COLUNA_TELEFONE, typeof(string)));
        }

        public void incluir(Pessoa pessoa)
        {
            Rows.Add(pessoa.nome, pessoa.telefone);
        }

        public void alterar(int indice, Pessoa pessoa)
        {
            Rows[indice][COLUNA_NOME] = pessoa.nome;
            Rows[indice][COLUNA_TELEFONE] = pessoa.telefone;
        }

        public void excluir(int indice)
        {
            Rows.RemoveAt(indice);
        }

        public void selecionar(int indice, Pessoa pessoa)
        {
            pessoa.nome = Rows[indice][COLUNA_NOME].ToString();
            pessoa.telefone = Rows[indice][COLUNA_TELEFONE].ToString();
        }
    }
}
