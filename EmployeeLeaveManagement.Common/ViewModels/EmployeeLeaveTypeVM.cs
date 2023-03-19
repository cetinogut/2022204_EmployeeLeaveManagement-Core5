using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeLeaveManagement.Common.ViewModels
{
    public class EmployeeLeaveTypeVM :BaseVM
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int DefaultDays { get; set; }
        public DateTime DateCreated { get; set; }

        [Display(Name = "Last Update")]
        public DateTime DateUpdated { get; set; }

        public bool IsActive { get; set; }

        //MVVM Create EmployeeType
        public void SetEmployeeType(string name)
        {
            this.Name = name;
        }
    }
}
