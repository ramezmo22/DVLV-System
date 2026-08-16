using System;
using System.Collections.Generic;
using System.Text;

namespace DVLV.BLL
{
    public class LicenseClassesBLL
    {

        public static (int Fees, int Validity) GetFeesAndValidityLength(int LicenseClassID)
        {
           return DAL.LicenseClassesDAL.GetFeesAndValidityLength(LicenseClassID);

        }
        public static int GetFees(int LicenseClassID)
        {
           ( int Fees,int v)= DAL.LicenseClassesDAL.GetFeesAndValidityLength(LicenseClassID);
            return Fees;
        }


    }
    }
