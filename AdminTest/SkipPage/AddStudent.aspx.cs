using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test;

public partial class AdminTest_SkipPage_AddStudent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //获取所有班级
        SqlConnection sqlConnection = SqlTools.Connection();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from classinfo", sqlConnection);
        DataSet dataSet = new DataSet();
        sqlDataAdapter.Fill(dataSet);

        //所有班级绑定到班级下拉框
        DropDownListClass.DataSource = dataSet;
        DropDownListClass.DataTextField = "name";
        DropDownListClass.DataBind();


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

    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        //添加数据库中的数据
        string sex = "";
        if (RadioButtonSexFemale.Checked) sex = "男";
        else sex = "女";
        Student s = new Student(
            TextBoxID.Text,
            TextBoxPassword.Text,
            TextBoxName.Text,
            sex,
            DropDownListClass.SelectedValue,
            DropDownListDept.SelectedValue,
            TextBoxState.Text,
            TextBoxBirth.Text,
            TextBoxAddress.Text,
            "addstudent处没有此功能",
            TextBoxEmail.Text,
            TextBoxPhone.Text
            );

        bool success = dao.AddBody(s,1);
        if(success) Response.Write("<script>alert('添加成功！')</script>");
        else Response.Write("<script>alert('修改失败！该学号已存在~')</script>");
    }

    protected void ButtonExit_Click(object sender, EventArgs e)
    {
        Response.Redirect("../StudentInfo.aspx");
    }
}