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
    public partial class DailyWorkShedule : Form
    {
        public static string command;
        int shiftId;
        List<EmployeeScheduleDetails> employees = new List<EmployeeScheduleDetails>();
        SqlConnection con = new SqlConnection(DbConnection.cs);
        DataTable dt = new DataTable();
        

        public DailyWorkShedule()
        {
            InitializeComponent();
            try
            {
                command = "select * from dbo.tblSysUser emps left join dbo.tblShiftScheduleRecords sh on sh.EmpID = emps.EmpiID and MONTH(sh.DateCreated) = MONTH(getdate()) and YEAR(sh.DateCreated) = YEAR(getdate()) left join dbo.tblShiftSched sched on sched.Id = sh.ShiftId";
                
                SqlCommand cmd = new SqlCommand(command, con);
                con.Open();

                cmd.ExecuteNonQuery();

                SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dAdapter.Fill(ds);
                SqlDataAdapter da = new SqlDataAdapter(command, con);
                
                da.Fill(dt);
                SqlDataReader sdr = cmd.ExecuteReader();

                dataGridView1.Rows.Clear();
                while (sdr.Read())
                {
                    EmployeeScheduleDetails emp = new EmployeeScheduleDetails();
                    emp.EmpiID = Convert.ToInt32(sdr["EmpiID"].ToString());
                    emp.FirstName = sdr["FirstName"].ToString();
                    emp.Department = sdr["Department"].ToString();
                    emp.ShiftSched = sdr["ShiftSched"].ToString();
                    string shTime = "";
                    if (sdr["TimeFrom"].ToString() != null)
                    {
                        shTime = sdr["TimeFrom"].ToString() + ":00" + sdr["TimeFromExt"].ToString() + " - " + sdr["TimeTo"].ToString() + ":00" + sdr["TimeToExt"].ToString();
                    }
                    string shDate = "";
                    if (sdr["StartDate"].ToString() != null)
                    {
                        if (sdr["EndDate"].ToString() != null)
                        {
                            shDate = sdr["StartDate"].ToString() + " to " + sdr["EndDate"].ToString();
                        }
                    }
                    emp.ShiftTime = shTime;
                    emp.ShiftDate = shDate;
                    employees.Add(emp);                  
                }
                DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
                checkColumn.Name = "Check";
                checkColumn.HeaderText = "Check";
                dataGridView1.Columns.Add(checkColumn);
                dataGridView1.DataSource = employees;
                dataGridView1.Invalidate();
                

                //dataGridView1.DataSource = ds.Tables[0];
                //dataGridView1.Sort(dataGridView1.Columns["EmpID"], ListSortDirection.Ascending);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:", ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            command = "select ShiftSched from dbo.tblShiftSched";
            SqlConnection con = new SqlConnection(DbConnection.cs);
            SqlCommand cmd = new SqlCommand(command, con);
            SqlDataAdapter da = new SqlDataAdapter(command, con);
            con.Open();
            cmd.ExecuteNonQuery();          
            da.Fill(dt);
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbShifts.Items.Add(dt.Rows[i]["ShiftSched"].ToString());
            }
            

            List<EmployeeScheduleDetails> employees = new List<EmployeeScheduleDetails>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //int empid = Convert.ToInt32(row.Cells["EmpID"].Value.ToString());
                bool isSelected = Convert.ToBoolean(row.Cells["Check"].Value);
                if (isSelected)
                {
                    EmployeeScheduleDetails emp = new EmployeeScheduleDetails();
                    emp.EmpiID = Convert.ToInt32(row.Cells["EmpiID"].Value.ToString());
                    emp.FirstName = row.Cells["FirstName"].Value.ToString();
                    emp.Department = row.Cells["Department"].Value.ToString();
                    //emp.ShiftTime = row.Cells["ShiftTime"].Value.ToString();
                    emp.ShiftSched = row.Cells["ShiftSched"].Value.ToString();
                    employees.Add(emp);                    
                }              
            }
            dataGridView2.DataSource = employees;
            dataGridView2.Invalidate();
            assignPanel.Visible = true;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DatagridData.EmpiID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["EmpiID"].Value.ToString());
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            assignPanel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt;
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                dt.DefaultView.RowFilter = string.Empty;
            }
            else
            {
                try
                {
                    //(dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("LastName LIKE '%{0}%'", (materialTextBox1.Text));
                    //(dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("EmpiID = " + textBox1.Text + "");
                    dt.DefaultView.RowFilter = string.Format("EmpiID = " + textBox1.Text + "");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt;
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                dt.DefaultView.RowFilter = string.Empty;
            }
            else
            {
                try
                {
                    dt.DefaultView.RowFilter = string.Format("Department LIKE '%{0}%'", (comboBox1.Text));
                    //(dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("EmpiID = "+materialTextBox1.Text+"");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                chk.Value = !(chk.Value == null ? false : (bool)chk.Value); //because chk.Value is initialy null
            }
        }
    }
}
