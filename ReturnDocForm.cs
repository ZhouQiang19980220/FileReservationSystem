using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileReservationSystem
{
    public partial class ReturnDocForm : Form
    {
        public ReturnDocForm()
        {
            InitializeComponent();
        }

        private void ReturnDocForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string objName = textBox_objName.Text;
            string objCode = textBox_ObjCode.Text;
            if (string.IsNullOrEmpty(objName))
            {
                MessageBox.Show("请输入被借阅人姓名！");
                return;
            }
            if (string.IsNullOrEmpty(objCode))
            {
                MessageBox.Show("请输入被借阅人档案号！");
                return;
            }

            //验证姓名和学号是否匹配
            string sql = string.Format(Globalconst.SELECT_DOCUMENT, objCode);
            DataSet ds = CADOConn.GetDataSet(sql);
            //如果查询结果为空
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("查无此人，请检查档案号是否正确！");
                return;
            }
            if (!string.Equals(ds.Tables[0].Rows[0][0].ToString(), objName))
            {
                MessageBox.Show("姓名和档案号不匹配，请重新输入！");
                return;
            }

            //查询此人的档案是否在不在架
            sql = string.Format(Globalconst.SELECT_DOCUMENT_STATUS, objCode);
            ds = CADOConn.GetDataSet(sql);
            string status = ds.Tables[0].Rows[0][0].ToString();
            if(status == Globalconst.ON_SHELF)
            {
                MessageBox.Show("此人的档案在架，无需归还！");
                return;
            }

            //如果所有条件都符合，就执行归还
            //归还：生成事件，维护档案记录
            //这里最后补充原子性操作
            string data = System.DateTime.Now.Date.ToString("yyyyMMdd");
            string sqlStr = string.Format(Globalconst.INSERT_EVENT, Globalconst.LEND, objCode, "", Program.curUser.UserName, data);
            CADOConn.ExecuteSQL(sqlStr);

            sqlStr = string.Format(Globalconst.UPDATE_DOCUMENT, Globalconst.ON_SHELF, objCode);
            CADOConn.ExecuteSQL(sqlStr);

            MessageBox.Show("归档成功！");

            this.Close();

            

        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
