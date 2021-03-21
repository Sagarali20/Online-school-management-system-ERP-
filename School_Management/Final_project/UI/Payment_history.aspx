﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Payment_history.aspx.cs" Inherits="Final_project.UI.Payment_history" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../Scripts/jquery-3.3.1.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

  <br /><br />

   
        <div id="page-inner"/> 
                        
            <div class="row">
                <div class="col-md-12">
                  <!--   Kitchen Sink -->
                    <div class="card">
                        <div class="card-action">
                            Payment_History
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
                                            <th >Paid</th>                                          
                                            <th>Recpts_No</th>
                                        </tr>
                                    </thead>                                 
                                 <tbody> 
                                     </HeaderTemplate>
                                   <ItemTemplate>
                      <tr>                            
                            <td><%# Eval("stdid") %></td>
                          <td><%# Eval("Pmonth","{0:dd-MM-yyyy }") %></td>
                          <td><%# Eval("Class") %></td>
                            <td style="text-align:center" class="fee"><%# Eval("Paid") %></td>
                             <td><%# Eval("Recpt") %></td> 
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


            <script>
                $(document).ready(function () {
                    var total=0;
                    var k = 200;
                    //document.write(k);
                    $("#form1").each(function () {
                        //total = total + parseInt($(this).val());
                        total = parseInt($("#fee").val());
                        var y = $("#fee").val();
                        var kk = 0;
                    });
                    var p = $("#fee").val();
                    //document.write(p);
                    alert("okk");
            });
         </script>
    
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</asp:Content>
