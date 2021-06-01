
namespace WindowsFormsApp1
{
    partial class BasicUserForm
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
            this.FileLeave = new System.Windows.Forms.Button();
            this.FileOT = new System.Windows.Forms.Button();
            this.employeeData = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Main = new System.Windows.Forms.Panel();
            this.empDataPanel = new System.Windows.Forms.Panel();
            this.panelemp = new System.Windows.Forms.Panel();
            this.Department = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.EmpiID = new System.Windows.Forms.Label();
            this.empPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Main.SuspendLayout();
            this.empDataPanel.SuspendLayout();
            this.panelemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
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
            this.empPanel.Size = new System.Drawing.Size(1214, 49);
            this.empPanel.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(1127, 9);
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
            this.button1.Location = new System.Drawing.Point(1172, 9);
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
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Timekeeping System v1.2.0.1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(156)))), ((int)(((byte)(169)))));
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.FileLeave);
            this.panel2.Controls.Add(this.FileOT);
            this.panel2.Controls.Add(this.employeeData);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 616);
            this.panel2.TabIndex = 1;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Location = new System.Drawing.Point(0, 431);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(217, 84);
            this.button8.TabIndex = 6;
            this.button8.Text = "Exit";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // FileLeave
            // 
            this.FileLeave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.FileLeave.Dock = System.Windows.Forms.DockStyle.Top;
            this.FileLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileLeave.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileLeave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FileLeave.Location = new System.Drawing.Point(0, 347);
            this.FileLeave.Name = "FileLeave";
            this.FileLeave.Size = new System.Drawing.Size(217, 84);
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
            this.FileOT.Location = new System.Drawing.Point(0, 263);
            this.FileOT.Name = "FileOT";
            this.FileOT.Size = new System.Drawing.Size(217, 84);
            this.FileOT.TabIndex = 3;
            this.FileOT.Text = "File OT";
            this.FileOT.UseVisualStyleBackColor = false;
            // 
            // employeeData
            // 
            this.employeeData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.employeeData.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeeData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeData.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeData.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.employeeData.Location = new System.Drawing.Point(0, 179);
            this.employeeData.Name = "employeeData";
            this.employeeData.Size = new System.Drawing.Size(217, 84);
            this.employeeData.TabIndex = 1;
            this.employeeData.Text = "Employee Data";
            this.employeeData.UseVisualStyleBackColor = false;
            this.employeeData.Click += new System.EventHandler(this.employeeData_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 179);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.Main.Controls.Add(this.empDataPanel);
            this.Main.Controls.Add(this.panel2);
            this.Main.Controls.Add(this.empPanel);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(0, 0);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(1214, 665);
            this.Main.TabIndex = 1;
            // 
            // empDataPanel
            // 
            this.empDataPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(98)))));
            this.empDataPanel.Controls.Add(this.panelemp);
            this.empDataPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.empDataPanel.Location = new System.Drawing.Point(216, 49);
            this.empDataPanel.Name = "empDataPanel";
            this.empDataPanel.Size = new System.Drawing.Size(998, 616);
            this.empDataPanel.TabIndex = 2;
            // 
            // panelemp
            // 
            this.panelemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.panelemp.Controls.Add(this.EmpiID);
            this.panelemp.Controls.Add(this.Department);
            this.panelemp.Controls.Add(this.FirstName);
            this.panelemp.Controls.Add(this.dgv1);
            this.panelemp.Location = new System.Drawing.Point(0, 1);
            this.panelemp.Name = "panelemp";
            this.panelemp.Size = new System.Drawing.Size(998, 615);
            this.panelemp.TabIndex = 0;
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department.ForeColor = System.Drawing.Color.White;
            this.Department.Location = new System.Drawing.Point(7, 106);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(76, 32);
            this.Department.TabIndex = 7;
            this.Department.Text = "label2";
            this.Department.Click += new System.EventHandler(this.Department_Click);
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.ForeColor = System.Drawing.Color.White;
            this.FirstName.Location = new System.Drawing.Point(7, 59);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(76, 32);
            this.FirstName.TabIndex = 6;
            this.FirstName.Text = "label2";
            this.FirstName.Click += new System.EventHandler(this.FirstName_Click);
            // 
            // dgv1
            // 
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(6, 155);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(980, 457);
            this.dgv1.TabIndex = 0;
            this.dgv1.Visible = false;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // EmpiID
            // 
            this.EmpiID.AutoSize = true;
            this.EmpiID.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpiID.ForeColor = System.Drawing.Color.White;
            this.EmpiID.Location = new System.Drawing.Point(7, 12);
            this.EmpiID.Name = "EmpiID";
            this.EmpiID.Size = new System.Drawing.Size(76, 32);
            this.EmpiID.TabIndex = 8;
            this.EmpiID.Text = "label2";
            // 
            // BasicUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 665);
            this.Controls.Add(this.Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BasicUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BasicUserForm";
            this.Load += new System.EventHandler(this.BasicUserForm_Load);
            this.empPanel.ResumeLayout(false);
            this.empPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Main.ResumeLayout(false);
            this.empDataPanel.ResumeLayout(false);
            this.panelemp.ResumeLayout(false);
            this.panelemp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel empPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button FileLeave;
        private System.Windows.Forms.Button FileOT;
        private System.Windows.Forms.Button employeeData;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Main;
        private System.Windows.Forms.Panel empDataPanel;
        private System.Windows.Forms.Panel panelemp;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label Department;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label EmpiID;
    }
}