<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Navbarlink.aspx.cs" Inherits="Final_project.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<link href="Content/bootstrap.min.css" rel="stylesheet" />
	<link href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css" rel="stylesheet" />
    
</head>
<body>
    <form id="form1" runat="server" >
		<br />
		<nav class="navbar fixed-top navbar-light bg-light navbar-expand-md">
			<div class="container">
				<a class="navbar-brand" href ="#"><span> <img alt="logo" src="images/aub.jpg" height="35" /></span>AUB</a>
				<button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarnav"><span class="navbar-toggler-icon"></span></button>
				<div class=" collapse navbar-collapse" id="navbarnav">
				<ul class="navbar-nav mx-auto" >
					<li class=" nav-item active">
						<a class="nav-link" href="#"><i class="fa fa-home"></i>Home</a>
					</li>
					<li class="nav-item">
						<a class="nav-link" href="#">Deshboard</a>
					</li>
			
					<li class ="nav-item dropdown">
						<a class="nav-link dropdown-toggle" data-toggle="dropdown" href="#">Class</a>
						<div class="dropdown-menu">
                            <asp:HyperLink ID="Class" CssClass="dropdown-item" runat="server"  NavigateUrl="~/class.aspx" Enabled="False">Class</asp:HyperLink>
                            <asp:HyperLink ID="Subject" CssClass="dropdown-item" runat="server" Enabled="False" NavigateUrl="~/Subject.aspx">Subject</asp:HyperLink>
                            <asp:HyperLink ID="Class_Section" CssClass="dropdown-item" runat="server" Enabled="False" NavigateUrl="~/class_section.aspx">Class_Section</asp:HyperLink>

						</div>
					</li>
                 <li class ="nav-item dropdown">
						<a class="nav-link dropdown-toggle" data-toggle="dropdown" href="#">Student_Info</a>
						<div class="dropdown-menu">
                            <asp:HyperLink ID="Student_Admission" CssClass="dropdown-item" runat="server" Enabled="False" NavigateUrl="~/Student_info.aspx">Student_Admission</asp:HyperLink>
                            <asp:HyperLink ID="Student_result" CssClass="dropdown-item" runat="server" Enabled="False" NavigateUrl="~/result.aspx">Student_result</asp:HyperLink>
                            <asp:HyperLink ID="Student_promotion" CssClass="dropdown-item" runat="server" Enabled="False" >Student_Promotion</asp:HyperLink>

						</div>
					</li>
				
					<li class ="nav-item dropdown">
						<a class="nav-link dropdown-toggle" data-toggle="dropdown" href="#">User_Info</a>
						<div class="dropdown-menu">
                            <asp:HyperLink ID="User_details" CssClass="dropdown-item" runat="server" Enabled="False" NavigateUrl="~/Employee_details.aspx">User_Details</asp:HyperLink>
                            <asp:HyperLink ID="Create_user" CssClass="dropdown-item" runat="server" Enabled="False" NavigateUrl="~/Create_User.aspx">Create_User</asp:HyperLink>
                            <asp:HyperLink ID="Change_password" CssClass="dropdown-item" runat="server" Enabled="False" NavigateUrl="~/passWord_Change.aspx">Change_PassWord</asp:HyperLink>
                            <asp:HyperLink ID="User_permission" CssClass="dropdown-item" runat="server" Enabled="False" NavigateUrl="~/passWord_Change.aspx">User_permission</asp:HyperLink>

						</div>
					</li>
						<li class ="nav-item dropdown">
						<a class="nav-link dropdown-toggle" data-toggle="dropdown" href="#">Attendence</a>
						<div class="dropdown-menu">
                            <asp:HyperLink ID="Student_atten" CssClass="dropdown-item" runat="server" Enabled="False" >Student_Atten</asp:HyperLink>
                            <asp:HyperLink ID="Staff_atten" CssClass="dropdown-item" runat="server" Enabled="False" >Staff_Atten</asp:HyperLink>

						</div>
					</li>
					<li class ="nav-item dropdown">
						<a class="nav-link dropdown-toggle" data-toggle="dropdown" href="#">Accounting</a>
						<div class="dropdown-menu">					
                            <asp:HyperLink ID="Student_account" CssClass="dropdown-item" runat="server" Enabled="False" >Student_Account</asp:HyperLink>
							 <asp:HyperLink ID="Staff_account" CssClass="dropdown-item" runat="server" NavigateUrl="~/result.aspx" >Staff_account</asp:HyperLink>    
						</div>
					</li>
				</ul>
					<asp:Button ID="Logout" runat="server" Text="Log Out" CssClass="btn btn-danger ml-2" />	

			</div>
                </div>
		</nav>
		<br />
				
    </form>
	<script src="Scripts/jquery-3.3.1.min.js"></script>
	<script src="Scripts/bootstrap.min.js"></script>
</body>
</html>

