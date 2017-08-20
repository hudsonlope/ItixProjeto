using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TpJogo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {

            JogosDAO.Start();

        }
    }

    protected void BtnEscolher_Click(object sender, EventArgs e)
    {

        if (ddlTpJogo.SelectedValue != null)
        {
            Session["TpJogo"] = ddlTpJogo.SelectedValue;
        }

        Response.Redirect("~/Menu.aspx?TpJogo=" + ddlTpJogo.SelectedValue, false);
    }

    protected void btnResultado_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/PagResultado.aspx", false);

    }
}