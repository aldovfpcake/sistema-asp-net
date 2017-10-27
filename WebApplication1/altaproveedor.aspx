<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="altaproveedor.aspx.cs" Inherits="WebApplication1.altaproveedor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


<div class="form-group">
<asp:Label runat="server" AssociatedControlID="" CssClass="col-md-2 control-label">CUENTA</asp:Label>
<div class="col-md-10">
<asp:TextBox runat="server"
ID="CUENTA"
CssClass=form-control
TextMode="SingleLine"
Width=323px 
 required="true" title="Campo Requerido"/>
 <asp:RequiredFieldValidator runat="server" id="reqName" controltovalidate="CUENTA" errormessage="El Nro de Cuenta es Rquerido" />
</div>
</div>
<br />
<div class="form-group">
<asp:Label runat="server" AssociatedControlID="" CssClass="col-md-2 control-label">RSOCIAL</asp:Label>
<div class="col-md-10">
<asp:TextBox runat="server"
ID="RSOCIAL"
CssClass=form-control
TextMode="SingleLine"
Width=323px />
</div>
</div>
<br />
<div class="form-group">
<asp:Label runat="server" AssociatedControlID="" CssClass="col-md-2 control-label">RESUM</asp:Label>
<div class="col-md-10">
<asp:TextBox runat="server"
ID="RESUM"
CssClass=form-control
TextMode="SingleLine"
Width=323px />
</div>
</div>
<br />
<div class="form-group">
<asp:Label runat="server" AssociatedControlID="" CssClass="col-md-2 control-label">LOCALIDAD</asp:Label>
<div class="col-md-10">
<asp:TextBox runat="server"
ID="LOCALIDAD"
CssClass=form-control
TextMode="SingleLine"
Width=323px />
</div>
</div>
<br/>
<div class="form-group">
<asp:Label runat="server" AssociatedControlID="" CssClass="col-md-2 control-label">CODPOSTAL</asp:Label>
<div class="col-md-10">
<asp:TextBox runat="server"
ID="CODPOSTAL"
CssClass=form-control
TextMode="SingleLine"
Width=323px />
</div>
</div>
<br/>
<div class="form-group">
<asp:Label runat="server" AssociatedControlID="" CssClass="col-md-2 control-label">PROIN</asp:Label>
<div class="col-md-10">
    <asp:DropDownList ID="PROVIN"  runat="server"   Width=290px required="true" title="Campo Requerido">
    </asp:DropDownList>
</div>
</div>
<br/>
<div class="form-group">
<asp:Label runat="server" AssociatedControlID="" CssClass="col-md-2 control-label">CUIT</asp:Label>
<div class="col-md-10">
<asp:TextBox runat="server"
ID="CUIT"
CssClass=form-control
TextMode="SingleLine"
Width=323px
pattern ="(20|23|24|27|30|33|34)(\D)?[0-9]{8}(\D)?[0-9]" 
 required="true" title="el cuit es requerido !!-!!!!!!!!-!"/>
</div>
</div>
<br/>
<div class="form-group">
<asp:Label runat="server" AssociatedControlID="" CssClass="col-md-2 control-label">TIPOIVA</asp:Label>
<div class="col-md-10">
<asp:DropDownList ID="ListaTipIva" autopostback="true" onselectedindexchanged="DescrpTipovia"  runat="server"   Width=290px >
</asp:DropDownList>
<asp:Label id="LabelListaTpIva" AssociatedControlId="ListaTipIva" 
    Text="" runat="server" />
</div>
</div>
<br/>
<div class="form-group">
<asp:Label runat="server" AssociatedControlID="" CssClass="col-md-2 control-label">CONTAB</asp:Label>
<div class="col-md-10">
<asp:DropDownList ID="LISTACONTA" autopostback="true" onselectedindexchanged="DescrpCuenta"  runat="server"   Width=290px  title="CUENTA REQUERIDA">
    </asp:DropDownList>
<p><asp:Label id="Descta1" AssociatedControlId="LISTACONTA" 
    Text="" runat="server" /> </p>
</div>
</div>
<br/>
<div class="form-group">
<asp:Label runat="server" AssociatedControlID="" CssClass="col-md-2 control-label">CONTAB1</asp:Label>
<div class="col-md-10">
<asp:DropDownList ID="LISTACONTA2" autopostback="true" onselectedindexchanged="DescrpCuenta2"  runat="server"   Width=290px  title="CUENTA REQUERIDA">
    </asp:DropDownList>
<p><asp:Label id="Descta2" AssociatedControlId="LISTACONTA2" 
    Text="" runat="server" /> </p>
</div>
</div>
<br/>
<div class="form-group">
<asp:Label runat="server" AssociatedControlID="" CssClass="col-md-2 control-label">CALLE</asp:Label>
<div class="col-md-10">
<asp:TextBox runat="server"
ID="CALLE"
CssClass=form-control
TextMode="SingleLine"
Width=323px />
</div>
</div>
<br/>
<div class="form-group">
<asp:Label runat="server" AssociatedControlID="" CssClass="col-md-2 control-label">NRO</asp:Label>
<div class="col-md-10">
<asp:TextBox runat="server"
ID="NRO"
CssClass=form-control
TextMode="SingleLine"
Width=323px />
</div>
</div>
<br />
<div class="form-group">
<asp:Label runat="server" AssociatedControlID="" CssClass="col-md-2 control-label">FECHAINGRESO</asp:Label>
<div class="col-md-10">
<asp:TextBox runat="server"
ID="FECHAINGRESO"
CssClass=form-control
TextMode="SingleLine"
Width=323px 
pattern="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d" required="true" title="Campo Requerido formato !!/!!/!!!!" />
<asp:Button id ="Btn" runat="server" OnClick="alta" Text="Aceptar" CssClass="btn btn-success" />
</div>
</div>
<div class="form-group">
<asp:Label runat="server" AssociatedControlID="" CssClass="col-md-2 control-label" ID="mensajealta" Text="ddddd" Visible="False"></asp:Label>
</div>



</asp:Content>



         