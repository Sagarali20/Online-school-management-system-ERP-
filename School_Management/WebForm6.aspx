<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="Final_project.WebForm6" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>    
    <style>
        .my-class{
            background-color: green;
            color: white;
            width: <%= Session["DaysAvailable"].ToString() %>%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">    

        <div class="my-class">
            Days available
        </div>
        <br/>
        <asp:Button ID="btnUpdateDays" runat="server" Text="Update days" OnClick="btnUpdateDays_Click"/>
    </form>
</body>
</html>