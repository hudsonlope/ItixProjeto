using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PagAleartorio : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // int QtdJogos = Convert.ToInt32(Request.QueryString["Qtd"]);
    }

    protected void btnProcessar_Click(object sender, EventArgs e)
    {


        if ((!String.IsNullOrEmpty(txtPrNumero.Text)) ||
            (!String.IsNullOrEmpty(txtSgNumero.Text)) ||
            (!String.IsNullOrEmpty(txtTerNumero.Text)) ||
            (!String.IsNullOrEmpty(txtQuarNumero.Text)) ||
            (!String.IsNullOrEmpty(txtQuiNumero.Text)) ||
            (!String.IsNullOrEmpty(txtSexNumero.Text)))
        {

            lblMsg.Text = String.Empty;

            var list = new List<int> { Convert.ToInt32(txtPrNumero.Text),
                                   Convert.ToInt32(txtSgNumero.Text),
                                   Convert.ToInt32(txtTerNumero.Text),
                                   Convert.ToInt32(txtQuarNumero.Text),
                                   Convert.ToInt32(txtQuiNumero.Text),
                                   Convert.ToInt32(txtSexNumero.Text)};

            JogosDAO.Jogos.RegistrarJogo(list);
        }

        else
            lblMsg.Text = "Gentilezar Preencher Todos os campos";




        //var ganhadores = JogosDAO.Jogos.Rodar();

        //lblGanhadores.Text =  string.Join(", ", ganhadores.Select(x => x.Codigo).ToList());
    }
}