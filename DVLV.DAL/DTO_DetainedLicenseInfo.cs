using System;

namespace DVLV.DAL
{
    public class DTO_DetainedLicenseInfo
    {
        public string ClassName { get; set; }
        public string FullName { get; set; }
        public int LicenseID { get; set; }
        public string NationalNumber { get; set; }
        public string Gender { get; set; }
        public string IssueDate { get; set; }
        public string IssueReason { get; set; }
        public string Notes { get; set; }
        public string IsActive { get; set; }
        public string DateOfBirth { get; set; }
        public int DriverID { get; set; }
        public string ExpirationDate { get; set; }
        public string IsDetained { get; set; }
        public string ImageURL { get; set; }
    }
}
