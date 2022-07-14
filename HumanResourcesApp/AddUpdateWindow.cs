using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResourcesApp
{
    public partial class AddUpdateEmployee : Form
    {
        private FileHelper<List<Employee>> _fileHelper = new FileHelper<List<Employee>>(Program.FilePath);
        private int _employeeId;
        private Employee _employee;
        private List<Employee> _employeesList;

        public AddUpdateEmployee(int Id = 0)
        {
            InitializeComponent();
            LoadListOfEmployees();
            _employeeId = Id;
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
            tbHiring.Text = _employee.HiringDate;
            tbRelease.Text = _employee.ReleaseDate;
            tbComments.Text = _employee.Comments;
            tbSalary.Text = _employee.Salary;
        }

        private void AddEditEmployeeData()
        {
            var newEmployee =  new Employee
            {
                Id = _employeeId,
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                HiringDate = tbHiring.Text,
                ReleaseDate = tbRelease.Text,
                Comments = tbComments.Text,
                Salary = tbSalary.Text
            };
            _employeesList.Add(newEmployee);
        }

        private int SetIdForNewEmployee()
        {
            var highestEmployeeId = _employeesList.OrderByDescending(x => x.Id).FirstOrDefault();
            return highestEmployeeId == null ? 1 : highestEmployeeId.Id + 1;
        }

        private void LoadListOfEmployees()
        {
            _employeesList = _fileHelper.DeserializeFromFile();
        }

        private void SaveEmployees()
        {
            _fileHelper.SerializeToJsonFile(_employeesList);
        }

        private void RemoveOldEmployeeData()
        {
            _employeesList.RemoveAll(x => x.Id == _employeeId);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            if (_employeeId == 0)                  
                _employeeId = SetIdForNewEmployee();
            else
                //Prevent creating the same id when editing
                RemoveOldEmployeeData();

            AddEditEmployeeData();
            SaveEmployees();
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
