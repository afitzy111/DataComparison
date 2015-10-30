using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BAL
/// </summary>
public class BAL
{
    public BAL()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    private int _id;
    private int _year_ref;
    private int _rain_full_year;
    private int _outflow_full_year;
    private int _rain_winter;
    private int _outflow_winter;
    private int _rain_summer;
    private int _outflow_summer;

    public int ID
    {
        get { return _id; }
        set { _id = value; }
    }

    public int Year_Ref
    {
        get { return _year_ref; }
        set { _year_ref = value; }
    }
    public int Rain_Full_Year
    {
        get { return _rain_full_year; }
        set { _rain_full_year = value; }
    }
    public int Outflow_Full_Year
    {
        get { return _outflow_full_year; }
        set { _outflow_full_year = value; }
    }
    public int Rain_Winter
    {
        get { return _rain_winter; }
        set { _rain_winter = value; }
    }
    public int Outflow_Summer
    {
        get { return _outflow_summer; }
        set { _outflow_summer = value; }
    }
    public int Rain_Summer
    {
        get { return _rain_summer; }
        set { _rain_summer = value; }
    }
    public int Rain_winter
    {
        get { return _rain_winter; }
        set { _rain_winter = value; }
    }

    public DataSet View()
    {
        try
        {
            DAL dbObject = new DAL();
            DataSet ds = dbObject.FetchView();
            return ds;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message.ToString());
        }
    }

    public DataSet GetItem()
    {
        try
        {
            DAL dbObject = new DAL();
            DataSet ds = dbObject.FetchView();
            return ds;
        }
        catch(Exception ex)
        {
            throw new Exception(ex.Message.ToString());
        }

    }


}

