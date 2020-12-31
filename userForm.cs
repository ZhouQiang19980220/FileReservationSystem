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
    public partial class userForm : Form
    {
        public userForm()
        {
            InitializeComponent();
        }

        //窗口加载时，根据当前登陆用户自动显示我的预约列表
        private void userForm_Load(object sender, EventArgs e)
        {
            //只有院系管理员才有的按钮
            if(Program.curUser.userType == User.UserType.CAN_ANTHORIZE)
            {
                button_lookAuthorizeApp.Visible = true;
            }
            else
            {
                button_lookAuthorizeApp.Visible = false;
            }
            loadDATA();
        }

        //将用户预约表加载到主窗口中
        public void loadDATA()
        {
            try
            {
                //到数据库中查询
                string sqlStr = string.Format(Globalconst.SELECT_APPLICATION, Program.curUser.IdCode);
                DataSet ds = CADOConn.GetDataSet(sqlStr);
                dataGridView_application.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //删除按钮
        private void button_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要删除本条记录？", "警告！", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if(dataGridView_application.CurrentRow == null)
                {
                    MessageBox.Show("什么都没选中！");
                    return;
                }
                int selectedRowIndex = dataGridView_application.CurrentRow.Index;
                string appId = dataGridView_application.Rows[selectedRowIndex].Cells[0].Value.ToString();
                string sqlStr = string.Format(Globalconst.DELETE_APPLICATION, appId);
                CADOConn.ExecuteSQL(sqlStr);
                loadDATA();
            }
        }

        private void dataGridView_application_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        //新增预约
        private void button_application_Click(object sender, EventArgs e)
        {
            applyForm af = new applyForm();
            af.ShowDialog();
            loadDATA();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定关闭吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        //查看授权申请界面
        private void button_lookAuthorizeApp_Click(object sender, EventArgs e)
        {
            authorizeForm af = new authorizeForm();
            af.ShowDialog();
        }
    }
}
