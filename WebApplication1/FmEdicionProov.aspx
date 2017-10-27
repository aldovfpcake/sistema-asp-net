<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FmEdicionProov.aspx.cs" Inherits="WebApplication1.FmEdicionProov" %>
<%@ Register src="WebUserControlCuit.ascx" tagname="WebUserControlCuit" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div class="wrapper">
         <div class="container">
             <div class="form-box">
                 <div class="panel panel-primary">
                     <div class="panel-heading text-center">
                         <h3>Edicion de Proveedores</h3>
          </div>
       </div>
   </div>
             <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
  </div>       
 </div>
<div class="row">
  <div class="col-sm-6">
     <div class="form-group">
        <label class="control-label" for="fname">Proveedor Nombre Resumido</label>
         <asp:TextBox ID="TextResum" runat="server" CssClass="form-control"></asp:TextBox>
     <div >
         <uc1:WebUserControlCuit ID="WebUserControlCuit1" 
             runat="server" />
     <br />
           </div>
       </div>
   </div>

    <asp:Button runat="server" OnClick="prueba" Text="Iniciar sesión" CssClass="btn btn-success" />











    </div>
</asp:Content>
