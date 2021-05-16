using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace test
{

   public class SqlTools
    {

        //static ConnectionPool c = ConnectionPool.getPool();//获取连接池对象
       


       //建立连接
       public static SqlConnection Connection()
        {

            //SqlConnection s = c.getConnection();


            string str = ConfigurationManager.AppSettings["myconnstring"];
            SqlConnection conection = new SqlConnection(str);
            conection.Open();


            return conection;
            //return s;
            
        }

        //创建数据库操作对象
        public static SqlCommand Command(string sql, SqlConnection connection)
        {
            
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            return sqlCommand;

            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "?";
            //cmd.Parameters.AddWithValue("?", sql);
            //cmd.Connection = Connection();
            //return cmd;


        }

        //实现增删改
        public static int Excute(string sql)
        {
            SqlConnection connection = Connection();
            int i= Command(sql,connection).ExecuteNonQuery();
            //CloseConnection(connection);
            return i;

        }

        //查
        public static SqlDataReader Read(string sql)
        {
            //SqlConnection.ClearAllPools();//杀死原来所有进程

            SqlConnection connection = Connection();
            SqlDataReader reader= Command(sql,connection).ExecuteReader();


            //CloseConnection(connection);
            return reader;

            
        }

        //释放连接
        public static void CloseConnection(SqlConnection con)
        {
            //c.closeConnection(con);
            con.Close();
        }


    }
}
