<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<MyTestingGroundMVC.ViewData.USStatesViewData>" %>
<%@ Import Namespace="System.Collections.Generic" %>
<%@ Import Namespace="MyTestingGroundMVC.Helpers"%>
<%= Html.PageHeader(Model.Subtitle)%>

<br />

<ul>
<%
     foreach (var state in Model.States)
    {%>
        
        <li><%= state %></li>
    <%}    
%> 
</ul>
