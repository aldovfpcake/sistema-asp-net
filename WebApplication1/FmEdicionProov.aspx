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
<div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="" CssClass="col-md-2 control-label">Nombre Resumido</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" 
                                ID="TextResum"  
                                CssClass="form-control" 
                                TextMode="SingleLine" 
                                Width="323px" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="TextResum"
                                CssClass="text-danger" ErrorMessage="El campo Obligatorio." />
                        </div>
 </div>

<div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="" CssClass="col-md-2 control-label">Razón Social</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" 
                                ID="TextRsocial"  
                                CssClass="form-control" 
                                TextMode="SingleLine" 
                                Width="323px" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="TextRsocial"
                                CssClass="text-danger" ErrorMessage="El campo Obligatorio." />
                        </div>
 </div>
    
<div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="" CssClass="col-md-2 control-label">Localidad</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" 
                                ID="TextLocalidad"  
                                CssClass="form-control" 
                                TextMode="SingleLine" 
                                Width="323px" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="TextRsocial"
                                CssClass="text-danger" ErrorMessage="El campo Obligatorio." />
                        </div>
 </div>
  
<div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="" CssClass="col-md-2 control-label">Código Postal</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" 
                                ID="TextCodPostal"  
                                CssClass="form-control" 
                                TextMode="SingleLine" 
                                Width="323px" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="TextRsocial"
                                CssClass="text-danger" ErrorMessage="El campo Obligatorio." />
                        </div>
 </div>
     
<div class="form-group">
<asp:Label runat="server" AssociatedControlID="" CssClass="col-md-2 control-label">Provincia</asp:Label>
<div class="col-md-10">
    <asp:DropDownList runat="server" ID="ProvinciasL" CssClass ="col-md-2">
    <asp:ListItem Text="" Value="theValue" />
</asp:DropDownList>
</div>
</div>

<div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="" CssClass="col-md-2 control-label">C.u.i.t.</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" 
                                ID="TextCuit"  
                                CssClass="form-control" 
                                TextMode="SingleLine" 
                                Width="323px" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="TextCuit"
                                CssClass="text-danger" ErrorMessage="El campo Obligatorio." />
                        </div>
 </div>

<div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="" CssClass="col-md-2 control-label">Tipo De Iva</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" 
                                ID="TextTipoiva"  
                                CssClass="form-control" 
                                TextMode="SingleLine" 
                                Width="123px" 
                                value = 0
                                />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="TextTipoiva"
                                CssClass="text-danger" ErrorMessage="El campo Obligatorio." />
                        </div>
       </div>
     







    <asp:Button runat="server" OnClick="prueba" Text="Iniciar sesión" CssClass="btn btn-success" />











   
</asp:Content>
