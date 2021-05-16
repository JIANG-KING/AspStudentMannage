using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test;


public partial class AdminTest_ExamInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection sqlConnection = SqlTools.Connection();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select exam.*,Course.name,ClassInfo.Name as'classname' from exam left join Course on Exam.Course=Course.ID join ClassInfo on exam.ClassInfo=ClassInfo.id", sqlConnection);
        DataSet dataSet = new DataSet();
        GridViewExamInfo.DataKeyNames = new string[] { "id" };
        sqlDataAdapter.Fill(dataSet);
        GridViewExamInfo.DataSource = dataSet;
        GridViewExamInfo.DataBind();

        sqlConnection.Close();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("./SkipPage/AddExam.aspx");
    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        string id = GridViewExamInfo.DataKeys[e.NewEditIndex].Value.ToString();
        Response.Redirect("./SkipPage/UpdateExam.aspx?id=" + id);
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string id = GridViewExamInfo.DataKeys[e.RowIndex].Value.ToString();
        bool success = dao.DeleteBody(id, 7);
        if (success)
        {
            Response.Write("<script>alert('删除成功！')</script>");

            //刷新该页面
            SqlConnection sqlConnection = SqlTools.Connection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select exam.*,Course.name,ClassInfo.Name as'classname' from exam left join Course on Exam.Course=Course.ID join ClassInfo on exam.ClassInfo=ClassInfo.id", sqlConnection);
            DataSet dataSet = new DataSet();
            GridViewExamInfo.DataKeyNames = new string[] { "id" };
            sqlDataAdapter.Fill(dataSet);
            GridViewExamInfo.DataSource = dataSet;
            GridViewExamInfo.DataBind();

            sqlConnection.Close();


            sqlConnection.Close();
        }
        else Response.Write("<script>alert('删除失败！')</script>");
    }
}