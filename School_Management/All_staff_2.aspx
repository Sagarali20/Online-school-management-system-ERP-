<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="All_staff_2.aspx.cs" Inherits="Final_project.All_staff_2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
         <div id="wrapper"/>
        <nav class="navbar navbar-default top-navbar" role="navigation">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".sidebar-collapse">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand waves-effect waves-dark" ><i class="large material-icons">My</i> <strong>School</strong></a>
				
		<div id="sideNav" href=""><i class="material-icons dp48">wellcome</i></div>
            </div>

            <ul class="nav navbar-top-links navbar-right"> 
              	<li><a class="dropdown-button waves-effect waves-dark" href="#!" data-activates="dropdown1"><i class="fa fa-tasks fa-fw"></i> <i class="material-icons right">Class</i></a></li>				
				<li><a class="dropdown-button waves-effect waves-dark" href="#!" data-activates="dropdown2"><i class="fa fa-tasks fa-fw"></i> <i class="material-icons right">Student_info</i></a></li>				
				<li><a class="dropdown-button waves-effect waves-dark" href="#!" data-activates="dropdown3"><i class="fa fa-tasks fa-fw"></i> <i class="material-icons right">Attendence</i></a></li>				
				<li><a class="dropdown-button waves-effect waves-dark" href="#!" data-activates="dropdown4"><i class="fa fa-tasks fa-fw"></i> <i class="material-icons right">Accounting</i></a></li>
				<li><a class="dropdown-button waves-effect waves-dark" href="#!" data-activates="dropdown5"><i class="fa fa-tasks fa-fw"></i> <i class="material-icons right">User_info</i></a></li>
				  <li><a class="dropdown-button waves-effect waves-dark" href="#!" data-activates="dropdown6"><i class="fa fa-user fa-fw"></i> <b></b> <i class="material-icons right"></i></a></li>
            </ul>
        </nav>
		<!-- Dropdown Structure -->
        <ul id="dropdown1" class="dropdown-content">
<li><asp:HyperLink ID="Class1" CssClass="dropdown-item" runat="server" Enabled="False" NavigateUrl="~/.aspx">Class</asp:HyperLink></li> 
<li><asp:HyperLink ID="subject" CssClass="dropdown-item" runat="server" Enabled="False" NavigateUrl="~/.aspx">Subject</asp:HyperLink></li> 
<li><asp:HyperLink ID="Class_sec" CssClass="dropdown-item" runat="server" Enabled="False" NavigateUrl="~/.aspx">Class_Sec</asp:HyperLink></li> 
 <li><asp:HyperLink ID="HyperLink4" CssClass="dropdown-item" runat="server" Enabled="False" NavigateUrl="~/.aspx">h</asp:HyperLink></li>        
</ul>
            <ul id="dropdown2" class="dropdown-content">
<li><asp:HyperLink ID="admission" CssClass="dropdown-item" runat="server" Enabled="False" NavigateUrl="~/.aspx">Student_Admission</asp:HyperLink></li> 
<li><asp:HyperLink ID="result" CssClass="dropdown-item" runat="server" Enabled="False" NavigateUrl="~/.aspx">Student_Result</asp:HyperLink></li> 
<li><asp:HyperLink ID="promotion" CssClass="dropdown-item" runat="server" Enabled="False" NavigateUrl="~/.aspx">Student_Promotion</asp:HyperLink></li> 
 <li><asp:HyperLink ID="HyperLink8" CssClass="dropdown-item" runat="server" Enabled="False" NavigateUrl="~/.aspx">h</asp:HyperLink></li>        
</ul>
            <ul id="dropdown3" class="dropdown-content">
<li><asp:HyperLink ID="std_attendence" CssClass="dropdown-item" runat="server" Enabled="False" NavigateUrl="~/.aspx">Student_Attendence</asp:HyperLink></li> 
<li><asp:HyperLink ID="Stuff_atten" CssClass="dropdown-item" runat="server" Enabled="False" NavigateUrl="~/.aspx">Stuff_Attendence</asp:HyperLink></li> 
<li><asp:HyperLink ID="HyperLink11" CssClass="dropdown-item" runat="server" Enabled="False" NavigateUrl="~/.aspx">h</asp:HyperLink></li> 
 <li><asp:HyperLink ID="HyperLink12" CssClass="dropdown-item" runat="server" Enabled="False" NavigateUrl="~/.aspx">h</asp:HyperLink></li>        
</ul>
            <ul id="dropdown4" class="dropdown-content">
<li><asp:HyperLink ID="Account_std" CssClass="dropdown-item" runat="server" Enabled="False" NavigateUrl="~/.aspx">Student_Account</asp:HyperLink></li> 
<li><asp:HyperLink ID="Account_stuff" CssClass="dropdown-item" runat="server" Enabled="False" NavigateUrl="~/.aspx">Stuff_Account</asp:HyperLink></li> 
<li><asp:HyperLink ID="HyperLink15" CssClass="dropdown-item" runat="server" Enabled="False" NavigateUrl="~/.aspx">h</asp:HyperLink></li> 
 <li><asp:HyperLink ID="HyperLink16" CssClass="dropdown-item" runat="server" Enabled="False" NavigateUrl="~/.aspx">h</asp:HyperLink></li>        
</ul>
            <ul id="dropdown5" class="dropdown-content">
<li><asp:HyperLink ID="User_Details" CssClass="dropdown-item" runat="server" Enabled="False" NavigateUrl="~/.aspx">User_Details</asp:HyperLink></li> 
<li><asp:HyperLink ID="Create_User" CssClass="dropdown-item" runat="server" Enabled="False" NavigateUrl="~/.aspx">Create_User</asp:HyperLink></li> 
<li><asp:HyperLink ID="Change_PassWord" CssClass="dropdown-item" runat="server" Enabled="False" NavigateUrl="~/.aspx">Change_PassWord</asp:HyperLink></li> 
 <li><asp:HyperLink ID="User_Permission" CssClass="dropdown-item" runat="server" Enabled="False" NavigateUrl="~/.aspx">User_Permission</asp:HyperLink></li>        
</ul>
            <ul id="dropdown" class="dropdown-content">
<li><asp:HyperLink ID="HyperLink21" CssClass="dropdown-item" runat="server" Enabled="False" NavigateUrl="~/.aspx">h</asp:HyperLink></li> 
<li><asp:HyperLink ID="HyperLink22" CssClass="dropdown-item" runat="server" Enabled="False" NavigateUrl="~/.aspx">h</asp:HyperLink></li> 
<li><asp:HyperLink ID="HyperLink23" CssClass="dropdown-item" runat="server" Enabled="False" NavigateUrl="~/.aspx">h</asp:HyperLink></li> 
 <li><asp:HyperLink ID="HyperLink24" CssClass="dropdown-item" runat="server" Enabled="False" NavigateUrl="~/.aspx">h</asp:HyperLink></li>        
</ul>
<ul id="dropdown6" class="dropdown-content">
<li><a href="#"><i class="fa fa-user fa-fw"></i> My Profile</a>
</li>
<li><a href="#"><i class="fa fa-gear fa-fw"></i> Settings</a>
</li> 
<li><a href="login.aspx"><i class="fa fa-sign-out fa-fw"></i> Logout</a>
</li>
</ul>


	   <!--/. NAV TOP  -->
        <!--/. NAV TOP  -->
        <nav class="navbar-default navbar-side" role="navigation">
            <div class="sidebar-collapse">
                <ul class="nav" id="main-menu">

                    <li>
                        <a href="#" class="waves-effect waves-dark"><i class="fa fa-dashboard"></i> Dashboard</a>
                    </li>



                    <li>
                        <a href="#" class="waves-effect waves-dark"><i class="fa fa-sitemap"></i>Class<span class="fa arrow"></span></a>
                        <ul class="nav nav-second-level">
                            <li>
                                <asp:HyperLink ID="Class_le" runat="server" NavigateUrl="~/class.aspx" Enabled="False">Class</asp:HyperLink>
                            </li>
                            <li>
                                <asp:HyperLink ID="subjectle" runat="server" NavigateUrl="~/Subject.aspx" Enabled="False">Subject</asp:HyperLink>
                            </li>
<%--                             <li>
                                <asp:HyperLink ID="Class_sec_le" runat="server" NavigateUrl="~/class_section.aspx">Class_Sec</asp:HyperLink>
                            </li>--%>

                        </ul>
                    </li>
                    <li>
                        <a href="#" class="waves-effect waves-dark"><i class="fa fa-sitemap"></i>Student_Info<span class="fa arrow"></span></a>
                        <ul class="nav nav-second-level">
                            <li>
                                <asp:HyperLink ID="Addmisionle" runat="server" NavigateUrl="~/Student_info.aspx" Enabled="False">Student_Admission</asp:HyperLink>
                            </li>
                            <li>
                                <asp:HyperLink ID="resultle" runat="server" NavigateUrl="~/result.aspx" Enabled="False">Student_Result</asp:HyperLink>
                            </li>
                             <li>
                                <asp:HyperLink ID="promotionle" runat="server" NavigateUrl="~/promotion.aspx" Enabled="False">Student_Promotion</asp:HyperLink>
                            </li>
                             <li>
                                <asp:HyperLink ID="speciale" runat="server" NavigateUrl="~/special_marks.aspx" Enabled="False">Special_Mark</asp:HyperLink>
                            </li>
                              <li>
                                <a href=".aspx"></a>
                            </li>
                        </ul>
                    </li>
                                        <li>
                        <a href="#" class="waves-effect waves-dark"><i class="fa fa-sitemap"></i>Attendence<span class="fa arrow"></span></a>
                        <ul class="nav nav-second-level">
                            <li>
                                <asp:HyperLink ID="attendencele" runat="server" NavigateUrl="~/Attendence.aspx" Enabled="False">Student_Attendence</asp:HyperLink>
                            </li>
                            <li>
                            <asp:HyperLink ID="stuffle" runat="server" Enabled="False">Stuff_Attendence</asp:HyperLink>
                            </li>

                        </ul>
                    </li>
                    <li>
                        <a href="#" class="waves-effect waves-dark"><i class="fa fa-sitemap"></i>Student_Account_info<span class="fa arrow"></span></a>
                        <ul class="nav nav-second-level">
                            <li>
                              <asp:HyperLink ID="accountpatmtdle" runat="server" NavigateUrl="~/std_payment_entry.aspx" Enabled="False">Std_Payment_Entry</asp:HyperLink>
                            </li>
                            <li>
                             <asp:HyperLink ID="std_accounthstoryle" runat="server" NavigateUrl="~/Account_info.aspx" Enabled="False">Account_History</asp:HyperLink>
                            </li>
<%--                             <li>
                             <asp:HyperLink ID="HyperLink1" runat="server">Payment_History</asp:HyperLink>
                            </li>--%>

                        </ul>
                    </li>
                            <li>
                        <a href="#" class="waves-effect waves-dark"><i class="fa fa-sitemap"></i>User_Info<span class="fa arrow"></span></a>
                        <ul class="nav nav-second-level">
                            <li>
                             
                                <asp:HyperLink ID="User_Detailsle" runat="server" NavigateUrl="~/Employee_details.aspx" Enabled="False">User_Details</asp:HyperLink>
                            </li>
                            <li>
                                <asp:HyperLink ID="Create_Userle" runat="server" NavigateUrl="~/Create_User.aspx" Enabled="False">Create_User</asp:HyperLink>
                            </li>
                             <li>
                                <asp:HyperLink ID="ChangePasswordle" runat="server" NavigateUrl="~/passWord_Change.aspx" Enabled="False">ChangePassword</asp:HyperLink>
                            </li>
                              <li>
                                <asp:HyperLink ID="User_permissionle" runat="server" NavigateUrl="~/Permission_System.aspx" Enabled="False">User_permission</asp:HyperLink>
                            </li>
                        </ul>
                    </li>
                                        <li>
                        <a href="#" class="waves-effect waves-dark"><i class="fa fa-sitemap"></i>A<span class="fa arrow"></span></a>
                        <ul class="nav nav-second-level">
                            <li>
                                <a href=".aspx"></a>
                            </li>
                            <li>
                                <a href=".aspx"></a>
                            </li>
                             <li>
                                <a href=".aspx"></a>
                            </li>
                              <li>
                                <a href=".aspx"></a>
                            </li>
                        </ul>
                    </li>
                                        <li>
                        <a href="#" class="waves-effect waves-dark"><i class="fa fa-sitemap"></i><span class="fa arrow"></span></a>
                        <ul class="nav nav-second-level">
                            <li>
                                <a href=".aspx"></a>
                            </li>
                            <li>
                                <a href=".aspx"></a>
                            </li>
                             <li>
                                <a href=".aspx"></a>
                            </li>
                              <li>
                                <a href=".aspx"></a>
                            </li>
                        </ul>
                    </li>

                </ul>

            </div>

        </nav>
        <!-- /. NAV SIDE  -->
        <div id="page-wrapper" >
<%--		  <div class="header"> 
                        <h1 class="page-header">
                            Tables Page
                        </h1>
						<ol class="breadcrumb">
					  <li><a href="#">Home</a></li>
					  <li><a href="#">Tables</a></li>
					  <li class="active">Data</li>
					</ol> 
									
		</div>--%>

</asp:Content>
