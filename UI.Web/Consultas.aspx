<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" 
    CodeFile="Consultas.aspx.cs" Inherits="Consultorio.Site.Consultas" Title="Consultas del Paciente" %>
    
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <table cellpadding="0" cellspacing="0">
        <tr>
            <td>
                <asp:Image ID="ImgConsultas" runat="server" SkinID="imgLogoCalendario" />
            </td>
            <td>
                <asp:Label ID="lblConsultas" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="SteelBlue"
                    Text="Consultas"></asp:Label>
            </td>
        </tr>
    </table>
    <br />
    <asp:Label ID="lblPeriodo" runat="server" Text="Ver Consultas" Font-Size="Small"></asp:Label>
    <asp:DropDownList ID="cmbTipoConsultas" runat="server" AutoPostBack="True" Width="115px" OnSelectedIndexChanged="cmbTipoConsultas_SelectedIndexChanged">
        <asp:ListItem Selected="True" Value="0">Todas</asp:ListItem>
        <asp:ListItem Value="1">Por Fecha</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Calendar ID="CalendarCtl" runat="server" BackColor="White" BorderColor="LightSteelBlue"
        BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black"
        Height="190px" NextPrevFormat="FullMonth" Visible="False" Width="350px">
        <SelectedDayStyle BackColor="#333399" ForeColor="White" />
        <TodayDayStyle BackColor="#CCCCCC" />
        <OtherMonthDayStyle ForeColor="#999999" />
        <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
        <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
        <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True"
            Font-Size="12pt" ForeColor="#333399" />
    </asp:Calendar>
    <br />
    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
    <asp:Label ID="lblErrores" runat="server" Font-Bold="True" Font-Size="Small" ForeColor="Red"
        Visible="False"></asp:Label><br />
    <br />
    <hr />
    <br />
    <asp:GridView ID="grdConsultas" runat="server" AllowPaging="True" AutoGenerateColumns="False"
        CellPadding="4" Font-Size="Small" ForeColor="#333333" Visible="False"
        Width="100%" BorderColor="SteelBlue" BorderStyle="Solid" BorderWidth="1px" OnPageIndexChanging="GridViewCtl_PageIndexChanging">
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <Columns>
            <asp:BoundField DataField="Fecha" HeaderText="Fecha">
                <ItemStyle Width="175px" />
            </asp:BoundField>
            <asp:BoundField DataField="Tema" HeaderText="Tema">
                <ItemStyle Width="200px" />
            </asp:BoundField>
            <asp:BoundField DataField="Estado" HeaderText="Estado">
                <ItemStyle Width="75px" />
            </asp:BoundField>
            <asp:BoundField DataField="ResultadoReunion" HeaderText="Resultado Consulta" />
        </Columns>
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" BorderColor="SteelBlue" BorderStyle="Solid" BorderWidth="1px" />
        <EmptyDataTemplate>
            <asp:Label ID="lblDatos" runat="server" ForeColor="SteelBlue" Text="No hay consultas para el período indicado"
                Width="249px"></asp:Label>
        </EmptyDataTemplate>
        <EditRowStyle BackColor="#999999" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    </asp:GridView>
    <br />
    <asp:Button ID="btnVolver" runat="server" Text="<< Volver" OnClick="btnVolver_Click" />
</asp:Content>