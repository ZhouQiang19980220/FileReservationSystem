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
    public partial class applyForm : Form
    {
        public applyForm()
        {
            InitializeComponent();
        }

        private void applyForm_Load(object sender, EventArgs e)
        {
            textBox_applicant.Text = Program.curUser.IdCode;
        }
        private void button_OK_Click(object sender, EventArgs e)
        {
            string appCode = textBox_applicant.Text;
            string objName = textBox_objname.Text;
            string objCode = textBox_object.Text;
            if (string.IsNullOrEmpty(textBox_objname.Text))
            {
                MessageBox.Show("请输入被借阅人姓名");
                return;
            }
            if (string.IsNullOrEmpty(textBox_object.Text))
            {
                MessageBox.Show("请输入被借阅人姓名");
                return;
            }

            //验证姓名和学号是否匹配
            string sql = string.Format(Globalconst.SELECT_DOCUMENT, textBox_object.Text);
            DataSet ds = CADOConn.GetDataSet(sql);
            //如果查血结果为空
            if(ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("查无此人，请检查档案号是否正确！");
            }
            if(!string.Equals(ds.Tables[0].Rows[0][0].ToString(), textBox_objname.Text))
            {
                MessageBox.Show("姓名和档案号不匹配，请重新输入！");
                return;
            }

            //不能自己借自己的档案
            if (string.Equals(textBox_object.Text, textBox_applicant.Text))
            {
                MessageBox.Show("您没有权限借阅自己的档案！");
                return;
            }

            //获取预约日期
            string data = dateTimePicker_application.Value.ToString("yyyy-MM-dd");

            //这里需要将预约号修改为序列
            //这里需要将授权人改为子查询
            //                                                   申请编号       申请人   被借阅人 授权人        日期
            sql = string.Format(Globalconst.INSERT_APPLICATION, "202012200004", appCode, objCode, "2007030001", data);
            CADOConn.ExecuteSQL(sql);
            MessageBox.Show("添加成功");
            this.Close();
        }

        private void button_cansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
