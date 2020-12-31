using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace FileReservationSystem
{
    /*用户类：用来对应数据库中的T_User*/
    class User
    {
        //用户类型
        public enum UserType:int
        {
            ORDINARY_TYPE = 0,      //普通用户
            CAN_ANTHORIZE = 1,      //可以授权用户
            ADMIN = 2               //管理员
        }
        //用户名
        public string UserName { get; set; }
        //密码
        public string Password { get; set; }
        //档案号
        public string IdCode { get; set; }
        //用户类型
        public UserType userType { get; set; }

        //构造函数
        public User(string userName = "", string password = "", string idCode = "", string UserType = null)
        {
            this.UserName = userName;
            this.Password = password;
            this.IdCode = idCode;

            this.userType = (UserType)Convert.ToInt32(UserType);
                    
        }

        //将数据读取到当前对象中
        public bool GetData(string userName)
        {
            //到数据库中查询
            string sqlStr = string.Format(Globalconst.SELECT_USER, userName);
            try
            {
                DataSet ds = CADOConn.GetDataSet(sqlStr);
                UserName = ds.Tables[0].Rows[0][0].ToString();
                Password = ds.Tables[0].Rows[0][1].ToString();
                IdCode = ds.Tables[0].Rows[0][2].ToString();
                userType = (UserType)Convert.ToInt32(ds.Tables[0].Rows[0][3].ToString());
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

    }
}
