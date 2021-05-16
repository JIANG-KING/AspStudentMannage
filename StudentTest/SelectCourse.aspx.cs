using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test;

public partial class StudentTest_SelectCourse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection sqlConnection = SqlTools.Connection();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from course", sqlConnection);
        DataSet dataSet = new DataSet();
        GridViewSelectCourse.DataKeyNames = new string[] { "id" };
        sqlDataAdapter.Fill(dataSet);
        for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)//将上课节次编号替换为上课节次
        {
            string s = dataSet.Tables[0].Rows[i]["Time"].ToString();

                string[] dayAndNode = s.Split(',');
                string CourseInfo = "";
                for (int j = 0; j < dayAndNode.Length; j++)
                {
                    CourseInfo += AlterString.outString(dayAndNode[j]) + "\n";
                }
                s = CourseInfo;
            dataSet.Tables[0].Rows[i][4] = s; //循环修改列传值
            string s2 = dataSet.Tables[0].Rows[i]["Place"].ToString();
            ClassRoom classRoom = (ClassRoom)dao.getBody(s2, 6); ;
            dataSet.Tables[0].Rows[i]["Place"] = classRoom.Number; //循环修改列传值
            string s3 = dataSet.Tables[0].Rows[i]["Teacher"].ToString();
            Teacher tea = (Teacher)dao.getBody(s3, 2); ;
            dataSet.Tables[0].Rows[i]["Teacher"] = tea.Name1; //循环修改列传值
        }
        dataSet.AcceptChanges();//这句最关键,完成修改,做用是允许对DATASET的修改
        GridViewSelectCourse.DataSource = dataSet;
        GridViewSelectCourse.DataBind();
        sqlConnection.Close();

    }




    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Student Stu = (Student)Session["student"];
        string ID=GridViewSelectCourse.SelectedValue.ToString();
        SqlConnection sqlConnection = SqlTools.Connection();
        string sql = string.Format(@"select course  from SelectCourse where Student={0}", Stu.ID1);
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection); ;
        DataSet dataSet = new DataSet();
        sqlDataAdapter.Fill(dataSet);
        sqlConnection.Close();
        String[] CourseId = new string[dataSet.Tables[0].Rows.Count];
        int count = 0;
        foreach (DataRow col in dataSet.Tables[0].Rows)//获取全部选课的课程号
        {
            CourseId[count] = col["course"].ToString();
            count++;
        }
        if (CourseId.Contains(ID))
        {
            Response.Write("<script>alert('选课失败！已经选择该课~')</script>");
        }
        else
        {
            string sql2 = string.Format(@"insert into SelectCourse values('{0}','{1}')", Stu.ID1, ID);
            int i = SqlTools.Excute(sql2);
            if(i==1) Response.Write("<script>alert('选课成功~')</script>");
            else
            {
                Response.Write("<script>alert('选课失败~')</script>");
            }
        }


    }
}
