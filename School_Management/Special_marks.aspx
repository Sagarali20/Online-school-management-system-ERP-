<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Special_marks.aspx.cs" Inherits="Final_project.Special_marks" %>

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
				<a class="navbar-brand" href ="All_staff_2.aspx"><span> <img alt="logo" src="images/aub.jpg" height="35" /></span>AUB</a>
				<button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarnav"><span class="navbar-toggler-icon"></span></button>
				<div class=" collapse navbar-collapse" id="navbarnav">
				<ul class="navbar-nav mx-auto" >
					<li class=" nav-item">
						<a class="nav-link" href="All_staff_2.aspx">Home</a>
					</li>
					<li class="nav-item">
						<a class="nav-link" href="promotion.aspx">Promotion</a>
					</li>


				</ul>
                     <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control col-md-2" Height="37px">
								 <asp:ListItem>Class</asp:ListItem>
								 <asp:ListItem>6</asp:ListItem>
                                 <asp:ListItem>7</asp:ListItem>
                                 <asp:ListItem>8</asp:ListItem>
                                 <asp:ListItem>9</asp:ListItem>
								 <asp:ListItem>10</asp:ListItem>
							 </asp:DropDownList>
                    <asp:Button ID="Search_button" class="btn btn-info" runat="server" Text="Search" OnClick="Search_button_Click" />
			
					</div>

			</div>
		</nav>
		<br />
		 <div class="container">
       <div class="row">
            <div class="col-lg-6 mx-auto">
                <div class="team-member bg-dark">
					<br />
               		<br />
					<h1 class="text-white font-italic text-center">Special_Mark</h1>
					


                       <div class="d-flex justify-content-center mt-3">
                         <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control col-md-6" >
			
							 </asp:DropDownList>
                       </div>

        
                       <div class="d-flex justify-content-center mt-3">
						<asp:TextBox ID="TextBox2" runat="server" CssClass="form-control  col-md-6"  placeholder="Special_mark"></asp:TextBox>
                       </div>

   

                    <div class="d-flex justify-content-center mt-3">
						<asp:Button ID="insert" runat="server" Text="Insert" CssClass="btn btn-info col-md-2 ml-1" OnClick="insert_Click" />
						<asp:Button ID="update" runat="server" Text="Update" CssClass="btn btn-info col-md-2 ml-1" OnClick="update_Click" Enabled="False" />
			     		<asp:Button ID="delete" runat="server" Text="Delete" CssClass="btn btn-info col-md-2 ml-1" OnClick="delete_Click" Enabled="False" />
                        <asp:Button ID="cancle" runat="server" Text="Cancle" CssClass="btn btn-info col-md-2 ml-1" Enabled="False" OnClick="cancle_Click" />


                    </div>
					<div class="text-center text-white mt-4">
						<asp:Label ID="Label5" runat="server" Visible="False"></asp:Label>
					</div>
                   
                </div><!-- .team-member -->
            </div><!-- .col -->
        </div><!-- .row -->
    </div><!-- .container -->
    
       
                <asp:Repeater ID="Repeater1" runat="server">
              
            <HeaderTemplate>
                <div class="card ">  
                <div class="card-header bg-info text-light"><h3>All Student Marks</h3></div>

                <table class="table text-center table-hover">
                    <thead>
                        <tr>
                            <th>Student_Id</th>                        
                            <th>Class</th>
                            <th>Total_Mark</th>
                        </tr>
                    </thead>
                    <tbody>                
            </HeaderTemplate>
            <ItemTemplate>
                      <tr>
                               <th><%# Eval("s_id") %></th>
                               <td><%# Eval("class") %></td>
                                <td><%# Eval("Total_mark") %></td>      
                        </tr>
            </ItemTemplate>
            <FooterTemplate>
                </tbody>
                </table>
                </div> 
            </FooterTemplate>

               
        </asp:Repeater> 
               

    </form>
	<script src="Scripts/jquery-3.3.1.min.js"></script>
	<script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
