<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<MyTestingGroundMVC.ViewData.EmployeeViewData>" %>
<%@ Import Namespace="System.Collections.Generic" %>
<%@ Import Namespace="MyTestingGroundMVC.Helpers"%>
<%@ Import Namespace="MyTestingGroundMVC.AdvWorksManagementService" %>


 

 <!--will remove this later -->
<%= Html.PageHeader(Model.Subtitle)%>


<ul>
<%
     foreach (Employee e in Model.Employees)
    {%>
        
        <li><%=
                ((Employee)e).Title.ToString()
            %>         
        </li>
    <%}    
%> 
</ul>
