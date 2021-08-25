<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1Switch.aspx.cs" Inherits="WebForms.Ejercicio1Switch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Calculadora</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" CssClass="text-primary" Text="Calculadora"></asp:Label>
            <br />
            <br />
            Ingrese un número:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="n1" runat="server"></asp:TextBox>
            <br />
            <br />
            Ingrese otro número:&nbsp;&nbsp;
            <asp:TextBox ID="n2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Value="0">Seleccione una operación</asp:ListItem>
                <asp:ListItem Value="1">SUMA</asp:ListItem>
                <asp:ListItem Value="2">RESTA</asp:ListItem>
                <asp:ListItem Value="3">MULTIPLICACIÓN</asp:ListItem>
                <asp:ListItem Value="4">DIVISIÓN</asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="lbl_resultado" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" CssClass="btn btn-success" runat="server" Text="Calcular" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
