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

        //预约表的5中状态
        public const string PENDING = "待处理";
        public const string AGREE = "同意授权";
        public const string DISAGREE = "退回";
        public const string READY = "档案已就绪";
        public const string SUCCESS = "档案已借阅";

        //档案状态
        public const string ON_SHELF = "0";
        public const string NOT_ON_SHELF = "1";


        //SQL查询语句
        //查询用户表
        public const string SELECT_USER = "select * from t_user where userId = '{0}'";
        //查询我的预约
        public const string SELECT_APPLICATION = "select app.APPID 预约号," +
                                                 " doc1.stu_name || '(' || app.teecode || ')'   申请人, " +
                                                 " doc2.stu_name || '(' || app.objcode || ')'   被借阅人," +
                                                 " doc3.stu_name || '(' || app.authcode || ')'   院系管理员," +
                                                 " app.appstatus 处理状态，" +
                                                 " app.time 预约时间" +
                                                 " from t_application app, t_document doc1, t_document doc2, t_document doc3" +
                                                 " where app.teecode = '{0}'" +
                                                 " and app.teecode = doc1.document_code" +
                                                 " and app.objcode = doc2.document_code" +
                                                 " and app.authcode = doc3.document_code";

        //删除某条预约记录
        public const string DELETE_APPLICATION = "delete from t_application where appid = '{0}'";

        //根据档案号查姓名
        public const string SELECT_DOCUMENT = "select stu_name from t_document where document_code = '{0}'";

        //插入新增的申请
        public const string INSERT_APPLICATION = "INSERT INTO T_APPLICATION(APPID, TEECODE, OBJCODE, AUTHCODE, APPSTATUS, TIME) " + 
                                                 "VALUES('{0}', '{1}', '{2}', '{3}', '待处理', TO_DATE('{4}', 'YYYY-MM-DD'))";

        //院系管理员查询预约
        public const string SELECT_APPLICATION_AUTHO = "select app.APPID 预约号," +
                                                       " doc1.stu_name || '(' || app.teecode || ')'   申请人, " +
                                                       " doc2.stu_name || '(' || app.objcode || ')'   被借阅人," +
                                                       " doc3.stu_name || '(' || app.authcode || ')'   院系管理员," +
                                                       " app.appstatus 处理状态，" +
                                                       " app.time 预约时间" +
                                                       " from t_application app, t_document doc1, t_document doc2, t_document doc3" +
                                                       " where app.authcode = '{0}'" +
                                                       " and app.teecode = doc1.document_code" +
                                                       " and app.objcode = doc2.document_code" +
                                                       " and app.authcode = doc3.document_code";
        //院系管理员查询预约：仅仅显示待处理
        public const string SELECT_APPLICATION_AUTHO_ONLY_SHOW_PEND = "select app.APPID 预约号," +
                                                                      " doc1.stu_name || '(' || app.teecode || ')'   申请人, " +
                                                                      " doc2.stu_name || '(' || app.objcode || ')'   被借阅人," +
                                                                      " doc3.stu_name || '(' || app.authcode || ')'   院系管理员," +
                                                                      " app.appstatus 处理状态，" +
                                                                      " app.time 预约时间" +
                                                                      " from t_application app, t_document doc1, t_document doc2, t_document doc3" +
                                                                      " where app.authcode = '{0}'" +
                                                                      " and app.teecode = doc1.document_code" +
                                                                      " and app.objcode = doc2.document_code" +
                                                                      " and app.authcode = doc3.document_code" +
                                                                      " and app.appstatus = '" + Globalconst.PENDING + "'";

        //档案管理员查询：显示同意授权
        public const string SELECT_APPLICATION_ADMIN_ONLY_SHOW_AGREE = "select app.APPID 预约号," +
                                                                      " doc1.stu_name || '(' || app.teecode || ')'   申请人, " +
                                                                      " doc2.stu_name || '(' || app.objcode || ')'   被借阅人," +
                                                                      " doc3.stu_name || '(' || app.authcode || ')'   院系管理员," +
                                                                      " app.appstatus 处理状态，" +
                                                                      " app.time 预约时间" +
                                                                      " from t_application app, t_document doc1, t_document doc2, t_document doc3" +
                                                                      " where app.teecode = doc1.document_code" +
                                                                      " and app.objcode = doc2.document_code" +
                                                                      " and app.authcode = doc3.document_code" +
                                                                      " and app.appstatus = '" + Globalconst.AGREE + "'";

        //更新预约表
        public const string UPDATE_APPLICATION = "update t_application set appstatus = '{0}' where appid = '{1}'";

        //管理员更新档案状态
        public const string UPDATE_DOCUMENT = "update t_document set status = '{0}' where document_code = '{1}'";
    }
}
