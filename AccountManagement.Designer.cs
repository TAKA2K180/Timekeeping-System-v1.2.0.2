
namespace WindowsFormsApp1
{
    partial class AccountManagement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNewPass = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConf = new MaterialSkin.Controls.MaterialTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOldPass = new MaterialSkin.Controls.MaterialTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 46);
            this.panel1.TabIndex = 0;
            // 
            // txtNewPass
            // 
            this.txtNewPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPass.Depth = 0;
            this.txtNewPass.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtNewPass.Location = new System.Drawing.Point(222, 91);
            this.txtNewPass.MaxLength = 50;
            this.txtNewPass.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNewPass.Multiline = false;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Password = true;
            this.txtNewPass.Size = new System.Drawing.Size(259, 50);
            this.txtNewPass.TabIndex = 1;
            this.txtNewPass.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(33, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "NEW PASSWORD";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(24, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 76);
            this.label2.TabIndex = 4;
            this.label2.Text = "CONFIRM NEW PASSWORD";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtConf
            // 
            this.txtConf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConf.Depth = 0;
            this.txtConf.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtConf.Location = new System.Drawing.Point(222, 183);
            this.txtConf.MaxLength = 50;
            this.txtConf.MouseState = MaterialSkin.MouseState.OUT;
            this.txtConf.Multiline = false;
            this.txtConf.Name = "txtConf";
            this.txtConf.Password = true;
            this.txtConf.Size = new System.Drawing.Size(259, 50);
            this.txtConf.TabIndex = 3;
            this.txtConf.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bebas Neue", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(40, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "OLD PASSWORD";
            // 
            // txtOldPass
            // 
            this.txtOldPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOldPass.Depth = 0;
            this.txtOldPass.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtOldPass.Location = new System.Drawing.Point(222, 285);
            this.txtOldPass.MaxLength = 50;
            this.txtOldPass.MouseState = MaterialSkin.MouseState.OUT;
            this.txtOldPass.Multiline = false;
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Password = true;
            this.txtOldPass.Size = new System.Drawing.Size(259, 50);
            this.txtOldPass.TabIndex = 5;
            this.txtOldPass.Text = "";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.Location = new System.Drawing.Point(518, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "SEE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button2.Location = new System.Drawing.Point(159, 467);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 49);
            this.button2.TabIndex = 8;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button3.Location = new System.Drawing.Point(299, 467);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 49);
            this.button3.TabIndex = 9;
            this.button3.Text = "SAVE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Menu;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Account Management";
            // 
            // AccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(606, 550);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountManagement";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox txtNewPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox txtConf;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialTextBox txtOldPass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
    }
}