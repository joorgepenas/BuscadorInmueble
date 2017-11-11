<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="BuscadorInmueble.Form.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="~/Content/CSS/Inmobiliaria.css" rel="stylesheet" />
<link rel="stylesheet" href="css/bootstrap.min.css">
    <title>PeñaCondeTingoLosta</title>

    <style type="text/css">
        .auto-style1 {
            margin-left: 170px;
        }
    </style>

</head>
<body class="acceso">
    <form id="form1" runat="server">
        <div>
        <h1>Iniciar Sesion</h1>		
		&nbsp;<asp:TextBox ID="txt1" runat="server"></asp:TextBox>
            <asp:TextBox type="password" ID="txt2" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="Button1" runat="server" BackColor="#2B2B2A" CssClass="auto-style1" OnClick="Button1_Click1" Text="Ingresar" Width="182px" Height="46px" />
    </form>
</body>
</html>
