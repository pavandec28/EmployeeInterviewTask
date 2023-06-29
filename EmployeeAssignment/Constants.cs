namespace EmployeeAssignment
{
    public class Constants
    {
        public enum EmployeeType
        {
            Hourly = 1,
            Salaried = 2,
            Manager = 3
        }

        public static List<Employee> employees = new List<Employee>()
        {
            new Employee()
            {
                empId = 1,
                empFullName = "Mason Nelson",
                empType = Constants.EmployeeType.Hourly,
                workedDays=0,
                noOfVacationDays = 0
            },
            new Employee()
            {
                empId = 2,
                empFullName = "Lara Cannon",
                empType = Constants.EmployeeType.Salaried,
                workedDays=0,
                noOfVacationDays = 0
            },
            new Employee()
            {
                empId = 3,
                empFullName = "Aliya Cole",
                empType = Constants.EmployeeType.Salaried,
                workedDays=0,
                noOfVacationDays = 0
            },
            new Employee()
            {
                empId = 4,
                empFullName = "Beatrice Buchanan",
                empType = Constants.EmployeeType.Manager,
                workedDays=0,
                noOfVacationDays = 0
            },
            new Employee()
            {
                empId = 5,
                empFullName = "Catherine Spencer",
                empType = Constants.EmployeeType.Manager,
                workedDays=0,
                noOfVacationDays = 0
            },
            new Employee()
            {
                empId = 6,
                empFullName = "Faith Lynn",
                empType = Constants.EmployeeType.Hourly,
                workedDays=0,
                noOfVacationDays = 0
            },
            new Employee()
            {
                empId = 7,
                empFullName = "Kadence Yates",
                empType = Constants.EmployeeType.Salaried,
                workedDays=0,
                noOfVacationDays = 0
            },
            new Employee()
            {
                empId = 8,
                empFullName = "Chaz Shannon",
                empType = Constants.EmployeeType.Salaried,
                workedDays=4,
                noOfVacationDays = 6.5
            },
            new Employee()
            {
                empId = 9,
                empFullName = "Raymond Oconnell",
                empType = Constants.EmployeeType.Hourly,
                workedDays=0,
                noOfVacationDays = 0
            },
            new Employee()
            {
                empId = 10,
                empFullName = "Julianne Manning",
                empType = Constants.EmployeeType.Hourly,
                workedDays=0,
                noOfVacationDays = 0
            }
        };
    }
}
