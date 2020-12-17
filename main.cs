﻿using System;
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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        //载入主窗口时，自动连接数据库
        private void main_Load(object sender, EventArgs e)
        {
            try
            {
                CADOConn.openConn();
            }
            catch(Exception ex)
            {
                MessageBox.Show("数据库连接失败，原因如下：" + ex.Message, "提示");
                Application.Exit();
            }
        }
    }
}
