using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Winform
{

    public partial class form : Form
    {
        String UserId;

        public form()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.labelOut.Visible = false;
            if (this.labelRegist.Visible == false)
            {
                this.labelRegist.Visible = true;
                labelRegist.Show();
            }
            this.panel2.Visible = false;
            this.panel3.Visible = false;
            this.panel4.Visible = false;
            this.ToolStripMenuItem.Visible = false;
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (textId.Text.Trim() == "")
            {
                MessageBox.Show("用户名不能为空");
                textId.Focus();
                return;
            }
            else if (textPw.Text.Trim() == "")
            {
                MessageBox.Show("密码不能为空!");
                textPw.Focus();
                return;
            }

            string constr = "server=.;database=Login;integrated security=SSPI";
            SqlConnection con = new SqlConnection(constr);//定义 sql server连接对象
            con.Open();
            string sql = "select id,pw from login where id = @id";
            SqlCommand com = new SqlCommand(sql, con);//定义查询命令            
            com.Parameters.Add(new SqlParameter("@id", SqlDbType.NChar, 50));
            com.Parameters["@id"].Value = textId.Text;
            UserId = textId.Text;
            SqlDataReader reader = com.ExecuteReader();//执行查询  

            if (!reader.Read())
            {
                MessageBox.Show("用户名不存在！请重新输入");
                textId.Text = "";
                textPw.Text = "";
                return;
            }
            else if (reader["pw"].ToString().Trim() == textPw.Text.Trim())
            {
                MessageBox.Show("恭喜您已成功登录", "确定", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textId.Text = "";
                textPw.Text = "";
                
            }
            else
            {
                MessageBox.Show("密码错误!请重新输入！");
                textId.Text = "";
                textPw.Text = "";
                return;
            }
            con.Close();
            con.Open();
            string sql1 = "SELECT * FROM login";
            SqlDataAdapter data = new SqlDataAdapter(sql1, con);//实例化适配器
            DataSet ds = new DataSet();//实例化数据表
            data.Fill(ds);//保存数据
            dataGridView1.DataSource = ds.Tables[0];//设置到DATAGRIDVIEW中
            this.panel1.Visible = false;
            this.panel2.Visible = true;
            panel2.Show();
            this.ToolStripMenuItem.Visible = true;
            this.labelOut.Visible = true;
            
            con.Close();                    //关闭连接
            con.Dispose();                  //释放连接
            reader.Dispose();               //释放资源   
        }

        private void labelRegist_Click(object sender, EventArgs e)
        {
            this.labelRegist.Visible = false;
            this.panel2.Visible = false;
            this.panel3.Visible = true;
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            this.labelRegist.Visible = false;
            if (this.labelOut.Visible == false)
            {
                this.labelOut.Visible = true;
                labelOut.Show();
            }
            string constr = "server=.;database=Login;integrated security=SSPI";
            SqlConnection con = new SqlConnection(constr);//定义 sql server连接对象
            con.Open();
            string sql = "insert into login(id,pw) values(@id,@pw)";
            SqlCommand com = new SqlCommand(sql, con);//定义查询命令
            com.Parameters.Add(new SqlParameter("@id", SqlDbType.NChar, 10));
            com.Parameters.Add(new SqlParameter("@pw", SqlDbType.NChar, 10));
            com.Parameters["@id"].Value = textInsertId.Text;
            com.Parameters["@pw"].Value = textInsertPw.Text;
            com.ExecuteNonQuery();//执行           
            MessageBox.Show("注册成功");
            textInsertId.Text = "";
            textInsertPw.Text = "";
            con.Close();
            con.Dispose();                  //释放连接
            return;
        }

        private void labelOut_Click(object sender, EventArgs e)
        {
           if (this.labelRegist.Visible == false)
            {
                this.labelRegist.Visible = true;
                labelRegist.Show();
            }
            if (this.panel1.Visible == false)
            {
                this.panel1.Visible = true;
                panel1.Show();
            }
            if (this.panel2.Visible == true)
            {
                this.panel2.Visible = false;
                panel1.Show();
            }
            if (this.panel3.Visible == true)
            {
                this.panel3.Visible = false;
                panel1.Show();
            }
            if (this.panel4.Visible == true)
            {
                this.panel4.Visible = false;
                panel1.Show();
            }
            if(this.ToolStripMenuItem.Visible == true)
            {
                this.ToolStripMenuItem.Visible = false;
            }
                     
        }


        private void ToolStripMenuItemUpdatePw_Click(object sender, EventArgs e)
        {
            this.panel2.Visible = false;
            this.panel1.Visible = false;
            this.panel3.Visible = false;
            this.panel4.Visible = true;
            panel4.Show(); 
           
        }

        private void ToolStripMenuItemXiaoHu_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要销户吗?", "销户", messButton);
            if (dr == DialogResult.OK)//如果点击“确定”按钮
            {
                string constr = "server=.;database=Login;integrated security=SSPI";
                SqlConnection con = new SqlConnection(constr);//定义 sql server连接对象
                con.Open();
                string sqlDe = "delete from login where id ='" + UserId + "'";
                SqlCommand cmdDe = new SqlCommand(sqlDe, con);
                int r = cmdDe.ExecuteNonQuery();                               
            }
            else//如果点击“取消”按钮
            {
                return;
            }
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            string constr = "server=.;database=Login;integrated security=SSPI";
            SqlConnection con = new SqlConnection(constr);//定义 sql server连接对象
            con.Open();
            string sql = "select pw from login where id = '" + UserId + "'";
            SqlCommand com = new SqlCommand(sql, con);//定义查询命令

            com.Parameters.Add(new SqlParameter("@id", SqlDbType.NChar, 50));
            com.Parameters["@id"].Value = UserId;
            SqlDataReader reader = com.ExecuteReader();//执行查询  

            if (reader.Read())
            {

                if (reader[0].ToString().Trim() == textOld.Text.Trim())
                {
                    if (textNew.Text.Trim() == "" || textNew1.Text.Trim() == "")
                    {
                        MessageBox.Show("新密码确认不能为空!");
                        return;
                    }
                    else if (textNew.Text.Trim() != textNew1.Text.Trim())
                    {
                        MessageBox.Show("2次输入的新密码不一样,请重新输入!");
                        textNew.Text = "";
                        textNew1.Text = "";                      
                        return;                     
                    }
                    else
                    {
                        reader.Close();
                        string sqlUpdate = "update login set pw = '" + textNew1.Text.Trim() + "'where id = '" + UserId + "'";
                        SqlCommand cmdUp = new SqlCommand(sqlUpdate, con);
                        if (cmdUp.ExecuteNonQuery() == 0)
                        {
                            MessageBox.Show("未知错误!");
                            return;
                        }
                        MessageBox.Show("恭喜你!密码修改成功!");
                        textOld.Text = "";
                        textNew.Text = "";
                        textNew1.Text = ""; 
                        //return;
                    }
                }
                else
                {
                    MessageBox.Show("旧密码错误或者不能为空");
                    textOld.Text = "";
                    textNew.Text = "";
                    textNew1.Text = "";
                    return;
                }
            }
        }

        private void ToolStripMenuItemUpdate_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = false;
            this.panel3.Visible = false;
            this.panel4.Visible = false;
            string constr = "server=.;database=Login;integrated security=SSPI";
            SqlConnection con = new SqlConnection(constr);//定义 sql server连接对象
            con.Open();
            string sql1 = "SELECT * FROM login";
            SqlDataAdapter data = new SqlDataAdapter(sql1, con);//实例化适配器
            DataSet ds = new DataSet();//实例化数据表
            data.Fill(ds);//保存数据
            dataGridView1.DataSource = ds.Tables[0];//设置到DATAGRIDVIEW中
            this.panel2.Visible = false;
            panel2.Show();
        }

    }
}
