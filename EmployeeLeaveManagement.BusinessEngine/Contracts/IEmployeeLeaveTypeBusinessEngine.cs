using EmployeeLeaveManagement.Common.ResultModels;
using EmployeeLeaveManagement.Common.ViewModels;
using System.Collections.Generic;

namespace EmployeeLeaveManagement.BusinessEngine.Contracts
{
    public interface IEmployeeLeaveTypeBusinessEngine
    {
        Result<List<EmployeeLeaveTypeVM>> GetAllEmployeeLeaveTypes();

        /// <summary>
        /// Creates new employee leave type
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        Result<EmployeeLeaveTypeVM> CreateEmployeeLeaveType(EmployeeLeaveTypeVM model);

        /// <summary>
        /// Updated the LEave Type data
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Result<EmployeeLeaveTypeVM> EditEmployeeLeaveType(EmployeeLeaveTypeVM model);

        /// <summary>
        /// Get Employee Leave Type by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Result<EmployeeLeaveTypeVM> GetEmployeeLeaveType(int id);

        Result<EmployeeLeaveTypeVM> RemoveEmployeeLeaveType(int id);
    }
}
