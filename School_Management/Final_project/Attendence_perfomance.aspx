<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Attendence_perfomance.aspx.cs" Inherits="Final_project.Attendence_perfomance" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
<asp:Repeater ID="final" runat="server" >
    <HeaderTemplate>
        <div class="card-header bg-info text-light text-center "><h3>All Students Attendence_Performance</h3></div>
        <table class="table text-center table-dark table-hover  mx-auto "> 
            
            <tr>
                <th>
                    Student_ID
                </th>
                <th>
                    Class
                </th>
                <th>
                    Percentage(%)
                </th>

            </tr>
    </HeaderTemplate>
    <ItemTemplate>
        <tr>
            <th>
                <asp:Label ID="Std_id" runat="server" Text='<%# Eval("Sid") %>' />
            </th>
            <td>
                <asp:Label ID="Roll" runat="server" Text='<%# Eval("class")%>' />
            </td>
            <td>
                <%# Eval("percentage")%>
            </td>
        

        </tr>
    </ItemTemplate>
    <FooterTemplate>
        </table>

    </FooterTemplate>
    

</asp:Repeater>  

   
        </div>

    </form>
    	<script src="Scripts/jquery-3.3.1.min.js"></script>
	<script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
