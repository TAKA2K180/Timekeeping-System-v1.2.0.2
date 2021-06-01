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
using TimeKeeping_System_v1._0._0._2.Model;

namespace WindowsFormsApp1
{
    public partial class employeedatalogin : Form
    {
        string userName = Environment.UserName;
        public employeedatalogin()
        {
            InitializeComponent();
        }
        private void materialButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public void materialButton1_Click(object sender, EventArgs e)
        {
            if (txt_UserName.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("Please provide Username and Password");
                return;
            }
            try
            {
                //Create SqlConnection
                SqlConnection con = new SqlConnection(DbConnection.cs);
                SqlCommand cmd = new SqlCommand("Select * from dbo.tblSysUser where [Username]='" + txt_UserName.Text + "' and PW='" + txt_Password.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();

                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.Read())
                {
                    GlobalLogin.Username = sdr["Username"].ToString();
                    GlobalLogin.Password = sdr["PW"].ToString();
                    GlobalLogin.UserRole = sdr["UserRole"].ToString();
                    GlobalLogin.Department = sdr["Department"].ToString();
                    GlobalLogin.FirstName = sdr["FirstName"].ToString();
                    GlobalLogin.LastName = sdr["LastName"].ToString();
                    GlobalLogin.EmpiID = Convert.ToInt32(sdr["EmpiID"]);

                    Form1 frm = new Form1();
                    AdminForm add = new AdminForm();
                    BasicUserForm bsu = new BasicUserForm();

                    if (sdr["UserRole"].ToString() == "User")
                    {
                        bsu.Show();
                        this.Hide();
                    }

                    if (sdr["UserRole"].ToString() == "Admin")
                    {
                        add.Show();
                        this.Hide();
                    }
                    if (sdr["UserRole"].ToString() == "SuperAdmin")
                    {
                        frm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txt_UserName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void employeedatalogin_Load(object sender, EventArgs e)
        {
            txt_UserName.Text = userName;
        }
    }
}
