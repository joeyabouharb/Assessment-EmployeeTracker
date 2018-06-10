namespace View
{
    partial class form2
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
            this.gbHours = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbHours.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbHours
            // 
            this.gbHours.Controls.Add(this.label4);
            this.gbHours.Controls.Add(this.label2);
            this.gbHours.Controls.Add(this.lblID);
            this.gbHours.Controls.Add(this.txtHours);
            this.gbHours.Controls.Add(this.txtDate);
            this.gbHours.Location = new System.Drawing.Point(12, 22);
            this.gbHours.Name = "gbHours";
            this.gbHours.Size = new System.Drawing.Size(198, 158);
            this.gbHours.TabIndex = 0;
            this.gbHours.TabStop = false;
            this.gbHours.Text = "Hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hours Worked";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Working Date";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(73, 16);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(28, 13);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "lblID";
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(85, 86);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(100, 20);
            this.txtHours.TabIndex = 3;
            this.txtHours.Tag = "Hours";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(85, 46);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 2;
            this.txtDate.Tag = "Date";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(10, 186);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(81, 34);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(116, 186);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 34);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 228);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.gbHours);
            this.Name = "form2";
            this.Text = "Adding Employee Hours";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gbHours.ResumeLayout(false);
            this.gbHours.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHours;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button btnExit;
    }
}