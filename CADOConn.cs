using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Windows.Forms;


namespace FileReservationSystem
{   //本类用来封装数据库底层接口
    class CADOConn
    {
        //用于连接Oracle数据库
        static private OracleConnection conn;
        //连接字符串
        static private string connStr = Globalconst.CONN_STR;
        //用于执行SQL语句
        static private OracleCommand cmd;

        //构造函数
        public CADOConn()
        {
            conn = new OracleConnection(connStr);
        }

        //打开数据库连接，主要是鲁棒性判断
        public static void openConn()
        {
            try
            {
                //如果没有连接，则先建立连接
                if (conn == null)
                {
                    conn = new OracleConnection(connStr);
                }
                //如果当前状态是关闭，则打开连接
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        //用于执行查询语句
        public static DataSet GetDataSet(string sql)
        {
            try
            {
                openConn();
                //定义OracleCommand对象，用来执行SQL语句
                cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                //执行
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                oracleDataAdapter.Fill(ds);

                conn.Close();
                return ds;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        //执行非查询语言
        public static bool ExecuteSQL(string sql)
        {
            try
            {
                openConn();
                cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                if(result == -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
