using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PagAutomatico : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int QtdJogos = Convert.ToInt32(Request.QueryString["Qtd"]);

        GerarNum(QtdJogos);

    }

    //Gerando Números - Faltou tratar os números para não repetir:
    private void GerarNum(int pQuantidade)
    {
        for (int valor = 1; valor <= pQuantidade; valor++)
        {
            string texto = "JOGO " + valor;
            Random randNum = new Random();

            listaResultado.Items.Add("-----------");
            listaResultado.Items.Add(texto);
            listaResultado.Items.Add("-----------");
            for (int i = 1; i <= 6; i++)
            {
                listaResultado.Items.Add(randNum.Next(1, 60).ToString());
            }

            JogosDAO.Start();
        }

        lblMsg.Text = "</br></br>" + "Jogo Gerado com Sucesso!!";

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/TpJogo.aspx");
    }
}