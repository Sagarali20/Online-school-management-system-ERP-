<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="Final_project.test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
	
    <form id="form1" runat="server" visible="True" >
	<nav class="navbar navbar-light bg-light navbar-expand-md">
			<div class="container">
				<a class="navbar-brand" href ="All_staff_2.aspx"><span> <img alt="logo" src="images/aub.jpg" height="35" /></span>AUB</a>
                <div class=" navbar-header"> 
     
				<button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarnav"><span class="navbar-toggler-icon"></span></button>
				<div class=" collapse navbar-collapse" id="navbarnav">
				<ul class="navbar-nav mx-auto" >
					<li class=" nav-item">
						<a class="nav-link" href="All_staff_2.aspx">Home</a>
					</li>

				</ul>			
					</div>
                  </div>
			</div>
		</nav>
		 <div class="container">
       <div class="row">
            <div class="col-lg-12 mx-auto">
                <div class="team-member bg-dark">
					<br />	
				<div class=" d-md-flex input-group justify-content-end ">
						 <asp:TextBox ID="text_serch" runat="server" CssClass="form-control  col-md-2 " Height="30px" placeholder="Subject_Id"></asp:TextBox>
					   <span class=" input-group-prepend">
						   <asp:Button ID="Search" runat="server" Text="Search" CssClass="btn btn-info " />

					   </span>
					</div>
	
					    <h2 class="text-white text-center">Add New subject</h2>
                       <div class="d-flex justify-content-center mt-3">
						<asp:TextBox ID="TextBox2" runat="server" CssClass="form-control  col-md-3" placeholder="Enter Subject_Id"></asp:TextBox>
                       </div>
	
					     <div class="d-flex justify-content-center mt-3 ">
							 <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control  col-md-3"  placeholder="Enter Subject_Name"></asp:TextBox>                    
                         </div>

						   <div class="d-flex justify-content-center mt-3 ">
							 <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control  col-md-3"  placeholder="Enter class_id"></asp:TextBox>                    
                         </div>
                    <div class="   mt-3">
						<asp:Button ID="insert" runat="server" Text="Add_New" CssClass="btn btn-info  col-md-2  mt-2" Enabled="False" />
						<asp:Button ID="Savesubj" runat="server" Text="Save_Subject" CssClass="btn btn-info  col-md-2  mt-2" Enabled="False" />
			     		<asp:Button ID="update" runat="server" Text="Update" CssClass="btn btn-info  col-md-2  mt-2" Enabled="False" />	
						<asp:Button ID="Delete" runat="server" Text="Delete" CssClass="btn btn-info  col-md-2  mt-2" Enabled="False" />
						<asp:Button ID="cancel" runat="server" Text="Cancle" CssClass="btn btn-info  col-md-2  mt-2" />



                    </div>
                    <br />
                    <br />
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
