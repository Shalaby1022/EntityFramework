namespace EntityFramework
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
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.dgv_Employees = new System.Windows.Forms.DataGridView();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.nud_age = new System.Windows.Forms.NumericUpDown();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_age)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(263, 179);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(86, 31);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(26, 45);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(49, 20);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name";
            // 
            // dgv_Employees
            // 
            this.dgv_Employees.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_Employees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Employees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dgv_Employees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgv_Employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Employees.GridColor = System.Drawing.Color.IndianRed;
            this.dgv_Employees.Location = new System.Drawing.Point(14, 237);
            this.dgv_Employees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_Employees.Name = "dgv_Employees";
            this.dgv_Employees.RowHeadersWidth = 51;
            this.dgv_Employees.RowTemplate.Height = 25;
            this.dgv_Employees.Size = new System.Drawing.Size(887, 311);
            this.dgv_Employees.TabIndex = 2;
            this.dgv_Employees.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Employees_RowHeaderMouseDoubleClick);
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Location = new System.Drawing.Point(39, 111);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(36, 20);
            this.lbl_age.TabIndex = 3;
            this.lbl_age.Text = "Age";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(337, 107);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(70, 20);
            this.lbl_pass.TabIndex = 5;
            this.lbl_pass.Text = "Password";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(337, 35);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(46, 20);
            this.lbl_email.TabIndex = 6;
            this.lbl_email.Text = "Email";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(119, 35);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(137, 27);
            this.txt_name.TabIndex = 7;
            // 
            // nud_age
            // 
            this.nud_age.Location = new System.Drawing.Point(119, 100);
            this.nud_age.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nud_age.Name = "nud_age";
            this.nud_age.Size = new System.Drawing.Size(137, 27);
            this.nud_age.TabIndex = 8;
            this.nud_age.ValueChanged += new System.EventHandler(this.nud_age_ValueChanged);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(413, 35);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(150, 27);
            this.txt_email.TabIndex = 10;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(413, 104);
            this.txt_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(150, 27);
            this.txt_password.TabIndex = 11;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(383, 179);
            this.btn_update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(86, 31);
            this.btn_update.TabIndex = 14;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(502, 179);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(86, 31);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(620, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Address";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(691, 32);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 27);
            this.textBox1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 564);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.nud_age);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.dgv_Employees);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_add);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_age)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void nud_age_ValueChanged(object sender, EventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.DataGridView dgv_Employees;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.NumericUpDown nud_age;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
