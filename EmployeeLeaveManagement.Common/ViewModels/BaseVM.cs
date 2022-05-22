
using System.ComponentModel.DataAnnotations;


namespace EmployeeLeaveManagement.Common.ViewModels
{
    public class BaseVM
    {
        [Key]
        public int Id { get; set; }
    }
}
