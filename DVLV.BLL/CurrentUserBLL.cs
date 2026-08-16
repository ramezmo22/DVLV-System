using System;

namespace DVLV.BLL
{
    public static class CurrentUserBLL
    {
        // Static properties for the current user
        public static int UserID { get; set; } = -1;
        public static string UserName { get; set; } = string.Empty;

        // Method to set the current user details
        public static void SetUser(int userId, string userName)
        {
            UserID = userId;
            UserName = userName;
        }

        // Method to clear the current user details
        public static void Clear()
        {
            UserID = -1;
            UserName = string.Empty;
            
        }
    }
}
