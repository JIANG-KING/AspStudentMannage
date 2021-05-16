using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class updatemanagerpass : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Admin a = (Admin)Session["admin"];
        bool success = dao.UpdatePwd(a.ID1, TextBox1.Text, TextBox2.Text, "Admin");
        if (success)
        {
            //更新session中teacher的密码
            a.Password1 = TextBox2.Text;
            Session["admin"] = a;
            Response.Write("<script>alert('修改成功!')</script>");

        }
        else
        {
            Response.Write("<script>alert('原密码错误！！！')</script>");
        }




        //CommDB mydb = new CommDB();
        //string mysql, sn = "";
        //int i;
        //mysql = "SELECT * FROM manager WHERE mno='" + Session["uno"] + "' AND mpass='" + TextBox1.Text.Trim() + "'";
        //i = mydb.Rownum(mysql, "manager", ref sn);
        //if (i == 0)
        //    Server.Transfer("~/displayinfo.aspx?info=原密码输入错误!");
        //else
        //{
        //    mysql = "UPDATE manager SET mpass='" + TextBox2.Text.Trim() + "' WHERE mno='" + Session["uno"] + "'";
        //    mydb.ExecuteNonQuery(mysql);
        //    Server.Transfer("~/displayinfo.aspx?info=密码修改成功!");
        //}
    }
}
