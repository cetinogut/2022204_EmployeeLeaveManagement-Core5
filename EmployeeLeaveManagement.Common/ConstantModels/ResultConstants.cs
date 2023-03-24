using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLeaveManagement.Common.ConstantModels
{
    public static class ResultConstants
    {
        public const string RecordFound = "İşlem başarılı, kayıt bulundu";
        public const string RecordNotFound = "İşlem başarısız, kayıt bulunamadı";
        public const string RecordCreatedWithSuccess = "Data saved to DB with success";
        public const string RecordCreationFailure = "Data could not be saved  to DB !!!";
        public const string RecordDeletedWithSuccess = "Data deleted from DB with success";
        public const string RecordDeletionFailure = "Data could not be deleted from DB !!!";


        //---------------------------------------------------------------------------------------//
        public const string Admin_Role = "Administrator";
        public const string Employee_Role = "Employee";

        public const string Admin_Email = "cogut1@gmail.com";
        public const string Admin_Password = "Admin123!";
        //---------------------------------------------------------------------------------------//
        public const string LoginUserInfo = "Giriş Yapan Kullanıcı Bilgisi";
        //---------------------------------------------------------------------------------------//
        public const string MailTagHelperSuffix = "noktaatisi.com";

    }
}
