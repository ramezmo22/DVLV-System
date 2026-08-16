using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace DVLV.DAL
{
    public class ApplicationTypesDAL
    {



        public static DataTable GetApplicationTypesDataTable()
        {
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            DataTable ApplicationTypes = new DataTable();
            String query = "Select * From ApplicationTypes; ";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                ApplicationTypes.Load(reader);
                reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            { 
                connection.Close();
            }
            return ApplicationTypes;
        }

        public static void GetApplicationTypeById(ref int id, ref string title, ref int fees)
        {
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string query = "SELECT ApplicationTypeID, ApplicationTypeTitle, ApplicationFees FROM ApplicationTypes WHERE ApplicationTypeID = @Id;";
            SqlCommand command = new SqlCommand(query, connection);
             command.Parameters.AddWithValue("@Id", id);

            try
            {
              

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
               
               
               
                if (reader.Read())
                {
                    // Update the ref parameters with the values from the database
                    id = reader.GetInt32(0); // ApplicationTypeID
                    title = reader.GetString(1); // ApplicationTypeTitle
                    fees = Convert.ToInt32(reader.GetDecimal(2)); // ApplicationFees
                }
                else
                {
                    throw new Exception("No application type found with the specified ID.");
                }
               
            }
            catch (Exception e)
            {
                throw new Exception("An error occurred while retrieving the application type.", e);
            }
            finally
            {
                if (command != null)
                {
                    command.Dispose();
                }
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public static bool UpdateApplicationTypeById(int id, string title, decimal fees)
        {
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            string query = "UPDATE ApplicationTypes SET ApplicationTypeTitle = @Title, ApplicationFees = @Fees WHERE ApplicationTypeID = @Id;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Title", title);
            command.Parameters.AddWithValue("@Fees", fees);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0; 
            }
            catch (Exception e)
            { 
                return false;
            }
            finally
            {
                connection.Close();
            }
        }


        public static float GetApplicationTypePrice(int Type)
        {
            float Price = -1;
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            String query = @"Select ApplicationTypes.ApplicationFees From ApplicationTypes
                where ApplicationTypeID=@Type";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Type", Type);
            try
            {
                connection.Open();
                var Result = command.ExecuteScalar();
                float.TryParse(Result.ToString(),out Price);
                return Price;

            }
            catch(Exception ex )
            {
                return Price;
            }
            finally
            {
                connection.Close();
            }


        }













    }
}
