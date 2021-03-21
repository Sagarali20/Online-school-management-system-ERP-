<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Account_info.aspx.cs" Inherits="Final_project.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br />
            <div id="page-inner"/> 
                
         
               
            <div class="row">
                <div class="col-md-12">
                  <!--   Kitchen Sink -->
                    <div class="card">
                        <div class="card-action">
                           Account_info
                        </div>
                        <div class="card-content">
                            <div class="table-responsiv ">
                                <asp:Repeater ID="Repeater1" runat="server">
                                    <HeaderTemplate> 

                                 
                                  <table class="table text-center mx-auto table-hover ">
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
<%--                              <td><asp:CheckBox ID="chkSelect" runat="server" Checked='true' /></td> --%>
                        </tr>
               
                   </ItemTemplate>
                       <FooterTemplate>
     
                      </tbody>
                     </table>
                    </FooterTemplate>
                                </asp:Repeater>
                           
               
   
                            </div>
                        </div>
                    </div>
                    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                     <!-- End  Kitchen Sink -->
                </div>
               
                   
                      <!-- End  Basic Table  -->
                </div>
            </div>
                <!-- /. ROW  -->
           
                <!-- /. ROW  -->
            <div class="row">

                <div class="col-md-12">
                     <!--    Context Classes  -->
                    <div class="card">
                       
                        <div class="card-action">
                            Context Classes
                        </div>
                        
                        <div class="card-content">
                            <div class="table-responsive">
                                <table class="table">
                                    <thead>
                                        <tr>
                                            <th>#</th>
                                            <th>First Name</th>
                                            <th>Last Name</th>
                                            <th>Username</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr class="success">
                                            <td>1</td>
                                            <td>Mark</td>
                                            <td>Otto</td>
                                            <td>@mdo</td>
                                        </tr>
                                        <tr class="info">
                                            <td>2</td>
                                            <td>Jacob</td>
                                            <td>Thornton</td>
                                            <td>@fat</td>
                                        </tr>
                                        <tr class="warning">
                                            <td>3</td>
                                            <td>Larry</td>
                                            <td>the Bird</td>
                                            <td>@twitter</td>
                                        </tr>
                                        <tr class="danger">
                                            <td>4</td>
                                            <td>John</td>
                                            <td>Smith</td>
                                            <td>@jsmith</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                    <!--  end  Context Classes  -->
                </div>
            </div>            
</asp:Content>
