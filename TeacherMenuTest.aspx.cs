using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeacherMenuTest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["teacher"] == null)
        {
            Response.Redirect("./LoginTest.aspx");
        }
        Teacher t = (Teacher)Session["teacher"];
        Label1.Text = "管理员端→欢迎你:" + t.Name1 + "(" + t.ID1 + ")";
        LabelName0.Text = t.Name1;
        LabeState0.Text = t.State1;
    }

    protected void ButtonEsc_Click(object sender, EventArgs e)
    {
        Session["teacher"] = null;
        Response.Redirect("~/LoginTest.aspx", true);
    }
}