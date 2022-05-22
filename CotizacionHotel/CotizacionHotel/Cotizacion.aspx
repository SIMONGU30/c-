<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cotizacion.aspx.cs" Inherits="CotizacionHotel.Cotizacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />

    <link href="css/estilos.css" rel="stylesheet" />

    <title> Reserva Hotel </title>
</head>
<body>
    <nav>
        <h1 class="my-5">Reserva Hotel Saimon </h1>
    </nav>
    <form id="form1"  class="text-center" runat="server">
        <div class="container">
            <asp:Label ID="lblNumeroDias" CssClass="form-label" runat="server" Text="Numero de Dias"></asp:Label><br />
            <asp:TextBox ID="txtNumeroDias" CssClass="form-control-sm" runat="server"></asp:TextBox><br />

            <asp:Label ID="lblValorPersona" runat="server" Text="Valor por Persona"></asp:Label><br />
            <asp:TextBox ID="txtValorPersona" CssClass="form-control-sm" runat="server"></asp:TextBox><br />

            <asp:Label ID="lblNumeroPersonas" runat="server" Text="Numero de Personas"></asp:Label><br />
            <asp:TextBox ID="txtNumeroPersonas" CssClass="form-control-sm" runat="server"></asp:TextBox><br />

            <asp:Label ID="lblAlimentacionPersona" runat="server" Text="Alimentacion por Persona"></asp:Label><br />
            <asp:TextBox ID="txtAlimentacionPersona" CssClass="form-control-sm" runat="server"></asp:TextBox><br />

            <br />

            <asp:Button ID="btnCotizar" CssClass="btn btn-success" runat="server" Text="Cotizar " OnClick="btnCotizar_Click" /><br />
            <br />
            <asp:Label ID="lblCotizacion" runat="server" Text="$ 000"></asp:Label><br />
            <asp:TextBox ID="txtCotizacion" runat="server">$ 000</asp:TextBox>
        </div>
            
    </form>
    <script src="Scripts/bootstrap.min.js"></script>

    <p>
        &lt;</p>

</body>
</html>
