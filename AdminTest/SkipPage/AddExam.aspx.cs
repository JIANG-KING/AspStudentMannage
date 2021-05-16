using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test;

public partial class AdminTest_SkipPage_AddExam : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection sqlConnection = SqlTools.Connection();

        //获取所有课程名
        SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter("select * from course", sqlConnection);
        DataSet dataSet1 = new DataSet();
        sqlDataAdapter1.Fill(dataSet1);

        //所有课程名绑定到课程号下拉框
        DropDownListCourse.DataSource = dataSet1;
        DropDownListCourse.DataTextField = "name";
        DropDownListCourse.DataBind();

        //获取所有教室
        SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter("select * from classroom", sqlConnection);
        DataSet dataSet2 = new DataSet();
        sqlDataAdapter2.Fill(dataSet2);

        //所有教室绑定到地点下拉框
        DropDownListPlace.DataSource = dataSet2;
        DropDownListPlace.DataTextField = "id";
        DropDownListPlace.DataBind();


        //获取所有班级
        SqlDataAdapter sqlDataAdapter3 = new SqlDataAdapter("select * from classinfo", sqlConnection);
        DataSet dataSet3 = new DataSet();
        sqlDataAdapter3.Fill(dataSet3);

        //所有班级绑定到班级下拉框
        DropDownListClass.DataSource = dataSet3;
        DropDownListClass.DataTextField = "name";
        DropDownListClass.DataBind();


        sqlConnection.Close();
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
            time = time + "2=" + DropDownListTuesday.SelectedValue + ",";
        }
        if (RadioButtonWed.Checked)
        {
            time = time + "3=" + DropDownListWednesday.SelectedValue + ",";
        }
        if (RadioButtonThur.Checked)
        {
            time = time + "4=" + DropDownListThursday.SelectedValue + ",";
        }
        if (RadioButtonFri.Checked)
        {
            time = time + "5=" + DropDownListFriday.SelectedValue + ",";
        }
        //去除最后一个逗号
        if (time.Length != 0)
        {
            time = time.Substring(0, time.Length - 1);
        }

        Exam ex = new Exam(
            TextBoxID.Text,
            DropDownListCourse.SelectedValue,
            TextBoxDate.Text,
            time,
            DropDownListPlace.SelectedValue,
            DropDownListClass.SelectedValue
            );
        bool success = dao.AddBody(ex, 7);
        if (success) Response.Write("<script>alert('添加成功！')</script>");
        else Response.Write("<script>alert('修改失败！该课程号已存在~')</script>");
    }

    protected void ButtonExit_Click(object sender, EventArgs e)
    {
        Response.Redirect("../ExamInfo.aspx");
    }
}