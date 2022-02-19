<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Fr_modificar.aspx.cs" Inherits="crud_libreria_web.FRONTEND.Fr_modificar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="estilos.css" type="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #btn_regresar {
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button class = "botones" ID="btn_regresar" runat="server" OnClick="btn_regresar_Click" Text="REGRESAR" Width="150px" />
            <asp:Button class="botones" ID="btn_modificar" runat="server" Text="MODIFICAR" OnClick="btn_modificar_Click"/>
        </div>
            
        <div class="contenedor">
            <div class ="div_labels">
                <asp:Label class= "etiquetas" ID="Label1" runat="server" Text="ISBN:"></asp:Label>
                <br />
                <br />
                <asp:Label class= "etiquetas" ID="Label2" runat="server" Text="Título:"></asp:Label>
                <br />
                <br />
                <asp:Label class= "etiquetas" ID="Label3" runat="server" Text="Edición:"></asp:Label>
                <br />
                <br />
                <asp:Label class= "etiquetas" ID="Label4" runat="server" Text="Año de publicación:"></asp:Label>
                <br />
                <br />
                <asp:Label class= "etiquetas" ID="Label5" runat="server" Text="Autor(es):"></asp:Label>
                <br />
                <br />
                <asp:Label class= "etiquetas" ID="Label6" runat="server" Text="País:"></asp:Label>
                <br />
                <br />
                <asp:Label class= "etiquetas" ID="Label7" runat="server" Text="Sipnosis:"></asp:Label>
                <br />
                <br />
                <asp:Label class= "etiquetas" ID="Label8" runat="server" Text="Carrera:"></asp:Label>
                <br />
                <br />
                <asp:Label class= "etiquetas" ID="Label9" runat="server" Text="Materia:"></asp:Label>
                <br />
                <br />
            </div>

            <div class="div_textBoxs">
                <div class ="espacio1"></div>
                <div class ="div_textBoxs">
                    <asp:TextBox class ="textBoxes" ID="txtISBN" runat="server"></asp:TextBox>
                </div>
                <div class ="espacio1"></div>
                <div class ="espacio1"></div>
                <asp:TextBox class ="textBoxes" ID="txtIsbnNUEVO" runat="server"></asp:TextBox>
                <br />
                <br />

                <div class ="espacio1"></div>
                <div class ="div_textBoxs">
                    <asp:TextBox class ="textBoxes" ID="txtTITULO" runat="server"></asp:TextBox>
                </div>
                <div class ="espacio1"></div>
                <div class ="espacio1"></div>
                <asp:TextBox class ="textBoxes" ID="txtTitutloNUEVO" runat="server"></asp:TextBox>
                <br />
                <br /> 

                <div class ="espacio1"></div>
                <div class ="div_textBoxs">
                    <asp:TextBox class ="textBoxes" ID="txtEDICION" runat="server"></asp:TextBox>
                </div>
                <div class ="espacio1"></div>
                <div class ="espacio1"></div>
                <asp:TextBox class ="textBoxes" ID="txtEdicionNUEVO" runat="server"></asp:TextBox>
                <br />
                <br /> 

                <div class ="espacio1"></div>
                <div class ="div_textBoxs">
                    <asp:TextBox class ="textBoxes" ID="txtANIO" runat="server"></asp:TextBox>
                </div>
                <div class ="espacio1"></div>
                <div class ="espacio1"></div>
                <asp:TextBox class ="textBoxes" ID="txtAnioNUEVO" runat="server"></asp:TextBox>
                <br />
                <br /> 

                <div class ="espacio1"></div>
                <div class ="div_textBoxs">
                    <asp:TextBox class ="textBoxes" ID="txtAUTOR" runat="server"></asp:TextBox>
                </div>
                <div class ="espacio1"></div>
                <div class ="espacio1"></div>
                <asp:TextBox class ="textBoxes" ID="txtAutoresNUEVO" runat="server"></asp:TextBox>
                <br />
                <br /> 
                
                <div class ="espacio1"></div>
                <div class ="div_textBoxs">
                    <asp:TextBox class ="textBoxes" ID="txtPAIS" runat="server"></asp:TextBox>
                </div>
                <div class ="espacio1"></div>
                <div class ="espacio1"></div>
                <asp:TextBox class ="textBoxes" ID="txtPaisNUEVO" runat="server"></asp:TextBox>
                <br />
                <br /> 
                
                <div class ="espacio1"></div>
                <div class ="div_textBoxs">
                    <asp:TextBox class ="textBoxes" ID="txtSINOPSIS" runat="server"></asp:TextBox>
                </div>
                <div class ="espacio1"></div>
                <div class ="espacio1"></div>
                <asp:TextBox class ="textBoxes" ID="txtSipnosisNUEVO" runat="server"></asp:TextBox>
                <br />
                <br /> 
                
                <div class ="espacio1"></div>
                <div class ="div_textBoxs">
                    <asp:TextBox class ="textBoxes" ID="txtCARRERA" runat="server"></asp:TextBox>
                </div>
                <div class ="espacio1"></div>
                <div class ="espacio1"></div>
                <asp:TextBox class ="textBoxes" ID="txtCarrearNUEVO" runat="server"></asp:TextBox>
                <br />
                <br /> 

                <div class ="espacio1"></div>
                <div class ="div_textBoxs">
                    <asp:TextBox class ="textBoxes" ID="txtMATERIA" runat="server"></asp:TextBox>
                </div>
                <div class ="espacio1"></div>
                <div class ="espacio1"></div>
                <asp:TextBox class ="textBoxes" ID="txtMateriaNUEVO" runat="server"></asp:TextBox>
                <br />
                <br /> 
                
            </div>
        </div>
        
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
