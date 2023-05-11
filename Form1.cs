using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;//数据库使用

namespace 针对SQL数据库_简单SQL语句程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            but断开数据库.Enabled = false;
            but连接数据库.Enabled = true;
            显示说明1.Text = "SQL server 连接状态未知";
            group查询功能.Enabled = false;
            group数据更改.Enabled = false;
            Box数据表.Enabled = false;
            dataGridView1.Enabled = false;
            button2获取表名.Enabled = false;
        }

        private void But连接数据库_Click(object sender, EventArgs e)
        {
            try
            {
                //创建数据库连接字符串
                string SqlStr = "Server=" + text数据库名.Text.ToString() + ";User Id =" + text用户名.Text.ToString() + "; Pwd =" + text密码.Text.ToString() + ";DataBase = " + text数据表.Text.ToString() + ";";
                //string SqlStr = "Server = 服务器名 ; User Id = 用户名; Pwd = 用户密码; DataBase = 数据库名;";
                SqlConnection con = new SqlConnection(SqlStr);//实例化SqlConnection数据库连接对象;
                con.Open();//打开数据库连接
                if (con.State == ConnectionState.Open)//判断连接是否打开
                {
                显示说明1.Text = "SQL server 数据库连接成功";
                but连接数据库.Enabled = false;
                but断开数据库.Enabled = true;
                button2获取表名.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void But断开数据库_Click_1(object sender, EventArgs e)
        {
            //string SqlStr = "Server = 服务器名 ; User Id = 用户名; Pwd = 用户密码; DataBase = 数据库名;";
            string SqlStr = "Server=" + text数据库名.Text.ToString() + ";User Id =" + text用户名.Text.ToString() + "; Pwd =" + text密码.Text.ToString() + ";DataBase = " + text数据表.Text.ToString() + ";";
            SqlConnection con = new SqlConnection(SqlStr);//实例化SqlConnection数据库连接对象
            con.Close();
            if (con.State == ConnectionState.Closed) //判断连接是否关闭
            {
                显示说明1.Text = "SQL server 数据库已关闭";
                but断开数据库.Enabled = false;
                but连接数据库.Enabled = true;
                group查询功能.Enabled = false;
                group数据更改.Enabled = false;
                Box数据表.Enabled = false;
                dataGridView1.Enabled = false;
                button2获取表名.Enabled = false;
                数据库连接Box.Enabled = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
            string SqlStr = "Server=" + text数据库名.Text.ToString() + ";User Id =" + text用户名.Text.ToString() + "; Pwd =" + text密码.Text.ToString() + ";DataBase = " + text数据表.Text.ToString() + ";";
            //string SqlStr = "Server = 服务器名 ; User Id = 用户名; Pwd = 用户密码; DataBase = 数据库名;";
            SqlConnection con = new SqlConnection(SqlStr);//实例化SqlConnection数据库连接对象;
            string sq1 = "select * from "+ textBox表名.Text.ToString();// SQL读语句 读取表####的全部数据 （文本格式)
            SqlDataAdapter mada = new SqlDataAdapter(sq1,con);//更新SQL语句命令
            DataSet mads = new DataSet();//建立适配器
            mada.Fill(mads, "wangyan");//刷新数据行
            dataGridView1.DataSource = mads.Tables["wangyan"];//获取在"wangyan"中的数据，并写入至表格dataGridView1
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Button2获取表名_Click(object sender, EventArgs e)
        {
            try
            {
                string SqlStr = "Server=" + text数据库名.Text.ToString() + ";User Id =" + text用户名.Text.ToString() + "; Pwd =" + text密码.Text.ToString() + ";DataBase = " + text数据表.Text.ToString() + ";";
                //string SqlStr = "Server = 服务器名 ; User Id = 用户名; Pwd = 用户密码; DataBase = 数据库名;";
                SqlConnection con = new SqlConnection(SqlStr);//实例化SqlConnection数据库连接对象;
                string sq1 = "Select Name FROM SysObjects Where XType='U' orDER BY Name";//获取所有表名
                SqlDataAdapter mada = new SqlDataAdapter(sq1, con);//更新SQL语句命令
                DataSet mads = new DataSet();//建立适配器
                mada.Fill(mads, "wangyan");//刷新数据行
                dataGridView1.DataSource = mads.Tables["wangyan"];//获取在"wangyan"中的数据，并写入至表格dataGridView1
                group查询功能.Enabled = true;
                group数据更改.Enabled = true;
                Box数据表.Enabled = true;
                dataGridView1.Enabled = true;
                数据库连接Box.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Butt查询单一数据_Click(object sender, EventArgs e)
        {
            try
            {
            string SqlStr = "Server=" + text数据库名.Text.ToString() + ";User Id =" + text用户名.Text.ToString() + "; Pwd =" + text密码.Text.ToString() + ";DataBase = " + text数据表.Text.ToString() + ";";
            //string SqlStr = "Server = 服务器名 ; User Id = 用户名; Pwd = 用户密码; DataBase = 数据库名;";
            SqlConnection con = new SqlConnection(SqlStr);//实例化SqlConnection数据库连接对象;
            //string sq1 = "select * from " + textBox表名.Text + " Where 数据列名 = 实际数据";//SQL查询语句 列出表中列下面的数据满足的行
            string sq1 = "select * from " + textBox表名.Text + " Where " + text数据列名.Text + "=" + text实际数据.Text;
            SqlDataAdapter mada = new SqlDataAdapter(sq1, con);
            DataSet mads = new DataSet();//建立适配器 
            mada.Fill(mads, "wangyan");//刷新数据行
            dataGridView1.DataSource = mads.Tables["wangyan"];//获取在"wangyan"中的数据，并写入至表格dataGridView1

                //con.Dispose();//释放SQL资源
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void Butt数据删除_Click(object sender, EventArgs e)
        {
            try
            { 
            string SqlStr = "Server=" + text数据库名.Text.ToString() + ";User Id =" + text用户名.Text.ToString() + "; Pwd =" + text密码.Text.ToString() + ";DataBase = " + text数据表.Text.ToString() + ";";
            //string SqlStr = "Server = 服务器名 ; User Id = 用户名; Pwd = 用户密码; DataBase = 数据库名;";
            SqlConnection con = new SqlConnection(SqlStr);//实例化SqlConnection数据库连接对象;
            //string sq1 = "delete from " + textBox表名.Text + " Where 数据列名 = 实际数据";//SQL查询语句 删除表中列下面的数据满足的行
            string sq1 = "delete from "+textBox表名.Text.ToString()+" Where "+ text数据列名.Text.ToString() + "=" + text实际数据.Text.ToString();
            SqlDataAdapter mada = new SqlDataAdapter(sq1, con);
            DataSet mads = new DataSet();//建立适配器
            mada.Fill(mads, "wangyan");//刷新数据行
            dataGridView1.DataSource = mads.Tables["wangyan"];//获取在"wangyan"中的数据，并写入至表格dataGridView1

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void But退出_Click(object sender, EventArgs e)
        {
            Close();
            SqlConnection con = new SqlConnection();//实例化SqlConnection数据库连接对象
            con.Close();
        }

        private void But帮助说明_Click(object sender, EventArgs e)
        {
            MessageBox.Show("说明\n" +
                "1.输入服务器名称【打开Microsoft SQL Server Management Studio查看服务器名】\n" +
                "2.输入用户名【默认】 一般为： sa\n" +
                "3.输入密码【默认】 一般为：Feeler+数字\n" +
                "4.输入数据表名【默认】 一般为：SSPECM\n" +
                "5.点击【连接数据库】\n" +
                "6.连接成功后点击【显示全部表名】\n" +
                "7.下方表格出现所有表名，选择自己需要的双击复制表名到【数据表名文本框中】\n" +
                "8.点击【查询表内容】\n" +
                "9.输入关键字【数据表列名】+【数据】\n" +
                "10.点击【查询】可以查询目标数据；【删除】可以删除目标数据\n" +
                "关于：后期功能阶段性增加\n" +
                "WangYan 2022-09-09 V1.0");
        }
    }
}
