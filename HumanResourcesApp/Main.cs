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
        public Main()
        {
            InitializeComponent();
            FileHelper.SerializeToJsonFile(new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    FirstName = "Dawid",
                    LastName = "Brzozowski",
                    HiringDate = new DateTime(1991, 02, 14),
                    ReleaseDate = new DateTime(2022, 02, 02),
                    Comments = "",
                    Salary = 500
                },
                new Employee
                {
                    Id = 1,
                    FirstName = "Dawid",
                    LastName = "Brzozowski",
                    HiringDate = new DateTime(1991, 02, 14),
                    ReleaseDate = new DateTime(2022, 02, 02),
                    Comments = "",
                    Salary = 500
                }
            });
            var employees = FileHelper.DeserializeFromFile();
            foreach (var employee in employees)
            {
                MessageBox.Show(employee.FirstName);
            }
        }

    }
}
