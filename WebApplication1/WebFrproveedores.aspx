<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFrproveedores.aspx.cs" Inherits="WebApplication1.WebFrproveedores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class="row">
        <div class="col-md-8">
            <section id="Padron">
                <div class="form-horizontal">
                    <h4>Padron de Proveedores</h4>
                  
                    <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                        <p class="text-danger">
                            <asp:Literal runat="server" ID="FailureText" />
                        </p>
                    </asp:PlaceHolder>
                    <asp:GridView ID="GridView1" 
                        runat="server" 
                        Width="596px">
                        <Columns>
                            <asp:HyperLinkField DataNavigateUrlFields="id" 
                                DataNavigateUrlFormatString="FmEdicionProov.aspx?id={0}" 
                                DataTextField="ID" 
                                
                                HeaderText="ID" />
                              
                            <asp:BoundField DataField = "id" HeaderText = "id" />

                        </Columns>
                    </asp:GridView>
                   </div>
                   <br />
                   
            </section>
            </div>
    </div>














</asp:Content>
