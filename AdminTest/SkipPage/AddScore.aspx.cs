using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test;


public partial class AdminTest_SkipPage_AddScore : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SqlConnection sqlConnection = SqlTools.Connection();

            //获取所有课程号
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter("select * from course", sqlConnection);
            DataSet dataSet1 = new DataSet();
            sqlDataAdapter1.Fill(dataSet1);

            //所有课程号绑定到课程号下拉框
            DropDownListCourseId.DataSource = dataSet1;
            DropDownListCourseId.DataTextField = "id";
            DropDownListCourseId.DataBind();

            //课程名根据课程号变化
            //1.获取课程号下拉框对应的课程名
            string sqlselectcoursename = string.Format("select name from course where id ='{0}'", DropDownListCourseId.SelectedValue);
            string coursename = "";
            IDataReader idr = SqlTools.Read(sqlselectcoursename);
            if (idr.Read())
            {
                coursename = idr.GetString(0);
            }
            //绑定课程名
            TextBoxCourseName.Text = coursename;

            //学生集根据课程号变化
            //1.获取课程号获取选择了该课程的所有学生
            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(string.Format("select name from student left join SelectCourse on selectcourse.student=student.id where course='{0}'", DropDownListCourseId.Text), sqlConnection);
            DataSet dataSet2 = new DataSet();
            sqlDataAdapter2.Fill(dataSet2);
            //所有系别绑定到学生下拉框
            DropDownListStudent.DataSource = dataSet2;
            DropDownListStudent.DataTextField = "name";
            DropDownListStudent.DataBind();

            sqlConnection.Close();

        }
        TextBoxCourseName.Enabled = false;
    }

    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        //修改数据库中的数据
        Score sc = new Score(
            Request.QueryString["id"],
            DropDownListStudent.SelectedValue,
            DropDownListCourseId.Text,
            TextBoxScore.Text,
            TextBoxTime.Text,
            "目前未实现"
            );
        bool success = dao.AddBody(sc, 5);
        if (success) Response.Write("<script>alert('添加成功！')</script>");
        else Response.Write("<script>alert('修改失败！该成绩已存在~')</script>");
    }

    protected void ButtonExit_Click(object sender, EventArgs e)
    {
        Response.Redirect("../ScoreInfo.aspx");
    }

    //每改变一次课程号，课程名和选课学生就得跟着变
    protected void DropDownListCourseId_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlConnection sqlConnection = SqlTools.Connection();
        //课程名根据课程号变化
        //1.获取课程号下拉框对应的课程名
        string sqlselectcoursename = string.Format("select name from course where id ='{0}'", DropDownListCourseId.SelectedValue);
        string coursename = "";
        IDataReader idr = SqlTools.Read(sqlselectcoursename);
        if (idr.Read())
        {
            coursename = idr.GetString(0);
        }
        //绑定课程名
        TextBoxCourseName.Text = coursename;

        //学生集根据课程号变化
        //1.获取课程号获取选择了该课程的所有学生
        SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(string.Format("select name from student left join SelectCourse on selectcourse.student=student.id where course='{0}'", DropDownListCourseId.Text), sqlConnection);
        DataSet dataSet2 = new DataSet();
        sqlDataAdapter2.Fill(dataSet2);
        //所有系别绑定到学生下拉框
        DropDownListStudent.DataSource = dataSet2;
        DropDownListStudent.DataTextField = "name";
        DropDownListStudent.DataBind();
    }
}