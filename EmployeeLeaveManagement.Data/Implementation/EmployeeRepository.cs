using EmployeeLeaveManagement.Data.Contracts;
using EmployeeLeaveManagement.Data.DataContext;
using EmployeeLeaveManagement.Data.DbModels;


namespace EmployeeLeaveManagement.Data.Implementation
{
   public  class EmployeeRepository : Repository <Employee>, IEmployeeRepository
    {
        private readonly EmployeeLeaveManagementContext _context;
        public EmployeeRepository(EmployeeLeaveManagementContext context) 
            : base (context)
        {
            _context = context;
        }
    }
}
