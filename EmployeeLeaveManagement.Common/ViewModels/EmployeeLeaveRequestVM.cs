using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLeaveManagement.Common.ViewModels
{
    public class EmployeeLeaveRequestVM :BaseVM
    {
        public string RequestingEmployeeId { get; set; }
        public EmployeeVM RequestingEmployee { get; set; }

        public int EmployeeLeaveTypeId { get; set; }
        public EmployeeLeaveTypeVM EmployeeLeaveType { get; set; }

        public string ApprovingEmployeeId { get; set; }
        public EmployeeVM ApprovingEmployee { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DateRequested { get; set; }

        [Display(Name="İzin Talebi Açıklama")]
        [MaxLength(300, ErrorMessage = "300 karakterden fazla değer girmeyiniz...")]
        public string RequestComments { get; set; }
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }
    }
}
