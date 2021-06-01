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
    public partial class BasicUserForm : Form
    {
        public static string command;
        public BasicUserForm()
        {
            InitializeComponent();
        }

        private void employeeData_Click(object sender, EventArgs e)
        {
            if (dgv1.Visible == false)
            {
                dgv1.Visible = true;
            }
            else 
            {
                dgv1.Visible = true;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BasicUserForm_Load(object sender, EventArgs e)
        {
            FirstName.Text = GlobalLogin.FirstName + " " + GlobalLogin.LastName;
            Department.Text = GlobalLogin.Department;
            EmpiID.Text = Convert.ToString(GlobalLogin.EmpiID); 

            try
            {
                if (GlobalLogin.UserRole == "User")
                {


                    command = "Select EmpiID, FirstName, LastName, Position, EmploymentStatus from dbo.tblSysUser where FirstName = '" + GlobalLogin.FirstName + "'";
                }
                else if (GlobalLogin.UserRole == "Admin")
                {

                    command = "Select EmpiID, FirstName, LastName, Department, Position, EmploymentStatus from dbo.tblSysUser";
                    //dataGridView1.Sort(dataGridView1.Columns["EmpiID"], ListSortDirection.Ascending);
                }
                else if (GlobalLogin.UserRole == "SuperAdmin")
                {

                    command = "Select EmpiID, FirstName, LastName, Department, Position, EmploymentStatus, UserRole from dbo.tblSysUser";
                }

                SqlConnection con = new SqlConnection(DbConnection.cs);
                SqlCommand cmd = new SqlCommand(command, con);
                con.Open();
                cmd.ExecuteNonQuery();

                SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dAdapter.Fill(ds);

                dgv1.DataSource = ds.Tables[0];
                dgv1.Sort(dgv1.Columns["EmpiID"], ListSortDirection.Ascending);

                dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DatagridData.EmpiID = Convert.ToInt32(dgv1.Rows[e.RowIndex].Cells["EmpiID"].Value.ToString());
            EmpDetails addemp = new EmpDetails();
            addemp.Show();
            this.Hide();
        }

        private void Department_Click(object sender, EventArgs e)
        {

        }

        private void FirstName_Click(object sender, EventArgs e)
        {

        }
    }
}
