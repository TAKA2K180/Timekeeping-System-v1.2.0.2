
namespace WindowsFormsApp1
{
    partial class BasicUserDetails
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
            this.Main = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Department = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.FileLeave = new System.Windows.Forms.Button();
            this.FileOT = new System.Windows.Forms.Button();
            this.FileManager = new System.Windows.Forms.Button();
            this.employeeData = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.empPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.AddEmp = new System.Windows.Forms.Button();
            this.Main.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.empPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.Main.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.AddEmp);
            this.panel3.Controls.Add(this.materialTextBox1);
            this.panel3.Controls.Add(this.materialComboBox1);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.Department);
            this.panel3.Controls.Add(this.FirstName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(235, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(995, 718);
            this.panel3.TabIndex = 2;
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department.ForeColor = System.Drawing.Color.Black;
            this.Department.Location = new System.Drawing.Point(6, 60);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(76, 32);
            this.Department.TabIndex = 5;
            this.Department.Text = "label2";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.ForeColor = System.Drawing.Color.Black;
            this.FirstName.Location = new System.Drawing.Point(6, 13);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(76, 32);
            this.FirstName.TabIndex = 4;
            this.FirstName.Text = "label2";
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
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
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
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
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
            this.FileLeave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
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
            this.FileOT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
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
            this.FileManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
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
            // 
            // employeeData
            // 
            this.employeeData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
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
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 210);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // empPanel
            // 
            this.empPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(98)))));
            this.empPanel.Controls.Add(this.button2);
            this.empPanel.Controls.Add(this.button1);
            this.empPanel.Controls.Add(this.label1);
            this.empPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.empPanel.Location = new System.Drawing.Point(0, 0);
            this.empPanel.Name = "empPanel";
            this.empPanel.Size = new System.Drawing.Size(1230, 49);
            this.empPanel.TabIndex = 0;
            this.empPanel.Visible = false;
            // 
            // button2
            // 
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
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(971, 496);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.materialComboBox1.Location = new System.Drawing.Point(740, 153);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(121, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 7;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox1.Location = new System.Drawing.Point(605, 154);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(129, 50);
            this.materialTextBox1.TabIndex = 8;
            this.materialTextBox1.Text = "";
            // 
            // AddEmp
            // 
            this.AddEmp.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmp.Location = new System.Drawing.Point(867, 167);
            this.AddEmp.Name = "AddEmp";
            this.AddEmp.Size = new System.Drawing.Size(116, 35);
            this.AddEmp.TabIndex = 9;
            this.AddEmp.Text = "Add Employee";
            this.AddEmp.UseVisualStyleBackColor = true;
            // 
            // BasicUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 767);
            this.Controls.Add(this.Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BasicUserDetails";
            this.Text = "BasicUserDetails";
            this.Load += new System.EventHandler(this.BasicUserDetails_Load);
            this.Main.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.empPanel.ResumeLayout(false);
            this.empPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Department;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button FileLeave;
        private System.Windows.Forms.Button FileOT;
        private System.Windows.Forms.Button FileManager;
        private System.Windows.Forms.Button employeeData;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel empPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private System.Windows.Forms.Button AddEmp;
    }
}