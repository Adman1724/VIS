<%@ Page Language="C#" MasterPageFile="~/Business.Master" AutoEventWireup="true" CodeBehind="Profil.aspx.cs" Inherits="MAJ0101_Web.Profil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="centring">
       <div class="content">
           <div class="header_text">Change Profile</div> 
           <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
           
               <div class="card_line">
                   <asp:Label CssClass="card_left_element" ID="nameLabel" runat="server" Text="Name"></asp:Label>
                   <asp:TextBox CssClass="card_right_element " ID="nameElement" Text="" runat="server"></asp:TextBox>
               </div>
               <div class="cardLine">
                   <asp:Label CssClass="card_left_element" ID="surnameLabel" runat="server" Text="Surname"></asp:Label>
                   <asp:TextBox CssClass="card_right_element" ID="surnameElement" Text="" runat="server"></asp:TextBox>
               </div>
            <div class="cardLine">
                   <asp:Label CssClass="card_left_element" ID="Label9" runat="server" Text="Personal ID Number"></asp:Label>
                   <asp:TextBox CssClass="card_right_element" ID="perIdNumElement" Enabled="false" Text="" runat="server"></asp:TextBox>
               </div>
               
               <div class="cardLine">
                   <asp:Label CssClass="card_left_element" ID="genderLabel" runat="server" Text="Adress"></asp:Label>
                   <asp:TextBox CssClass="card_right_element" ID="adressElement" Enabled="false" Text="" runat="server"></asp:TextBox>
               </div>
           
            <div class="cardLine">

                   <asp:Label CssClass="card_left_element" ID="Label10" runat="server" Text="Sex"></asp:Label>
                  <asp:TextBox ID="sexElement" runat="server" Enabled="false"></asp:TextBox>
               </div>
               <div class="cardLine">

                   <asp:Label CssClass="card_left_element" ID="Label1" runat="server" Text="Work group"></asp:Label>
                   <asp:DropDownList ID="workGroupElement" runat="server"></asp:DropDownList>
               </div>
           <div class="cardLine">
                   <asp:Label CssClass="cardLabel" ID="mailLabel" runat="server" Text="Mail"></asp:Label>
                   <asp:TextBox CssClass="rightCardElement profileInput" ID="mailElement" Text="" runat="server"></asp:TextBox>
               </div>
               <div class="cardLine">
                   <asp:Label CssClass="card_left_element" ID="Label2" runat="server" Text="Project"></asp:Label>
                   <asp:TextBox CssClass="card_right_element" ID="projectElement" Enabled="false" Text="" runat="server"></asp:TextBox>
               </div>
               <div class="cardLine">
                   <asp:Label CssClass="card_left_element" ID="Label5" runat="server" Text="Position"></asp:Label>
                    <asp:TextBox CssClass="card_right_element" ID="positionElemnt" Enabled="false" Text="" runat="server"></asp:TextBox>
               </div>
           <div class="cardLine">
                   <asp:Label CssClass="card_left_element" ID="Label6" runat="server" Text="Old Password"></asp:Label>
                   <asp:TextBox CssClass="card_right_element" TextMode="Password" ID="oldPasswordElement" Text="" runat="server"></asp:TextBox>
               </div>
               <div class="cardLine">
                   <asp:Label CssClass="card_left_element" ID="Label3" runat="server" Text="Change Password"></asp:Label>
                   <asp:TextBox CssClass="card_right_element" TextMode="Password" ID="password1" Text="" runat="server"></asp:TextBox>
               </div>
               <div class="cardLine">
                   <asp:Label CssClass="card_left_element" ID="Label4" runat="server" Text="Confirm Password"></asp:Label>
                   <asp:TextBox CssClass="card_right_element" TextMode="Password" ID="password2" Text="" runat="server"></asp:TextBox>
               </div>
               <asp:Button ID="profileConfirmButton" CssClass="rateConfirmButton" runat="server" Text="Update"  />
           </div>
       

      
   </div>

    </asp:Content>