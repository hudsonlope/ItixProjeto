using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PagResultado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var ganhadores = JogosDAO.Jogos.Rodar();

        lblMsg.Text = string.Join(", ", ganhadores.Select(x => x.Codigo).ToList());
    }
}