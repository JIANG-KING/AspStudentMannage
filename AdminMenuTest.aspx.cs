using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminMenuTest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] == null)
        {
            Response.Redirect("./LoginTest.aspx");
        }
        Admin a = (Admin)Session["admin"];
        LabelWelcome.Text = "管理员端→欢迎你:" + a.Name1 + "(" + a.ID1 + ")";
        ShowLevel.Text = a.AccountLevel1;
        ShowID.Text = a.ID1;
        ShowEmail.Text = a.Email1;
        ShowPhone.Text = a.Telephone1;
    }

    protected void ButtonEsc_Click(object sender, EventArgs e)
    {
        Session["student"] = null;
        Response.Redirect("~/LoginTest.aspx", true);
    }
}