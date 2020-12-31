using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FileReservationSystem
{
    /*对应数据库中的预约表 T_application*/
    class T_application
    {
        enum App_Satus
        {
            PENDING,            //待处理
            IS_AUTHORIZED,     //已经授权
            REJECT,            //退回：不同意授权
            READY,             //档案已经就绪:待取走
            FILE_LENT          //档案被借走
        }
        //预约号
        public string AppId { get; set; }
        //申请人档案号
        public string TeeCode { get; set; }
        //目标档案号
        public string ObjCode { get; set; }
        //院系管理员档案号
        public string AuthCode { get; set; }
        //申请状态
        public string AppStatus { get; set; }

        //构造函数
        public T_application() { }

        //获取数据
        public bool getData(string teeCode)
        {
            //到数据库中查询
            string sqlStr = string.Format(Globalconst.SELECT_APPLICATION, teeCode);
            try
            {
                DataSet ds = CADOConn.GetDataSet(sqlStr);
                AppId = ds.Tables[0].Rows[0][0].ToString();
                TeeCode = ds.Tables[0].Rows[0][1].ToString();
                ObjCode = ds.Tables[0].Rows[0][2].ToString();
                AuthCode = ds.Tables[0].Rows[0][2].ToString();
                AppStatus = ds.Tables[0].Rows[0][2].ToString();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        
    }
}
