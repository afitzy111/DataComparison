using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;

public partial class MainGraphTable : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!Page.IsPostBack)
        {
            GetChartData();

        }
    }

    protected void btnShow_Click(object sender, EventArgs e)
    {
        try
        {
            BAL Cust = new BAL();
            DataSet dstObj = Cust.View();
            if(dstObj.Tables.Count > 0)
            {
                gvCustomer.DataSource = dstObj;
                gvCustomer.DataBind();
            }
            else
            {
                ShowAlert("No Records Found");
            }
        }
        catch(Exception ex)
        {
            ShowAlert(ex.Message.ToString());
        }
    }



    private void ShowAlert(string strmsg)
    {
        string str1;
        str1 = "<script language = 'javascript' type = 'text.javascript'> alert('" + strmsg + "');</script>";
        ClientScript.RegisterClientScriptBlock(this.GetType(), "JS", str1);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            //BAL Cust = new BAL();
            //DataSet dstObj = Cust.View();

            //            Series series = Chart1.Series["Series1"];
            //          series.Points.AddXY(Cust.Year_Ref,Cust.Rain_Winter);

            GetChartData();
        }
        catch (Exception ex)
        {
            ShowAlert(ex.Message.ToString());
        }
    }

    public void GetChartData()
    {
        // BAL Cust = new BAL() ;
        // DataSet dstObj = Cust.ToArray<Enum>();


        //Series series = Chart1.Series["Series1"];

        BAL Cust = new BAL();
        DataSet dstObj = Cust.View();

        


        Chart1.DataSource = dstObj;
        dstObj.CreateDataReader();
        //Chart1.Series["Series1"].
        Chart1.Series["Series1"].ChartType = SeriesChartType.Line;
        Chart1.Series["Series1"].XValueMember = "Year_Ref";
        Chart1.Series["Series1"].YValueMembers = "Rain_Full_Year";
        
        Chart1.DataBind();

        //chartPlaceHolder.Controls.Add(chart1);


    }

}