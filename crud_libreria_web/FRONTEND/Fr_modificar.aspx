﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Fr_modificar.aspx.cs" Inherits="crud_libreria_web.FRONTEND.Fr_modificar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="estilos.css" type="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="ISBN:               "></asp:Label>
            <asp:TextBox ID="txtISBN" runat="server"></asp:TextBox>

            <asp:TextBox ID="txtIsbnNuevo" runat="server"></asp:TextBox>

        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="TITULO:             "></asp:Label>
            <asp:TextBox ID="txtTITULO" runat="server"></asp:TextBox>

        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="EDICION:            "></asp:Label>
            <asp:TextBox ID="txtEDICION" runat="server"></asp:TextBox>

        </div>
        <div>
            <asp:Label ID="Label4" runat="server" Text="AÑO DE PUBLICACION: "></asp:Label>
            <asp:TextBox ID="txtANIO" runat="server"></asp:TextBox>

        </div>
        <div>
            <asp:Label ID="Label5" runat="server" Text="AUTOR(ES):          "></asp:Label>
            <asp:TextBox ID="txtAUTOR" runat="server"></asp:TextBox>
        </div>
        <div>
           <asp:Label ID="Label6" runat="server" Text="PAIS:                "></asp:Label>
            <asp:TextBox ID="txtPAIS" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label7" runat="server" Text="SINOPSIS:           "></asp:Label>
            <asp:TextBox ID="txtSINOPSIS" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label8" runat="server" Text="CARRERA:            "></asp:Label>
            <asp:TextBox ID="txtCARRERA" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label9" runat="server" Text="MATERIA:            "></asp:Label>
            <asp:TextBox ID="txtMATERIA" runat="server"></asp:TextBox>
            <br />
            <asp:Button class = "botones" ID="btn_regresar" runat="server" OnClick="btn_regresar_Click" Text="REGRESAR" />
            <asp:Button class="botones" ID="btn_modificar" runat="server" Text="MODIFICAR" OnClick="btn_modificar_Click"/>
        </div>

        
        
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
