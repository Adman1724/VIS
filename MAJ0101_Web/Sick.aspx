<%@ Page Language="C#" MasterPageFile="~/Business.Master" AutoEventWireup="true" CodeBehind="Sick.aspx.cs" Inherits="MAJ0101_Web.Sick" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="centring">
       
       
   </div>
    <div class="card_line">
             
               <asp:GridView ID="GridView2" runat="server" OnRowDataBound="GridView2_RowDataBound">
               </asp:GridView>
               
               </div>


               
               

    </asp:Content>