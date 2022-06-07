using EmployeeLeaveManagement.Data.Contracts;
using EmployeeLeaveManagement.Data.DataContext;


namespace EmployeeLeaveManagement.Data.Implementation
{
    public class UnitOfWork : IUnitOfWork  // database rollbacks are done via this class
    {
        private readonly EmployeeLeaveManagementContext _context;
        public UnitOfWork(EmployeeLeaveManagementContext context)
        {
            _context = context;
            employeeLeaveAllocation = new EmployeeLeaveAllocationRepository(_context);
            employeeLeaveRequest = new EmployeeLeaveRequestRepository(_context);
            employeeLeaveType = new EmployeeLeaveTypeRepository(_context);
        }
         
        public IEmployeeLeaveAllocationRepository employeeLeaveAllocation { get; private set; }
        public IEmployeeLeaveRequestRepository employeeLeaveRequest { get; private set; }
        public IEmployeeLeaveTypeRepository employeeLeaveType { get; private set; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
