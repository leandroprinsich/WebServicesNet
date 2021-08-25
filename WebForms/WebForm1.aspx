<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebForms.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Primera página ASP.NET WebForms</title>
    <%--    <link href="estilos/estilos.css" rel="stylesheet" />--%>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="myDiv">
            <h1 id="myH1">Hola mundo (ASP.NET)</h1>
            <asp:Button ID="Btn_Mostrar" CssClass="btn-success" ForeColor="yellow" runat="server" Text="Defensa y justicia" />
            <br />
            <br />
        </div>
        <div>
            <select>
                <option>ASP.Net</option>
                <option>C#.Net</option>
                <option>Js</option>
                <option>CSS</option>
            </select>
            <input type="text" id="Text1" value=""/>
            <br />
            <br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>ASP.Net</asp:ListItem>
                <asp:ListItem>C#.Net</asp:ListItem>
                <asp:ListItem>Js</asp:ListItem>
                <asp:ListItem>CSS</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
        </div>
        <asp:Button ID="Button1" CssClass="btn-success" runat="server" Text="Mostrar Selección" OnClick="Button1_Click" />
    </form>
</body>
</html>
<%--<script>document.getElementById("myDiv").style.display = "none";</script>--%>
