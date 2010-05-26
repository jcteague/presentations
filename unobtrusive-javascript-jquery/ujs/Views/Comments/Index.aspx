<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<System.Collections.Generic.IEnumerable<ujs.Models.Comments>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
  <link href="../../Content/Comments.css" rel="stylesheet" type="text/css" />
  <script src="../../Scripts/jquery-1.4.1.js" type="text/javascript"></script>

  <script src="../../Scripts/Comments.js" type="text/javascript"></script>
</head>
<body>
    
    <div id="container">
      <% foreach(var comment in Model) {%> 
        
        <div class="pane">
          <h3><%= comment.Title %> </h3>
          <p>
            <%= comment.Body %> 
          </p>
          <%=Html.ActionLink("Delete", "Delete",new{id=comment.Id},new{@class="delete"}) %> 
        </div>
      <%} %>
    
        </div>
</body>
</html>
