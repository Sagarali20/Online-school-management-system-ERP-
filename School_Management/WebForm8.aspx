<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm8.aspx.cs" Inherits="Final_project.WebForm8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="Repeater1" runat="server">
                            <HeaderTemplate>   
                <div class="card-header bg-info text-light"><h3>Student all results info</h3></div>

                <table class="table text-center mx-auto table-hover " style=" ">
                    <thead>
                        <tr class="alert-info">
                            <th>Student_ID</th>
                            <th>Roll_No</th>
                            <th>Class</th>
                            <th>GPA</th>
                            <th>Total_Mark</th>
                            <th>Mark</th>
                        </tr>
                    </thead>
                    <tbody>                
            </HeaderTemplate>
            <ItemTemplate>
                      <tr>
                            <th><%# Eval("Student_id") %></th>
                               <td><%# Eval("Roll_no") %></td>
                               <td><%# Eval("class") %></td>
                                <td><%# Eval("GPA") %></td>
                                <td><%# Eval("Total_Mark") %></td>                             
                              <td><asp:CheckBox ID="chkSelect" runat="server" Checked='true' /></td> 
                        </tr>
               
            </ItemTemplate>

            <FooterTemplate>
                    <tr class="alert-dark">
                        <td>Total</td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td>500000</td>
                        <td>ZXzx</td>
                    </tr>
                </tbody>
                </table>
            </FooterTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
