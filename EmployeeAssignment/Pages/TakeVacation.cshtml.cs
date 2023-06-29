using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeAssignment.Pages
{
    public class TakeVacationModel : PageModel
    {
        private readonly ILogger<TakeVacationModel> _logger;

        public TakeVacationModel(ILogger<TakeVacationModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(int? id, double? days)
        {
            try
            {
                if (id != null)
                {
                    var emp = Constants.employees.Where(x => x.empId == id).SingleOrDefault();
                    if (emp != null)
                    {
                        switch (emp.empType)
                        {
                            case Constants.EmployeeType.Hourly:
                                new HourlyEmployee().TakeVacation(days.Value, id.Value);
                                break;
                            case Constants.EmployeeType.Salaried:
                                new SalariedEmployee().TakeVacation(days.Value, id.Value);
                                break;
                            case Constants.EmployeeType.Manager:
                                new Manager().TakeVacation(days.Value, id.Value);
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