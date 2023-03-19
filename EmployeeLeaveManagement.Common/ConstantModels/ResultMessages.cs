using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLeaveManagement.Common.ConstantModels
{
    public static class ResultMessages
    {
        public const string RecordFound = "İşlem başarılı, kayıt bulundu";
        public const string RecordNotFound = "İşlem başarısız, kayıt bulunamadı";
        public const string RecordCreatedWithSuccess = "Data saved to DB with success";
        public const string RecordCreationFailure = "Data could not be saved  to DB !!!";
        public const string RecordDeletedWithSuccess = "Data deleted from DB with success";
        public const string RecordDeletionFailure = "Data could not be deleted from DB !!!";




    }
}
