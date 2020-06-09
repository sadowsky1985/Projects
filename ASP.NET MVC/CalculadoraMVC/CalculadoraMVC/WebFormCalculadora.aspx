<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormCalculadora.aspx.cs" Inherits="CalculadoraMVC.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label2" runat="server" Text="CALCULADORA"></asp:Label>
            <br />
            <br />
            Valor 1:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Valor 2:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </div>
        <asp:RadioButton ID="RadioButton1" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Suma" Checked="True" GroupName="Operando" />
        <p>
            <asp:RadioButton ID="RadioButton2" runat="server" Text="Resta" GroupName="Operando" />
        </p>
        <p>
            <asp:RadioButton ID="RadioButton3" runat="server" Text="Multiplicación" GroupName="Operando" />
        </p>
        <p>
            <asp:RadioButton ID="RadioButton4" runat="server" Text="División" GroupName="Operando" />
        </p>
        <asp:Button ID="Button1" runat="server" Text="Resultado" OnClick="Button1_Click" />
        <p>
            <asp:Label ID="Resultado" runat="server" Text="0"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
