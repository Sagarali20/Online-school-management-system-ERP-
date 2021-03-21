<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee_details.aspx.cs" Inherits="Final_project.Employee" %>

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
					<asp:TextBox ID="TextSearch" runat="server" CssClass="form-control col-2" placeholder="Employee_Id"></asp:TextBox>
					<asp:Button ID="Search" runat="server" Text="Search" CssClass="btn btn-info" OnClick="Search_Click" />
					<asp:Button ID="Log_out" runat="server" Text="Log Out" CssClass="btn btn-danger ml-1" />			
					</div>

			</div>
		</nav>
	<br /><br />
       <div class="row">
            <div class="col-lg-8 mx-auto bg-dark ">
				<div class="row bg-dark ">
					<div class="col-lg-8">
				    <div class="team-member bg-dark">
                    <div class="d-flex justify-content-end mt-3">
						<asp:TextBox ID="TextBox1" runat="server"  CssClass=" form-control col-md-6" placeholder="Enter Employee_Id"></asp:TextBox>
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
						<asp:TextBox ID="TextBox5" runat="server"  CssClass=" form-control col-md-6" placeholder="Enter Present_Address"></asp:TextBox>
                        </div>
					   <div class="d-flex justify-content-end mt-1">
						<asp:TextBox ID="TextBox6" runat="server"  CssClass=" form-control col-md-6" placeholder="Enter parnament_Address" OnTextChanged="TextBox6_TextChanged"></asp:TextBox>
                        </div>
					  <div class="d-flex justify-content-end mt-1">
							 <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control col-md-6">
								 <asp:ListItem>--Select here--</asp:ListItem>
								 <asp:ListItem>Male</asp:ListItem>
								 <asp:ListItem>Female</asp:ListItem>
							 </asp:DropDownList>
                       </div>
				     <div class="d-flex justify-content-end mt-1">
						<asp:TextBox ID="TextBox8" runat="server"  CssClass=" form-control col-md-6" placeholder="Enter N_id Number"></asp:TextBox>
                        </div>
					  <div class="d-flex justify-content-end mt-1">
						<asp:TextBox ID="TextBox9" runat="server"  CssClass=" form-control col-md-6" placeholder="Enter Email_id"></asp:TextBox>
                        </div>
					   <div class="d-flex justify-content-end mt-1">
						<asp:TextBox ID="TextBox10" runat="server"  CssClass=" form-control col-md-6" placeholder="Enter Phone_number"></asp:TextBox>
                        </div>
					   <div class="d-flex justify-content-end mt-1">
						<asp:TextBox ID="TextBox11" runat="server"  CssClass=" form-control col-md-6" placeholder="Enter Religion"></asp:TextBox>
                        </div>
					   <div class="d-flex justify-content-end mt-1">
						   <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control col-md-6"/>
                        </div>
                   
                     </div><!-- .team-member -->

					</div>
						<div class="col-lg-4">	

				    <div class="team-member bg-dark">
											<br /><br /><br /><br />
					 <div class="col-md-12">
						 <asp:Image ID="Image1" runat="server" CssClass=" card-img-top" />

				     </div>
                   
                     </div><!-- .team-member -->

					</div>


				</div>
		           <div class=" d-md-flex justify-content-center  mt-1">
						<asp:Button ID="insert" runat="server" Text="Insert" CssClass="btn btn-info form-control col-md-2 ml- mt-2" OnClick="insert_Click"/>
						<asp:Button ID="update" runat="server" Text="Update" CssClass="btn btn-info form-control col-md-2 ml-1 mt-2"/>
			     		<asp:Button ID="delete" runat="server" Text="Delete" CssClass="btn btn-info form-control col-md-2 ml-1 mt-2"/>	
						<asp:Button ID="view" runat="server" Text="View" CssClass="btn btn-info form-control col-md-2 ml-1 mt-2" OnClick="view_Click"/>
                       	<asp:Button ID="cancle" runat="server" Text="Cancle" CssClass="btn btn-info form-control col-md-2 ml-1 mt-2"/>


                    </div>
					<div class="text-center text-white mt-4">
						<asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
					</div>

            </div><!-- .col -->
    </div><!-- .container -->
        <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate>
                <h1>All Employee details</h1>
                <table class="table text-center">
                    <thead>
                        <tr>
                           <th>Student_Id</th>
                            <th>Teacher_ID</th>
                            <th>Class</th>
                            <th>Exam_Type</th>
                            <th>Subject</th>
                            <th>Tutorial_Exam</th>
                            <th>Final_Exam</th>
                            <th>Total_Mark</th>
                            <th>Grade</th>
                            <th>GPA</th>
                            <th>Credit</th>

                        </tr>
                    </thead>
                    <tbody>                
            </HeaderTemplate>
            <ItemTemplate>
                      <tr>
                               <th><%# Eval("S_id") %></th>
                               <td><%# Eval("T_id") %></td>
                               <td><%# Eval("Class") %></td>
                                <td><%# Eval("exam_type") %></td>
                                <td><%# Eval("C_id") %></td> 
                                <td><%# Eval("tutorial_exam") %></td>   
                                <td><%# Eval("final_semester") %></td> 
                                <td><%# Eval("total_mark") %></td>  
                                <td><%# Eval("Grade") %></td>
                                <td><%# Eval("GPA") %></td>
                                <td><%# Eval("credit") %></td> 
                       
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
