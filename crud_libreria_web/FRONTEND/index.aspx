<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="crud_libreria_web.FRONTEND.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvMain" runat="server" OnSelectedIndexChanged="gvMain_SelectedIndexChanged">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:CheckBox ID="checkLista" runat ="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
             </asp:GridView>
            <asp:Button ID="btn_mostar" runat="server" OnClick="btn_mostar_Click" Text="MOSTRAR" />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ELIMINAR" />
        </div>
    </form>
</body>
</html>
