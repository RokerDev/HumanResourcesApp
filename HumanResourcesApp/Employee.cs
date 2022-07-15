using System;

namespace HumanResourcesApp
{
    class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime HiringDate { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public string Comments { get; set; }

        public decimal Salary { get; set; }

        public int GroupId { get; set; }
    }
}
