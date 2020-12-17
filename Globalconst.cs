using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReservationSystem
{
    //本类用来存储全部常量
    public class Globalconst
    {
        //连接字符串:用来连接数据库
        public const string CONN_STR = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=166.111.68.220)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=dbta)));Persist Security Info=True;User ID=s2017011616;Password=zq1518376556;";

        //用于提示
        public const string PLEASE_INPUT_USERNAME = "请输入用户名";
        public const string PLEASE_INPUT_PASSWORD = "请输入密码";
    }
}
