<%--<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Site.Master"CodeBehind="WebPadronProveedores.aspx.cs" Inherits="WebApplication1.WebPadronProveedores" %>--%>

    
 <asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

 <h2> &nbsp;</h2>
     <div class="wrapper">
         <div class="container">
             <div class="form-box">
                 <div class="panel panel-primary">
                     <div class="panel-heading text-center">
                         <h3>Registro de Proveedores</h3>

                 
          </div>
       </div>
   </div>
  </div>       
 </div>
  <div class="form-group"> 
                    <div class="row">
                         <div class="col-sm-offset-5 col-sm-3  btn-submit">
                          </div>    
  <asp:Button runat="server" OnClick="prueba" Text="Iniciar sesión" CssClass="btn btn-success" />
                            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;
                         <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                         <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                            <asp:GridView ID="GridView1" runat ="server" BackColor="#3366FF" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Width="881px" CaptionAlign="Right" CssClass="alert-warning" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowCommand="GridView1_RowCommand">
                                 <Columns>
                                     <asp:HyperLinkField DataNavigateUrlFields="id" Text="EDITAR" DataNavigateUrlFormatString="FmEdicionProov.aspx?id={0}" DataTextField="id" />
<asp:TemplateField><ItemTemplate>
                                  <asp:Button ID="AddButton" runat="server" 
                                  CommandName ="AddToCart" 
                                  CommandArgument= "<%# ((GridViewRow) Container).RowIndex %>"
                                  Text ="Add to Cart" />
                                  
</ItemTemplate>
</asp:TemplateField>
                                 </Columns>
                                 
                                 <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                                 <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                                 <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                                 <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                                 <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                                 <SortedAscendingCellStyle BackColor="#FFF1D4" />
                                 <SortedAscendingHeaderStyle BackColor="#B95C30" />
                                 <SortedDescendingCellStyle BackColor="#F1E5CE" />
                                 <SortedDescendingHeaderStyle BackColor="#93451F" />
                                 
 
                                </asp:GridView>                 
                                                           
                            
                       
                    </div>
                </div>
                     
     
                     
</asp:Content>
