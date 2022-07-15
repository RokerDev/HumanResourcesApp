namespace HumanResourcesApp
{
    partial class AddUpdateEmployee
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
            this.lbFirstName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbHiringDate = new System.Windows.Forms.Label();
            this.lbReleaseDate = new System.Windows.Forms.Label();
            this.tbComments = new System.Windows.Forms.TextBox();
            this.lbComments = new System.Windows.Forms.Label();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.lbSalary = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnDismiss = new System.Windows.Forms.Button();
            this.tbEmployeeId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.dtpHiring = new System.Windows.Forms.DateTimePicker();
            this.dtpRelease = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(12, 41);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(57, 13);
            this.lbFirstName.TabIndex = 0;
            this.lbFirstName.Text = "First Name";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(101, 38);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(126, 20);
            this.tbFirstName.TabIndex = 1;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(101, 64);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(126, 20);
            this.tbLastName.TabIndex = 3;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(11, 67);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(58, 13);
            this.lbLastName.TabIndex = 2;
            this.lbLastName.Text = "Last Name";
            // 
            // lbHiringDate
            // 
            this.lbHiringDate.AutoSize = true;
            this.lbHiringDate.Location = new System.Drawing.Point(10, 145);
            this.lbHiringDate.Name = "lbHiringDate";
            this.lbHiringDate.Size = new System.Drawing.Size(72, 13);
            this.lbHiringDate.TabIndex = 4;
            this.lbHiringDate.Text = "Date of Hiring";
            // 
            // lbReleaseDate
            // 
            this.lbReleaseDate.AutoSize = true;
            this.lbReleaseDate.Location = new System.Drawing.Point(10, 171);
            this.lbReleaseDate.Name = "lbReleaseDate";
            this.lbReleaseDate.Size = new System.Drawing.Size(84, 13);
            this.lbReleaseDate.TabIndex = 6;
            this.lbReleaseDate.Text = "Date of Release";
            this.lbReleaseDate.Visible = false;
            // 
            // tbComments
            // 
            this.tbComments.Location = new System.Drawing.Point(100, 90);
            this.tbComments.Name = "tbComments";
            this.tbComments.Size = new System.Drawing.Size(126, 20);
            this.tbComments.TabIndex = 11;
            // 
            // lbComments
            // 
            this.lbComments.AutoSize = true;
            this.lbComments.Location = new System.Drawing.Point(11, 93);
            this.lbComments.Name = "lbComments";
            this.lbComments.Size = new System.Drawing.Size(56, 13);
            this.lbComments.TabIndex = 10;
            this.lbComments.Text = "Comments";
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(100, 116);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(126, 20);
            this.tbSalary.TabIndex = 13;
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.Location = new System.Drawing.Point(11, 119);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(36, 13);
            this.lbSalary.TabIndex = 12;
            this.lbSalary.Text = "Salary";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(146, 194);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(81, 23);
            this.Cancel.TabIndex = 14;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(12, 194);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(80, 23);
            this.btnConfirm.TabIndex = 15;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnDismiss
            // 
            this.btnDismiss.Location = new System.Drawing.Point(146, 223);
            this.btnDismiss.Name = "btnDismiss";
            this.btnDismiss.Size = new System.Drawing.Size(80, 23);
            this.btnDismiss.TabIndex = 16;
            this.btnDismiss.Text = "Dismiss";
            this.btnDismiss.UseVisualStyleBackColor = true;
            this.btnDismiss.Click += new System.EventHandler(this.btnDismiss_Click);
            // 
            // tbEmployeeId
            // 
            this.tbEmployeeId.Location = new System.Drawing.Point(101, 12);
            this.tbEmployeeId.Name = "tbEmployeeId";
            this.tbEmployeeId.ReadOnly = true;
            this.tbEmployeeId.Size = new System.Drawing.Size(126, 20);
            this.tbEmployeeId.TabIndex = 18;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(11, 15);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(65, 13);
            this.lbId.TabIndex = 17;
            this.lbId.Text = "Employee Id";
            // 
            // dtpHiring
            // 
            this.dtpHiring.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHiring.Location = new System.Drawing.Point(100, 142);
            this.dtpHiring.Name = "dtpHiring";
            this.dtpHiring.Size = new System.Drawing.Size(126, 20);
            this.dtpHiring.TabIndex = 19;
            this.dtpHiring.Value = new System.DateTime(2022, 7, 15, 12, 1, 59, 0);
            // 
            // dtpRelease
            // 
            this.dtpRelease.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRelease.Location = new System.Drawing.Point(100, 168);
            this.dtpRelease.Name = "dtpRelease";
            this.dtpRelease.Size = new System.Drawing.Size(126, 20);
            this.dtpRelease.TabIndex = 20;
            this.dtpRelease.Value = new System.DateTime(2022, 7, 15, 10, 17, 0, 0);
            this.dtpRelease.Visible = false;
            // 
            // AddUpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 258);
            this.Controls.Add(this.dtpRelease);
            this.Controls.Add(this.dtpHiring);
            this.Controls.Add(this.tbEmployeeId);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.btnDismiss);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.lbSalary);
            this.Controls.Add(this.tbComments);
            this.Controls.Add(this.lbComments);
            this.Controls.Add(this.lbReleaseDate);
            this.Controls.Add(this.lbHiringDate);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lbFirstName);
            this.Name = "AddUpdateEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbHiringDate;
        private System.Windows.Forms.Label lbReleaseDate;
        private System.Windows.Forms.TextBox tbComments;
        private System.Windows.Forms.Label lbComments;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.Label lbSalary;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnDismiss;
        private System.Windows.Forms.TextBox tbEmployeeId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.DateTimePicker dtpHiring;
        private System.Windows.Forms.DateTimePicker dtpRelease;
    }
}