<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server"> 
    
    <h2>Examples</h2>
    <p> Links to the examples that I've created so far.</p>

     <ul>                     
        <li><%: Html.ActionLink("States", "States", "Examples", new { @Id = "states" })%></li>
        <li><%: Html.ActionLink("Employees", "Employees", "Examples", new { @Id = "states" })%></li>
    </ul>
  
</asp:Content>
