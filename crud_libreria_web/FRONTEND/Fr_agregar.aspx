<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Fr_agregar.aspx.cs" Inherits="crud_libreria_web.FRONTEND.Fr_agregar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel ="stylesheet"  href ="estilos.css" type ="text/css"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label class= "etiquetas" ID="Label1" runat="server" Text="ISBN:               "></asp:Label>
            <asp:TextBox class ="textBoxes" ID="txtISBN" runat="server"></asp:TextBox>

        </div>
        <div>
            <asp:Label class= "etiquetas" ID="Label2" runat="server" Text="TITULO:             "></asp:Label>
            <asp:TextBox class ="textBoxes" ID="txtTITULO" runat="server"></asp:TextBox>

        </div>
        <div>
            <asp:Label class= "etiquetas" ID="Label3" runat="server" Text="EDICION:            "></asp:Label>
            <asp:TextBox class ="textBoxes" ID="txtEDICION" runat="server"></asp:TextBox>

        </div>
        <div>
            <asp:Label  class= "etiquetas" ID="Label4" runat="server" Text="AÑO DE PUBLICACION: "></asp:Label>
            <asp:TextBox class ="textBoxes" ID="txtAÑO" runat="server"></asp:TextBox>

        </div>
        <div>
            <asp:Label class= "etiquetas"  ID="Label5" runat="server" Text="AUTOR(ES):          "></asp:Label>
            <asp:TextBox class ="textBoxes" ID="txtAUTOR" runat="server"></asp:TextBox>
        </div>
        <div>
           <asp:Label class= "etiquetas" ID="Label6" runat="server" Text="PAIS:                "></asp:Label>
            <asp:TextBox class ="textBoxes" ID="txtPAIS" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label class= "etiquetas" ID="Label7" runat="server" Text="SINOPSIS:           "></asp:Label>
            <asp:TextBox class ="textBoxes" ID="txtSINOPSIS" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label class= "etiquetas" ID="Label8" runat="server" Text="CARRERA:            "></asp:Label>
            <asp:TextBox class ="textBoxes" ID="txtCARRERA" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label class= "etiquetas" ID="Label9" runat="server" Text="MATERIA:            "></asp:Label>
            <asp:TextBox class ="textBoxes" ID="txtMATERIA" runat="server"></asp:TextBox>
        </div>

        
        
        <asp:Button class= "botones" ID="btn_regrear" runat="server" OnClick="btn_regrear_Click" Text="REGRESAR" />
        <asp:Button class= "botones" ID="btn_Agregar_FrAgregar" runat="server" OnClick="btn_agregar_Click" Text="AGREGAR" />
    </form>
</body>
</html>

