using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test;

public partial class StudentTest_ShowPublicInformation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Teacher Tea = (Teacher)Session["teacher"];
        SqlConnection sqlConnection = SqlTools.Connection();
        string sql = string.Format(@"select *  from PublicInformation where Receiver='全部' or Receiver='全体老师' or Receiver='{0}'", Tea.ID1);
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection); ;
        DataSet dataSet = new DataSet();
        sqlDataAdapter.Fill(dataSet);
        sqlConnection.Close();
        GridViewInformation.DataKeyNames = new string[] { "id" };
        GridViewInformation.DataSource = dataSet;
        

        GridViewInformation.DataBind();
        for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)//添加序号
        {
            GridViewInformation.Rows[i].Cells[0].Text = (i+1).ToString();

        }
    }

    protected void GridViewInformation_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["informationid"] = GridViewInformation.DataKeys[GridViewInformation.SelectedIndex].Value.ToString();
        Response.Redirect("~/TeacherTest/ShowInformation.aspx", true);
    }
}