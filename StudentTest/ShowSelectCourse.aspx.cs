using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test;

public partial class StudentTest_ShowSelectCourse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Student Stu = (Student)Session["student"];
        SqlConnection sqlConnection = SqlTools.Connection();
        string sql = string.Format(@"select course  from SelectCourse where Student={0}", Stu.ID1);
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection); ;
        DataSet dataSet = new DataSet();
        sqlDataAdapter.Fill(dataSet);
        sqlConnection.Close();
        int count = 0;
        Course[] course = new Course[dataSet.Tables[0].Rows.Count];//存储所有课程信息
        foreach (DataRow col in dataSet.Tables[0].Rows)//获取全部选课的课程号
        {
            course[count] = (Course)dao.getBody(col["course"].ToString(), 4); ;
            count++;
        }
        for(int i = 0; i < count; i++)//将字符串节次转换文字
        {
            string[] dayAndNode = course[i].Time.Split(',');
            string CourseInfo="";
            for(int j = 0; j < dayAndNode.Length; j++)
            {
                CourseInfo += AlterString.outString(dayAndNode[j])+ "<Br>";
            }
            course[i].Time = CourseInfo;
            string Teacher = "";
            Teacher tea=  (Teacher)dao.getBody(course[i].Teacher, 2); ;
            Teacher = tea.Name1;
            course[i].Teacher = Teacher;
            string s = course[i].Place;
            ClassRoom classRoom = (ClassRoom)dao.getBody(s, 6); ;
            course[i].Place = classRoom.Number; //循环修改列传值
        }
        DataTable dt = new DataTable();//实例化一个空数据源        
        for (int k = 0; k < count; k++)//要添加的行数
        {
            DataRow dr = dt.NewRow();
            dt.Rows.Add(dr);
        }
        GridViewShowSelectCourse.DataSource = dt;
        GridViewShowSelectCourse.DataBind();
        for(int i = 0; i < count; i++)
        {
            GridViewShowSelectCourse.Rows[i].Cells[0].Text = course[i].ID;
            GridViewShowSelectCourse.Rows[i].Cells[1].Text = course[i].Name;
            GridViewShowSelectCourse.Rows[i].Cells[2].Text = course[i].Teacher;
            GridViewShowSelectCourse.Rows[i].Cells[3].Text = course[i].Date;
            GridViewShowSelectCourse.Rows[i].Cells[4].Text = course[i].Time;
            GridViewShowSelectCourse.Rows[i].Cells[5].Text = course[i].Week;
            GridViewShowSelectCourse.Rows[i].Cells[6].Text = course[i].Place;
            GridViewShowSelectCourse.Rows[i].Cells[7].Text = course[i].Score;
        }
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Student Stu = (Student)Session["student"];
        string ID = GridViewShowSelectCourse.SelectedRow.Cells[0].Text;
        string sql2 = string.Format(@" delete from SelectCourse where student='{0}'and course='{1}'", Stu.ID1, ID);
        int i = SqlTools.Excute(sql2);
        if (i == 1)
        {
            Response.Write("<script>alert('退选成功~')</script>");
            Page_Load(sender,e);
        }
        else
        {
            Response.Write("<script>alert('退选失败~')</script>");
        }
    }
}