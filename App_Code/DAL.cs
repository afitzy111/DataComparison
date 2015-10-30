using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for DAL
/// </summary>
public class DAL
{
    public DAL()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public DataSet FetchView()
    {
        try
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                ConString.con.Open();
                cmd.Connection = ConString.con;
                //cmd.CommandType
                cmd.CommandText = "select year_ref, rain_full_year from RainfallExperiment";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                       return ds;

            }
        }
        catch
        {
            return null;
        }
        //throw new NotImplementedException();
    }

    /*
    public DataSet GetChartData()
    {
        try
        {
            string cs = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("select year_ref, rain_full_year from RainfallExperiment", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while(rdr.Read()){
                    
                }
            }
        }
        catch
        {
            return null;
        }
        //throw new NotImplementedException();
    }
    */

}