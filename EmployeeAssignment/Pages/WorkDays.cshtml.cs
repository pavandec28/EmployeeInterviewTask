using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeAssignment.Pages
{
    public class WorkDaysModel : PageModel
    {
        private readonly ILogger<WorkDaysModel> _logger;

        public WorkDaysModel(ILogger<WorkDaysModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(int? id, int? days)
        {
            try
            {
                if (id != null && days != null)
                {
                    var emp = Constants.employees.Where(x => x.empId == id).SingleOrDefault();
                    if (emp != null)
                    {
                        switch (emp.empType)
                        {
                            case Constants.EmployeeType.Hourly:
                                new HourlyEmployee().Work(days.Value, id.Value);
                                break;
                            case Constants.EmployeeType.Salaried:
                                new SalariedEmployee().Work(days.Value, id.Value);
                                break;
                            case Constants.EmployeeType.Manager:
                                new Manager().Work(days.Value, id.Value);
                                break;

                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}