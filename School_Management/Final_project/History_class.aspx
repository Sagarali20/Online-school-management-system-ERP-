<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="History_class.aspx.cs" Inherits="Final_project.History_class" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" >
		<nav class="navbar fixed-top navbar-light bg-light navbar-expand-md">
			<div class="container">
				<a class="navbar-brand" href ="#"><span> <img alt="logo" src="images/aub.jpg" height="35" /></span>AUB</a>
				<button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarnav"><span class="navbar-toggler-icon"></span></button>
				<div class=" collapse navbar-collapse" id="navbarnav">
				<ul class="navbar-nav mx-auto" >
					<li class=" nav-item">
						<a class="nav-link" href="All_staff_2.aspx">Home</a>
					</li>
					<li class="nav-item">
						<a class="nav-link" href="#">About</a>
					</li>
					<li class ="nav-item">
						<a class="nav-link" href="#">Service</a>
					</li>
					<li class ="nav-item dropdown">
						<a class="nav-link dropdown-toggle" data-toggle="dropdown" href="#">Dropdown</a>
						<div class="dropdown-menu">
							<a href="#" class="dropdown-item">link 1</a>
							 <a href="#" class="dropdown-item">link 2</a>
							<a href="#" class="dropdown-item">link 3</a>
						</div>
					</li>

				</ul>
                    <asp:Button ID="View_All" class="btn btn-info mr-2" runat="server" Text="View All" OnClick="View_All_Click" />
                    <asp:TextBox ID="Searchtext" CssClass="form-control col-2" placeholder="Search_std_Id" runat="server"></asp:TextBox>
                    <asp:Button ID="Search_button" class="btn btn-info" runat="server" Text="Search" OnClick="Search_button_Click" />
                    <asp:Button ID="log_out" runat="server" Text="Log Out" CssClass="btn btn-danger ml-2"/>
			
					</div>

			</div>
		</nav>
		<br />
        <br />

          <div class="card mx-auto">
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
<%--                      <tr>
                            <th><%# Eval("Student_id") %></th>
                               <td><%# Eval("Roll_no") %></td>
                               <td><%# Eval("class") %></td>
                                <td><%# Eval("GPA") %></td>
                                <td><%# Eval("Total_Mark") %></td>                             
                              <td><asp:CheckBox ID="chkSelect" runat="server" Checked='true' /></td> 
                        </tr>--%>
               
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
	<script src="Scripts/jquery-3.3.1.min.js"></script>
	<script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
