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

        public AddUpdateEmployee()
        {
            InitializeComponent();
        }

        private Employee HireNewEmpolyee()
        {
            return new Employee
            {
                Id = SetNewId(),
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                HiringDate = Convert.ToDateTime(tbHiring.Text),
                ReleaseDate = Convert.ToDateTime(tbRelease.Text),
                Comments = tbComments.Text,
                Salary = Convert.ToInt32(tbSalary.Text)
            };
        }
    }
}
