using EmployeeLeaveManagement.Data.Contracts;
using EmployeeLeaveManagement.Data.DataContext;
using EmployeeLeaveManagement.Data.DbModels;

namespace EmployeeLeaveManagement.Data.Implementation
{
    public class EmployeeLeaveRequestRepository : Repository<EmployeeLeaveRequest>, IEmployeeLeaveRequestRepository
    {
        private readonly EmployeeLeaveManagementContext _context;
        public EmployeeLeaveRequestRepository(EmployeeLeaveManagementContext context) : base(context)
        {
            _context = context;
        }
    }
}
