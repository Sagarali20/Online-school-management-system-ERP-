<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Permission_System.aspx.cs" Inherits="Final_project.admin_card" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

	<link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
	
    <form id="form1" runat="server">
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

		<div class="container bg-light">
		<br />
				<div class=" d-md-flex input-group justify-content-end  ">
					<asp:CheckBox ID="CheckBox2" text="Active" runat="server" CssClass=" form-control col-1 bg-success text-white" style="left: 0px; top: 0px" />
						 <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control  col-md-2 "  placeholder="User_Name"></asp:TextBox>
					   <span class=" input-group-prepend">
						   <asp:Button ID="Search" runat="server" Text="Search" CssClass="btn btn-info form-control " OnClick="Search_Click" />
					   </span>	
			   </div>
			<div class="row">
				<asp:Button ID="Save_Access" runat="server" Text="Save_Access" CssClass="btn btn-info col-md-2 ml-2 mt-1" OnClick="Save_Access_Click" />
				<asp:Button ID="Update" runat="server" Text="Update" CssClass="btn btn-info col-md-2 ml-2 mt-1" Enabled="False" OnClick="Update_Click" />
				<asp:Button ID="cancle" runat="server" Text="Cancle" CssClass="btn btn-info col-md-2 ml-2 mt-1" Enabled="False" OnClick="cancle_Click" />
			<asp:TextBox ID="TextBox1" runat="server" CssClass="form-control  col-md-2 ml-2 mt-1 "  placeholder="Will Show" Enabled="False"></asp:TextBox>
			<asp:TextBox ID="TextBox2" runat="server" CssClass="form-control  col-md-2 ml-2 mt-1"  placeholder="User_Name"  Enabled="False"></asp:TextBox>

				</div>
			
			<div class=" row no-gutters mt-2">
			<div class="col-6 ">
		   <div class=" card-columns">
			 <div class="card bg-light ">
			   <div class=" card-body">
				   <h5>Form Access</h5>
                         <asp:CheckBoxList ID="accesslist" runat="server">
							 <asp:ListItem text="ins" Value="1">Class</asp:ListItem>
							 <asp:ListItem text="update" Value="2">Subject</asp:ListItem>
							 <asp:ListItem text="delete" Value="3">Std_Admission</asp:ListItem>
							  <asp:ListItem text="view"  Value="4">Student_Result</asp:ListItem>
							  <asp:ListItem text="insert" Value="5">Promosition</asp:ListItem>
							  <asp:ListItem text="insert" Value="6">Special_mark</asp:ListItem>
							  <asp:ListItem text="insert" Value="7">Attendence</asp:ListItem>
							  <asp:ListItem text="insert" Value="8">Std_Payment</asp:ListItem>
							  <asp:ListItem text="insert" Value="9">Account_history</asp:ListItem>
							  <asp:ListItem text="insert" Value="10">User_details</asp:ListItem>
                             <asp:ListItem text="insert" Value="11">Create_User</asp:ListItem>
                             <asp:ListItem text="insert" Value="12">Change_Password</asp:ListItem>
                             <asp:ListItem text="insert" Value="13">User_Permission</asp:ListItem>
                         </asp:CheckBoxList>
			     </div>
			</div>
	

			<div class="card bg-light">
			   <div class=" card-body">
               <h5>Class</h5>
				   <asp:CheckBoxList ID="classlist" runat="server">
							 <asp:ListItem text="insert" Value="insert">Insert</asp:ListItem>
							 <asp:ListItem text="update" Value="update">Update</asp:ListItem>
							 <asp:ListItem text="delete" Value="delete">Delete</asp:ListItem>
							  <asp:ListItem text="view"  Value="view">View</asp:ListItem>
                         </asp:CheckBoxList>
			     </div>
			</div>
			   			<div class="card bg-light">
			   <div class=" card-body">
				    <h5>Subject</h5>
                         <asp:CheckBoxList ID="subjectlist" runat="server">
							 <asp:ListItem text="insert" Value="insert">Insert</asp:ListItem>
							 <asp:ListItem text="update" Value="update">Update</asp:ListItem>
							 <asp:ListItem text="delete" Value="delete">Delete</asp:ListItem>
							  <asp:ListItem text="view"  Value="view">View</asp:ListItem>
                         </asp:CheckBoxList>
			     </div>
			</div>
			   			<div class="card bg-light">
			   <div class=" card-body">
				    <h5>Std_admission</h5>
                         <asp:CheckBoxList ID="Stdaddmissionlist" runat="server">
							 <asp:ListItem text="insert" Value="insert">Insert</asp:ListItem>
							 <asp:ListItem text="update" Value="update">Update</asp:ListItem>
							 <asp:ListItem text="delete" Value="delete">Delete</asp:ListItem>
							  <asp:ListItem text="view"  Value="view">View</asp:ListItem>
                         </asp:CheckBoxList>
			     </div>
			</div>
	
			   			<div class="card bg-light">
			   <div class=" card-body">
				    <h5>Std_Result</h5>
                         <asp:CheckBoxList ID="std_resultlist" runat="server">
							 <asp:ListItem text="insert" Value="insert">Insert</asp:ListItem>
							 <asp:ListItem text="update" Value="update">Update</asp:ListItem>
							 <asp:ListItem text="delete" Value="delete">Delete</asp:ListItem>
							  <asp:ListItem text="view"  Value="view">View</asp:ListItem>
                         </asp:CheckBoxList>
			     </div>
			</div>

			   </div>
			   </div>
				<div class="col-6 ">
		   <div class=" card-columns">
			 <div class="card  bg-light">
			   <div class=" card-body">
				    <h5>Special_mark</h5>
                         <asp:CheckBoxList ID="specialmarklist" runat="server">
							 <asp:ListItem  Value="insert">Insert</asp:ListItem>
							 <asp:ListItem  Value="update">Update</asp:ListItem>
							 <asp:ListItem  Value="delete">Delete</asp:ListItem>
							  <asp:ListItem  Value="view">View</asp:ListItem>
                         </asp:CheckBoxList>
			     </div>
			</div>

			<div class="card bg-light">
			   <div class=" card-body">
				    <h5>Std_payment</h5>
                         <asp:CheckBoxList ID="paymentList" runat="server">
                           <asp:ListItem text="insert" Value="insert">Insert</asp:ListItem>
							 <asp:ListItem text="update" Value="update">Update</asp:ListItem>
							 <asp:ListItem text="delete" Value="delete">Delete</asp:ListItem>
							  <asp:ListItem text="view"  Value="view">View</asp:ListItem>

                         </asp:CheckBoxList>
			     </div>
			</div>
	
			<div class="card bg-light">
			   <div class=" card-body">
				   <h5>User_Details</h5>
                         <asp:CheckBoxList ID="userdetailsLiast" runat="server">
							 <asp:ListItem text="insert" Value="insert">Insert</asp:ListItem>
							 <asp:ListItem text="update" Value="update">Update</asp:ListItem>
							 <asp:ListItem text="delete" Value="delete">Delete</asp:ListItem>
							  <asp:ListItem text="view"  Value="view">View</asp:ListItem>
                         </asp:CheckBoxList>
			     </div>
			</div>
			   			<div class="card bg-light">
			   <div class=" card-body">
				   <h5>Create_user</h5>
                         <asp:CheckBoxList ID="createuserlist" runat="server">
							 <asp:ListItem text="insert" Value="insert">Add_New_User</asp:ListItem>
							 <asp:ListItem text="update" Value="save">Save_User</asp:ListItem>
							 <asp:ListItem text="delete" Value="permission">Permission</asp:ListItem>
							  <asp:ListItem text="view"  Value="update">Update_UserInf</asp:ListItem>
							  <asp:ListItem text="view1" Value="view">View_All_User</asp:ListItem>
                         </asp:CheckBoxList>
			     </div>
			</div>
<%--			   	<div class="card bg-light">
			   <div class=" card-body">
				   <h5>Std_Acoount</h5>
                         <asp:CheckBoxList ID="changepass" runat="server">
							 <asp:ListItem text="insert" Value="insert">Insert</asp:ListItem>
							 <asp:ListItem text="update" Value="update">Update</asp:ListItem>
							 <asp:ListItem text="delete" Value="delete">Delete</asp:ListItem>
							  <asp:ListItem text="view"  Value="view">View</asp:ListItem>
                         </asp:CheckBoxList>
			     </div>
			</div>--%>


			   </div>
			   </div>
				</div>
	

			   </div>

    </form>
	<script src="Scripts/jquery-3.3.1.min.js"></script>
	<script src="Scripts/bootstrap.min.js"></script>

</body>
</html>
