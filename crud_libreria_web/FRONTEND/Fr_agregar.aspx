<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Fr_agregar.aspx.cs" Inherits="crud_libreria_web.FRONTEND.Fr_agregar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="ISBN:               "></asp:Label>
            <asp:TextBox ID="txtISBN" runat="server"></asp:TextBox>

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
            <asp:TextBox ID="txtAÑO" runat="server"></asp:TextBox>

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
        </div>

        
        
        <asp:Button ID="btn_regrear" runat="server" OnClick="btn_regrear_Click" Text="REGRESAR" />
        <asp:Button ID="btn_Agregar_FrAgregar" runat="server" OnClick="btn_agregar_Click" Text="Agregar" />
    </form>
</body>
</html>

