<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Create_User.aspx.cs" Inherits="Final_project.Create_User" %>

<!DOCTYPE html>

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
					<asp:Button ID="Button5" runat="server" Text="Log Out" CssClass="btn btn-danger ml-2" OnClick="Button5_Click" />			
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
						 <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control  col-md-2 " TextMode="Password" placeholder="Employee_Id"></asp:TextBox>
					   <span class=" input-group-prepend">
						   <asp:Button ID="Button8" runat="server" Text="Search" CssClass="form-control btn btn-info " />

					   </span>
					    
			   </div>
					    <h2 class="text-white text-center">Add New User</h2>
                       <div class="d-flex justify-content-center mt-3">
						<asp:TextBox ID="TextBox2" runat="server" CssClass="form-control  col-md-3" placeholder="Enter User_Id"></asp:TextBox>
                       </div>
				         <div class="d-flex justify-content-center mt-3">
							 <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control col-md-3">
								 <asp:ListItem>Employee_Designation</asp:ListItem>
								 <asp:ListItem>Teacher</asp:ListItem>
								 <asp:ListItem>Employee</asp:ListItem>
							 </asp:DropDownList>
                       </div>
					     <div class="d-flex justify-content-center mt-3 ">
							 <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control  col-md-3"  placeholder="Enter User_Name"></asp:TextBox>                    
                         </div> 

						   <div class="d-flex justify-content-center mt-3 ">
							 <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control  col-md-3" TextMode="Password" placeholder="Enter New PassWord"></asp:TextBox>                    
                         </div>
						   <div class="d-flex justify-content-center mt-3 ">
							 <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control  col-md-3" TextMode="Password" placeholder="Confirm PassWord"></asp:TextBox>                    
                         </div>
                    <div class=" d-md-flex justify-content-center  mt-3">
						<asp:Button ID="AddNew" runat="server" Text="Add_New" CssClass="btn btn-info form-control col-md-1 ml- mt-2" OnClick="AddNew_Click" Enabled="False"  />
						<asp:Button ID="Save_user" runat="server" Text="Save_User" CssClass="btn btn-info form-control col-md-1 ml-1 mt-2" OnClick="Save_user_Click" Enabled="False"  />
			     		<asp:Button ID="Update" runat="server" Text="Update" CssClass="btn btn-info form-control col-md-1 ml-1 mt-2" OnClick="Update_Click" Enabled="False"   />	
						<asp:Button ID="Permission" runat="server" Text="Permission" CssClass="btn btn-info form-control col-md-1 ml-1 mt-2" OnClick="Permission_Click" Enabled="False"   />
			            <asp:Button ID="view" runat="server" Text="View" CssClass="btn btn-info form-control col-md-1 ml-1 mt-2" OnClick="view_Click" Enabled="False"  />
					    <asp:Button ID="cancle" runat="server" Text="Cancle" CssClass="btn btn-info form-control col-md-1 ml-1 mt-2" OnClick="cancle_Click"  />
                    </div>
					<div class="text-center text-white mt-4">
						<asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
			
                   
                </div>
					<br /><br />
            </div><!-- .team-member -->
            </div><!-- .col -->
		   </div><!-- .row -->
    </div><!-- .container -->
        	<div class="card ">
				<div class="card-header bg-info text-light"><h3>All Users</h3></div>
                 <asp:GridView ID="GridView1" runat="server" CssClass="table table-hover table-bordered text-center"></asp:GridView>

            </div>
    </form>
	<script src="Scripts/jquery-3.3.1.min.js"></script>
	<script src="Scripts/bootstrap.min.js"></script>
</body>
</html>