<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProjetoCadastro.aspx.cs" Inherits="Projeto.WEB.Pages.ProjetoCadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cadastrando o Projeto</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../Content/bootstrap-theme.min.css" rel="stylesheet" />
</head>
<body class="container">
    <h4>Cadastro de Projeto</h4>
    <hr />
    <form id="form1" runat="server">
    <div>
        <div class="row">
            <div class="col-md-4">

                <label>Nome Projeto: </label>
                <asp:TextBox runat="server" ID="txtNomeProjeto" CssClass="form-control" />
                <br />
                <label>Data Inicio: </label>
                <asp:TextBox runat="server" ID="txtDataInicio" CssClass="form-control" type="date" />
                <br />
                <label>Data Fim: </label>
                <asp:TextBox runat="server" ID="txtDataFim" CssClass="form-control" type="date" />
                <br />

            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:GridView runat="server" ID="GridFuncionario"
                    CssClass="table table-hover" AutoGenerateColumns="false" GridLines="None">
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <!--Campo para checkBox para a seleção-->
                            <asp:CheckBox ID="chkFuncionario" runat="server" />

                                <!--Armazenar o id do funcionario (oculto) -->
                            <asp:Label ID="lblCodigo" runat="server" 
                                Text='<%# Eval("IdFuncionario") %>' Visible="false" />
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Nome do Funcionário" >
                            <ItemTemplate>
                                <%# Eval("NomeFuncionario")%>
                            </ItemTemplate>
                        </asp:TemplateField>

                         <asp:TemplateField HeaderText="Função" >
                            <ItemTemplate>
                                <%# Eval("Funcao")%>
                            </ItemTemplate>
                        </asp:TemplateField>                       
                    </Columns>
                </asp:GridView>
                <br />

                <asp:Button runat="server" ID="BtnCadastro" 
                    Text="Cadastrar Projeto" CssClass="btn btn-success"
                    OnClick="BtnCadastro_Click"/>
                <br />
                <br />
                <asp:Label ID="lblMensagem" runat="server" />
            </div>
        </div>
    </div>
    </form>
</body>
</html>
