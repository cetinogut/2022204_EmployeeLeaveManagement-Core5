using EmployeeLeaveManagement.Common.ResultModels;
using EmployeeLeaveManagement.Common.ViewModels;
using System.Collections.Generic;

namespace EmployeeLeaveManagement.BusinessEngine.Contracts
{
    public interface IEmployeeLeaveTypeBusinessEngine
    {
        Result<List<EmployeeLeaveTypeVM>> GetAllEmployeeLeaveTypes();
    }
}
