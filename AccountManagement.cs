using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeKeeping_System_v1._0._0._2.Model;

namespace WindowsFormsApp1
{
    public partial class AccountManagement : Form
    {
        public AccountManagement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtConf.Password == true)
            {
                txtNewPass.Password = false;
                txtConf.Password = false;
                txtOldPass.Password = false;
            }
            else
            {
                txtConf.Password = true;
                txtNewPass.Password = true;
                txtOldPass.Password = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (GlobalLogin.UserRole == "SuperAdmin")
            //{
            //    //Form1 form1 = new Form1();
            //    //form1.Show();
            //    this.Hide();
            //}
            //else if (GlobalLogin.UserRole == "Admin")
            //{
            //    //AdminForm adm = new AdminForm();
            //    //adm.Show();
            //    this.Hide();
            //}
            //else if (GlobalLogin.UserRole == "User")
            //{
            //    //BasicUserForm bsc = new BasicUserForm();
            //    //bsc.Show();
            //    this.Hide();
            //}
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(DbConnection.cs);
            SqlCommand cmd = new SqlCommand("SELECT PW FROM tblSysUser", con);
            con.Open();


            if (GlobalLogin.Password != txtOldPass.Text)
            {
                MessageBox.Show("Old Password does not match");
            }
            if (txtNewPass.Text != txtConf.Text)
            {
                MessageBox.Show("Password does not match");
            }

            try
            {
                cmd.CommandText = ("UPDATE [TimekeepingSample].[dbo].[tblSysUser] set PW = '" + txtNewPass.Text + "' where [Username] = '" + GlobalLogin.Username + "'");
                MaterialMessageBox.Show("Password updated!");
                this.Hide();
                cmd.ExecuteNonQuery();
                con.Close();
                Application.Restart();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }

            con.Close();
        }
    }
}
