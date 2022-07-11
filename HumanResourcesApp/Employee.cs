using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesApp
{
    class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime HiringDate { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Comments { get; set; }

        public int Salary { get; set; }
    }
}
