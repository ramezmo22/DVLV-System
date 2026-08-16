using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;

using System.Text;

namespace DVLV.DAL
{
    public class CountriesDAL
    {

        public static DataTable GetAllCountryNames()
        {
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            DataTable Countries = new DataTable();
            string query = "Select * From Countries";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                Countries.Load(reader);
                return Countries;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
        public static string GetCountryNameById(int CountryID)
        {
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string CountryName = "";
            string query = "Select CountryName From Countries Where CountryID = @CountryID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryID", CountryID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                    CountryName = result.ToString();
                return CountryName;
            }
            catch (Exception ex)
            {
                return "";
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
