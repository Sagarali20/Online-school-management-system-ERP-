<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Account_info.aspx.cs" Inherits="Final_project.Account_info" %>

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

    <form id="form1" runat="server" >
		

		 <div class="container">
       <div class="row">
            <div class="col-lg-4 mx-auto">
                <div class="team-member bg-dark">
					<br />
					<h2 class="text-white font-italic text-center">Account_info</h2>
					<br />						

                      <div class="d-flex justify-content-center mt-1">
						<asp:TextBox ID="TextBox2" runat="server" CssClass="form-control  col-md-9" placeholder="Student_Id"></asp:TextBox>

                       </div>			

                    <div class="d-flex justify-content-center mt-3">
						<asp:Button ID="Search" runat="server" Text="Search" CssClass="btn btn-info col-md-9" OnClick="Search_Click"  />

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
                <div class="card-header bg-info text-light"><h3>Student_Account_info</h3></div>

                <table class="table text-center table-hover">
                    <thead>
                        <tr class="info">
                            <th>###</th>
                            <th>Month</th>
                            <th>Class</th>
                            <th >Payable</th>
                            <th>Paid</th>
                            <th>Dues</th>
                        </tr>
                    </thead>
                    <tbody>                
            </HeaderTemplate>
            <ItemTemplate>
                      <tr>
                            <td><%# Eval("stdid") %></td>
                          <td><%# Eval("Month","{0:dd-MM-yyyy }") %></td>
                          <td><%# Eval("Class") %></td>
                               <td><%# Eval("Payable") %></td>
                               <td style="text-align:center"><%# Eval("Paid") %></td>
                             <td><%# Eval("Dues") %></td>                          
                       
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
