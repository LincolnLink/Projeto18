using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entidades
{
    public class Projetos
    {   
        /// <summary>
        /// Atribustos, lista de funcionarios
        /// </summary>
        private int idProjeto;
        private string nomeProjeto;
        private DateTime dataInicio;
        private DateTime dataFim;
        private List<Funcionario> funcionarios;
        /// <summary>
        /// Métodos contrutores!
        /// </summary>
        public Projetos()
        {

        }
        public Projetos(int idProjeto, string nomeProejeto, DateTime dataInicio, DateTime dataFim)
        {
            IdProjeto = idProjeto;
            NomeProjeto = nomeProejeto;
            DataInicio = dataInicio;
            DataFim = dataFim;
        }
        /// <summary>
        /// Encapsulamento
        /// </summary>
        public int IdProjeto
        {
            set { idProjeto = value; }
            get { return idProjeto;  }
        }
        public string NomeProjeto
        {
            set { nomeProjeto = value; }
            get { return nomeProjeto;  }
        }
        public DateTime DataInicio
        {
            set { dataInicio = value; }
            get { return dataInicio; }
        }
        public DateTime DataFim
        {
            set { dataFim = value; }
            get { return dataFim;  }
        }
        public List<Funcionario> Funcionarios
        {
            set { funcionarios = value; }
            get { return funcionarios; }
        }
        /// <summary>
        /// SobreEscrita do metodo ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Id: " + idProjeto + " Nome do projeto: " + nomeProjeto
                + "Data de Incio: " + dataInicio + "Data Final: " + dataFim;
        }
    }
}
