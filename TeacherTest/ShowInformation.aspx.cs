using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test;

public partial class StudentTest_ShowInformation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Session["informationid"].ToString();
        SqlConnection sqlConnection = SqlTools.Connection();
        string sql = string.Format(@"select *  from PublicInformation where id={0}", id);
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection); ;
        DataSet dataSet = new DataSet();
         sqlDataAdapter.Fill(dataSet);
        sqlConnection.Close();
        //dataSet.Tables[0].Rows[0]["ClassInfo"].ToString();
        this.TextBoxTitle.Text = dataSet.Tables[0].Rows[0]["Title"].ToString(); 
        TextBoxText.Text = dataSet.Tables[0].Rows[0]["News"].ToString(); 
        TextBoxSender.Text = dataSet.Tables[0].Rows[0]["SubmitPerson"].ToString(); 
        TextBoxTime.Text = dataSet.Tables[0].Rows[0]["Time"].ToString(); 

    }
}