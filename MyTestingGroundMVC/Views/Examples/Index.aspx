<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Head" runat="server">
 <script src="../../Scripts/jQuery-Collapser/jquery.collapser.min.js" type="text/javascript"></script>
    <link href="../../Scripts/jQuery-Collapser/Collapser.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">

        $(document).ready(function () {

            $('.collapser').collapser({
                target: 'next',
                effect: 'slide',
                changeText: 0,
                expandClass: 'expIco',
                collapseClass: 'collIco'
            }, function () {
                $('.panel').slideUp();
            });


        });
    </script>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">    
    <h2>Examples</h2>
    <p> Here are the examples that I've created so far.</p>

    <!-- Collapser -->
    <h4 class="collapser">List of States</h4>
    <div class="panel">
        <p>
         A simple example showing how to display data from a pre-populated data model. <%: Html.ActionLink("States", "States", "Examples", new { @Id = "states" })%>
        </p>
    </div>
	
    <h4 class="collapser">List of Employees</h4>
    <div class="panel">
        <p>
         Loads a list of employees from the AdventureWorks database using Entity Framework as the ORM. The data access layer uses Repository Pattern
         to perform CRUD functions. <%: Html.ActionLink("Employees", "Employees", "Examples", new { @Id = "employees" })%>
        </p>
    </div>  
  
</asp:Content>
