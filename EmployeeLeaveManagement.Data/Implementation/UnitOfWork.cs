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
            employeeLeaveAllocationRepository = new EmployeeLeaveAllocationRepository(_context); // for private sets //bu inject işlemi için gerekli
            employeeLeaveRequestRepository = new EmployeeLeaveRequestRepository(_context);
            employeeLeaveTypeRepository = new EmployeeLeaveTypeRepository(_context);
            employeeRepository = new EmployeeRepository(_context);

            
        }
         
        //bunları UofW vasıtasıyla çağıracağımız için repositoryleri burada tanımlıyoruz.
        public IEmployeeLeaveAllocationRepository employeeLeaveAllocationRepository { get; private set; } // we dont want these values to be set from outside the class thats why we made them private set.
        public IEmployeeLeaveRequestRepository employeeLeaveRequestRepository { get; private set; }
        public IEmployeeLeaveTypeRepository employeeLeaveTypeRepository { get; private set; }
        public IEmployeeRepository employeeRepository { get; private set; }


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
