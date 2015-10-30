<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MainGraphTable.aspx.cs" Inherits="MainGraphTable" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="gvCustomer" runat="server">
        </asp:GridView>
    
        <asp:Button ID="btnShow" runat="server" Text="Year and Rainfall Display Data" OnClick="btnShow_Click" />
    
    </div>
        
        <asp:Chart ID="Chart1" runat="server" ChartArea ="ChartArea1">
            <series>
                <asp:Series Name="Series1">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>
        
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </form>
</body>
</html>
