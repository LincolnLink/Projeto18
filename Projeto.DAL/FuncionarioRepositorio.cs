using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //SQL
using Projeto.Entidades.Tipos; //Enum
using Projeto.Entidades; //entidades

namespace Projeto.DAL
{
    public class FuncionarioRepositorio : Conexao
    {

        #region Imprimir Tabela
        public List<Funcionario> FindAll()
        {
            OpenConnection();

            string query = "select * from Funcionario";

            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();

            List<Funcionario> lista = new List<Funcionario>();

            while (dr.Read())
            {
                Funcionario f = new Funcionario();
                f.IdFuncionario = Convert.ToInt32(dr["IdFuncionario"]);
                f.NomeFuncionario = Convert.ToString(dr["NomeFuncionario"]);
                /// <summary>
                /// Converte o dado em string, para depois converter em um Enum!
                /// </summary>
                string fucao = Convert.ToString(dr["Funcao"]);
                f.Funcao = (Funcao) Enum.Parse(typeof(Funcao), fucao);

                lista.Add(f);
            }

            CloseConnection();
            return lista;
        }
        #endregion
        
    }
}
