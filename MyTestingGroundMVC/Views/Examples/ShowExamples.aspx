<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="System.Collections.Generic" %>
<%@ Import Namespace="MyTestingGroundMVC.Helpers"%>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">	
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

   <%
       
    
           if (ViewData.ModelMetadata.ModelType == typeof(MyTestingGroundMVC.ViewData.USStatesViewData) )
           {
               Html.RenderPartial("StateList");              
           }


           if (ViewData.ModelMetadata.ModelType == typeof(MyTestingGroundMVC.ViewData.EmployeeViewData))
           {
               Html.RenderPartial("Employees");
           }
     
   %>
    
</asp:Content>