using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test;
public partial class AdminTest_ScoreInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection sqlConnection = SqlTools.Connection();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select score.id,Score.SubmitTime,Score.Score,Course.Name,student.Name as'studentname' from score left join student on Score.Student=student.ID join Course on Score.Course=Course.ID", sqlConnection);
        DataSet dataSet = new DataSet();
        GridViewScore.DataKeyNames = new string[] { "id" };
        sqlDataAdapter.Fill(dataSet);
        GridViewScore.DataSource = dataSet;
        GridViewScore.DataBind();

        sqlConnection.Close();
    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        string id = GridViewScore.DataKeys[e.NewEditIndex].Value.ToString();
        Response.Redirect("./SkipPage/UpdateScore.aspx?id=" + id);
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string id = GridViewScore.DataKeys[e.RowIndex].Value.ToString();
        bool success = dao.DeleteBody(id, 5);
        if (success)
        {
            Response.Write("<script>alert('删除成功！')</script>");

            //刷新该页面
            SqlConnection sqlConnection = SqlTools.Connection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select score.id,Score.SubmitTime,Score.Score,Course.Name,student.Name as'studentname' from score left join student on Score.Student=student.ID join Course on Score.Course=Course.ID", sqlConnection);
            DataSet dataSet = new DataSet();
            GridViewScore.DataKeyNames = new string[] { "id" };
            sqlDataAdapter.Fill(dataSet);
            GridViewScore.DataSource = dataSet;
            GridViewScore.DataBind();

            sqlConnection.Close();
        }
        else Response.Write("<script>alert('删除失败！')</script>");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("./SkipPage/AddScore.aspx");
    }
}