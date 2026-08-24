using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DVLV;
namespace DVLV.BLL
{
    public class TestTypesBLL
    {




        public static DataTable GetTypes()
        {
            return DAL.TestTypesDAL.GetTestTypesDataTable();
        }
        public static DataTable GetType(int ID)
        {
            return DAL.TestTypesDAL.GetTestTypesDataTable(ID);
        }

        public static bool UpdateType(int ID , String Title, String Describtion , int Fees)
        {
            return DAL.TestTypesDAL.UpdateType(ID, Title, Describtion, Fees);
        }






    }
}
