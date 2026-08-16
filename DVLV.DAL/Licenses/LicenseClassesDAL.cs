using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DVLV.DAL
{
    public class LicenseClassesDAL
    {


        public static (int Fees,int Validity) GetFeesAndValidityLength(int ClassID)
        {
            int fees = -1, validity = -1;
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string query = @"Select ClassFees,LicenseClasses.DefaultValidityLength From LicenseClasses
                            where LicenseClassID=@ClassID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClassID", ClassID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();  // Move to the first row
                    fees = Convert.ToInt16(reader["ClassFees"]);
                    validity = Convert.ToInt16(reader["DefaultValidityLength"]);
                }
                else return (-1, -1);

                reader.Close();
            }
            catch(Exception ex )
            {

            }
            finally
            {
                connection.Close();
            }
            return (fees, validity);




        }









    }
}
