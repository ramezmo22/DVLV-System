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

        public static DataTable GetAllDetainedLicenses(int FilterMood = 0, string FilterQuery = "")
        {
            DataTable DetainedLicenses = DAL.DetainedLicensesDAL.GetAllDetainedLicenses();
            if (FilterQuery == "")
                return DetainedLicenses;
          switch (FilterMood)
            {
                case 0:
                    return DetainedLicenses;
                case 1:
                    DetainedLicenses = FilterDetainLicenses(DetainedLicenses, FilterQuery,1);
                    break;                                            
                case 2:                                               
                    DetainedLicenses = FilterDetainLicenses(DetainedLicenses, FilterQuery,2);
                    break;                                            
                case 3:                                               
                    DetainedLicenses = FilterDetainLicenses(DetainedLicenses, FilterQuery,3);
                    break;                                            
                case 4:                                              
                    DetainedLicenses = FilterDetainLicenses(DetainedLicenses, FilterQuery,4);
                    break;                                            
                case 5:                                              
                    DetainedLicenses = FilterDetainLicenses(DetainedLicenses, FilterQuery,5);
                    break;

            }
            return DetainedLicenses;
        }

        public static DataTable FilterDetainLicenses(DataTable DetainedLicenses, string FilterQuery, int FilterMood)
        {
            DataRow[] rows = null;
            DataTable Dest = DetainedLicenses.Clone();
            switch (FilterMood)
            {
                case 0:
                    return DetainedLicenses;
                case 1:
                    // Filter by Detain ID
                    if (int.TryParse(FilterQuery, out int detainID))
                        rows = DetainedLicenses.Select("DetainID = " + detainID.ToString());
                    break;
                case 2:
                    // Filter by Is Released
                    if (int.TryParse(FilterQuery, out int isReleased))
                        rows = DetainedLicenses.Select("IsReleased = " + (isReleased == 1 ? 1 : 0).ToString());
                    break;
                case 3:
                    // Filter by National No.
                    rows = DetainedLicenses.Select("NationalNo LIKE '%" + FilterQuery.Replace("'", "''") + "%'");
                    break;
                case 4:
                    // Filter by Full Name
                    rows = DetainedLicenses.Select("[Full Name] LIKE '%" + FilterQuery.Replace("'", "''") + "%'");
                    break;
                case 5:
                    // Filter by Release Application ID
                    if (int.TryParse(FilterQuery, out int releaseAppID))
                        rows = DetainedLicenses.Select("ReleaseApplicationID = " + releaseAppID.ToString());
                    break;
            }

            if (rows != null)
            {
                foreach (DataRow r in rows)
                    Dest.ImportRow(r);
            }
            return Dest;
        }


    }
}
