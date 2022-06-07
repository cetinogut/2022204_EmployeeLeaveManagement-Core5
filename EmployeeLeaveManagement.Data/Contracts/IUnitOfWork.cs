using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLeaveManagement.Data.Contracts
{
    public  interface IUnitOfWork : IDisposable
    {
        IEmployeeLeaveAllocationRepository employeeLeaveAllocation { get; }
        IEmployeeLeaveRequestRepository employeeLeaveRequest { get;  }
        IEmployeeLeaveTypeRepository employeeLeaveType { get; }
        void Save();
    }
}
