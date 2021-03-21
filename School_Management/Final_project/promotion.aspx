<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="promotion.aspx.cs" Inherits="Final_project.promotion" %>

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
				<a class="navbar-brand" href ="#"><span> <img alt="logo" src="images/aub.jpg" height="35" /></span>AUB</a>
                <div class=" navbar-header"> 
     
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
       
                   	<li class ="nav-item">
						<a class="nav-link" href="#"><i class="fas fa-bell"></i></a>
					</li>
				</ul>			
					</div>
                  </div>
			</div>
		</nav>

    <form id="form1" runat="server" >
		

		 <div class="container">
       <div class="row">
            <div class="col-lg-4 mx-auto">
                <div class="team-member bg-dark">
					<br />
					<h1 class="text-white font-italic text-center">Promotion</h1>
					<br />						

                      <div class="d-flex justify-content-center mt-1">
							 <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control col-md-9">
                                 <asp:ListItem>Class</asp:ListItem>
								 <asp:ListItem>6</asp:ListItem>
                                 <asp:ListItem>7</asp:ListItem>
                                 <asp:ListItem>8</asp:ListItem>
                                 <asp:ListItem>9</asp:ListItem>
								 <asp:ListItem>10</asp:ListItem>
							 </asp:DropDownList>
                       </div>			

                    <div class="d-flex justify-content-center mt-3">
						<asp:Button ID="Promotions" runat="server" Text="Promotion" CssClass="btn btn-info col-md-9" OnClick="Promotions_Click" />

                    </div>
					<div class="text-center text-white mt-4">
						   <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
					    <br /> 
                        <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
                        <br />
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Special_marks.aspx" Visible="False">Click here to solved this problem !!! </asp:HyperLink>
                        <br />

					</div>
					<br />
                    
                </div><!-- .team-member -->
            </div><!-- .col -->
        </div><!-- .row -->
    </div><!-- .container -->
            <div class="card ">
                <asp:Repeater ID="Repeater1" runat="server">

            <HeaderTemplate>   
                <div class="card-header bg-info text-light"><h3>All Students</h3></div>

                <table class="table text-center table-hover">
                    <thead>
                        <tr>
                            <th>Roll_No</th>
                            <th>Student_ID</th>
                            <th>Class</th>
                            <th>GPA</th>
                            <th>Total_Mark</th>
                        </tr>
                    </thead>
                    <tbody>                
            </HeaderTemplate>
            <ItemTemplate>
                      <tr>
                            <th><%# Eval("Roll_no") %></th>
                               <td><%# Eval("Student_Id") %></td>
                               <td><%# Eval("Class") %></td>
                                <td><%# Eval("GPA") %></td>
                                <td><%# Eval("Total_Marks") %></td>                             
                       
                        </tr>
            </ItemTemplate>
            <FooterTemplate>
                </tbody>
                </table>
            </FooterTemplate>
        </asp:Repeater>  
                </div>
    </form>
</body>
</html>
