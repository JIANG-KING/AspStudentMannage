using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test;


public partial class TeacherTest_QuerySelectCourse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Teacher t = (Teacher)Session["teacher"];

        SqlConnection sqlConnection = SqlTools.Connection();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(string.Format("select selectcourse.ID as'id',Course.ID as'courseid',course.Name as'coursename',student.ID as'studentid',student.Name as'studentname',Course.Score as'coursescore' from  SelectCourse join course on Course.ID=SelectCourse.Course join student on student.ID=SelectCourse.Student where Course.id in(select id from course where teacher='{0}')",
            t.ID1), sqlConnection);
        DataSet dataSet = new DataSet();
        GridViewQuerySelectCourse.DataKeyNames = new string[] { "id" };
        sqlDataAdapter.Fill(dataSet);
        GridViewQuerySelectCourse.DataSource = dataSet;
        GridViewQuerySelectCourse.DataBind();

        sqlConnection.Close();
    }
}