using Steamship.Tech.DbContexts;
using Steamship.Tech.Models;
using System.Collections.Generic;
using System.Linq;

namespace Steamship.Tech.Services
{
    public class SteamshipRepository : ISteamshipRepository
    {
        private readonly SteamshipContext _steamshipContext;

        public SteamshipRepository(SteamshipContext steamshipContext)
        {
            _steamshipContext = steamshipContext;
        }

        public IEnumerable<EmployeeDetail> GetEmployees()
        {
            var employees = _steamshipContext.Employees.ToList();

            var employeeDetails = new List<EmployeeDetail>();

            foreach (var employee in employees)
            {
                employeeDetails.Add(
                    new EmployeeDetail
                    {
                        EmployeeName = employee.FirstName + " " + employee.LastName,
                        LineManagerName = GetManagerName(employee.LineManagerId),
                        TotalSales = GetTotalNumberOfSales(employee.EmployeeId),
                        TotalSalesFigure = GetSalesFigures(employee.EmployeeId)
                    }
                );
            }

            return employeeDetails
                .OrderByDescending(s => s.TotalSalesFigure);
        }

        private string GetManagerName(int? managerId)
        {
            if (managerId == null)
            {
                return "No Manager";
            }

            var managerDetail = _steamshipContext.Employees
                .Where(m => m.EmployeeId == managerId)
                .Select(m => new ManagerDetail { ManagerName = m.FirstName + " " + m.LastName })
                .FirstOrDefault();

            return managerDetail.ManagerName;
        }

        private int GetTotalNumberOfSales(int employeeId)
        {
            return _steamshipContext.Sales
                .Where(e => e.EmployeeId == employeeId)
                .Count();
        }

        private double GetSalesFigures(int employeeId)
        {
            return _steamshipContext.Sales
                .Where(e => e.EmployeeId == employeeId)
                .Select(e => e.SalePrice)
                .Sum();
        }
    }
}
