using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ResetPwd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    { 
        if(!IsPostBack)
        
        
        {
                TextBoxID.Text = "";
        TextBoxName.Text = "";
        TextBoxPhone.Text = "";
        TextBoxEmail.Text = "";
        TextBoxPwdNew.Text = "";
        TextBoxPwdCon.Text = "";
        
        }

    }



    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        if (RadioButtonAdmin.Checked == true)
        {
            Admin Admin = (Admin)dao.getBody(TextBoxID.Text, 3);
            if (Admin != null)
            {
                Admin admin2 = new Admin(TextBoxID.Text, TextBoxPwdNew.Text, TextBoxName.Text, TextBoxPhone.Text,TextBoxEmail.Text);
                if (Admin .Equals( admin2))
                {
                    bool success = dao.UpdateWithoutPwd(admin2.ID1,TextBoxPwdCon.Text ,"Admin");
                    if (success)
                    {
                        Response.Write("<script>alert('修改成功!')</script>");

                    }
                    else
                    {
                        Response.Write("<script>alert('出现意外！！！！')</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('信息错误！！！！')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('账号不存在！！！！')</script>");
            }
        }
        if (RadioButtonStudent.Checked == true)
        {
            Student Stu = (Student)dao.getBody(TextBoxID.Text.ToString(), 1);
            if (Stu != null)
            {
                Student Stu2 = new Student(TextBoxID.Text, TextBoxPwdNew.Text, TextBoxName.Text, TextBoxEmail.Text, TextBoxPhone.Text);
                if (Stu.Equals(Stu2))
                {
                    bool success = dao.UpdateWithoutPwd(Stu2.ID1, TextBoxPwdCon.Text,"Student");
                    if (success)
                    {
                        Response.Write("<script>alert('修改成功!')</script>");

                    }
                    else
                    {
                        Response.Write("<script>alert('出现意外！！！！')</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('信息错误！！！！')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('账号不存在！！！！')</script>");
            }
        }
        if (RadioButtonTeacher.Checked == true)
        {
            Teacher Tea = (Teacher)dao.getBody(TextBoxID.Text, 2);
            if (Tea != null)
            {
                Teacher Tea2 = new Teacher(TextBoxID.Text, TextBoxPwdNew.Text, TextBoxName.Text, TextBoxEmail.Text, TextBoxPhone.Text);
                if (Tea.Equals(Tea2))
                {
                    bool success = dao.UpdateWithoutPwd(Tea2.ID1, TextBoxPwdCon.Text, "Teacher");
                    if (success)
                    {
                        Response.Write("<script>alert('修改成功!')</script>");

                    }
                    else
                    {
                        Response.Write("<script>alert('出现意外！！！！')</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('信息错误！！！！')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('账号不存在！！！！')</script>");
            }
        }
    }

    protected void ButtonReset_Click(object sender, EventArgs e)
    {
        TextBoxID.Text = "";
        TextBoxName.Text = "";
        TextBoxPhone.Text = "";
        TextBoxEmail.Text = "";
        TextBoxPwdNew.Text = "";
        TextBoxPwdCon.Text = "";
    }
}