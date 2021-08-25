<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Prueba_WebService.aspx.cs" Inherits="Consumiendo_WS.Prueba_WebService" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Consumiendo Web Services</title>
    <!-- CSS only -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-KyZXEAg3QhqLMpG8r+8fhAXLRk2vvoC2f3B09zVXn8CA5QIVfZOJ3BCsw2P0p/We" crossorigin="anonymous"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" CssClass="btn-danger" Text="Probar hello world" OnClick="Button1_Click" /> <br />
            <asp:Label ID="Label1" runat="server" Text="" CssClass="form-label"></asp:Label> <br />
            <asp:Button ID="Button2" CssClass="btn-danger" runat="server" Text="probar fecha hora" OnClick="Button2_Click" /> <br />
            <asp:Label ID="Label2" runat="server" CssClass="form-label" Text=""></asp:Label> <br />
        </div>
    </form>
</body>
</html>
