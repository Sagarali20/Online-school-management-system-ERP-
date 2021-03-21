<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student_info.aspx.cs" Inherits="Final_project.Admin_panel" %>

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
					<asp:TextBox ID="TextSearch" runat="server" CssClass="form-control col-5" Height="40px" placeholder="Student_Id" OnTextChanged="TextSearch_TextChanged"></asp:TextBox>
					<asp:Button ID="Search" runat="server" Text="Search" CssClass="btn btn-info" OnClick="Search_Click" />
					</div>

			</div>
		</nav>

       <div class="row">
            <div class="col-lg-8 mx-auto bg-dark ">
				<div class="row ">
					<div class="col-lg-8">
				    <div class="team-member">
                    <div class="d-flex justify-content-end mt-3">
						<asp:TextBox ID="TextBox1" runat="server"  CssClass=" form-control col-md-6" placeholder="Enter_Student_Id"></asp:TextBox>
                        </div>
				    <div class="d-flex justify-content-end mt-1">
						<asp:TextBox ID="TextBox2" runat="server"  CssClass=" form-control col-md-6" placeholder="Enter Full_Name"></asp:TextBox>
                        </div>
					  <div class="d-flex justify-content-end mt-1">
						<asp:TextBox ID="TextBox3" runat="server"  CssClass=" form-control col-md-6" placeholder="Enter Father_Name"></asp:TextBox>
                        </div>
				     <div class="d-flex justify-content-end mt-1">
						<asp:TextBox ID="TextBox4" runat="server"  CssClass=" form-control col-md-6" placeholder="Enter Mother_Name"></asp:TextBox>
                        </div>
					  <div class="d-flex justify-content-end mt-1">
						<asp:TextBox ID="TextBox5" runat="server"  CssClass=" form-control col-md-6" placeholder="Class"></asp:TextBox>
                        </div>
					   <div class="d-flex justify-content-end mt-1">
						<asp:TextBox ID="TextBox6" runat="server"  CssClass=" form-control col-md-6" placeholder="Phone_Number"></asp:TextBox>
                        </div>

				     <div class="d-flex justify-content-end mt-1">
						<asp:TextBox ID="TextBox8" runat="server"  CssClass=" form-control col-md-6" placeholder="Address"></asp:TextBox>
                        </div>
					  <div class="d-flex justify-content-end mt-1">
						<asp:TextBox ID="TextBox9" runat="server"  CssClass=" form-control col-md-6" placeholder="Birth_Day"></asp:TextBox>
                        </div>
					   <div class="d-flex justify-content-end mt-1">
						<asp:TextBox ID="TextBox10" runat="server"  CssClass=" form-control col-md-6" placeholder="Enter Religion"></asp:TextBox>
                        </div>
               		  <div class="d-flex justify-content-end mt-1">
							 <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control col-md-6">
								 <asp:ListItem>--Select here--</asp:ListItem>
								 <asp:ListItem>Male</asp:ListItem>
								 <asp:ListItem>Female</asp:ListItem>
							 </asp:DropDownList>
                       </div>

					   <div class="d-flex justify-content-end mt-1">
						   <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control col-md-6 image"/>
                        </div>
                   
                     </div><!-- .team-member -->

					</div>
						<div class="col-lg-4">	

				    <div class="team-member bg-dark">
										
					 <div class="col-md-12">
						 <asp:Image ID="Image1" runat="server" CssClass=" card-img-top" />

				     </div>
                   
                     </div><!-- .team-member -->

					</div>


				</div>
              					<div class="text-center text-white mt-4">
						<asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
					</div>
		           <div class=" d-md-flex justify-content-center  mt-1">
						<asp:Button ID="insert" runat="server" Text="Insert" CssClass="btn btn-info  col-md-2 ml- mt-2" OnClick="insert_Click" Enabled="False"/>
						<asp:Button ID="update" runat="server" Text="Update" CssClass="btn btn-info  col-md-2 ml-1 mt-2" OnClick="update_Click" Enabled="False"/>
			     		<asp:Button ID="delete" runat="server" Text="Delete" CssClass="btn btn-info  col-md-2 ml-1 mt-2" OnClick="delete_Click" Enabled="False"/>	
						<asp:Button ID="cancle" runat="server" Text="Cancle" CssClass="btn btn-info  col-md-2 ml-1 mt-2" OnClick="cancle_Click"/>

                    </div>


                <br />
                 <br /> <br /> 
            </div><!-- .col -->

    </div><!-- .container -->
         <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
            <HeaderTemplate>
                <h1>All Student details</h1>
                <table class="table text-center">
                    <thead>
                        <tr>
                            <th>User_Id</th>
                            <th>Nmae</th>
                            <th>Father_name</th>
                            <th>Mother_name</th>
                            <th>Class</th>
                            <th>Phone number</th>
                            <th>Address</th>
                            <th>Birthday</th>
                            <th>Religion</th>
                            <th>Gender</th>
                            <th>PassWord</th>
                           
                        </tr>
                    </thead>
                    <tbody>                
            </HeaderTemplate>
            <ItemTemplate>
                      <tr>
                            <th><%# Eval("St_id") %></th>
                               <td><%# Eval("st_name") %></td>
                               <td><%# Eval("St_fname") %></td>
                                <td><%# Eval("st_mname") %></td>
                                <td><%# Eval("st_class") %></td>
                                 <td><%# Eval("St_phone") %></td>
                                 <td><%# Eval("st_Address") %></td>
                          <td><%# Eval("St_date_of_birth") %></td>
                          <td><%# Eval("st_religion") %></td>
                          <td><%# Eval("st_gender") %></td>
                          <td><%# Eval("password") %></td>
                       
                        </tr>
            </ItemTemplate>
            <FooterTemplate>
                </tbody>
                </table>
            </FooterTemplate>
        </asp:Repeater>          

    </form>
	<script src="Scripts/jquery-3.3.1.min.js"></script>
	<script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
