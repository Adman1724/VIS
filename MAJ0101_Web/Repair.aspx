<%@ Page Language="C#" MasterPageFile="~/Business.Master" AutoEventWireup="true" CodeBehind="Repair.aspx.cs" Inherits="MAJ0101_Web.Repair" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="centring">
       <div class="content">
           <div class="header_text">Report Error</div> 
              <div class="card_line">
                   <asp:Label CssClass="card_left_element" ID="nameLabel" runat="server" Text="Hardware Name:"></asp:Label>
                    <asp:DropDownList  CssClass="card_right_element" ID="hardwareElement" runat="server"></asp:DropDownList>
               </div>
           <div class="card_line">
                   <asp:Label CssClass="card_left_element" ID="label1" runat="server" Text="Text of Report:"></asp:Label>
                    
               <asp:TextBox CssClass="card_right_element" Rows="10" ID="textReport" runat="server"></asp:TextBox>
               </div>
          
           
           </div>
       

      
   </div>
    <div class="card_line">
               
               <asp:Button ID="uploadButton" CssClass="card_right_element rateConfirmButton" runat="server" Text="Upload Error Report" OnClick="uploadButton_Click1" />
               </div>


    </asp:Content>

