using AutoMapper;
using EmployeeLeaveManagement.Common.ViewModels;
using EmployeeLeaveManagement.Data.DbModels;


namespace EmployeeLeaveManagement.Common.Mappings
{
  public  class Maps : Profile
    {
        public Maps()
        {
            CreateMap<EmployeeLeaveType, EmployeeLeaveTypeVM>().ReverseMap();
            CreateMap<EmployeeLeaveRequest, EmployeeLeaveRequestVM>().ReverseMap();
            CreateMap<EmployeeLeaveAllocation, EmployeeLeaveAllocationVM>().ReverseMap();
            CreateMap<Employee, EmployeeVM>().ReverseMap();
        }
        
    }
}
