<%@ Page Title="Login" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Testing_Mini_Project._Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   <center>
        <h1 style="font-size: xx-large; font-weight: bold; color: #0000FF">Sign In</h1>
       <table style="width: 351px; height: 200px; background-color: #0000FF; font-size: large; font-weight: bold; color: #FFFFFF;" >
           <tr>
               <td style="width: 121px" align="center">Username</td>
               <td style="width: 188px">
                   <asp:TextBox ID="txt_login_username" runat="server" Width="203px"></asp:TextBox></td>
           </tr>

            <tr>
               <td style="width: 121px" align="center">Password</td>
               <td style="width: 188px">
                   <asp:TextBox ID="txt_login_pass" runat="server"  Width="203px"></asp:TextBox></td>
           </tr>
            
           <tr>
               <td colspan="2" align="center">
                <asp:Button ID="btn_login_b" runat="server" Text="Login" style="font-weight: bold; color:#000000;" OnClientClick="return userValid();" OnClick="btn_login_b_Click" />
               </td>
           </tr>
       </table>


   </center>
   <script>
       function userValid() {
           var Name;
           var Password;
           Name = document.getElementById('<%= txt_login_username.ClientID %>').value;
             Password = document.getElementById('<%= txt_login_pass.ClientID %>').value;
             if (Name == '') {
                 alert("Please enter all field");
                 return false;
             }
             if (Password == '') {
                 alert("Please enter all field");
                 return false;
             }
             alert("Login Successful");
             return true;



         }
   </script>
    


</asp:Content>

