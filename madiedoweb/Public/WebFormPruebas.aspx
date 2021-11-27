<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormPruebas.aspx.cs" Inherits="cartagenafirmas.Public.WebFormPruebas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 69%;
        }
        .auto-style2 {
            width: 53%;
        }
    </style>
    <link href="../Styles/Style_reserva.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="class_Hoteles">
        
       
    <h1>Lista de Zonificada de Hoteles Disponibles</h1>
        <h2 class="les">Seleccione ver para ver una Ciudad</h2>
                        <asp:GridView ID="GridViewHoteles" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnSelectedIndexChanged="GridViewHoteles_SelectedIndexChanged" PageSize="20" AllowSorting="True" Font-Size="Medium" Width="100%">
                            <Columns>
                                <asp:TemplateField HeaderText="N°" SortExpression="Nro.">
                                    <ItemTemplate>
                                        <%# Container.DataItemIndex + 1%>
                                    </ItemTemplate>
                                    <ItemStyle Width="20px" />
                                </asp:TemplateField>
                                <asp:CommandField HeaderText="Ver" ShowSelectButton="True" SelectText="Ver" >
                                <ItemStyle Width="35px" />
                                </asp:CommandField>
                                <asp:BoundField DataField="id_sede" HeaderText="Documento" >
                                <ItemStyle Width="25px" HorizontalAlign="Right" Wrap="True" />
                                </asp:BoundField>
                                <asp:BoundField DataField="Nombre_sede" HeaderText="Ciudad" >
                                <ItemStyle Font-Size="X-Small" HorizontalAlign="center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="ubicacion" HeaderText="Ubicacion" />
                            </Columns>
                        </asp:GridView>
          </div>            <table id="tabla_Hotel" style="vertical-align:top" >
                                        <tr>

                                            hola
                                            <td class="auto-style2">
                                                 <h1>Seleccione para ver detalles del hotel</h1>
                                                 <asp:GridView ID="GridView2" class="capa1" runat="server" AutoGenerateColumns="False" CaptionAlign="Top" Font-Size="Medium" HorizontalAlign="Center" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" Width="100%" BackColor="White">
                                                        <Columns>
                                                            <asp:TemplateField HeaderText="N°">
                                                                <ItemTemplate>
                                                                    <%# Container.DataItemIndex + 1%>
                                                                </ItemTemplate>
                                                                <ItemStyle Width="20px" />
                                                            </asp:TemplateField>
                                                            <asp:CommandField AccessibleHeaderText="Detalles" HeaderText="Detalle" ShowSelectButton="True" >
                                                            <ItemStyle Width="70px" />
                                                            </asp:CommandField>
                                                            <asp:BoundField DataField="id_hotel" HeaderText="id" >
                                                            <ItemStyle Width="20px" />
                                                            </asp:BoundField>
                                                            <asp:BoundField DataField="nombre_hotel" HeaderText="Nombre " >
                                                            <ItemStyle Width="180px" />
                                                            </asp:BoundField>
                                                            <asp:BoundField DataField="direccion_hotel" HeaderText="direccion" >
                                                            </asp:BoundField>
                                                        </Columns>
                                                    </asp:GridView>
                                                </td>
                                            <td>
                                                <span class="style99">
                                                                                                   <table id="tablaFirmasMuestraDatos">
                                                    <tr>
                                                       
                                                        
                                                        <td class="auto-style1">
                                                            <asp:Label ID="LabelFilaSeleccionada" runat="server" Text="Label" Visible="False"></asp:Label>
                                                            <br />
                                                            Lugar de Ubicación del Hotel:<strong class="style103">
                                                            <br />
                                    <asp:TextBox ID="TexBoxNombreSede" runat="server" CssClass="auto-style26" style="font-size: medium" TabIndex="2" Width="97%"></asp:TextBox>
                                                            <br />
                                    </strong></td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style1"><span class="style99">Nombre Hotel:&nbsp;<asp:TextBox ID="TexBoxNombreHotel" runat="server" TabIndex="3" Width="100px"></asp:TextBox>
                                                            &nbsp;&nbsp;&nbsp; Numero de habitaciones <asp:TextBox ID="TexBox_Num_Habitaciones" runat="server" TabIndex="3" Width="67px"></asp:TextBox>
                                                            <br />
                                                            Tipo: <asp:TextBox ID="TexBox_Tipo_Habitaciones" runat="server" TabIndex="3" Width="67px"></asp:TextBox>
                                                &nbsp; Cupo Disponible <asp:TextBox ID="TexBox_Cupo_Disponible" runat="server" TabIndex="3" Width="67px"></asp:TextBox>
                                                </span></td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style1"><span class="style99">Dirección:<asp:TextBox ID="TexBoxDireccionHotel" runat="server" TabIndex="3" Width="97%"></asp:TextBox>
                                                            <br />
                                                </span></td>
                                                    </tr>
                                                    </table>

                                                </span>
                                                <br />
                                            </td>
                                        </tr>
                                    </table>
                     
           
    </form>
</body>
</html>
