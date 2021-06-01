
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.empPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.FileLeave = new System.Windows.Forms.Button();
            this.FileOT = new System.Windows.Forms.Button();
            this.FileManager = new System.Windows.Forms.Button();
            this.employeeData = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Main = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.IDno = new System.Windows.Forms.Label();
            this.AddEmp = new System.Windows.Forms.Button();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.Department = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.empPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Main.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // empPanel
            // 
            this.empPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.empPanel.Controls.Add(this.button2);
            this.empPanel.Controls.Add(this.button1);
            this.empPanel.Controls.Add(this.label1);
            this.empPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.empPanel.Location = new System.Drawing.Point(0, 0);
            this.empPanel.Name = "empPanel";
            this.empPanel.Size = new System.Drawing.Size(1230, 49);
            this.empPanel.TabIndex = 0;
            this.empPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1147, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "_";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(1189, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Timekeeping System v1.2.0.1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(179)))), ((int)(((byte)(191)))));
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.FileLeave);
            this.panel2.Controls.Add(this.FileOT);
            this.panel2.Controls.Add(this.FileManager);
            this.panel2.Controls.Add(this.employeeData);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 718);
            this.panel2.TabIndex = 1;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Location = new System.Drawing.Point(0, 630);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(235, 84);
            this.button8.TabIndex = 6;
            this.button8.Text = "Exit";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Location = new System.Drawing.Point(0, 546);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(235, 84);
            this.button7.TabIndex = 5;
            this.button7.Text = "Process";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // FileLeave
            // 
            this.FileLeave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.FileLeave.Dock = System.Windows.Forms.DockStyle.Top;
            this.FileLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileLeave.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileLeave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FileLeave.Location = new System.Drawing.Point(0, 462);
            this.FileLeave.Name = "FileLeave";
            this.FileLeave.Size = new System.Drawing.Size(235, 84);
            this.FileLeave.TabIndex = 4;
            this.FileLeave.Text = "File Leave";
            this.FileLeave.UseVisualStyleBackColor = false;
            // 
            // FileOT
            // 
            this.FileOT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.FileOT.Dock = System.Windows.Forms.DockStyle.Top;
            this.FileOT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileOT.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileOT.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FileOT.Location = new System.Drawing.Point(0, 378);
            this.FileOT.Name = "FileOT";
            this.FileOT.Size = new System.Drawing.Size(235, 84);
            this.FileOT.TabIndex = 3;
            this.FileOT.Text = "File OT";
            this.FileOT.UseVisualStyleBackColor = false;
            // 
            // FileManager
            // 
            this.FileManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.FileManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.FileManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileManager.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileManager.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FileManager.Location = new System.Drawing.Point(0, 294);
            this.FileManager.Name = "FileManager";
            this.FileManager.Size = new System.Drawing.Size(235, 84);
            this.FileManager.TabIndex = 2;
            this.FileManager.Text = "File Manager";
            this.FileManager.UseVisualStyleBackColor = false;
            this.FileManager.Click += new System.EventHandler(this.FileManager_Click);
            // 
            // employeeData
            // 
            this.employeeData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.employeeData.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeeData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeData.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeData.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.employeeData.Location = new System.Drawing.Point(0, 210);
            this.employeeData.Name = "employeeData";
            this.employeeData.Size = new System.Drawing.Size(235, 84);
            this.employeeData.TabIndex = 1;
            this.employeeData.Text = "Employee Data";
            this.employeeData.UseVisualStyleBackColor = false;
            this.employeeData.Click += new System.EventHandler(this.employeeData_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(156)))), ((int)(((byte)(169)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 210);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.Main.Controls.Add(this.panel3);
            this.Main.Controls.Add(this.panel2);
            this.Main.Controls.Add(this.empPanel);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(0, 0);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(1230, 767);
            this.Main.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(235, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(995, 718);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.IDno);
            this.panel1.Controls.Add(this.AddEmp);
            this.panel1.Controls.Add(this.materialTextBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.materialComboBox1);
            this.panel1.Controls.Add(this.Department);
            this.panel1.Controls.Add(this.FirstName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 718);
            this.panel1.TabIndex = 13;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(131, 155);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 49);
            this.button4.TabIndex = 15;
            this.button4.Text = "LOG OUT";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(6, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 49);
            this.button3.TabIndex = 14;
            this.button3.Text = "ACCOUNT MANAGEMENT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // IDno
            // 
            this.IDno.AutoSize = true;
            this.IDno.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDno.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.IDno.Location = new System.Drawing.Point(15, 3);
            this.IDno.Name = "IDno";
            this.IDno.Size = new System.Drawing.Size(76, 32);
            this.IDno.TabIndex = 13;
            this.IDno.Text = "label2";
            // 
            // AddEmp
            // 
            this.AddEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmp.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddEmp.Location = new System.Drawing.Point(866, 155);
            this.AddEmp.Name = "AddEmp";
            this.AddEmp.Size = new System.Drawing.Size(116, 49);
            this.AddEmp.TabIndex = 12;
            this.AddEmp.Text = "Add Employee";
            this.AddEmp.UseVisualStyleBackColor = true;
            this.AddEmp.Visible = false;
            this.AddEmp.Click += new System.EventHandler(this.AddEmp_Click);
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox1.Location = new System.Drawing.Point(604, 156);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(129, 50);
            this.materialTextBox1.TabIndex = 11;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.Visible = false;
            this.materialTextBox1.TextChanged += new System.EventHandler(this.materialTextBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(977, 496);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Items.AddRange(new object[] {
            "",
            "HRD",
            "ACCT",
            "CBNS",
            "CV 70/100",
            "HMC",
            "Injection",
            "Lab IPP/monomer prep",
            "Lab quality",
            "Molds control",
            "Packing",
            "Polyvalent",
            "Production training",
            "Semi finish/sapphire",
            "Tinting",
            "Uncoat/coat",
            "Accounting/finance",
            "CIPE",
            "Executive",
            "Gen. prod. Maintenance",
            "Logistics",
            "Material control",
            "Process engineering",
            "Production planning",
            "Production management",
            "Safety",
            "Store",
            "Sde",
            "New flows and projects",
            "Costumer service",
            "Metrology",
            "Product distribution",
            "Product quality dept.",
            "Quality dept.",
            "Repacking",
            "MIS"});
            this.materialComboBox1.Location = new System.Drawing.Point(739, 155);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(121, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 10;
            this.materialComboBox1.Visible = false;
            this.materialComboBox1.SelectedIndexChanged += new System.EventHandler(this.materialComboBox1_SelectedIndexChanged);
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Department.Location = new System.Drawing.Point(15, 66);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(76, 32);
            this.Department.TabIndex = 5;
            this.Department.Text = "label2";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FirstName.Location = new System.Drawing.Point(15, 34);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(76, 32);
            this.FirstName.TabIndex = 4;
            this.FirstName.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 767);
            this.Controls.Add(this.Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.empPanel.ResumeLayout(false);
            this.empPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Main.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel empPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button FileLeave;
        private System.Windows.Forms.Button FileOT;
        private System.Windows.Forms.Button FileManager;
        private System.Windows.Forms.Button employeeData;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Main;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Department;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddEmp;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label IDno;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}

