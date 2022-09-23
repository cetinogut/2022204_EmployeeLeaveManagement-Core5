using EmployeeLeaveManagement.Data.Contracts;
using EmployeeLeaveManagement.Data.DataContext;
using EmployeeLeaveManagement.Data.DbModels;


namespace EmployeeLeaveManagement.Data.Implementation
{
   public  class EmployeeLeaveTypeRepository : Repository <EmployeeLeaveType>, IEmployeeLeaveTypeRepository
    {
        private readonly EmployeeLeaveManagementContext _context;
        public EmployeeLeaveTypeRepository(EmployeeLeaveManagementContext context) 
            : base (context)
        {
            _context = context;
        }
    }
}
