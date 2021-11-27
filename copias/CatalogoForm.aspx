<%@ Page Title="" Language="C#" MasterPageFile="~/GetFirmas/AnidadaPaginasSeguras.master" AutoEventWireup="true" CodeBehind="CatalogoForm.aspx.cs" Inherits="cartagenafirmas.Public.CatalogoForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
              
              
              <asp:DataList ID="CatalagoDataList1" runat="server" RepeatColumns="4" CellPadding="5" CellSpacing="5" RepeatDirection="Vertical" RepeatLayout="Flow" Height="400px" Width="100%" CssClass="hidebr">
                   <ItemStyle VerticalAlign="Top" Wrap="True" HorizontalAlign="Left" CssClass="tdContainer" />
                   <ItemTemplate>
        <div id="divCatalogo">
               <table id="tablaCatalogo">
                      <tr>
                          <td><%#Eval("tituloNoticia") %></td>
                      </tr>
                      <tr>
                          <td><a href="<%#Eval("urlPaginaNoticia") %>"><img id="imgCatalogo" src="<%#Eval("fotoNoticia") %>" /></a> </td>
                      </tr>
                      <tr>
                          <td><p id="mensajeCatalogo"><%#Eval("mensajeNoticia") %></p></td>
                      </tr>
                      <tr>
                          <td>fecha nota</td>
                      </tr>
                  </table>
        </div>

                   </ItemTemplate>
              </asp:DataList>
                  

</asp:Content>
