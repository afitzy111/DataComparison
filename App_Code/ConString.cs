using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ConString
/// </summary>
public class ConString
{
    public static SqlConnection con;
    static ConString()
    {
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
    }

}