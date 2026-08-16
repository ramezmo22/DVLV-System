using System;
using System.Collections.Generic;
using System.Text;

namespace DVLV.BLL
{
    public class TestsBLL
    {
        public static bool IsPersonHasPassedTheTest(int LocalDrivingLicenseApplicationID, int TestType)
        {

            return DAL.TestsDAL.IsPersonHasPassedTheTest(LocalDrivingLicenseApplicationID,TestType);
            
        }

        public static int AddTest(int TestAppointmentID, bool result, String Notes)
        {
            return DAL.TestsDAL.AddTest(TestAppointmentID, result, Notes,CurrentUserBLL.UserID);
        }









    }
}
