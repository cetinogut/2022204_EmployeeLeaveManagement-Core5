using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLeaveManagement.Data.Contracts
{
    public  interface IUnitOfWork : IDisposable //işlem bitince garbage coleector ile kaybet.
    {
        IEmployeeLeaveAllocationRepository employeeLeaveAllocationRepository { get; }
        IEmployeeLeaveRequestRepository employeeLeaveRequestRepository { get;  }
        IEmployeeLeaveTypeRepository employeeLeaveTypeRepository { get; }
        IEmployeeRepository employeeRepository { get; }
        void Save();
    }
}
