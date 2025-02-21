using MvcPerson.Models;

namespace MvcMovie.Models
{
    public class Employee : Person
    {
        public string EmployeeId { get; set; }
        public int Age { get; set; }

        public Employee()
        {
            EmployeeId = string.Empty;
            Age = 0;
        }
    }
}