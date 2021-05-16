using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StudentTest_UpdatePwd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ButtonUpdate_Click(object sender, EventArgs e)
    {
        Student Stu = (Student)Session["student"];
        bool success = dao.UpdatePwd(Stu.ID1, TextBoxOldPwd.Text, TextBoxNewPwd.Text, "Student");
        if (success)
        {
            //更新session中Stu的密码
            Stu.Password1 = TextBoxNewPwd.Text;
            Session["teacher"] = Stu;
            Response.Write("<script>alert('修改成功!')</script>");

        }
        else
        {
            Response.Write("<script>alert('原密码错误！！！')</script>");
        }
    }
}