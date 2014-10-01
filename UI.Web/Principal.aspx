<%@ Page Language="C#" CodeFile="Principal.aspx.cs" Inherits="Consultorio.Site.Principal" Title="Pagina Principal" 
    MasterPageFile="~/MasterPage.master" AutoEventWireup="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <br />
        <table cellspacing="0" cellpadding="0">
            <tr>
                <td>
                    <asp:Image ID="ImgPacientes" runat="server" SkinID="imgLogoPaciente" />
                </td>
                <td>
                    <asp:Label ID="lblPacientes" runat="server" Font-Size="Large" ForeColor="SteelBlue"
                        Text="Pacientes" Font-Bold="True"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="btnActualizar" runat="server" Text="Actualizar Grilla" OnClick="btnActualizar_Click" /><br />
        <br />
        <asp:GridView ID="grdPacientes" runat="server" AllowPaging="True"
            AutoGenerateColumns="False" CellPadding="4" Font-Size="Small" 
            ForeColor="#333333" Width="100%" BorderColor="SteelBlue" BorderStyle="Solid" 
            BorderWidth="1px" OnPageIndexChanging="grdPacientes_PageIndexChanging" 
            OnRowCommand="grdPacientes_RowCommand" 
            onselectedindexchanged="grdPacientes_SelectedIndexChanged">
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Tipo y Nº Doc" />
                <asp:BoundField DataField="NomAp" HeaderText="Nombre y Apellido" />
                <asp:BoundField DataField="ObrasSociales" HeaderText="Obras Sociales" />
                <asp:BoundField DataField="Direccion" HeaderText="Dirección" />
                <asp:BoundField DataField="Telefonos" HeaderText="Telefonos" />
                <asp:BoundField DataField="Email" HeaderText="Email" />              
                <asp:TemplateField HeaderText="Detalle">
                    <ItemStyle HorizontalAlign="Center" />
                    <ItemTemplate>
                        <asp:Button ID="BtnVerConsultas" runat="server" Text="..." CommandName="VerConsultas" CommandArgument='<%# Eval("Id") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <EmptyDataTemplate>
                <asp:Label ID="lblSinDatos" runat="server" Font-Bold="True" ForeColor="SteelBlue"
                    Text="No hay pacientes cargados en el sistema" Width="254px"></asp:Label>
            </EmptyDataTemplate>
            <EditRowStyle BackColor="#999999" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        </asp:GridView>
        <br />
        <asp:Label ID="lblErrores" runat="server" Font-Bold="True" Font-Size="Small" ForeColor="Red"
            Visible="False"></asp:Label>
    </div>
</asp:Content>
