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
    public partial class authorizeForm : Form
    {
        private bool onlyShowPending = false;
        public authorizeForm()
        {
            InitializeComponent();
        }

        //窗口加载时，自动载入数据
        private void authorizeForm_Load(object sender, EventArgs e)
        {
            loadDATA();
        }

        //仅仅显示待处理或者是显示全部
        private void OnlyShowPending()
        {
            if (onlyShowPending)
            {
                button_onlyShowPending.Text = "显示全部记录";
            }
            else
            {
                button_onlyShowPending.Text = "仅显示待处理";
            }
            loadDATA();
        }

        public void loadDATA()
        {
            try
            {
                string sqlStr;
                if (!onlyShowPending)
                {
                    //到数据库中查询
                    sqlStr = string.Format(Globalconst.SELECT_APPLICATION_AUTHO, Program.curUser.IdCode);
                }
                else
                {
                    sqlStr = string.Format(Globalconst.SELECT_APPLICATION_AUTHO_ONLY_SHOW_PEND, Program.curUser.IdCode);
                }
                DataSet ds = CADOConn.GetDataSet(sqlStr);
                dataGridView_authorize.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //同意
        private void button_agree_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridView_authorize.CurrentRow.Index;
            string appId = dataGridView_authorize.Rows[selectedRowIndex].Cells[0].Value.ToString();
            string appStatus = dataGridView_authorize.Rows[selectedRowIndex].Cells[4].Value.ToString();
            if(appStatus.Equals(Globalconst.PENDING))
            {
                string sqlStr = string.Format(Globalconst.UPDATE_APPLICATION, Globalconst.AGREE, appId);
                CADOConn.ExecuteSQL(sqlStr);
                MessageBox.Show("同意授权成功！");
                loadDATA();
            }
            else
            {
                MessageBox.Show("该条记录已经处理过！");
            }

        }

        private void button_disagree_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridView_authorize.CurrentRow.Index;
            string appId = dataGridView_authorize.Rows[selectedRowIndex].Cells[0].Value.ToString();
            string appStatus = dataGridView_authorize.Rows[selectedRowIndex].Cells[4].Value.ToString();
            if (appStatus.Equals(Globalconst.PENDING))
            {
                string sqlStr = string.Format(Globalconst.UPDATE_APPLICATION, Globalconst.DISAGREE, appId);
                CADOConn.ExecuteSQL(sqlStr);
                MessageBox.Show("不同意授权成功！");
                loadDATA();
            }
            else
            {
                MessageBox.Show("该条记录已经处理过！");
            }
        }

        private void button_onlyShowPending_Click(object sender, EventArgs e)
        {
            onlyShowPending = !onlyShowPending;
            OnlyShowPending();
        }
    }
}
