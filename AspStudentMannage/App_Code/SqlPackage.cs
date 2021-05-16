using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AspStudentMannage.App_Code
{
    public class SqlPackage
    {
        //读取web.config配置文件 数据库连接字符串
        private static readonly string connString = ConfigurationManager.
            ConnectionStrings["SqlLibraryMS"].ConnectionString;

        /// <summary>
        /// 执行增删改操作
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="commandParams"></param>
        /// <returns>影响的行数</returns>
        public static int ExecNonQuery(string sql, params SqlParameter[] commandParams)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand();
                PreParedCommand(sql, commandParams, conn, cmd);
                return cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 执行查询并返回第一行第一列的值
        /// </summary>
        /// <param name="sql">查询语句 不能为空</param>
        /// <param name="commandParams">参数数组  可以为空</param>
        /// <returns>第一行第一列的值</returns>
        public static object ExecScalar(string sql, params SqlParameter[] commandParams)
        {
            //创建数据库连接对象  执行完后自动释放资源
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand();
                PreParedCommand(sql, commandParams, conn, cmd);
                return cmd.ExecuteScalar();
            }
        }

        /// <summary>
        /// 执行查询的方法 必须保存数据库连接状态才能读取数据
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="commandParams"></param>
        /// <returns>SqlDataReader对象</returns>
        public static SqlDataReader ExecDataReader(string sql, params SqlParameter[] commandParams)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            PreParedCommand(sql, commandParams, conn, cmd);
            //CommandBehavior.CloseConnection 当dataReader对象关闭 则自动关闭connection对象
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        /// <summary>
        /// 断开式读取数据
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="commandParams"></param>
        /// <returns>DataSet</returns>
        public static DataSet ExecDataSet(string sql, params SqlParameter[] commandParams)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand();
                PreParedCommand(sql, commandParams, conn, cmd);

                //创建适配器对象
                using (SqlDataAdapter dap = new SqlDataAdapter())
                {
                    dap.SelectCommand = cmd; //适配器对象关联command对象
                    DataSet ds = new DataSet();
                    dap.Fill(ds);//填充数据到dataset对象保存
                    return ds;
                }
            }
        }


        /// <summary>
        /// 给command对象属性赋值
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="commandParams"></param>
        /// <param name="conn"></param>
        /// <param name="cmd"></param>
        private static void PreParedCommand(string sql, SqlParameter[] commandParams, SqlConnection conn, SqlCommand cmd)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.CommandText = sql;//设置执行的SQL语句
            cmd.Connection = conn;//关联已连接的数据库对象

            if (commandParams != null)//判断参数数组不为空则
            {
                //遍历每一个参数 并添加到command对象的Parameters属性接收
                foreach (SqlParameter sp in commandParams)
                {
                    cmd.Parameters.Add(sp);
                }
            }
        }
    }
}