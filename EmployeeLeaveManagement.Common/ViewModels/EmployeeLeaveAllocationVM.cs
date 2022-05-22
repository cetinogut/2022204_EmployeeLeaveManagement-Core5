using System;


namespace EmployeeLeaveManagement.Common.ViewModels
{
   public class EmployeeLeaveAllocationVM : BaseVM
    {
         public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }
        public int Period { get; set; }


        public string EmployeeId { get; set; }

        public EmployeeVM EmployeeVm { get; set; }

        public int EmployeeLeaveTypeId { get; set; }
        
        public EmployeeLeaveTypeVM EmployeeLeaveTypeVm { get; set; }
    }
}
