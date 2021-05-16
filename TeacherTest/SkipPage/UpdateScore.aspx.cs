using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test;

public partial class AdminTest_SkipPage_UpdateScore : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //获取要编辑成绩
            string id = Request.QueryString["id"];
            Score sc = (Score)dao.getBody(id, 5);

            TextBoxScore.Text = sc.Scores1;
            TextBoxTime.Text = sc.Submittime;

            //绑定课程号
            TextBoxCourseID.Text = sc.Course1;
            string sqlselectcoursename = string.Format("select name from course where id='{0}'", sc.Course1);
            string coursename = "";
            IDataReader idr = SqlTools.Read(sqlselectcoursename);
            if (idr.Read())
            {
                coursename = idr.GetString(0);
            }
            //绑定课程名
            TextBoxName.Text = coursename;

            //获取所有选择了该课的学生
            SqlConnection sqlConnection = SqlTools.Connection();
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(string.Format("select student.Name from score,student where student.ID=Score.Student and course='{0}'", sc.Course1), sqlConnection);
            DataSet dataSet1 = new DataSet();
            sqlDataAdapter1.Fill(dataSet1);
            //所有系别绑定到学生下拉框
            DropDownListStudent.DataSource = dataSet1;
            DropDownListStudent.DataTextField = "name";
            DropDownListStudent.DataBind();
            //下拉框选中该成绩学生
            DropDownListStudent.SelectedValue = sc.Student1;

        }

        //不能改
        TextBoxCourseID.Enabled = false;
        DropDownListStudent.Enabled = false;
        TextBoxName.Enabled = false;


    }

    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        //修改数据库中的数据
        Score sc = new Score(
            Request.QueryString["id"],
            DropDownListStudent.SelectedValue,
            TextBoxName.Text,
            TextBoxScore.Text,
            TextBoxTime.Text,
            "目前未实现"
            );
        bool success = dao.UpdateBody(sc, 5);
        if (success) Response.Write("<script>alert('修改成功！')</script>");
        else Response.Write("<script>alert('修改失败！')</script>");
    }

    protected void ButtonExit_Click(object sender, EventArgs e)
    {
        Response.Redirect("../ScoreInfo.aspx");
    }
}