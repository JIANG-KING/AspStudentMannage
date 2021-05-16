using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LoginTest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonLogin_Click(object sender, EventArgs e)
    {

        if (TextBoxCheckcode.Text.ToUpper().Trim() != Session["validcode"].ToString().ToUpper().Trim()) //验证码输入错误
            Response.Write("<script>alert('你的验证码输入错误，请重输入!')</script>");
        //if (1 == 2) { }//调试阶段停用验证码
        else
        {
            if (RadioButtonStudent.Checked)   //学生登陆
            {
                object o = dao.Login(TextBoxAccount.Text, TextBoxPassword.Text, 1);
                if (o == null)
                {
                    Response.Write("<script>alert('用户名或密码错误！')</script>");
                }
                else
                {
                    Session["student"] = o;
                    Server.Transfer("~/Studentmain.aspx");
                }

            }
            else if (RadioButtonTeacher.Checked)   //教师登陆
            {
                object o = dao.Login(TextBoxAccount.Text, TextBoxPassword.Text, 2);
                if (o == null)
                {
                    Response.Write("<script>alert('用户名或密码错误！')</script>");
                }
                else
                {
                    Session["teacher"] = o;
                    Server.Transfer("~/TeacherMenuTest.aspx");
                }

            }
            else if (RadioButtonAdmin.Checked)   //管理员登陆
            {
                object o = dao.Login(TextBoxAccount.Text, TextBoxPassword.Text, 3);
                if (o == null)
                {
                    Response.Write("<script>alert('用户名或密码错误！')</script>");
                }
                else
                {
                    Session["admin"] = o;
                    Server.Transfer("~/AdminMenuTest.aspx");
                }
            }
            else   //没有选择用户类型
                Response.Write("<script>alert('对不起，必须选择用户类型!')</script>");
        }
    }

}