<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Fr_modificar.aspx.cs" Inherits="crud_libreria_web.FRONTEND.Fr_modificar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btn_regresar" runat="server" OnClick="btn_regresar_Click" Text="REGRESAR" />
        </div>
        <p>
            Titulo:
            <asp:TextBox ID="txtTitulo" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </p>
    </form>
</body>
</html>
