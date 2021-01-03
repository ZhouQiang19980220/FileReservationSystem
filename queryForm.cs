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
    public partial class queryForm : Form
    {
        public queryForm()
        {
            InitializeComponent();
        }

        //窗口载入时，在TextBox中增加提示
        private void queryForm_Load(object sender, EventArgs e)
        {
            //设置提示
            Win32Utility.SetCueText(textBox_name, Globalconst.PLEASE_INPUT_NAME);
            Win32Utility.SetCueText(textBox_code, Globalconst.PLEASE_INPUT_CODE);
        }


        //查询按钮：姓名支持模糊查询
        //当前仅仅支持借档案事件查询
        private void button_query_Click(object sender, EventArgs e)
        {
            string name = "%" + textBox_name.Text.ToString() + "%";
            string code = textBox_code.Text.ToString();
            string sqlStr;

            if (string.IsNullOrEmpty(code))
            {
                sqlStr = string.Format(Globalconst.SELECT_EVENT, name, '%');
            }
            else
            {
                sqlStr = string.Format(Globalconst.SELECT_EVENT, name, code);
            }
            DataSet ds = CADOConn.GetDataSet(sqlStr);
            dataGridView_queryResult.DataSource = ds.Tables[0];
        }
    }
}
