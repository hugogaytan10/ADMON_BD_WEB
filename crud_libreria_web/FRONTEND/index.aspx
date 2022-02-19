<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="crud_libreria_web.FRONTEND.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="estilos.css" type="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div class="div_botones">
            <asp:Button class= "botones" ID="btn_eliminar" runat="server" OnClick="Button1_Click" Text="ELIMINAR" />
            <asp:Button class= "botones" ID="btn_agegar" runat="server" OnClick="btn_agegar_Click" Text="AGREGAR" />
            <asp:Button class= "botones" ID="btn_modificar" runat="server" OnClick="btn_modificar_Click" Text="MODIFICAR" />
            <asp:Button class= "botones" ID="btn_mostar" runat="server" OnClick="btn_mostar_Click" Text="MOSTRAR" />
        </div>
        <div>
            <asp:GridView class="grid_estilos" ID="gvMain" runat="server"  >
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:CheckBox ID="checkLista" runat ="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
             </asp:GridView>
            
        </div>
    </form>
</body>
</html>
