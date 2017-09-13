using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Projeto.Entidades;
using Projeto.BLL;

namespace Projeto.WEB.Pages
{
    public partial class ProjetoCadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Verifica se a pagina esta sendo carregada pela primeira vez
            if (! IsPostBack)
            {
                try
                {
                    FuncionarioBusiness rep = new FuncionarioBusiness();

                    GridFuncionario.DataSource = rep.Consultar();
                    GridFuncionario.DataBind();

                }
                catch (Exception ex)
                {
                    lblMensagem.Text = ex.Message;
                }
            }

        }

        protected void BtnCadastro_Click(object sender, EventArgs e)
        {
            //método executado quando o botão for clicado...
            try
            {
                List<Funcionario> listaFuncionarios = new List<Funcionario>();

                //percorrer as linhas do gridView
                foreach ( GridView linha in GridFuncionario.Rows)
                {
                    //Buscar o checkBox contido na linha do grid
                    CheckBox chkFunciorio = linha.FindControl("chkFunciorio") as CheckBox;

                    //Verificar se o checkBox esta marcado..
                    if (chkFunciorio.Checked)
                    {
                        //capturar a label que contem o id do funcionario..
                        Label lblCodigo = linha.FindControl("lblCodigo") as Label;

                        //criando um novo funcionario..
                        Funcionario f = new Funcionario();
                        f.IdFuncionario = int.Parse(lblCodigo.Text);

                        //adicionar na lista..
                        listaFuncionarios.Add(f);
                    }
                }

                //gravar o projeto
                Projetos p = new Projetos();
                p.NomeProjeto = txtNomeProjeto.Text;
                p.DataInicio = DateTime.Parse(txtDataInicio.Text);
                p.DataFim = DateTime.Parse(txtDataFim.Text);

                ProjetoBusiness business = new ProjetoBusiness();
                business.Cadastrar(p, listaFuncionarios);

                //mensagem de sucesso..
                lblMensagem.Text = "Projeto " + p.NomeProjeto + ", cadastrado com sucesso.";

                LimparCampos();


            }
            catch (Exception ex)
            {
                //imprimir mensagem de erro
                lblMensagem.Text = ex.Message;
            }
        }

        #region LimparCampo
        //método para limpar os campos da página
        private void LimparCampos()
        {
            txtNomeProjeto.Text = string.Empty; //vazio
            txtDataInicio.Text = string.Empty;
            txtDataFim.Text = string.Empty;

            //varrer o gridview..
            foreach (GridViewRow linha in GridFuncionario.Rows)
            {
                //capturar o checkBox
                CheckBox chkFuncionario = linha.FindControl("chkFuncionario") as CheckBox;

                //limpa o CheckBox
                if (chkFuncionario.Checked) chkFuncionario.Checked = false;

            }
        }

        #endregion
    }
}