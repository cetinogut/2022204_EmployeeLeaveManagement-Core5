using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLeaveManagement.Common.ViewModels
{
    public class EmployeeVM // this does not inherti from baseVM because the id in .net table is string
    {
        public string  Id { get; set; }

        [Display(Name ="Kullanıcı Adı")]
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
