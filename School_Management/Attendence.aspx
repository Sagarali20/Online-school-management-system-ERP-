<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Attendence.aspx.cs" Inherits="Final_project.WebForm5" %>

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
        <br />

       
		 <div class="container">
       <div class="row">
            <div class="col-lg-4 mx-auto">
                <div class="team-member bg-dark">
					<br />
					<h1 class="text-white font-italic text-center">Attendence</h1>
					<br />
                      <div class="d-flex justify-content-center mt-1">
							 <asp:DropDownList ID="DropDownList1" runat="server"  AutoPostBack="true" CssClass="form-control col-md-9" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                           
						       
							 </asp:DropDownList>
                       </div>
                          <div class="d-flex justify-content-center mt-1">
							 <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control col-md-9" >
                            
       

							 </asp:DropDownList>
                       </div>	

                    <div class="d-flex justify-content-center mt-3">
						<asp:Button ID="Promotions" runat="server" Text="Start" CssClass="btn btn-info col-md-9" OnClick="Promotions_Click"  />

                    </div>
					<div class="text-center text-white mt-4">
						   <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
					    <br /> 
                        <br />
                     

					</div>
					
                    
                </div><!-- .team-member -->
            </div><!-- .col -->
        </div><!-- .row -->
    </div><!-- .container -->
<div class="container">
<asp:Repeater ID="final" runat="server" OnItemCommand="final_ItemCommand">
    <HeaderTemplate>
        <div class="card-header bg-info text-light text-center "><h3>All Students</h3></div>
        <table class="table text-center table-dark table-hover  mx-auto "> 
            
            <tr>
                <th>
                    Student_ID
                </th>
                <th>
                    Roll_no
                </th>
                <th>
                    Student_Name
                </th>
                <th>
                    Attendence_Mark
                </th>
            </tr>
    </HeaderTemplate>
    <ItemTemplate>
        <tr>
            <th>
                <asp:Label ID="Std_id" runat="server" Text='<%# Eval("Student_id") %>' />
            </th>
            <td>
                <asp:Label ID="Roll" runat="server" Text='<%# Eval("Roll_no") %>' />
            </td>
            <td>
                <asp:Label ID="lblCountry" runat="server" Text='<%# Eval("St_name") %>' />
            </td>
        
              <td><asp:CheckBox ID="chkSelect" runat="server" Checked='true' /></td> 

        </tr>
    </ItemTemplate>
    <FooterTemplate>
        </table>
                     <div class="d-flex justify-content-center ">
					<asp:Button ID="submission" runat="server" Text="Submit" CssClass="btn btn-info col-md-9"  />
                    </div>
    </FooterTemplate>
    

</asp:Repeater>  

   
        </div>


    </form>
   

	<script src="Scripts/jquery-3.3.1.min.js"></script>
	<script src="Scripts/bootstrap.min.js"></script>
</body>
</html>

