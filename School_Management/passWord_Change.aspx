<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="passWord_Change.aspx.cs" Inherits="Final_project.passWord_Change" %>

<!DOCTYPE html>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" >
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
		<br />
		 <div class="container">
       <div class="row">
            <div class="col-lg-6 mx-auto">
                <div class="team-member bg-dark">
					<br />
					<h2 class="text-center text-white font-italic">PassWord Change</h2>
					<br />
                       <div class="d-flex justify-content-center mt-3">
						<asp:TextBox ID="TextBox2" runat="server" CssClass="form-control  col-md-6" placeholder="Enter User_Name"></asp:TextBox>
                       </div>
					     <div class="d-flex justify-content-center mt-3 ">
							 <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control  col-md-6" TextMode="Password" placeholder="Enter Old Password"></asp:TextBox>                    
                         </div>

						   <div class="d-flex justify-content-center mt-3 ">
							 <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control  col-md-6" TextMode="Password" placeholder="Enter New PassWord"></asp:TextBox>                    
                         </div>
						   <div class="d-flex justify-content-center mt-3 ">
							 <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control  col-md-6" TextMode="Password" placeholder="Confirm PassWord"></asp:TextBox>                    
                         </div>

                    <div class="d-flex justify-content-center mt-3">
						<asp:Button ID="Button1" runat="server" Text="Update" CssClass="btn btn-info col-md-6" OnClick="Button1_Click" />
                    </div>
					<div class="text-center text-white mt-4">
						<asp:Label ID="Label5" runat="server" Text="Label" Visible="False"></asp:Label>
					</div>
                   
                </div><!-- .team-member -->k
            </div><!-- .col -->
        </div><!-- .row -->
    </div><!-- .container -->
    </form>
	<script src="Scripts/jquery-3.3.1.min.js"></script>
	<script src="Scripts/bootstrap.min.js"></script>
</body>
</html>