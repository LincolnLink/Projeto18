using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entidades.Tipos; //Enum

namespace Projeto.Entidades
{
    public class Funcionario
    {
        /// <summary>
        /// Atributos, Enum e uma lista de projetos!
        /// </summary>
        private int idFuncionario;
        private string nomeFuncionario;
        private Funcao funcao; //Enum
        private List<Projeto> projetos;
        /// <summary>
        /// Métodos contrutores
        /// </summary>
        public Funcionario()
        {

        }

        public Funcionario(int idFuncionario, string nomeFuncionario, Funcao funcao)
        {
            IdFuncionario = idFuncionario;
            NomeFuncionario = nomeFuncionario;
            Funcao = funcao;
        }
        /// <summary>
        /// Encapsulamento
        /// </summary>
        public int IdFuncionario
        {
            set { idFuncionario = value; }
            get { return idFuncionario;  }
        }
        public string NomeFuncionario
        {
            set { nomeFuncionario = value; }
            get { return nomeFuncionario;  }
        }
        public Funcao Funcao
        {
            set { funcao = value; }
            get { return funcao;  }
        }
        public List<Projeto> Projetos
        {
            set { projetos = value; }
            get { return projetos;  }
        }
        /// <summary>
        /// Override sobreposição do metodo ToString!
        /// </summary>
        /// <returns>Retorna um novo valor</returns>
        public override string ToString()
        {
            return "ID do Funcionario: " + idFuncionario +
                "Nome do Funcionario: " + nomeFuncionario;
        }
    }
}
