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

        }
    }
}