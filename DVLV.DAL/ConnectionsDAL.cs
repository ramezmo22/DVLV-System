using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Configuration;

namespace DVLV.DAL
{
    internal class ConnectionsDAL
    {
        //public static string ConnectionString { get; } =
        //    "Server=.;Database=DVLV;User Id=sa;Password=123456;TrustServerCertificate=True;";
        public static string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    }
}
