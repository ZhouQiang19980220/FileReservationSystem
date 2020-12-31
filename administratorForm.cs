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
    public partial class administratorForm : Form
    {
        public administratorForm()
        {
            InitializeComponent();
        }

        //载入数据
        private void administratorForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            try
            {
                //到数据库中查询
                string sqlStr = string.Format(Globalconst.SELECT_APPLICATION_ADMIN_ONLY_SHOW_AGREE);
                DataSet ds = CADOConn.GetDataSet(sqlStr);
                dataGridView_admin.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //维护状态：确定档案是已经借出去了
        private void button_lend_Click(object sender, EventArgs e)
        {

            if(dataGridView_admin.CurrentRow == null)
            {
                MessageBox.Show("什么都没选中！");
                return;
            }
            int select_index = dataGridView_admin.CurrentRow.Index;
            string appid = dataGridView_admin.Rows[select_index].Cells[0].Value.ToString();
            string objNameCode = dataGridView_admin.Rows[select_index].Cells[2].Value.ToString();
            string[] temp = objNameCode.Split('(');
            string objCode = temp[1];
            objCode = objCode.Substring(0, 10);

            //更新档案状态
            string sqlStr = string.Format(Globalconst.UPDATE_DOCUMENT, Globalconst.NOT_ON_SHELF, objCode);
            CADOConn.ExecuteSQL(sqlStr);

            //更新预约状态
            sqlStr = string.Format(Globalconst.UPDATE_APPLICATION, Globalconst.SUCCESS, appid);
            CADOConn.ExecuteSQL(sqlStr);

            MessageBox.Show("存档成功!");

            loadData();
        }

        //退出
        private void button_exit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("确定退出?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
