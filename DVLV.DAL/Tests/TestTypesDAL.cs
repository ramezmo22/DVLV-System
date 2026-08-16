using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLV.DAL
{
    public class TestTypesDAL
    {

        public static DataTable GetTestTypesDataTable(int ID = -1)
        {
            DataTable TypesTable = new DataTable();
            SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
            String query =ID==-1? @"Select TestTypes.TestTypeID,TestTypes.TestTypeTitle,
            TestTypes.TestTypeDescription,TestTypes.TestTypeFees 
            From TestTypes;"
            :
            @"Select TestTypes.TestTypeID,TestTypes.TestTypeTitle, 
            TestTypes.TestTypeDescription,TestTypes.TestTypeFees 
            From TestTypes
            Where TestTypes.TestTypeID = @ID";

            SqlCommand command = new SqlCommand(query, connection);
            if (ID != -1) 
            {
                command.Parameters.AddWithValue("@ID", ID);
            }
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                TypesTable.Load(reader);
                reader.Close();
            }
            catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return TypesTable;



        }
        public static bool UpdateType(int ID=-1,String Title="", String Describtion="",int Fees=0)
        {
            if(ID==-1)
            {
                return false;
            }
            else
            {
                SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
                String query = @"UPDATE TestTypes
                        SET TestTypeTitle =@Title ,
                            TestTypeDescription =@Describtion ,
                            TestTypeFees = @Fees
                            WHERE TestTypeID =@ID  ";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", ID);
                command.Parameters.AddWithValue("@Title", Title);
                command.Parameters.AddWithValue("@Describtion", Describtion);
                command.Parameters.AddWithValue("@Fees", Fees);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }


    }
}
