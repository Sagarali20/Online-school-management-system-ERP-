<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="std_payment_entry.aspx.cs" Inherits="Final_project.std_payment_entry" %>

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
                    <asp:TextBox ID="Searchtext" CssClass="form-control col-2" placeholder="Search_std_Id" runat="server"></asp:TextBox>

                              <asp:DropDownList ID="DropDownList4" runat="server" CssClass="form-control col-md-2"   >
								 <asp:ListItem>Class</asp:ListItem>
								 <asp:ListItem>6</asp:ListItem>
                                 <asp:ListItem>7</asp:ListItem>
                                 <asp:ListItem>8</asp:ListItem>
                                 <asp:ListItem>9</asp:ListItem>
								 <asp:ListItem>10</asp:ListItem>
							 </asp:DropDownList>

                    <asp:Button ID="Search_button" class="btn btn-info" runat="server" Text="Search" OnClick="Search_button_Click"  />
                    <asp:Button ID="log_out" runat="server" Text="Log Out" CssClass="btn btn-danger ml-2" />
			
					</div>

			</div>
		</nav>
		<br />
		 <div class="container">
       <div class="row">
            <div class="col-lg-7 mx-auto">
                <div class="team-member bg-dark">
					<br />

                       <div class="d-flex justify-content-center mt-3">
						<asp:TextBox ID="TextBox2" runat="server" CssClass="form-control  col-md-6" placeholder="S_id"></asp:TextBox>
                       </div>

                        <div class="d-flex justify-content-center mt-3">
							 <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control col-md-6"  >
								 <asp:ListItem>Class</asp:ListItem>
								 <asp:ListItem>6</asp:ListItem>
								 <asp:ListItem>7</asp:ListItem>
                              	 <asp:ListItem>8</asp:ListItem>
                                 <asp:ListItem>9</asp:ListItem>
                                 <asp:ListItem>10</asp:ListItem>
							 </asp:DropDownList>

                       </div> 

                             <div class="d-flex justify-content-center">

                                 
                       </div>
                      <div class="d-flex justify-content-center mt-3">
                    <asp:Calendar ID="Calendar1" runat="server" BackColor="#66FFFF" CssClass="text-white" Height="20px" Width="20px"   ></asp:Calendar>

                       </div>
			         <div class="d-flex justify-content-center mt-3">
						<asp:TextBox ID="TextBox5" runat="server" CssClass="form-control  col-md-6" placeholder="Total_Taka"></asp:TextBox>
                       </div>
			           <div class="d-flex justify-content-center mt-3">
						<asp:TextBox ID="TextBox6" runat="server" CssClass="form-control  col-md-6" placeholder="Recpts_no"></asp:TextBox>
                       </div>
       			           <div class="d-flex justify-content-center mt-3">
						<asp:TextBox ID="TextBox7" runat="server" CssClass="form-control  col-md-6" placeholder="Recpts_no"></asp:TextBox>
                       </div>

                    <div class="d-flex justify-content-center mt-3">
						<asp:Button ID="insert" runat="server" Text="Insert" CssClass="btn btn-info col-md-2 ml-1" OnClick="insert_Click" />
						<asp:Button ID="update" runat="server" Text="Update" CssClass="btn btn-info col-md-2 ml-1" OnClick="update_Click"  />
			     		<asp:Button ID="delete" runat="server" Text="Delete" CssClass="btn btn-info col-md-2 ml-1" OnClick="delete_Click"  />
                        <asp:Button ID="view" runat="server" Text="View" CssClass="btn btn-info col-md-2 ml-1" OnClick="view_Click" />
                        <asp:Button ID="cancle" runat="server" Text="Cancle" CssClass="btn btn-info col-md-2 ml-1" />


                    </div>
					<div class="text-center text-white mt-4">
						<asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
					</div>

                   
                </div><!-- .team-member -->
            </div><!-- .col -->
        </div><!-- .row -->
    </div><!-- .container -->
        <div class="container">
         
                <asp:Repeater ID="Repeater1" runat="server">

            <HeaderTemplate>   
                <div class="card-header bg-info text-light"><h3>All Student Marks</h3></div>

                <table class="table text-center table-hover">
                    <thead>
                        <tr>
 
                            <th>Student_Id</th>
                            <th>Month</th>
                            <th>Paid</th>
                            <th>Class</th>
                            <th>Recepts_no</th>
                        </tr>
                    </thead>
                    <tbody>                
            </HeaderTemplate>
            <ItemTemplate>
                      <tr>
                               <th><%# Eval("stdid") %></th>
                               <td><%# Eval("pmonth") %></td>
                               <td><%# Eval("paid") %></td>
                                <td><%# Eval("class") %></td>
                                <td><%# Eval("Recepts_no") %></td>

 
                       
                        </tr>
                
            </ItemTemplate>
                 
            <FooterTemplate>
                 
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

