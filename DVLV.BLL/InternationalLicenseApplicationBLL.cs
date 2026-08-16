using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace DVLV.BLL
{
    public class InternationalLicenseApplicationBLL
    {

        public static (int InternationalApplicationID,
        DateTime ApplicationDate,
        DateTime IssueDate,
        int fees,
        int InternationalLicenseID,
        DateTime ExpiarartionDate,
        String CreatedByUserName) GetApplciationInfo(int LicenseID)
        {
            
            return DAL.IntarnationalLicensesDAL.GetApplicationInfo(LicenseID);
        }

        public static bool HasInternationalLicense(int LocalLicenseID)
        {
            return DAL.IntarnationalLicensesDAL.HasInternationalLicense(LocalLicenseID);
        }
        public static int AddNewInrternationalLicense(int ApplicationID, int DriverID, int LocalLicenseID, DateTime issueDate, DateTime ExpirationDate,bool IsActive,int CurrentUserID)
        {
            return DAL.IntarnationalLicensesDAL.AddNewInrternationalLicense(ApplicationID, DriverID, LocalLicenseID, issueDate, ExpirationDate, IsActive, CurrentUserID);
        }

        public static DataTable LoadDataToGridView(int FilterationNumber, String filterValue)
        {
            DataTable data = DAL.IntarnationalLicensesDAL.GetInternationalDrivingLicenseTable();

            // إذا كان الفلتر "None" أو لم يدخل المستخدم قيمة
            if (FilterationNumber == 0 || string.IsNullOrEmpty(filterValue))
                return data;

            // إنشء جدول جديد للبيانات المفلترة
            DataTable filteredData = data.Clone();
            DataRow[] filteredRows; // Array Of Rows 

            // InternationalLicenseID	ApplicationID	DriverID	IssuedUsingLocalLicenseID  IsActive	
            switch (FilterationNumber)
            {
                case 1: // International License
                    filteredRows = data.Select($"InternationalLicenseID = {filterValue}");
                    break;
                case 2: // DriverID
                    filteredRows = data.Select($"DriverID = {filterValue}");
                    break;
                case 3://IssuedUsingLocalLicenseID
                    filteredRows = data.Select($"IssuedUsingLocalLicenseID = {filterValue}");
                    break;
                case 4: // IsActive
                    filteredRows = data.Select($"IsActive = {filterValue}");
                    break;
                default:
                    return data;
            }

            // أضافة الصفوف المفلترة إلى الجدول الجديد
            foreach (DataRow row in filteredRows)
            {
                filteredData.Rows.Add(row.ItemArray);
            }

            return filteredData;
        }






    }
}
