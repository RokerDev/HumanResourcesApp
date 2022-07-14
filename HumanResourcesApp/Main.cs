using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HumanResourcesApp
{
    public partial class Main : Form
    {
        private FileHelper<List<Employee>> _fileHelper = new FileHelper<List<Employee>>(Program.FilePath);
        private List<Group> _groups = GroupHelper.GetGroupsData();

        public Main()
        {
            InitializeComponent();
            InitGroupComboBox();
            ReloadEmployeeList();
            SetColumnHeaders();
            HideColumnNames();
        }

        private void HideColumnNames()
        {
            dgvEmployeesList.Columns[nameof(Employee.GroupId)].Visible = false;
            dgvEmployeesList.Columns[nameof(Employee.Id)].Visible = false;
        }

        private void SetColumnHeaders()
        {
            dgvEmployeesList.Columns[nameof(Employee.Id)].HeaderText = "Id";
            dgvEmployeesList.Columns[nameof(Employee.FirstName)].HeaderText = "First Name"; 
            dgvEmployeesList.Columns[nameof(Employee.LastName)].HeaderText = "Last Name";
            dgvEmployeesList.Columns[nameof(Employee.HiringDate)].HeaderText = "Hiring Date";
            dgvEmployeesList.Columns[nameof(Employee.ReleaseDate)].HeaderText = "Release Date";
            dgvEmployeesList.Columns[nameof(Employee.Comments)].HeaderText = "Comments";
            dgvEmployeesList.Columns[nameof(Employee.Salary)].HeaderText = "Salary";
            dgvEmployeesList.Columns[nameof(Employee.GroupId)].HeaderText = "Group Id";
        }

        private void InitGroupComboBox()
        {
            cmbGroups.DataSource = _groups;
            cmbGroups.DisplayMember = "Name";
            cmbGroups.ValueMember = "Id";
        }

        private void ReloadEmployeeList()
        {
            var employees = _fileHelper.DeserializeFromFile();
            var selectedGroup = (cmbGroups.SelectedItem as Group).Id;

            if (selectedGroup != 0)
                employees = employees.Where(x => x.GroupId == selectedGroup).ToList();

            dgvEmployeesList.DataSource = employees;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addUpdateEmployee = new AddUpdateEmployee();
            addUpdateEmployee.FormClosing += AddUpdateEmployee_FormClosing;
            addUpdateEmployee.ShowDialog();
        }

        private void AddUpdateEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReloadEmployeeList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var selectedEmployee = dgvEmployeesList.SelectedRows;
            var selectedEmployeeId = Convert.ToInt32(selectedEmployee[0].Cells[0].Value);
            var addUpdateEmployee = new AddUpdateEmployee(selectedEmployeeId);
            addUpdateEmployee.FormClosing += AddUpdateEmployee_FormClosing;
            addUpdateEmployee.ShowDialog();
        }

        private void cmbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadEmployeeList();
        }
    }
}
