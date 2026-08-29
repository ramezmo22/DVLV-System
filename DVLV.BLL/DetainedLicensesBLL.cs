using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Text;

namespace DVLV.BLL
{
    public class DetainedLicensesBLL
    {
        public static DAL.DTO_DetainedLicenseInfo GetDetainedLicenseFullInfo(int LicenseID)
        {
            return DAL.LicensesDAL.GetLicenseFullInfo(LicenseID);
        }

        public static int DetainLicense(int LicenseID, DateTime DetainDate, int FineFees, int CreatedByUserID, bool IsReleased)
        {
            return DAL.DetainedLicensesDAL.DetainLicense(LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased);
        }

        public static (int DetainID, DateTime DetainDate, int FineFees, int CreatedByUserID) GetDetainData(int LicenseID)
        {
            return (DAL.DetainedLicensesDAL.GetDetainData(LicenseID));
        }

        public static bool Release_License(int LicenseID, int ReleaseApplicationID, DateTime ReleaseDate, int ReleasedByUserID)
        {
            return DAL.DetainedLicensesDAL.Release_License(LicenseID, ReleaseApplicationID, ReleaseDate, ReleasedByUserID);
        }

        // التعديل صار هنا: دالة نظيفة بدون معاملات لجلب الجدول كاملاً فقط
        public static DataTable GetAllDetainedLicenses()
        {
            return DAL.DetainedLicensesDAL.GetAllDetainedLicenses();
        }
    }
}