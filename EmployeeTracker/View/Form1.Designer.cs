namespace View
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tbInsert = new System.Windows.Forms.TabPage();
            this.btnExit3 = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.gbInsert = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.tbEmployee = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit2 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lbID = new System.Windows.Forms.ListBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.txtEditDOB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEditFirst = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEditEmail = new System.Windows.Forms.TextBox();
            this.txtEditPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEditLast = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbReports = new System.Windows.Forms.TabPage();
            this.btnExit1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblHours = new System.Windows.Forms.Label();
            this.lbEmpID = new System.Windows.Forms.ListBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnHourRep = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tbInsert.SuspendLayout();
            this.gbInsert.SuspendLayout();
            this.tbEmployee.SuspendLayout();
            this.gbDetails.SuspendLayout();
            this.tbReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tbInsert);
            this.tabControl.Controls.Add(this.tbEmployee);
            this.tabControl.Controls.Add(this.tbReports);
            this.tabControl.Location = new System.Drawing.Point(16, 18);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(568, 501);
            this.tabControl.TabIndex = 5;
            this.tabControl.Tag = "";
            // 
            // tbInsert
            // 
            this.tbInsert.BackColor = System.Drawing.Color.Transparent;
            this.tbInsert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbInsert.Controls.Add(this.btnExit3);
            this.tbInsert.Controls.Add(this.btnCreate);
            this.tbInsert.Controls.Add(this.gbInsert);
            this.tbInsert.Location = new System.Drawing.Point(4, 28);
            this.tbInsert.Margin = new System.Windows.Forms.Padding(4);
            this.tbInsert.Name = "tbInsert";
            this.tbInsert.Padding = new System.Windows.Forms.Padding(4);
            this.tbInsert.Size = new System.Drawing.Size(560, 469);
            this.tbInsert.TabIndex = 0;
            this.tbInsert.Tag = "Create";
            this.tbInsert.Text = "Create Employee";
            // 
            // btnExit3
            // 
            this.btnExit3.Location = new System.Drawing.Point(462, 416);
            this.btnExit3.Name = "btnExit3";
            this.btnExit3.Size = new System.Drawing.Size(87, 42);
            this.btnExit3.TabIndex = 8;
            this.btnExit3.Text = "Exit";
            this.btnExit3.UseVisualStyleBackColor = true;
            this.btnExit3.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(122, 305);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(137, 42);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create Employee";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // gbInsert
            // 
            this.gbInsert.Controls.Add(this.label4);
            this.gbInsert.Controls.Add(this.txtFirst);
            this.gbInsert.Controls.Add(this.label5);
            this.gbInsert.Controls.Add(this.txtLast);
            this.gbInsert.Controls.Add(this.label3);
            this.gbInsert.Controls.Add(this.txtEmail);
            this.gbInsert.Controls.Add(this.label2);
            this.gbInsert.Controls.Add(this.txtPhone);
            this.gbInsert.Controls.Add(this.label1);
            this.gbInsert.Controls.Add(this.txtDOB);
            this.gbInsert.Location = new System.Drawing.Point(20, 19);
            this.gbInsert.Name = "gbInsert";
            this.gbInsert.Size = new System.Drawing.Size(306, 268);
            this.gbInsert.TabIndex = 6;
            this.gbInsert.TabStop = false;
            this.gbInsert.Tag = "Create Employee";
            this.gbInsert.Text = "Employee Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date of Birth";
            // 
            // txtFirst
            // 
            this.txtFirst.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirst.Location = new System.Drawing.Point(107, 46);
            this.txtFirst.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(132, 27);
            this.txtFirst.TabIndex = 1;
            this.txtFirst.Tag = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone";
            // 
            // txtLast
            // 
            this.txtLast.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLast.Location = new System.Drawing.Point(107, 81);
            this.txtLast.Margin = new System.Windows.Forms.Padding(4);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(132, 27);
            this.txtLast.TabIndex = 3;
            this.txtLast.Tag = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(107, 116);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 27);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.Tag = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(107, 151);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(132, 27);
            this.txtPhone.TabIndex = 9;
            this.txtPhone.Tag = "Phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(107, 185);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(132, 27);
            this.txtDOB.TabIndex = 10;
            this.txtDOB.Tag = "DOB";
            // 
            // tbEmployee
            // 
            this.tbEmployee.BackColor = System.Drawing.Color.Transparent;
            this.tbEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbEmployee.Controls.Add(this.btnCancel);
            this.tbEmployee.Controls.Add(this.btnExit2);
            this.tbEmployee.Controls.Add(this.btnUpdate);
            this.tbEmployee.Controls.Add(this.btnRefresh);
            this.tbEmployee.Controls.Add(this.lbID);
            this.tbEmployee.Controls.Add(this.btnEdit);
            this.tbEmployee.Controls.Add(this.btnEnter);
            this.tbEmployee.Controls.Add(this.gbDetails);
            this.tbEmployee.Location = new System.Drawing.Point(4, 28);
            this.tbEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmployee.Name = "tbEmployee";
            this.tbEmployee.Padding = new System.Windows.Forms.Padding(4);
            this.tbEmployee.Size = new System.Drawing.Size(560, 469);
            this.tbEmployee.TabIndex = 1;
            this.tbEmployee.Tag = "Employees";
            this.tbEmployee.Text = "Current Employees";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(385, 320);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 41);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit2
            // 
            this.btnExit2.Location = new System.Drawing.Point(462, 416);
            this.btnExit2.Name = "btnExit2";
            this.btnExit2.Size = new System.Drawing.Size(87, 42);
            this.btnExit2.TabIndex = 8;
            this.btnExit2.Text = "Exit";
            this.btnExit2.UseVisualStyleBackColor = true;
            this.btnExit2.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(255, 320);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 41);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(7, 320);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 41);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lbID
            // 
            this.lbID.FormattingEnabled = true;
            this.lbID.ItemHeight = 19;
            this.lbID.Location = new System.Drawing.Point(7, 26);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(120, 270);
            this.lbID.TabIndex = 10;
            this.lbID.SelectedIndexChanged += new System.EventHandler(this.lbID_SelectedIndexChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(154, 255);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(192, 41);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit Employee Details";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Enabled = false;
            this.btnEnter.Location = new System.Drawing.Point(385, 255);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(164, 39);
            this.btnEnter.TabIndex = 8;
            this.btnEnter.Text = "Enter Employee Hours";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.txtEditDOB);
            this.gbDetails.Controls.Add(this.label6);
            this.gbDetails.Controls.Add(this.txtEditFirst);
            this.gbDetails.Controls.Add(this.label7);
            this.gbDetails.Controls.Add(this.txtEditEmail);
            this.gbDetails.Controls.Add(this.txtEditPhone);
            this.gbDetails.Controls.Add(this.label8);
            this.gbDetails.Controls.Add(this.label9);
            this.gbDetails.Controls.Add(this.txtEditLast);
            this.gbDetails.Controls.Add(this.label10);
            this.gbDetails.Location = new System.Drawing.Point(154, 18);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(395, 220);
            this.gbDetails.TabIndex = 7;
            this.gbDetails.TabStop = false;
            this.gbDetails.Tag = "Create Employee";
            this.gbDetails.Text = "Employee Details";
            // 
            // txtEditDOB
            // 
            this.txtEditDOB.Enabled = false;
            this.txtEditDOB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditDOB.Location = new System.Drawing.Point(157, 172);
            this.txtEditDOB.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditDOB.Name = "txtEditDOB";
            this.txtEditDOB.Size = new System.Drawing.Size(162, 27);
            this.txtEditDOB.TabIndex = 10;
            this.txtEditDOB.Tag = "DOB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "First Name";
            // 
            // txtEditFirst
            // 
            this.txtEditFirst.Enabled = false;
            this.txtEditFirst.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditFirst.Location = new System.Drawing.Point(157, 23);
            this.txtEditFirst.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditFirst.Name = "txtEditFirst";
            this.txtEditFirst.Size = new System.Drawing.Size(162, 27);
            this.txtEditFirst.TabIndex = 1;
            this.txtEditFirst.Tag = "First Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Last Name";
            // 
            // txtEditEmail
            // 
            this.txtEditEmail.Enabled = false;
            this.txtEditEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditEmail.Location = new System.Drawing.Point(157, 99);
            this.txtEditEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditEmail.Name = "txtEditEmail";
            this.txtEditEmail.Size = new System.Drawing.Size(162, 27);
            this.txtEditEmail.TabIndex = 3;
            this.txtEditEmail.Tag = "Email";
            // 
            // txtEditPhone
            // 
            this.txtEditPhone.Enabled = false;
            this.txtEditPhone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditPhone.Location = new System.Drawing.Point(157, 137);
            this.txtEditPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditPhone.Name = "txtEditPhone";
            this.txtEditPhone.Size = new System.Drawing.Size(162, 27);
            this.txtEditPhone.TabIndex = 9;
            this.txtEditPhone.Tag = "Phone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(63, 103);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(55, 141);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Phone";
            // 
            // txtEditLast
            // 
            this.txtEditLast.Enabled = false;
            this.txtEditLast.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditLast.Location = new System.Drawing.Point(157, 61);
            this.txtEditLast.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditLast.Name = "txtEditLast";
            this.txtEditLast.Size = new System.Drawing.Size(162, 27);
            this.txtEditLast.TabIndex = 5;
            this.txtEditLast.Tag = "Last Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 175);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 19);
            this.label10.TabIndex = 6;
            this.label10.Text = "Date of Birth";
            // 
            // tbReports
            // 
            this.tbReports.BackColor = System.Drawing.Color.Transparent;
            this.tbReports.Controls.Add(this.btnExit1);
            this.tbReports.Controls.Add(this.label11);
            this.tbReports.Controls.Add(this.txtTotal);
            this.tbReports.Controls.Add(this.lblHours);
            this.tbReports.Controls.Add(this.lbEmpID);
            this.tbReports.Controls.Add(this.dataGridView2);
            this.tbReports.Controls.Add(this.btnHourRep);
            this.tbReports.Location = new System.Drawing.Point(4, 28);
            this.tbReports.Margin = new System.Windows.Forms.Padding(4);
            this.tbReports.Name = "tbReports";
            this.tbReports.Padding = new System.Windows.Forms.Padding(4);
            this.tbReports.Size = new System.Drawing.Size(560, 469);
            this.tbReports.TabIndex = 2;
            this.tbReports.Tag = "Reports";
            this.tbReports.Text = "Reports";
            // 
            // btnExit1
            // 
            this.btnExit1.Location = new System.Drawing.Point(466, 420);
            this.btnExit1.Name = "btnExit1";
            this.btnExit1.Size = new System.Drawing.Size(87, 42);
            this.btnExit1.TabIndex = 7;
            this.btnExit1.Text = "Exit";
            this.btnExit1.UseVisualStyleBackColor = true;
            this.btnExit1.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 19);
            this.label11.TabIndex = 6;
            this.label11.Text = "Employee ID:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(319, 352);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(45, 27);
            this.txtTotal.TabIndex = 5;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(214, 355);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(99, 19);
            this.lblHours.TabIndex = 4;
            this.lblHours.Text = "Total Hours = ";
            // 
            // lbEmpID
            // 
            this.lbEmpID.FormattingEnabled = true;
            this.lbEmpID.ItemHeight = 19;
            this.lbEmpID.Location = new System.Drawing.Point(16, 26);
            this.lbEmpID.Name = "lbEmpID";
            this.lbEmpID.Size = new System.Drawing.Size(124, 289);
            this.lbEmpID.TabIndex = 3;
            this.lbEmpID.SelectedIndexChanged += new System.EventHandler(this.lbEmpID_SelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(183, 7);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(370, 314);
            this.dataGridView2.TabIndex = 2;
            // 
            // btnHourRep
            // 
            this.btnHourRep.Location = new System.Drawing.Point(16, 321);
            this.btnHourRep.Name = "btnHourRep";
            this.btnHourRep.Size = new System.Drawing.Size(124, 91);
            this.btnHourRep.TabIndex = 1;
            this.btnHourRep.Text = "Re/Generate Report for Employee Hours";
            this.btnHourRep.UseVisualStyleBackColor = true;
            this.btnHourRep.Click += new System.EventHandler(this.btnHourRep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 521);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Employee Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.VisibleChanged += new System.EventHandler(this.Form1_VisibilityChanged);
            this.tabControl.ResumeLayout(false);
            this.tbInsert.ResumeLayout(false);
            this.gbInsert.ResumeLayout(false);
            this.gbInsert.PerformLayout();
            this.tbEmployee.ResumeLayout(false);
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.tbReports.ResumeLayout(false);
            this.tbReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tbInsert;
        private System.Windows.Forms.TabPage tbEmployee;
        private System.Windows.Forms.TabPage tbReports;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox gbInsert;
        private System.Windows.Forms.ListBox lbID;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEditFirst;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEditEmail;
        private System.Windows.Forms.TextBox txtEditPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEditLast;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtEditDOB;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnHourRep;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.ListBox lbEmpID;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnExit3;
        private System.Windows.Forms.Button btnExit2;
        private System.Windows.Forms.Button btnExit1;
        private System.Windows.Forms.Button btnCancel;
    }
}

