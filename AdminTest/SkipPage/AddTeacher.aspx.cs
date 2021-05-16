using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test;

public partial class AdminTest_SkipPage_AddTeacher : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection sqlConnection = SqlTools.Connection();

        //获取所有系别
        SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter("select * from dept", sqlConnection);
        DataSet dataSet1 = new DataSet();
        sqlDataAdapter1.Fill(dataSet1);

        //所有系别绑定到系别下拉框
        DropDownListDept.DataSource = dataSet1;
        DropDownListDept.DataTextField = "name";
        DropDownListDept.DataBind();

        sqlConnection.Close();
    }

    protected void ButtonExit_Click(object sender, EventArgs e)
    {
        Response.Redirect("../TeacherInfo.aspx");
    }

    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        //添加数据库中的数据
        string sex = "";
        if (RadioButtonSexFemale.Checked) sex = "女";
        else sex = "男";
        Teacher t = new Teacher(
            TextBoxID.Text,
            TextBoxPassword.Text,
            TextBoxName.Text,
            TextBoxState.Text,
            sex,
            TextBoxBirth.Text,
            TextBoxArriveDate.Text,
            TextBoxPhone.Text,
            "addstudent处没有此功能",
            TextBoxAddress.Text,
            TextBoxEmail.Text,
            DropDownListDept.SelectedValue
            );
        bool success = dao.AddBody(t, 2);
        if (success) Response.Write("<script>alert('添加成功！')</script>");
        else Response.Write("<script>alert('修改失败！该工号已存在~')</script>");
    }
}