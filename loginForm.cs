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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }
        //载入主窗口时，自动连接数据库
        private void main_Load(object sender, EventArgs e)
        {
            comboBox_userType.SelectedIndex = 0;
            try
            {
                CADOConn.openConn();
            }
            catch(Exception ex)
            {
                MessageBox.Show("数据库连接失败，原因如下：" + ex.Message, "提示");
                Application.Exit();
            }

            //设置提示
            Win32Utility.SetCueText(textBox_user, Globalconst.PLEASE_INPUT_USERNAME);
            Win32Utility.SetCueText(textBox_password, Globalconst.PLEASE_INPUT_PASSWORD);
        }

        //登陆按钮
        private void button_login_Click(object sender, EventArgs e)
        {
            string userName = textBox_user.Text;
            string password = textBox_password.Text;
            User.UserType userType;
            //如果用户名为空
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("请输入用户名！");
                textBox_user.Focus();
                return;
            }
            //如果密码为空
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("请输入密码！");
                textBox_password.Focus();
                return;
            }
            //如果没有选择用户类型
            if(comboBox_userType.SelectedIndex == -1)
            {
                MessageBox.Show("请选择用户类型！");
                comboBox_userType.Focus();
                return;
            }
            //根据选择的用户类型设置UserType
            else
            {
                userType = (User.UserType)comboBox_userType.SelectedIndex;
            }

            //数据库中没有查询到任何记录
            if (!Program.curUser.GetData(userName))
            {
                MessageBox.Show("用户名输入错误！");
                textBox_user.Focus();
                return;
            }
            else
            {
                if (Program.curUser.Password != password || Program.curUser.userType != userType)
                {
                    MessageBox.Show("用户名或者密码或者用户类型错误！");
                    textBox_user.Focus();
                    return;
                }
                else
                {
                    MessageBox.Show("登陆成功！");
                    this.Hide();
                    if(userType == User.UserType.ORDINARY_TYPE || userType == User.UserType.CAN_ANTHORIZE)
                    {
                        userForm uf = new userForm();
                        uf.ShowDialog();
                    }
                    else
                    {
                        administratorForm af = new administratorForm();
                        af.ShowDialog();
                    }
                    Application.ExitThread();
                }
            }
        }

        //退出按钮
        private void button_cansel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("您确定关闭吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
