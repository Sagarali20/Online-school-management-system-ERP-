<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Progressbar.aspx.cs" Inherits="Final_project.UI.Progressbar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <br /><br />
                     <!-- /. ROW  -->
				 	<div class="row">
                    <div class="col-md-6 ">
                        <div class="card">
                        <div class="card-action">
                            Attendence Progress (<%#percen %>%) 
                        </div>
                       
                        <div class="card-content ">
                       <div class="progress progress-striped active">
  <div class="progress-bar progress-bar-primary" role="progressbar" aria-valuenow="40" aria-valuemin="0" aria-valuemax="100" style="width: <%# Session["DaysAvailable"].ToString() %>%;"><%#percen %>%  
   
    <span class="sr-only"></span>
  </div>
</div>
                            </div>
                            </div>
                    </div>

                </div>		
</asp:Content>
