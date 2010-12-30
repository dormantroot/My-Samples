<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<MyTestingGroundMVC.ViewData.EmployeeViewData>" %>
<%@ Import Namespace="System.Collections.Generic" %>
<%@ Import Namespace="MyTestingGroundMVC.Helpers"%>
<%@ Import Namespace="MyTestingGround.DomainObjects" %>

 


<%= Html.PageHeader(Model.Subtitle)%>


<ul>
<%
     foreach (IEmployee e in Model.Employees)
    {%>
        
        <li><%=
                ((Employee)e).Title.ToString()
            %>
             - 
            <%=
                ((Employee)e).BirthDate.ToString() 
            %>
        </li>
    <%}    
%> 
</ul>
