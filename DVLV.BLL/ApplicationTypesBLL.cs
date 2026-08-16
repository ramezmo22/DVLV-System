using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DVLV.DAL;
using Microsoft.Identity.Client;
namespace DVLV.BLL
{
    public class ApplicationTypesBLL
    {


        public static DataTable GetTypes()
        {
            return DAL.ApplicationTypesDAL.GetApplicationTypesDataTable();
        }

        public static void GetType(ref int  ID,ref string Title,ref int fees)
        {
            DAL.ApplicationTypesDAL.GetApplicationTypeById(ref ID,ref Title,ref fees);
        }

        public static bool UpdateApplicationType(int ID,string Title,int Fees)
        {
            return DAL.ApplicationTypesDAL.UpdateApplicationTypeById(ID, Title, Fees);
        }

    }
}
