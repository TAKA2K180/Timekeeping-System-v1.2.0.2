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
    public partial class BasicUserDetails : Form
    {
        public static string command;
        public BasicUserDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BasicUserDetails_Load(object sender, EventArgs e)
        {
            try
            {
                if (GlobalLogin.UserRole == "User")
                {
                    materialComboBox1.Visible = false;
                    AddEmp.Visible = false;
                    command = "Select EmpiID, FirstName, LastName, Position, EmploymentStatus from dbo.tblSysUser where FirstName = '" + GlobalLogin.FirstName + "'";
                }
                else if (GlobalLogin.UserRole == "Admin")
                {
                    materialComboBox1.Visible = true;
                    command = "Select EmpiID, FirstName, LastName, Department, Position, EmploymentStatus from dbo.tblSysUser";
                    //dataGridView1.Sort(dataGridView1.Columns["EmpiID"], ListSortDirection.Ascending);
                }
                else if (GlobalLogin.UserRole == "SuperAdmin")
                {
                    materialComboBox1.Visible = true;
                    command = "Select EmpiID, FirstName, LastName, Department, Position, EmploymentStatus, UserRole from dbo.tblSysUser";
                }

                SqlConnection con = new SqlConnection(DbConnection.cs);
                SqlCommand cmd = new SqlCommand(command, con);
                con.Open();
                cmd.ExecuteNonQuery();

                SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dAdapter.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Sort(dataGridView1.Columns["EmpiID"], ListSortDirection.Ascending);
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }

            FirstName.Text = GlobalLogin.FirstName + " " + GlobalLogin.LastName;
            Department.Text = GlobalLogin.Department;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
    }
}
