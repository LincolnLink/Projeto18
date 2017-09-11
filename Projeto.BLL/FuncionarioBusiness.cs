using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.DAL;
using Projeto.Entidades;

namespace Projeto.BLL
{
     public class FuncionarioBusiness
    {
        /// <summary>
        ///Método para consultar funcionario 
        /// </summary>
        public List<Funcionario> Consultar()
        {
            FuncionarioRepositorio rep = new FuncionarioRepositorio();
            return rep.FindAll();
        }

    }
}
