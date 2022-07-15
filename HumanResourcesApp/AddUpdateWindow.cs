using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HumanResourcesApp
{
    public partial class AddUpdateEmployee : Form
    {
        private FileHelper<List<Employee>> _fileHelper = new FileHelper<List<Employee>>(Program.FilePath);
        private int _employeeId;
        private Employee _employee;
        private List<Employee> _employeesList;
        private int _groupId;
        private DateTime? _releaseDate;

        public AddUpdateEmployee(int Id = 0)
        {
            InitializeComponent();
            _employeesList = _fileHelper.DeserializeFromFile();
            _employeeId = Id;
            _groupId = 1;

            GetEmployeeData();
        }

        private void GetEmployeeData()
        {
            if (_employeeId != 0)
            {
                Text = "Edit Employee Data";
                _employee = _employeesList.Where(x => x.Id == _employeeId).FirstOrDefault();
                AssingEmployeeDataToTextBox();
            }
            else
            {
                btnDismiss.Visible = false;
                Height = Size.Height - 30;
            }
        }

        private void AssingEmployeeDataToTextBox()
        {
            tbEmployeeId.Text = _employee.Id.ToString();
            tbFirstName.Text = _employee.FirstName;
            tbLastName.Text = _employee.LastName;
            dtpHiring.Value = _employee.HiringDate;
            if (_employee.ReleaseDate.HasValue)
                dtpRelease.Value = (DateTime)_employee.ReleaseDate;
            tbComments.Text = _employee.Comments;
            nudSalary.Value = _employee.Salary;
        }

        private void AddEditEmployeeData()
        {
            var newEmployee = new Employee
            {
                Id = _employeeId,
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                HiringDate = Convert.ToDateTime(dtpHiring.Value.ToShortDateString()),
                ReleaseDate = _releaseDate,
                Comments = tbComments.Text,
                Salary = nudSalary.Value,
                GroupId = _groupId
            };

            _employeesList.Add(newEmployee);
        }

        private int SetIdForNewEmployee()
        {
            var highestEmployeeId = _employeesList.OrderByDescending(x => x.Id).FirstOrDefault();
            return highestEmployeeId == null ? 1 : highestEmployeeId.Id + 1;
        }

        private void SaveEmployees()
        {
            if (_employeeId == 0)
                _employeeId = SetIdForNewEmployee();
            else
                //Prevent creating the same id when editing
                RemoveOldEmployeeData();

            AddEditEmployeeData();
            _fileHelper.SerializeToJsonFile(_employeesList);
        }

        private void RemoveOldEmployeeData()
        {
            _employeesList.RemoveAll(x => x.Id == _employeeId);
        }

        private void Dismiss_Employee()
        {
            _groupId = 2;
            lbReleaseDate.Visible = true;
            dtpRelease.Visible = true;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (_groupId == 2)
                _releaseDate = Convert.ToDateTime(dtpRelease.Value.ToShortDateString());    
            SaveEmployees();
            Close();
        }

        private void btnDismiss_Click(object sender, EventArgs e)
        {
            var userAnswer = 
                MessageBox.Show($"Are you sure to dismiss " +
                $"{_employee.FirstName} {_employee.LastName}".Trim(),
                "Dismiss Employee",
                MessageBoxButtons.YesNo);

            if (userAnswer == DialogResult.Yes)
            {
                Dismiss_Employee();
            }
        }
    }
}
