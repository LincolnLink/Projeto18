using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Projeto.Entidades;

namespace Projeto.DAL
{
    public class ProjetoRepositorio : Conexao
    {
        
        #region Inserindo
        /// <summary>
        /// Método para inserir um projeto na base de dados...
        /// </summary>
        /// <param name="p">O objeto</param>
        public void Insert(EntidadeProjeto p)
        {
            OpenConnection();
            try
            {
                tr = con.BeginTransaction(); //abrindo transação...
                
                string queryProjeto = " INSERT INTO Projeto(NomeProjeto, DateInicio, DateFim) " +
                    " VALUES(@NomeProjeto, @DataInicio, @DataFim) " +
                    " SELECT SCOPE_IDENTITY() ";

                cmd = new SqlCommand(queryProjeto, con, tr);
                cmd.Parameters.AddWithValue("@NomeProjeto", p.NomeProjeto);
                cmd.Parameters.AddWithValue("@DataInicio", p.DataInicio);
                cmd.Parameters.AddWithValue("@DataFim", p.DataFim);
                p.IdProjeto = Convert.ToInt32(cmd.ExecuteScalar());

                string queryProjetoFuncionario = " INSERT INTO ProjetoFuncionario(IdProjeto, IdFuncionario) " +
                    " VALUES(@IdProjeto, @IdFuncionario) ";

                //varrer os funcionarios contidos no projeto..
                foreach (Funcionario f in p.Funcionarios)
                {
                    cmd = new SqlCommand(queryProjetoFuncionario, con, tr);
                    cmd.Parameters.AddWithValue("@IdProjeto", p.IdProjeto);
                    cmd.Parameters.AddWithValue("@IdFuncionario", f.IdFuncionario);
                    cmd.ExecuteNonQuery();
                }
                tr.Commit(); //executa a finaliza a transação...
            }
            catch (Exception e)
            {
                tr.Rollback(); //Desfazendo a transação
                throw new Exception(e.Message); //retorna o erro

            }
            CloseConnection();
        }
        #endregion

        
        
    }
}
