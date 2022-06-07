using EmployeeLeaveManagement.BusinessEngine.Contracts;
using EmployeeLeaveManagement.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLeaveManagement.BusinessEngine.Implementation
{
    public class EmployeeLeaveTypeBusinessEngine : IEmployeeLeaveTypeBusinessEngine
    {
        private readonly IUnitOfWork _unitOfwork;
        public EmployeeLeaveTypeBusinessEngine(IUnitOfWork unitOfWork)
        {
            _unitOfwork = unitOfWork;
            
        }
    }
}
