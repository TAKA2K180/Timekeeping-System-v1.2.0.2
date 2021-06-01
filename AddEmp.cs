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
    public partial class AddEmp : Form
    {
        SqlConnection con = new SqlConnection(DbConnection.cs);
        string command;
        public AddEmp()
        {
            InitializeComponent();
        }

        private void AddEmp_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Form1 fm = new Form1();
            //fm.Show();
            this.Hide();
        }

        private void empEdit_Click(object sender, EventArgs e)
        {

        }

        private void empSave_Click(object sender, EventArgs e)
        {
            SqlCommand scmd = new SqlCommand();
            con.Open();
            scmd.Connection = con;
            scmd.CommandText = "INSERT INTO tblSysUser (EmpiID, FirstName, LastName, Department, Position, Age, Gender, MobileNumber, Birthday, MaritalStatus, Address, SSSNumber, TINNumber, HDMFNumber, PhilhealthNumber, Nickname, DateHired, Bloodtype, MiddleName) values ('" + txtEmpID.Text + "', '" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + txtDepartment.Text + "', '" + txtPosition.Text + "', '" + txtAge.Text + "', '" + txtGender.Text + "', '" + txtMobile.Text + "', '" + txtBirthday.Text + "', '" + txtMarSt.Text + "', '" + txtAdd.Text + "', '" + txtSSS.Text + "', '" + txtTIN.Text + "', '" + txtHDMF.Text + "', '" + txtPhilhealth.Text + "', '" + txtNickname.Text + "', '" + txtDateHired.Text + "', '" + txtBlood.Text + "', '"+txtMiddle+"')";


            
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
    }
}
