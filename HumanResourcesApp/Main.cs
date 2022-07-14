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
    public partial class Main : Form
    {
        private FileHelper<List<Employee>> _fileHelper = new FileHelper<List<Employee>>(Program.FilePath);
        public Main()
        {
            InitializeComponent();
            ReloadEmployeeList();
        }

        private void ReloadEmployeeList()
        {
            var employees = _fileHelper.DeserializeFromFile();
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
    }
}
