using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLV.DAL
{
    public class DetainedLicensesDAL
    {

		public static int DetainLicense(int LicenseID, DateTime DetainDate, int FineFees, int CreatedByUserID, bool IsReleased)
		{
			SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
			string query = @"insert into DetainedLicenses (LicenseID,DetainDate,FineFees,CreatedByUserID,IsReleased)
							values (@LicenseID,@DetainDate,@FineFees,@CreatedByUserID,@IsReleased)
							Select SCOPE_IDENTITY();";
			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@LicenseID", LicenseID);
			command.Parameters.AddWithValue("@DetainDate", DetainDate);
			command.Parameters.AddWithValue("@FineFees", FineFees);
			command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
			command.Parameters.AddWithValue("@IsReleased", IsReleased);

			try
			{
				connection.Open();
				var result = command.ExecuteScalar();
				if (int.TryParse(result.ToString(), out int DetainID))
					return DetainID;
			}
			catch (Exception ex)
			{
				return (-1);
			}
			finally
			{
				connection.Close();
			}
			return (-1);
		}

		public static (int DetainID, DateTime DetainDate, int FineFees, int CreatedByUserID) GetDetainData(int LicenseID)
		{
			SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
			string query = @"Select DetainedLicenses.DetainID, DetainedLicenses.DetainDate, DetainedLicenses.FineFees, DetainedLicenses.CreatedByUserID From DetainedLicenses 
				where DetainedLicenses.LicenseID = @LicenseID;";
			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@LicenseID", LicenseID);

			try
			{
				connection.Open();
				SqlDataReader reader = command.ExecuteReader();
				if (reader.Read())
				{
					int DetainID = Convert.ToInt32(reader["DetainID"]);
					DateTime DetainDate = Convert.ToDateTime(reader["DetainDate"]);
					int FineFees = Convert.ToInt32(reader["FineFees"]);
					int CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
					return (DetainID, DetainDate, FineFees, CreatedByUserID);
				}
			}
			catch (Exception ex)
			{
				return (-1, DateTime.Now, 0, 0);
			}
			finally
			{
				connection.Close();
			}
			return (-1, DateTime.Now, 0, 0);
		}

		public static bool Release_License(int LicenseID, int ReleaseApplicationID, DateTime ReleaseDate, int ReleasedByUserID)
		{
			SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
			string query = @"Update DetainedLicenses Set 
				DetainedLicenses.IsReleased = 1,
				DetainedLicenses.ReleaseApplicationID = @ReleaseApplicationID,
				DetainedLicenses.ReleaseDate = @ReleaseDate,
				DetainedLicenses.ReleasedByUserID = @ReleasedByUserID
				where DetainedLicenses.LicenseID = @LicenseID;";

			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@LicenseID", LicenseID);
			command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
			command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
			command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);

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

		public static DataTable GetAllDetainedLicenses()
		{
			DataTable table = new DataTable();
			SqlConnection connection = new SqlConnection(ConnectionsDAL.ConnectionString);
			string query = @"SELECT 
							DetainedLicenses.DetainID ,
							DetainedLicenses.LicenseID ,
							DetainedLicenses.DetainDate ,
							DetainedLicenses.IsReleased,
							DetainedLicenses.FineFees,
							DetainedLicenses.ReleaseDate,
							DetainedLicenses.ReleaseApplicationID ,
							People.NationalNo ,
							People.FirstName + ' ' + ISNULL(People.SecondName, '') + ' ' + ISNULL(People.ThirdName, '') + ' ' + People.LastName AS [Full Name]
						FROM DetainedLicenses
						INNER JOIN Licenses ON DetainedLicenses.LicenseID = Licenses.LicenseID
						INNER JOIN Drivers ON Licenses.DriverID = Drivers.DriverID
						INNER JOIN People ON Drivers.PersonID = People.PersonID
						ORDER BY DetainedLicenses.DetainDate DESC;";

			SqlCommand command = new SqlCommand(query, connection);

			try
			{
				connection.Open();
				SqlDataReader reader = command.ExecuteReader();
				if (reader != null)
				{
					table.Load(reader);
					reader.Close();
				}
			}
			catch (Exception ex)
			{
				return table;
			}
			finally
			{
				connection.Close();
			}
			return table;
		}
	}
}
