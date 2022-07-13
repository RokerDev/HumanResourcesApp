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
        private List<Employee> _employees;

        public AddUpdateEmployee(int Id = 0)
        {
            InitializeComponent();
            _employeeId = Id;
            ReloadEmployees();
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
            _employees.Add(newEmployee);
        }

        private int SetIdForNewEmployee()
        {
            var highestEmployeeId = _employees.OrderByDescending(x => x.Id).FirstOrDefault();
            return highestEmployeeId == null ? 1 : highestEmployeeId.Id + 1;
        }

        private void ReloadEmployees()
        {
            _employees = _fileHelper.DeserializeFromFile();
        }

        private void SaveEmployees()
        {
            _fileHelper.SerializeToJsonFile(_employees);
        }

        private void RemoveOldEmployeeData()
        {
            _employees.RemoveAll(x => x.Id == _employeeId);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            if (_employeeId == 0)                  
                _employeeId = SetIdForNewEmployee();
            else
                //Prevent creating the same id when editing
                RemoveOldEmployeeData();

            AddEditEmployeeData();
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
