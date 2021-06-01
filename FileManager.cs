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
    public partial class FileManager : Form
    {
        public static string command;
        int shiftId;
        List<EmployeeScheduleDetails> employees = new List<EmployeeScheduleDetails>();
        public FileManager()
        {
            InitializeComponent();
            FirstName.Text = GlobalLogin.FirstName + " " + GlobalLogin.LastName;
            Department.Text = GlobalLogin.Department;
            IDno.Text = Convert.ToString(GlobalLogin.EmpiID);
            //tabPage3.Text = "Daily work schedule";

            
        }

        private void employeeData_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void FileManager_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            FirstName.Text = GlobalLogin.FirstName + " " + GlobalLogin.LastName;
            Department.Text = GlobalLogin.Department;
            IDno.Text = Convert.ToString(GlobalLogin.EmpiID);

           
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void cbShifts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DailyWorkShedule dw = new DailyWorkShedule();
            dw.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
