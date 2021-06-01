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
    public partial class EmpDetails : Form
    {
        SqlConnection con = new SqlConnection(DbConnection.cs);
        public EmpDetails()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (GlobalLogin.UserRole == "SuperAdmin")
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else if (GlobalLogin.UserRole == "User")
            {
                BasicUserForm bsu = new BasicUserForm();
                bsu.Show();
                this.Hide();
            }
            else if (GlobalLogin.UserRole == "Admin")
            {
                AdminForm adm = new AdminForm();
                adm.Show();
                this.Hide();
            }
        }

        private void empEdit_Click(object sender, EventArgs e)
        {
            txtEmpID.Enabled = true;
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtDepartment.Enabled = true;
            txtAdd.Enabled = true;
            txtAge.Enabled = true;
            txtBirthday.Enabled = true;
            txtMarSt.Enabled = true;
            txtGender.Enabled = true;
            txtPosition.Enabled = true;
            txtTIN.Enabled = true;
            txtSSS.Enabled = true;
            txtMiddle.Enabled = true;
            txtNickname.Enabled = true;
            txtDateHired.Enabled = true;
            txtShift.Enabled = true;
            txtEmpStatus.Enabled = true;
            txtPhilhealth.Enabled = true;
            txtHDMF.Enabled = true;
            txtBlood.Enabled = true;
            txtActive.Enabled = true;
            txtMobile.Enabled = true;
        }

        private void empSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Please confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    SqlCommand scmd = new SqlCommand();
                    con.Open();
                    scmd.Connection = con;
                    scmd.CommandText = ("UPDATE [TimekeepingSample].[dbo].[tblSysUser] set EmpiID = '" + txtEmpID.Text + "', [FirstName] = '" + txtFirstName.Text + "', [LastName] = '" + txtLastName.Text + "', Department = '" + txtDepartment.Text + "', Position = '" + txtPosition.Text + "', Age = '" + txtAge.Text + "', Gender = '" + txtGender.Text + "', MobileNumber = '" + txtMobile.Text + "', Birthday = '" + txtBirthday.Text + "', [MaritalStatus] = '" + txtMarSt.Text + "', Address = '" + txtAdd.Text + "', [SSSNumber] = '" + txtSSS.Text + "', [TINNumber] = '" + txtTIN.Text + "', [HDMFNumber] = '" + txtHDMF.Text + "', [PhilhealthNumber] = '" + txtPhilhealth.Text + "', Nickname = '" + txtNickname.Text + "', [ActiveStatus] = '" + txtActive.Text + "', [DateHired] = '" + txtDateHired.Text + "', Bloodtype = '" + txtBlood.Text + "', [MiddleName] = '" + txtMiddle.Text + "' where EmpiID ='" + txtEmpID.Text + "'");
                    scmd.ExecuteNonQuery();
                    MessageBox.Show("Data saved");
                    con.Close();
                    this.Hide();
                    if (GlobalLogin.UserRole == "SuperAdmin")
                    {
                        Form1 frm1 = new Form1();
                        frm1.Show();
                    }
                    else if (GlobalLogin.UserRole == "User")
                    {
                        BasicUserForm bsu = new BasicUserForm();
                        bsu.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
            }
        }

        private void addemp_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from dbo.tblSysUser where EmpiID = " + DatagridData.EmpiID + "", con);
            con.Open();
            cmd.ExecuteNonQuery();
            try
            {
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    txtEmpID.Text = sdr["EmpiID"].ToString();
                    txtFirstName.Text = sdr["FirstName"].ToString();
                    txtLastName.Text = sdr["LastName"].ToString();
                    txtDepartment.Text = sdr["Department"].ToString();
                    txtAdd.Text = sdr["Address"].ToString();
                    txtAge.Text = sdr["Age"].ToString();
                    txtBirthday.Text = sdr["Birthday"].ToString();
                    txtMarSt.Text = sdr["MaritalStatus"].ToString();
                    txtGender.Text = sdr["Gender"].ToString();
                    txtAdd.Text = sdr["Address"].ToString();
                    txtPosition.Text = sdr["Position"].ToString();
                    txtTIN.Text = sdr["TINNumber"].ToString();
                    txtSSS.Text = sdr["SSSNumber"].ToString();
                    txtMiddle.Text = sdr["MiddleName"].ToString();
                    txtNickname.Text = sdr["Nickname"].ToString();
                    txtDateHired.Text = sdr["DateHired"].ToString();
                    //txtShift.Text = sdr["Shift"].ToString();
                    txtEmpStatus.Text = sdr["EmploymentStatus"].ToString();
                    txtPhilhealth.Text = sdr["PhilhealthNumber"].ToString();
                    txtHDMF.Text = sdr["HDMFNumber"].ToString();
                    txtBlood.Text = sdr["Bloodtype"].ToString();
                    txtActive.Text = sdr["ActiveStatus"].ToString();
                    txtMobile.Text = sdr["MobileNumber"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:", ex.Message);
                throw;
            }
            
            

            con.Close();

            if (GlobalLogin.UserRole == "User")
            {
                empSave.Enabled = false;
                empSave.Enabled = false;
                caution.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
