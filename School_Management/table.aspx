<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="table.aspx.cs" Inherits="Final_project.table" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<link href="Content/bootstrap.min.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">

			<div class="card ">
				<div class="card-header bg-info"><h3>All Brand</h3></div>
					  <table class="table">
    <thead class=" thead-light">
      <tr>
        <th>Firstname</th>
        <th>Lastname</th>
        <th>Email</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td>John</td>
        <td>Doe</td>
        <td>john@example.com</td>
      </tr>
      <tr>
        <td>Mary</td>
        <td>Moe</td>
        <td>mary@example.com</td>
      </tr>
      <tr>
        <td>July</td>
        <td>Dooley</td>
        <td>july@example.com</td>
      </tr>
    </tbody>
  </table>
	</div>
		
			<div class="card ">
				<div class="card-header bg-info text-light"><h3>All Users</h3></div>
	
		<asp:GridView ID="GridView1" runat="server" CssClass="table table-hover table-bordered text-center" AutoGenerateColumns="False">
			<Columns>
				<asp:BoundField DataField="userid" HeaderText="User_name" />
			</Columns>
				</asp:GridView>


	</div>
	

		<br />
		<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    </form>	
	<script src="Scripts/jquery-3.3.1.min.js"></script>
	<script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
