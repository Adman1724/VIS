<%@ Page Language="C#" MasterPageFile="~/Business.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="MAJ0101_Web.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="centring">
       
       
   </div>
    <div class="card_line">
             
               <asp:GridView ID="GridView1" runat="server" OnRowDataBound="GridView1_RowDataBound" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowCommand="GridView1_RowCommand">
               </asp:GridView>
               <table class="auto-style1">
                   <tr>
                       <td>Date:</td>
                       <td>
                           <asp:DropDownList ID="DropDownList1" runat="server">
                           </asp:DropDownList>
                       </td>
                   </tr>
                   <tr>
                       <td>Text</td>
                       <td>
                           <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                       </td>
                   </tr>
               </table>
               </div>


               <asp:Button ID="uploadButton" CssClass="card_right_element rateConfirmButton" runat="server" Text="Upload" OnClick="uploadButton_Click1" />
               

    </asp:Content>