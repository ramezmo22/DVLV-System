using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;

namespace DVLV.BLL
{
    public class DriverBLL
    {


        public static int AddNewDriver(int PersonID)
        {
            return DAL.DriversDAL.AddNewDriver(PersonID, CurrentUserBLL.UserID, DateTime.Now);
        }


        public static void GetDriverinfo(
            ref string className,
            ref string fullname,
            ref int licenseID,
            ref string nationalNumber,
            ref int gendor,
            ref DateTime issueDate,
            ref int issueReason,
            ref string notes,
            ref bool isActive,
            ref DateTime dateOfBirth,
            ref int driverID,
            ref DateTime expirationDate,
            ref string ImagePath)
        {
            DAL.DriversDAL.GetDriverinfo(
                ref className,
                ref fullname,
                ref licenseID,
                ref nationalNumber,
                ref gendor,
                ref issueDate,
                ref issueReason,
                ref notes,
                ref isActive,
                ref dateOfBirth,
                ref driverID,
                ref expirationDate,
                ref ImagePath );
        }

        public static int GetDriverIDByPersonID(int PersonID)
        {
            return DAL.DriversDAL.GetDriverIDByPersonID(PersonID);
        }

        public static int GetDriverIDByApplcationID(int ApplicationID)
        {
            return DAL.DriversDAL.GetDriverIDByApplcationID(ApplicationID);
        }
        public static DataTable GetFilteredData(int FilterIndex, string FilterText)
        {
            DataTable data = DAL.DriversDAL.GetDriversData();
            
            if (string.IsNullOrEmpty(FilterText))
                return data;
            //Array of rows to add later in a table
            DataRow[] filteredRows = new DataRow[] { };

            switch (FilterIndex)
            {
                case 0: // none
                    return data;

                case 1: // DriverID
                    if (int.TryParse(FilterText, out int driverID))
                        filteredRows = data.Select($"DriverID = {driverID}");
                    break;

                case 2: // PersonID
                    if (int.TryParse(FilterText, out int personID))
                        filteredRows = data.Select($"PersonID = {personID}");
                    break;

                case 3: // NationalNumber
                    filteredRows = data.Select($"NationalNo LIKE '%{FilterText}%'");
                    break;

                case 4: // FullName
                    filteredRows = data.Select($"FullName LIKE '%{FilterText}%'");
                    break;
            }

            // new table to add the filtered rows
            DataTable result = data.Clone();
            foreach (DataRow row in filteredRows)
                result.ImportRow(row);

            return result;
        }


        public static int GetDriverIDByLicenseID(int LicenseID)
        {
            return DAL.DriversDAL.GetDriverIDByLicenseID(LicenseID);
        }

        public static (string FullName,
        int LicenseID,
        string NationalNumber,
        int Gender,
        DateTime IssueDate,
        DateTime ExpirationDate,
        int DriverID,
        DateTime DateOfBirth,
        bool IsActive,
        int ApplicationID
        ) GetDriverInternationalLicenseInfo(int InternationalLicenseID)
        {

            return DAL.DriversDAL.GetDriverInternationalLicenseInfo(InternationalLicenseID);



        }
    }
}
