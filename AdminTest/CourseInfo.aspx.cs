using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test;

public partial class AdminTest_ClassInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection sqlConnection = SqlTools.Connection();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select Course.id ,Course.Name as'coursename',Teacher.Name as'teachername',Course.Date,course.time,place,week,Score from Course left join Teacher on Course.Teacher=Teacher.id", sqlConnection);
        DataSet dataSet = new DataSet();
        GridViewCourse.DataKeyNames = new string[] { "id" };
        sqlDataAdapter.Fill(dataSet);
        GridViewCourse.DataSource = dataSet;
        GridViewCourse.DataBind();

        sqlConnection.Close();
    }



    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        string id = GridViewCourse.DataKeys[e.NewEditIndex].Value.ToString();
        Response.Redirect("./SkipPage/UpdateCourse.aspx?id=" + id);
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

        string id = GridViewCourse.DataKeys[e.RowIndex].Value.ToString();
        bool success = dao.DeleteBody(id, 4);
        if (success)
        {
            Response.Write("<script>alert('删除成功！')</script>");

            //刷新该页面
            SqlConnection sqlConnection = SqlTools.Connection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select Course.id ,Course.Name as'coursename',Teacher.Name as'teachername',Course.Date,course.time,place,week,Score from Course left join Teacher on Course.Teacher=Teacher.id", sqlConnection);
            DataSet dataSet = new DataSet();
            GridViewCourse.DataKeyNames = new string[] { "id" };
            sqlDataAdapter.Fill(dataSet);
            GridViewCourse.DataSource = dataSet;
            GridViewCourse.DataBind();


            sqlConnection.Close();
        }
        else Response.Write("<script>alert('删除失败！')</script>");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("./SkipPage/AddCourse.aspx");
    }
}