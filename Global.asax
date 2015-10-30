<%@ Application Language="C#" %>
<%@ Import Namespace="WebSite1" %>
<%@ Import Namespace="System.Web.Optimization" %>
<%@ Import Namespace="System.Web.Routing" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e)
    {
        RouteConfig.RegisterRoutes(RouteTable.Routes);
        BundleConfig.RegisterBundles(BundleTable.Bundles);
    }

    void Application_BeginRequest(object sender, EventArgs e)
{
    var app = (HttpApplication)sender;
    if (app.Context.Request.Url.LocalPath.EndsWith("/"))
    {
    app.Context.RewritePath(
             string.Concat(app.Context.Request.Url.LocalPath, "default.aspx"));
    }
}

</script>
