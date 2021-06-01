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
    public partial class AdminForm : Form
    {
        SqlConnection con = new SqlConnection(DbConnection.cs);
        public static string command;
        public AdminForm()
        {
            InitializeComponent();
            FirstName.Text = GlobalLogin.FirstName + " " + GlobalLogin.LastName;
            Department.Text = GlobalLogin.Department;
            IDno.Text = Convert.ToString(GlobalLogin.EmpiID);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AccountManagement am = new AccountManagement();
            am.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void employeeData_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Visible == false)
            {
                dataGridView1.Visible = true;
                //Empdetailspanel.Visible = false;
            }
            else
            {
                dataGridView1.Visible = false;
            }
            if (materialTextBox1.Visible == false)
            {
                materialTextBox1.Visible = true;
            }
            else
            {
                materialTextBox1.Visible = false;
            }
            if (materialComboBox1.Visible == false)
            {
                materialComboBox1.Visible = true; ;
            }
            else
            {
                materialComboBox1.Visible = false;
            }
            if (AddEmp.Visible == false)
            {
                AddEmp.Visible = true;
            }
            else
            {
                AddEmp.Visible = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DatagridData.EmpiID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["EmpiID"].Value.ToString());
            EmpDetails addemp = new EmpDetails();
            addemp.Show();
            //this.Hide();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (GlobalLogin.UserRole == "User")
                {
                    //materialComboBox1.Visible = false;
                    /*ddEmp.Visible = false;*/
                    command = "Select EmpiID, FirstName, LastName, Position, EmploymentStatus from dbo.tblSysUser where FirstName = '" + GlobalLogin.FirstName + "'";
                }
                else if (GlobalLogin.UserRole == "Admin")
                {
                    //materialComboBox1.Visible = true;
                    //materialTextBox1.Visible = true;
                    command = "Select EmpiID, FirstName, LastName, Department, Position, EmploymentStatus from dbo.tblSysUser";
                    //dataGridView1.Sort(dataGridView1.Columns["EmpiID"], ListSortDirection.Ascending);
                }
                else if (GlobalLogin.UserRole == "SuperAdmin")
                {
                    //materialComboBox1.Visible = true;
                    //materialTextBox1.Visible = true;
                    command = "Select EmpiID, FirstName, LastName, Department, Position, EmploymentStatus, UserRole from dbo.tblSysUser";
                }
                
                SqlConnection con = new SqlConnection(DbConnection.cs);
                SqlCommand cmd2 = new SqlCommand(command, con);
                con.Open();
                cmd2.ExecuteNonQuery();

                SqlDataAdapter dAdapter = new SqlDataAdapter(cmd2);
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void AddEmp_Click(object sender, EventArgs e)
        {
            AddEmp ad = new AddEmp();
            ad.Show();
            //this.Hide();
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(materialTextBox1.Text))
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                try
                {
                    //(dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("LastName LIKE '%{0}%'", (materialTextBox1.Text));
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("EmpiID = " + materialTextBox1.Text + "");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }
        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(materialComboBox1.Text))
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                try
                {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Department LIKE '%{0}%'", (materialComboBox1.Text));
                    //(dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("EmpiID = "+materialTextBox1.Text+"");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }
        }

        private void FileManager_Click(object sender, EventArgs e)
        {
            FileManager fm = new FileManager();
            fm.Show();
            this.Hide();
        }
    }
}
