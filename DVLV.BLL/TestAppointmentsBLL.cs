using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using DVLV.DAL;
namespace DVLV.BLL
{
    public class TestAppointmentsBLL
    {
        public static DataTable GetAppointmentsDataTable(int LocalDrivingLicenseApplicationID,int TestID)
        {
            return DAL.TestAppointmentsDAL.GetPersonAppointmentsGridView(LocalDrivingLicenseApplicationID,TestID);
        }


        public static bool IsPersonHasAcctiveAppointment(int LocalDrivingLicenseApplicationID, int TestType)
        {
            return DAL.TestAppointmentsDAL.IsPersonHasAcctiveAppointment(LocalDrivingLicenseApplicationID, TestType);
        }


        public static int AddNewTestAppointment(int TestType, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, int Fees, int CurrentUserID, bool IsLocked)
        {

            return DAL.TestAppointmentsDAL.AddNewTestAppointment(TestType, LocalDrivingLicenseApplicationID, AppointmentDate, Fees, CurrentUserID, IsLocked);
        }

        public static bool IsAppointmentLocked(int AppointemntID)
        {
            return DAL.TestAppointmentsDAL.IsAppointmentLocked(AppointemntID);
        }

        public static DateTime GetAppointmentDate(int AppointmentID)
        {
            return DAL.TestAppointmentsDAL.GetAppointmentDate(AppointmentID);
        }

        public static bool UpdateDate(int AppointmentID, DateTime Date)
        {
            return DAL.TestAppointmentsDAL.UpdateDate(AppointmentID, Date);
        }

        public static bool UpdateLockStutus(int TestAppointmentID,bool Stutus)
        {
            return DAL.TestAppointmentsDAL.UpdateLockStutus(TestAppointmentID,Stutus);


        }
        


    }
}

    

