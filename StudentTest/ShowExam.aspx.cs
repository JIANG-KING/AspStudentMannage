using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test;

public partial class StudentTest_ShowExam : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Student Stu = (Student)Session["student"];
        SqlConnection sqlConnection = SqlTools.Connection();
        string sql = string.Format(@" select * from Exam where ClassInfo='{0}'", Stu.Class1.ToLower().Trim());
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
        DataSet dataSet = new DataSet();
        GridViewShowExam.DataKeyNames = new string[] { "id" };
        sqlDataAdapter.Fill(dataSet);
        sqlConnection.Close();
        GridViewShowExam.DataSource = dataSet;
        GridViewShowExam.DataBind();
        for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)//将教师编号替换为教师姓名
        {
            string s = dataSet.Tables[0].Rows[i]["Course"].ToString();
            Course course = (Course)dao.getBody(s, 4);
            ClassRoom cl = (ClassRoom)dao.getBody(dataSet.Tables[0].Rows[i]["Place"].ToString(), 6);
            ClassInfo classInfo = (ClassInfo)dao.getBody(dataSet.Tables[0].Rows[i]["ClassInfo"].ToString(), 9);
            string s2 = dataSet.Tables[0].Rows[i]["Time"].ToString();
            string[] dayAndNode = s2.Split(',');
            string CourseInfo = "";
            for (int j = 0; j < dayAndNode.Length; j++)
            {
                CourseInfo += AlterString.outString(dayAndNode[j]) + "\n";
            }


            
            dataSet.Tables[0].Rows[i]["Time"] = CourseInfo;
            dataSet.Tables[0].Rows[i]["Place"] = cl.Number;
            dataSet.Tables[0].Rows[i]["Classinfo"] = classInfo.Name; //循环修改列传值
        }
        dataSet.AcceptChanges();
        GridViewShowExam.DataSource = dataSet;
        GridViewShowExam.DataBind();

        for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)//将教师编号替换为教师姓名
        {
            string s = dataSet.Tables[0].Rows[i]["Course"].ToString();
            Course course = (Course)dao.getBody(s, 4);
            GridViewShowExam.Rows[i].Cells[2].Text = course.Name;
        }
    }
}