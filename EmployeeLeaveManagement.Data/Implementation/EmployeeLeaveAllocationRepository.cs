using EmployeeLeaveManagement.Data.Contracts;
using EmployeeLeaveManagement.Data.DataContext;
using EmployeeLeaveManagement.Data.DbModels;


namespace EmployeeLeaveManagement.Data.Implementation
{
    public class EmployeeLeaveAllocationRepository : Repository<EmployeeLeaveAllocation>, IEmployeeLeaveAllocationRepository
    {
        private readonly EmployeeLeaveManagementContext _context;

        public EmployeeLeaveAllocationRepository(EmployeeLeaveManagementContext context) : base (context)
        {
            _context = context;

        }
    }
}
