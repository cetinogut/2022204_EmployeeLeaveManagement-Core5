using AutoMapper;
using EmployeeLeaveManagement.BusinessEngine.Contracts;
using EmployeeLeaveManagement.Common.ConstantModels;
using EmployeeLeaveManagement.Common.ResultModels;
using EmployeeLeaveManagement.Common.ViewModels;
using EmployeeLeaveManagement.Data.Contracts;
using EmployeeLeaveManagement.Data.DbModels;
using EmployeeLeaveManagement.Data.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeLeaveManagement.BusinessEngine.Implementation
{
    public class EmployeeLeaveTypeBusinessEngine : IEmployeeLeaveTypeBusinessEngine
    {
        #region Variables
        private readonly IUnitOfWork _unitOfwork;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public EmployeeLeaveTypeBusinessEngine(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfwork = unitOfWork;
            _mapper = mapper;

        }

        
        #endregion

        #region Custom Methods
        public Result<List<EmployeeLeaveTypeVM>> GetAllEmployeeLeaveTypes()
        {
            var data = _unitOfwork.employeeLeaveTypeRepository.GetAll( ).ToList();

            // following code block is an example of  returning the view without using the view model.
            #region method1
            //if (data != null)
            //{
            //    List<EmployeeLeaveType> returndata = new List<EmployeeLeaveType>();

            //    foreach (var item in data)
            //    {
            //        returndata.Add(new EmployeeLeaveType()
            //        {
            //            Id = item.Id,
            //            DateCreated = item.DateCreated,
            //            DefaultDays = item.DefaultDays,
            //            Name = item.Name
            //        });

            //    }

            //    return new Result<List<EmployeeLeaveType>>(true, ResultMessages.RecordFound, returndata);

            //}

            //// if result is null
            ////return new Result<List<EmployeeLeaveType>>(false, "Data bulunamadı");
            //return new Result<List<EmployeeLeaveType>>(false, ResultMessages.RecordNotFound); 
            #endregion

            // following lcode block is using Mapper and VM

            #region method2
            var leaveTypes = _mapper.Map<List<EmployeeLeaveType>, List<EmployeeLeaveTypeVM>>(data);
            return new Result<List<EmployeeLeaveTypeVM>>(true, ResultConstants.RecordFound, leaveTypes); 
            #endregion


        }

        
        public Result<EmployeeLeaveTypeVM> CreateEmployeeLeaveType(EmployeeLeaveTypeVM model)
        {
            if (model != null)
            {
                try
                {
                    var leaveType = _mapper.Map<EmployeeLeaveTypeVM, EmployeeLeaveType>(model);
                    leaveType.DateCreated = DateTime.Now;
                    leaveType.DateUpdated = DateTime.Now;
                    leaveType.IsActive = true;
                    _unitOfwork.employeeLeaveTypeRepository.Add(leaveType);
                    _unitOfwork.Save();
                    return new Result<EmployeeLeaveTypeVM>(true, ResultConstants.RecordCreatedWithSuccess);
                }
                catch (Exception ex)
                {

                    return new Result<EmployeeLeaveTypeVM>(false, ResultConstants.RecordCreationFailure + " - " + ex.Message.ToString());
                }
            }
            else
                return new Result<EmployeeLeaveTypeVM>(false, ResultConstants.RecordCreationFailure);
        }

        public Result<EmployeeLeaveTypeVM> EditEmployeeLeaveType(EmployeeLeaveTypeVM model)
        {
            if (model != null)
            {
                try
                {
                    var leaveType = _mapper.Map<EmployeeLeaveTypeVM, EmployeeLeaveType>(model);
                    leaveType.DateUpdated = DateTime.Now;
                    _unitOfwork.employeeLeaveTypeRepository.Update(leaveType);
                    _unitOfwork.Save();
                    return new Result<EmployeeLeaveTypeVM>(true, ResultConstants.RecordCreatedWithSuccess);
                }
                catch (Exception ex)
                {

                    return new Result<EmployeeLeaveTypeVM>(false, ResultConstants.RecordCreationFailure + " - " + ex.Message.ToString());
                }
            }
            else
                return new Result<EmployeeLeaveTypeVM>(false, ResultConstants.RecordCreationFailure);
        }

        public Result<EmployeeLeaveTypeVM> GetEmployeeLeaveType(int id)
        {
           var data = _unitOfwork.employeeLeaveTypeRepository.Get(id);
            if (data != null)
            {
                var leaveType = _mapper.Map<EmployeeLeaveType, EmployeeLeaveTypeVM>(data);
                return new Result<EmployeeLeaveTypeVM>(true, ResultConstants.RecordFound, leaveType);
            }
            else
            {
                return new Result<EmployeeLeaveTypeVM>(false, ResultConstants.RecordNotFound);
            }
        }

        public Result<EmployeeLeaveTypeVM> RemoveEmployeeLeaveType(int id)
        {
            var data = _unitOfwork.employeeLeaveTypeRepository.Get(id);
            if (data != null)
            {
                data.IsActive = false;
                data.DateUpdated = DateTime.Now;
               // _unitOfwork.employeeLeaveTypeRepository.Remove(data); // no data deletion, just update the IsActive property
                _unitOfwork.employeeLeaveTypeRepository.Update(data);
                _unitOfwork.Save();
                return new Result<EmployeeLeaveTypeVM>(true, ResultConstants.RecordDeletedWithSuccess);
            }
            else
                return new Result<EmployeeLeaveTypeVM>(false, ResultConstants.RecordDeletionFailure);
        }
        #endregion




    }
}
