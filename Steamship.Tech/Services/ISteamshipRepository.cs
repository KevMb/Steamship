using Steamship.Tech.Models;
using System.Collections.Generic;

namespace Steamship.Tech.Services
{
    public interface ISteamshipRepository
    {
        IEnumerable<EmployeeDetail> GetEmployees();
    }
}
