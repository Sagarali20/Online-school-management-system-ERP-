<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Result_history.aspx.cs" Inherits="Final_project.UI.Result_history" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <br /><br />
 <div class="card ">

     		
       <div class="row">
            <div class="col-lg-2 mx-auto mt- ">
                <div class="team-member bg-dark">
					<br />
					<h1 class="text-white font-italic text-center ">Semester</h1>
					<br />
                      <div class="d-flex justify-content-center mt-1">
							 <asp:DropDownList ID="DropDownList1" runat="server"  AutoPostBack="true" CssClass="form-control col-md-9" >
                           	     <asp:ListItem>--Click here--</asp:ListItem>
								 <asp:ListItem>Spring</asp:ListItem>
                                 <asp:ListItem>Summer</asp:ListItem>
                                 <asp:ListItem>Fall</asp:ListItem>
                           
						       
							 </asp:DropDownList>
                       </div>
					
                    
                </div><!-- .team-member -->
            </div><!-- .col -->
        </div><!-- .row -->

     
                <asp:Repeater ID="Repeater1" runat="server">

            <HeaderTemplate>   
                <div class="card-header bg-info text-light"><h3 class="text-center"> All Result</h3></div>

                <table class="table text-center table-hover">
                    <thead>
                        <tr>
                            <th class="text-center">Student_Id</th>
                            <th class="text-center">Class</th>
                            <th class="text-center">Exam_Type</th>
                            <th class="text-center">Subject</th>
                            <th class="text-center">Tutorial_Exam</th>
                            <th class="text-center">Final_Exam</th>
                            <th class="text-center">Total_Mark</th>
                            <th class="text-center">Grade</th>
                            <th class="text-center">GPA</th>
                        </tr>
                    </thead>
                    <tbody>                
            </HeaderTemplate>
            <ItemTemplate>
                      <tr>
                               <th class="text-center"><%# Eval("S_id") %></th>
                               <td class="text-center"><%# Eval("Class") %></td>
                                <td class="text-center"><%# Eval("exam_type") %></td>
                                <td class="text-center"><%# Eval("C_id") %></td> 
                                <td class="text-center"><%# Eval("tutorial_exam") %></td>   
                                <td class="text-center"><%# Eval("final_semester") %></td> 
                                <td class="text-center"><%# Eval("total_mark") %></td>  
                                <td class="text-center"><%# Eval("Grade") %></td>
                                <td class="text-center"><%# Eval("GPA") %></td>
                       
                        </tr>
            </ItemTemplate>
            <FooterTemplate>
                </tbody>
                </table>
            </FooterTemplate>
        </asp:Repeater>  
                </div>
    	<script src="Scripts/jquery-3.3.1.min.js"></script>
	<script src="Scripts/bootstrap.min.js"></script>
</asp:Content>
