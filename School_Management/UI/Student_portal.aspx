<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student_portal.aspx.cs" Inherits="Final_project.Student_portal" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<link href="Content/bootstrap.min.css" rel="stylesheet" />
	<script src="Scripts/jquery-3.3.1.min.js"></script>
	<script src="Scripts/bootstrap.min.js"></script>
    <link href="Content/all.min.css" rel="stylesheet" />
	<script src="Scripts/popper.min.js"></script>
</head>
<body>
	<nav class="navbar navbar-light bg-light navbar-expand-md">
			<div class="container">
				<a class="navbar-brand" href ="/Fornt_template_2.aspx"><span> <img alt="logo" src="images/aub.jpg" height="35" /></span>AUB</a>
                <div class=" navbar-header"> 
     
				<button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarnav"><span class="navbar-toggler-icon"></span></button>
				<div class=" collapse navbar-collapse" id="navbarnav">
				<ul class="navbar-nav mx-auto" >
					<li class=" nav-item">
						<a class="nav-link" href="/Fornt_template_2.aspx">Home</a>
					</li>

				</ul>

		
					</div>
                  </div>
			</div>
		</nav>

    <form id="form1" runat="server" >
		
		<br /><br /><br />
		 <div class="container">
       <div class="row">
            <div class="col-lg-6 mx-auto">
                <div class="team-member bg-dark">
					<br />
					<h1 class="text-white font-italic text-center">Student_Portal</h1>
					<br />
				
                       <div class="d-flex justify-content-center mt-3">
						<asp:TextBox ID="TextBox1" runat="server" CssClass="form-control  col-md-6" placeholder="Enter You Student_Id"></asp:TextBox>
                       </div>
					     <div class="d-flex justify-content-center mt-3 ">
							 <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control  col-md-6" TextMode="Password" placeholder="Enter Your Password" style="left: 0px; top: 0px"></asp:TextBox>                    
                    </div>

                    <div class="d-flex justify-content-center mt-3">
						<asp:Button ID="Button1" runat="server" Text="Login" CssClass="btn btn-info col-md-6" OnClick="Button1_Click"  />

                    </div>
					<div class="text-center text-white mt-4">
						<asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
					</div>

					<br /><br /><br />
                    
                </div><!-- .team-member -->
            </div><!-- .col -->
        </div><!-- .row -->
    </div><!-- .container -->
    </form>

</body>
</html>
