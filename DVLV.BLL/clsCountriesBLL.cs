using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DVLV.DAL;
namespace DVLV.BLL
{
    public class clsCountriesBLL
    {
        public static DataTable GetAllCountries()
        {
            DataTable dataTable = new DataTable();
            dataTable = CountriesDAL.GetAllCountryNames();
            return dataTable;
     
        }
        public static string GetCountryById(int ID)
        {
            return CountriesDAL.GetCountryNameById(ID);
        }
    }
}
