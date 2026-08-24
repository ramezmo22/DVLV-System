using System.Data;
using System.Diagnostics;
using DVLV.DAL;
using Microsoft.IdentityModel.Tokens;

namespace DVLV.BLL
{
    public class PeopleBLL
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public short Gendor { get; set; }// 0 or 1  : 0 Male 1 Female
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int CountryID { get; set; }
        public string ImagePath { get; set; }

        public PeopleBLL()
        {
            Mode = enMode.AddNew;
            this.PersonID = -1;
            this.NationalNo = "";
            this.Gendor = 0;
            this.DateOfBirth = DateTime.Now.AddYears(-18);
            this.Phone = "";
            this.Email = "";
            this.ImagePath = "";
            this.Address = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.CountryID = 90;

        }
        public PeopleBLL(PersonDataTransferObject obj)
        {
            this.PersonID = obj.PersonID;
            this.NationalNo = obj.NationalNo;
            this.Gendor = obj.Gendor;
            this.DateOfBirth = obj.DateOfBirth;
            this.Phone = obj.Phone;
            this.Email = obj.Email;
            this.ImagePath = obj.ImagePath;
            this.Address = obj.Address;
            this.FirstName = obj.FirstName;
            this.SecondName = obj.SecondName;
            this.ThirdName = obj.ThirdName;
            this.LastName = obj.LastName;
            this.CountryID = obj.CountryID;
            this.Mode = enMode.Update;
        }



        private bool _AddPerson()
        {

            // Build DTO from current BLL instance
            PersonDataTransferObject obj = new PersonDataTransferObject();

            obj.NationalNo = this.NationalNo;
            obj.Gendor = this.Gendor;
            obj.DateOfBirth = this.DateOfBirth;
            obj.Phone = this.Phone;
            obj.Email = this.Email;
            obj.ImagePath = this.ImagePath;
            obj.Address = this.Address;
            obj.FirstName = this.FirstName;
            obj.SecondName = this.SecondName;
            obj.ThirdName = this.ThirdName;
            obj.LastName = this.LastName;
            obj.CountryID = this.CountryID;
            obj.PersonID = -1;

            // Persist and capture the generated ID
            this.PersonID = PeopleDAL.AddNewPerson(obj);

            return (this.PersonID != -1);
        }
        private bool _UpdatePerson()
        {
            if (PeopleDAL.IsPersonExists(this.PersonID))
            {
                PersonDataTransferObject obj = new PersonDataTransferObject();
                obj.PersonID = this.PersonID;
                obj.NationalNo = this.NationalNo;
                obj.Gendor = this.Gendor;
                obj.DateOfBirth = this.DateOfBirth;
                obj.Phone = this.Phone;
                obj.Email = this.Email;
                obj.ImagePath = this.ImagePath;
                obj.Address = this.Address;
                obj.FirstName = this.FirstName;
                obj.SecondName = this.SecondName;
                obj.ThirdName = this.ThirdName;
                obj.LastName = this.LastName;
                obj.CountryID = this.CountryID;
                if (PeopleDAL.UpdatePersonInfo(obj))
                    return true;
                else
                    return false;


            }
            else
                return false;
        }
        public static DataTable GetAllPeopleTable()
        {
            return PeopleDAL.Get_All_People_Data();
        }
        public static int PersonSelection(int FilterMood = -1, string ForSearching = "")
        {
           
            switch (FilterMood)
            {
                case 0: // PersonID (int)
                    {
                        if (int.TryParse(ForSearching, out int personId))
                        {
                            if (PeopleDAL.IsPersonExists(personId))
                                return personId;
                            else
                                return -1; // Return -1 if no match is found
                        }
                        return -1; // Return -1 if ForSearching is not a valid integer
                    }
                case 1: // NationalNo (string)
                    {
                        int result = PeopleDAL.FindPersonByNationalNumber(ForSearching);
                        if (result != -1)
                            return result;
                        else
                            return -1; // Return -1 if no match is found                                                
                    }
                default:
                    return -1;
            }
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddPerson())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else return false;
                    }
                case enMode.Update:
                    {
                        return (_UpdatePerson());
                    }
            }
            return false;
        }
        public static int GetPersonIDByNationalNumber(string NationalNum)
        {
            int personID = DAL.PeopleDAL.FindPersonByNationalNumber(NationalNum);
            if (personID != -1)
            {
                return personID;
            }
            else return -1;
        }
        public static PeopleBLL FindPerson(int ID)
        {
            PersonDataTransferObject obj = DAL.PeopleDAL.FindPersonByID(ID);
            if (obj != null)
            {
                return new PeopleBLL(obj);
            }
            else return null;
        }
        public static bool IsPersonExists(int ID)
        {
            return PeopleDAL.IsPersonExists(ID);

        }
        public static bool DeletePerson(int ID)
        {
            if (PeopleDAL.IsPersonExists(ID))
            {
                return PeopleDAL.DeletePerson(ID);
            }
            else return false;
        }
        public static int GetPersonIDByApplicationID(int ApplicationID)
        {
            return PeopleDAL.GetPersonIDByApplicationID(ApplicationID);
        }
        public static String GetFullName(int PersonID)
        {
            return DAL.PeopleDAL.GetPersonFullName(PersonID);
        }
        public static int GetPersonIDByDriverID(int DriverID)
        {
            return DAL.PeopleDAL.GetPersonIDByDriverID(DriverID);
        }
    }
}
