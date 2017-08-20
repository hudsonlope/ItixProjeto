using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Menu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            int TpConta = Convert.ToInt32(Request.QueryString["TpJogo"]);

        }
    }

    protected void btnProcessar_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(txtQtdJogos.Text.ToString()))
        {
            //   Response.Redirect("~/Menu.aspx?TpJogo=1");
            LblMenssagem.Text = ("Favor Preenchar o Campo Quantidade!");
        }
        else if (ddlTpEscolha.SelectedValue.Equals("1"))
        {
            Response.Redirect("~/PagAleartorio.aspx?Qtd=" + txtQtdJogos.Text, false);
        }
        else if (ddlTpEscolha.SelectedValue.Equals("2"))
        {
            Response.Redirect("~/PagAutomatico.aspx?Qtd=" + txtQtdJogos.Text, false);
        }
    }
}
