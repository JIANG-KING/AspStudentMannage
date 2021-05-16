using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test;

public partial class AdminTest_SkipPage_AddCourse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


        //获取所有老师
        SqlConnection sqlConnection = SqlTools.Connection();
        SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter("select * from teacher", sqlConnection);
        DataSet dataSet1 = new DataSet();
        sqlDataAdapter1.Fill(dataSet1);

        //所有老师绑定到系别下拉框
        DropDownListTeacher.DataSource = dataSet1;
        DropDownListTeacher.DataTextField = "name";
        DropDownListTeacher.DataBind();


        //获取所有教室
        SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter("select * from classroom", sqlConnection);
        DataSet dataSet2 = new DataSet();
        sqlDataAdapter2.Fill(dataSet2);
        //所有教室绑定到系别下拉框
        DropDownListPlace.DataSource = dataSet2;
        DropDownListPlace.DataTextField = "id";
        DropDownListPlace.DataBind();

    }

    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        //修改数据库中的数据

        //导出上课时间
        string time = "";
        if (RadioButtonMonday.Checked)
        {
            time = time + "1=" + DropDownListMonday.SelectedValue + ",";
        }
        if (RadioButtonTuesday.Checked)
        {
            time = time + "2=" + DropDownListMonday.SelectedValue + ",";
        }
        if (RadioButtonWed.Checked)
        {
            time = time + "3=" + DropDownListMonday.SelectedValue + ",";
        }
        if (RadioButtonThur.Checked)
        {
            time = time + "4=" + DropDownListMonday.SelectedValue + ",";
        }
        if (RadioButtonFri.Checked)
        {
            time = time + "5=" + DropDownListMonday.SelectedValue + ",";
        }
        //去除最后一个逗号
        if (time.Length != 0)
        {
            time = time.Substring(0, time.Length - 1);
        }

        //导出上课周次
        string week = DropDownListStart.SelectedValue + "-" + DropDownListEnd.SelectedValue;

        Course c = new Course(
            TextBoxID.Text,
            TextBoxName.Text,
            DropDownListTeacher.SelectedValue,
            TextBoxDate.Text,
            time,
            week,
            DropDownListPlace.SelectedValue,
            TextBoxScore.Text
            );
        bool success = dao.AddBody(c, 4);
        if (success) Response.Write("<script>alert('添加成功！')</script>");
        else Response.Write("<script>alert('修改失败！该课程号已存在~')</script>");
    }

    protected void ButtonExit_Click(object sender, EventArgs e)
    {
        Response.Redirect("../CourseInfo.aspx");
    }
}