using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.DAL;
using Projeto.Entidades;
using Projeto.Entidades.Tipos;

namespace Projeto.BLL
{
    public class ProjetoBusiness
    {
        ///<summary>
        ///Criando um método para gravar Projeto e relacionamento
        ///com funcionarios do mesmo projeto
        ///</summary>
        public void Cadastrar(Projetos p, List<Funcionario> funcionarios)
        {
            //verificar a lista de funcionarios..
            if (funcionarios.Where(f => f.Funcao.Equals(Funcao.Gerente)).Count() > 0)
            {
                //relacionamento do Projeto com os Funcionarios..
                p.Funcionarios = funcionarios;

                //gravar no banco de dados..
                ProjetoRepositorio rep = new ProjetoRepositorio();
                rep.Insert(p);
            }
            else
            {
                throw new Exception("O Projeto deve conter pelo menos 1 Gerente."); 
            }
        }

    }
}
