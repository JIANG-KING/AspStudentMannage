using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test;

public partial class StudentTest_ShowScore : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Student Stu = (Student)Session["student"];
        SqlConnection sqlConnection = SqlTools.Connection();
        string sql = string.Format(@" select * from Score where student='{0}'", Stu.ID1);
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
        DataSet dataSet = new DataSet();
        GridViewShowScore.DataKeyNames = new string[] { "id" };
        sqlDataAdapter.Fill(dataSet);
        sqlConnection.Close();



        
        GridViewShowScore.DataSource = dataSet;
        GridViewShowScore.DataBind();
        for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)//将教师编号替换为教师姓名
        {
            string s = dataSet.Tables[0].Rows[i]["Course"].ToString();
            Course course = (Course)dao.getBody(s, 4);
            GridViewShowScore.Rows[i].Cells[2].Text = course.Name; //循环修改列传值
            GridViewShowScore.Rows[i].Cells[3].Text = course.Score;
        }
    }
}