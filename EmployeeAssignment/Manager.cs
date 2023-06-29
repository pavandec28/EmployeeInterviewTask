using Microsoft.VisualBasic;

namespace EmployeeAssignment
{
    public class Manager
    {
        public void Work(int daysWorked, int empId)
        {
            try
            {
                int currentWorkDays = Constants.employees.Where(x => x.empId == empId).SingleOrDefault().workedDays;
                if (currentWorkDays < daysWorked)
                {
                    Constants.employees.Where(x => x.empId == empId).SingleOrDefault().workedDays = daysWorked;

                    double vacationRate = (30.0 / 260.0);
                    double vacationDays = Math.Round((vacationRate * (daysWorked - currentWorkDays)), 2);
                    double currentVacationCount = Constants.employees.Where(x => x.empId == empId).SingleOrDefault().noOfVacationDays;
                    Constants.employees.Where(x => x.empId == empId).SingleOrDefault().noOfVacationDays = currentVacationCount + vacationDays;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void TakeVacation(double vacationUsed, int empId)
        {
            try
            {
                double vacation = Constants.employees.Where(x => x.empId == empId).SingleOrDefault().noOfVacationDays;
                if (vacation > 1)
                    Constants.employees.Where(x => x.empId == empId).SingleOrDefault().noOfVacationDays = vacation - vacationUsed;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
