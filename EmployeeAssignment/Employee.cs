using static EmployeeAssignment.Constants;

namespace EmployeeAssignment
{
    public class Employee
    {
        public int empId { get; set; }

        public string empFullName { get; set; }

        public EmployeeType empType { get; set; }

        public int workedDays { get; set; }

        public double noOfVacationDays { get; set; }
    }
}
