<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="Final_project.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>	<link href="Content/bootstrap.min.css" rel="stylesheet" />
	<link href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css" rel="stylesheet" />
    
</head>
<body>
    <form id="form1" runat="server">
				<nav class="navbar fixed-top navbar-light bg-light navbar-expand-md">
			<div class="container">
				<a class="navbar-brand" href ="#"><span> <img alt="logo" src="images/aub.jpg" height="35" /></span>AUB</a>
				<button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarnav"><span class="navbar-toggler-icon"></span></button>

				<div class=" collapse navbar-collapse" id="navbarnav">
				<ul class="navbar-nav mx-auto" >
					<li class=" nav-item">
						<a class="nav-link" href="#">Home</a>
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
					<asp:Button ID="Button5" runat="server" Text="Log Out" CssClass="btn btn-danger ml-2" OnClick="Button5_Click" />			
					</div>

			</div>
		</nav>
		
				<br />
				<br />				
				<br />
       <div class="container">	   
		   <div class="row justify-content-center">
					   <asp:Button ID="class" runat="server" Text="Class" CssClass="btn btn-info form-control col-md-2 ml-2 mt-2" OnClick="class_Click" style="left: 0px; top: 0px" Enabled="False"/>
					   <asp:Button ID="subject" runat="server" Text="Subject" CssClass="btn btn-info form-control col-md-2 ml-2 mt-2" OnClick="subject_Click" Enabled="False"/>
		               <asp:Button ID="Class_section" runat="server" Text="Class_Section" CssClass="btn btn-info form-control col-md-2 ml-2 mt-2 " OnClick="Class_section_Click" Enabled="False"/>
		               <asp:Button ID="Result" runat="server" Text="Result" CssClass="btn btn-info form-control col-md-2 ml-2 mt-2" Enabled="False" OnClick="Result_Click"/>
		               <asp:Button ID="create_Account" runat="server" Text="Create_User" CssClass="btn btn-info form-control col-md-2 ml-2 mt-2" style="left: 0px; top: 0px" Enabled="False" OnClick="create_Account_Click"/>
			      </div>
		     <div class="row justify-content-center">
					   <asp:Button ID="passWord_change" runat="server" Text="PassWord_Change" CssClass="btn btn-info form-control col-md-2 ml-2 mt-2" Enabled="False" OnClick="passWord_change_Click"/>
					   <asp:Button ID="user_info" runat="server" Text="User_Info" CssClass="btn btn-info form-control col-md-2 ml-2 mt-2" Enabled="False" OnClick="user_info_Click"/>
		               <asp:Button ID="Std_account" runat="server" Text="Std_Account" CssClass="btn btn-info form-control col-md-2 ml-2 mt-2 " Enabled="False"/>
		               <asp:Button ID="student_info" runat="server" Text="Student_Info" CssClass="btn btn-info form-control col-md-2 ml-2 mt-2" style="left: 0px; top: 0px" Enabled="False" OnClick="student_info_Click"/>
			 </div>
           <div class="row  justify-content-center">
               	       <asp:Button ID="Staff_Account" runat="server" Text="Staff_Account" CssClass="btn btn-info form-control col-md-2 ml-2 mt-2" style="left: 0px; top: 0px" Enabled="False"/>
                       <asp:Button ID="User_permission" runat="server" Text="User_permission" CssClass="btn btn-info form-control col-md-2 ml-2 mt-2" style="left: 0px; top: 0px" Enabled="False"/>
                        <asp:Button ID="Button2" runat="server" Text="Teacher_Account" CssClass="btn btn-info form-control col-md-2 ml-2 mt-2" style="left: 0px; top: 0px" Enabled="False"/>

               </div>
       </div>
        
    </form>
		<script src="Scripts/jquery-3.3.1.min.js"></script>
	<script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
