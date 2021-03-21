<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="class_section.aspx.cs" Inherits="Final_project.class_section" %>

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
					<asp:Button ID="log_out" runat="server" Text="Log Out" CssClass="btn btn-danger ml-2" OnClick="log_out_Click" />			
					</div>

			</div>
		</nav>
		<br /><br />
		 <div class="container">
       <div class="row">
            <div class="col-lg-12 mx-auto">
                <div class="team-member bg-dark">
					<br />	
				<div class=" d-md-flex input-group justify-content-end ">
						 <asp:TextBox ID="text_search" runat="server" CssClass="form-control  col-md-2 " placeholder="Section_Id"></asp:TextBox>
					   <span class=" input-group-prepend">
						   <asp:Button ID="Search" runat="server" Text="Search" CssClass="form-control btn btn-info " />

					   </span>
					</div>
	
					    <h2 class="text-white text-center">Add New Class_Section</h2>
                       <div class="d-flex justify-content-center mt-3">
						<asp:TextBox ID="TextBox1" runat="server" CssClass="form-control  col-md-3" placeholder="Enter Section_id"></asp:TextBox>
                       </div>
	
					     <div class="d-flex justify-content-center mt-3 ">
							 <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control  col-md-3"  placeholder="Section_Name"></asp:TextBox>                    
                         </div>

				
                    <div class=" d-md-flex justify-content-center  mt-3">
						<asp:Button ID="insert" runat="server" Text="Add_New" CssClass="btn btn-info form-control col-md-2 ml- mt-2" Enabled="False" />
						<asp:Button ID="Savesubj" runat="server" Text="Save_Subject" CssClass="btn btn-info form-control col-md-2 ml-1 mt-2" Enabled="False"/>
			     		<asp:Button ID="update" runat="server" Text="Update" CssClass="btn btn-info form-control col-md-2 ml-1 mt-2" Enabled="False" />	
						<asp:Button ID="Delete" runat="server" Text="Delete" CssClass="btn btn-info form-control col-md-2 ml-2 mt-2" Enabled="False" />
						<asp:Button ID="cancel" runat="server" Text="Cancle" CssClass="btn btn-info form-control col-md-2 ml-2 mt-2" />



                    </div>
					<div class="text-center text-white mt-4">
						<asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
			
                   
                </div>
					<br /><br />
            </div><!-- .team-member -->
            </div><!-- .col -->
		   </div><!-- .row -->
    </div><!-- .container -->
		
    </form>
	<script src="Scripts/jquery-3.3.1.min.js"></script>
	<script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
