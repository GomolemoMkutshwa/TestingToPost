<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="TroyeComputerSolutions.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Registration Platform</title>
   <style>
 body{

            background: #EEEEEE;
        }
        /*406D95*/
 .sidebar{

             height: 210%;
             width: 200px;
             position:fixed;
             z-index: 0;
             top:0;
             left: 0;
             
             background-color: #406D95;
             overflow:auto;
             padding-top: 0px;
             margin-top:0px;
         } 
         .sidebar a{
             margin-top:20px;
             padding: 10px 16px;
             cursor:pointer;
             width:100%;
             float:left;
             text-decoration: none;
             font-size: 20px;
             color:#EEE;
             background-color:transparent;
             display:block;
         }
 .sidebar a:hover {
   
      color:#ffffff;
 }
 .sidebar a.active{
     color: #ffffff;
 }
 
 .tabcontent{
     float: left;
     padding: 0px 12px;
     width: 80%;
     border-left: none;
     height: 50px;
 }
 h1{

    font-family:"Century Gothic";
    font-size:x-large;
 }
 hr{
     border-color:#000000;
     border-width:thin
     ;
 }

 @media screen and (max-height: 450px){
     .sidebar{padding-top:15px;}
     .sidebar a{font-size: 18px;}
 }
 
.topBar a{

    float:right;
    margin-right:70px;
    color: #000000;
    text-decoration:none;
    font-size:20px;
}
   </style>
    


</head>
<body>
    <form id="form1" runat="server">
    <div>
           <div class="sidebar" id="mySidenav" >

     <a href="#Dashboard" class="active" onclick="openOption(event, 'Home')">Troye</a>
     <a href="#Dashboard" class="tablinks" id="defaultOpen" onclick="openOption(event, 'Dashboard')">Dashboard</a>
     <a href="#Employees" class="tablinks"  onclick="openOption(event, 'Employees')">Employees</a>
     <a href="#Register" class="tablinks" onclick="openOption(event, 'Register')">Register</a>
     <a href="CreateProject.aspx" class="tablinks" onclick="openOption(event, 'Projects')">Projects</a>

       </div>
        <div  style="width:200px;margin-top: 5px; margin-left: 290px;  margin-bottom: 5px;">
           <h1>Register New Employees Below </h1></div>
      <%--REGISTER A USER--%>
  
<div id="Register" class="tabcontent" style="width:900px;height: 2200px;margin-top: 90px; margin-left: 290px;  margin-bottom: 15px; background-color:#FFFFFF;">
          <h1>Personal </h1>
    
<asp:Label ID="txtName" runat="server" Text="Name"></asp:Label> <input name="Name" type="text"  style="margin-top:0%; background-color:transparent; width:50%; height: 5%; border-top-color:transparent; border-left-color:transparent; border-left-width:thin; border-left-style:solid; border-right-color:transparent;border-bottom-color:#000000; border-bottom-width:thin; margin-left: 29%; "/>
<br />
<asp:Label ID="txtSurname" runat="server" Text="Surname"></asp:Label><input name="Surname" type="text"  style="margin-top:2%; background-color:transparent; width:50%; height: 5%; border-top-color:transparent; border-left-color:transparent; border-left-width:thin; border-left-style:solid; border-right-color:transparent;border-bottom-color:#000000; border-bottom-width:thin; margin-left: 27%; " />
<br />
<asp:Label ID="txtId" runat="server" Text="Id"></asp:Label> <input name="Name" type="text"  style="margin-top:2%; background-color:transparent; width:50%; height: 5%; border-top-color:transparent; border-left-color:transparent; border-left-width:thin; border-left-style:solid; border-right-color:transparent;border-bottom-color:#000000; border-bottom-width:thin; margin-left:32%; "/>
<br />
<br />  
         
<h1>Conatact </h1>
    <hr /> 
<asp:Label ID="txtAddress" runat="server" Text="Address"></asp:Label><input name="Adress" type="text" style="margin-top:2%; background-color:transparent; width:50%; height: 5%; border-top-color:transparent; border-left-color:transparent; border-left-width:thin; border-left-style:solid; border-right-color:transparent;border-bottom-color:#000000; border-bottom-width:thin; margin-left: 27%; " />
<br />
<asp:Label ID="txtCity" runat="server" Text="City"></asp:Label><input name="City" type="text"  style="margin-top:2%; background-color:transparent; width:50%; height: 5%; border-top-color:transparent; border-left-color:transparent; border-left-width:thin; border-left-style:solid; border-right-color:transparent;border-bottom-color:#000000; border-bottom-width:thin; margin-left: 29%; " />
<br />
<asp:Label ID="txtProvince" runat="server" Text="Province"></asp:Label><input name="Email" type="text"  style="margin-top:2%; background-color:transparent; width:50%; height: 5%; border-top-color:transparent; border-left-color:transparent; border-left-width:thin; border-left-style:solid; border-right-color:transparent;border-bottom-color:#000000; border-bottom-width:thin; margin-left: 26%; "/>
<br />
<asp:Label ID="txtPhone" runat="server" Text="Phone"></asp:Label><input name="Phone" type="text" placeholder="+2712345678" style="margin-top:2%; background-color:transparent; width:50%; height: 5%; border-top-color:transparent; border-left-color:transparent; border-left-width:thin; border-left-style:solid; border-right-color:transparent;border-bottom-color:#000000; border-bottom-width:thin; margin-left: 28%; "/>
<br />
<br />
<h1>Skills </h1>
    <hr />

<asp:Label ID="txtSkills" runat="server" Text="Skills"></asp:Label><input name="Name" type="text" placeholder="UX Designer" style="margin-top:2%; background-color:transparent; width:50%; height: 5%; border-top-color:transparent; border-left-color:transparent; border-left-width:thin; border-left-style:solid; border-right-color:transparent;border-bottom-color:#000000; border-bottom-width:thin; margin-left: 26%; " />
<br />
<asp:Label ID="txtYears" runat="server" Text="Years"></asp:Label><input name="Password1" type="number"   style="margin-top:2%;width :50%; height: 5%; background-color:transparent; border-top-color:transparent;border-left-color:transparent; border-left-style:solid; border-left-width:thin; border-right-color:transparent;border-bottom-color:#000000; border-bottom-width:thin; margin-left: 26%; "/>
<br />

<h1>Account </h1>
    <hr />
<asp:Label ID="txtEmail" runat="server" Text="Email"></asp:Label><input name="Email  " type="text" placeholder="@gmail.com" style="margin-top:2%; background-color:transparent; width:50%; height: 5%; border-top-color:transparent; border-left-color:transparent; border-left-width:thin; border-left-style:solid; border-right-color:transparent;border-bottom-color:#000000; border-bottom-width:thin; margin-left: 29%; " />
<br />
<asp:Label ID="txtUsername" runat="server" Text="Username"></asp:Label><input name="Name" type="text" placeholder="5559333" style="margin-top:2%; background-color:transparent; width:50%; height: 5%; border-top-color:transparent; border-left-color:transparent; border-left-width:thin; border-left-style:solid; border-right-color:transparent;border-bottom-color:#000000; border-bottom-width:thin; margin-left: 26%; "/>
<br />
<asp:Label ID="txtPassword" runat="server" Text="Password"></asp:Label><input name="Password1" type="password"  placeholder="jUICYmilk5!"  style="margin-top:2%;width :50%; height: 5%; background-color:transparent; border-top-color:transparent;border-left-color:transparent; border-left-style:solid; border-left-width:thin; border-right-color:transparent;border-bottom-color:#000000; border-bottom-width:thin; margin-left: 26%; "/>
<br />
<asp:Label ID="txtConfirm" runat="server" Text="Confirm"></asp:Label><input name="Confirm" type="password"  style="margin-top:2%;width :50%; height: 5%; background-color:transparent; border-top-color:transparent;border-left-color:transparent; border-left-style:solid; border-left-width:thin; border-right-color:transparent;border-bottom-color:#000000; border-bottom-width:thin; margin-left: 26%; "/>
<br/>
 <asp:Button runat="server" Text="Rgister" OnClick="btnRegister_Click" style="margin-top:10%; border-width: thin; margin-left: 39%; width :24%; height: 50px; background-color:#000000; border-style:solid; border-width:thin; font-family:'Century Gothic'; color:#ffffff; outline-color: #000000; border-radius:25px; margin-bottom:20px;" id="Button1"/>


        </div>
    </div>
    </form>
</body>
</html>
