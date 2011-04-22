<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MyTestingGroundMVC.ViewData.EmployeeJqGridViewData>" %>
<%@ Import Namespace="System.Collections.Generic" %>
<%@ Import Namespace="MyTestingGroundMVC.Helpers"%>
<%@ Import Namespace="Trirand.Web.Mvc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Adventure Works Employee Example
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Head" runat="server">  
    <!-- The jQuery UI theme that will be used by the grid -->
    <link rel="stylesheet" type="text/css" href="http://www.trirand.net/aspnetmvc/Content/themes/redmond/jquery-ui-1.8.2.custom.css" />
    <!-- The jQuery UI theme extension jqGrid needs -->
    <link rel="stylesheet" type="text/css" href="http://www.trirand.net/aspnetmvc/Content/themes/ui.jqgrid.css" />    
    <script type="text/javascript" src="http://www.trirand.net/aspnetmvc/Scripts/jquery-1.4.4.min.js"></script>
    <script type="text/javascript" src="http://www.trirand.net/aspnetmvc/Scripts/trirand/i18n/grid.locale-en.js"></script>
    <script type="text/javascript" src="http://www.trirand.net/aspnetmvc/Scripts/trirand/jquery.jqGrid.min.js"></script>
    <script type="text/javascript" src="http://www.trirand.net/aspnetmvc/Scripts/trirand/jquery.jqDatePicker.min.js"></script>    
    <script type="text/javascript" src="http://www.trirand.net/aspnetmvc/Scripts/trirand/jquery.jqAutoComplete.min.js"></script>    
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">


<%= Html.PageHeader(Model.Subtitle)%>


  <%
       
    
      Html.RenderPartial("StateList");  
     
   %>

</asp:Content>
