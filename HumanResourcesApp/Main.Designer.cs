namespace HumanResourcesApp
{
    partial class Main
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvEmployeesList = new System.Windows.Forms.DataGridView();
            this.cmbGroups = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeesList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(333, 28);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Human Resource Manager";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Turquoise;
            this.btnAdd.Location = new System.Drawing.Point(632, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdate.Location = new System.Drawing.Point(713, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvEmployeesList
            // 
            this.dgvEmployeesList.AllowUserToAddRows = false;
            this.dgvEmployeesList.AllowUserToDeleteRows = false;
            this.dgvEmployeesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployeesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployeesList.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvEmployeesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeesList.GridColor = System.Drawing.Color.Aqua;
            this.dgvEmployeesList.Location = new System.Drawing.Point(12, 45);
            this.dgvEmployeesList.MultiSelect = false;
            this.dgvEmployeesList.Name = "dgvEmployeesList";
            this.dgvEmployeesList.ReadOnly = true;
            this.dgvEmployeesList.RowHeadersVisible = false;
            this.dgvEmployeesList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEmployeesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeesList.Size = new System.Drawing.Size(776, 521);
            this.dgvEmployeesList.TabIndex = 3;
            // 
            // cmbGroups
            // 
            this.cmbGroups.FormattingEnabled = true;
            this.cmbGroups.Location = new System.Drawing.Point(505, 12);
            this.cmbGroups.Name = "cmbGroups";
            this.cmbGroups.Size = new System.Drawing.Size(121, 21);
            this.cmbGroups.TabIndex = 4;
            this.cmbGroups.SelectedIndexChanged += new System.EventHandler(this.cmbGroups_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 578);
            this.Controls.Add(this.cmbGroups);
            this.Controls.Add(this.dgvEmployeesList);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbTitle);
            this.Name = "Main";
            this.Text = "Human Resources App";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeesList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvEmployeesList;
        private System.Windows.Forms.ComboBox cmbGroups;
    }
}

