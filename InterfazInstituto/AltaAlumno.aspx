﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AltaAlumno.aspx.cs" Inherits="InterfazInstituto.AltaAlumno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Alta de alumnos</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Alta de Alumnos</h1>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lbl_Nombre0" runat="server">Seleccione la carrera:</asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Ingrese el nombre del alumno:"></asp:Label>
            <asp:TextBox ID="txt_Nombre" runat="server" Width="295px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="SelectorCurso" runat="server" AutoPostBack="True" >
                <asp:ListItem>Programacion .Net</asp:ListItem>
                <asp:ListItem>Programacion PHP</asp:ListItem>
                <asp:ListItem>Data Science</asp:ListItem>
                <asp:ListItem>Marketing Digital</asp:ListItem>
                <asp:ListItem>Diseño Web</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Ingrese el apellido del alumno:"></asp:Label>
            <asp:TextBox ID="txt_Apellido" runat="server" Width="295px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lbl_Nombre1" runat="server">Seleccione un curso:</asp:Label>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Ingrese el código del alumno:"></asp:Label>
            <asp:TextBox ID="txt_Codigo" runat="server" Width="301px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="Curso1" runat="server" AutoPostBack="True" Text="Javascript Inicial" />
            <br />
            <br />
            <asp:Button ID="btn_Crear" runat="server" Text="Crear Objeto de Tipo Alumno" OnClick="btn_Crear_Click" />
            <br />
            <br />
            <asp:Label ID="lbl_Nombre" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbl_Apellido" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbl_Codigo" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbl_Carrera" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbl_Curso" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>