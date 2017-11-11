<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Challenge_Postage_Calculator_Helper_Methods.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <span class="auto-style1">Postal Calculator</span><br />
            <br />
            Width:
            <asp:TextBox ID="widthTextBox" runat="server" OnTextChanged="widthTextBox_TextChanged" AutoPostBack="True"></asp:TextBox>
            <br />
            Heigth:
            <asp:TextBox ID="heightTextBox" runat="server" OnTextChanged="heightTextBox_TextChanged" AutoPostBack="True"></asp:TextBox>
            <br />
            Length:
            <asp:TextBox ID="lengthTextBox" runat="server" OnTextChanged="lengthTextBox_TextChanged" AutoPostBack="True"></asp:TextBox>
            <br />
            <br />
            <asp:RadioButton ID="groundRadioButton" runat="server" GroupName="postal" OnCheckedChanged="groundRadioButton_CheckedChanged" Text="Ground" AutoPostBack="True" />
            <br />
            <asp:RadioButton ID="airRadioButton" runat="server" GroupName="postal" OnCheckedChanged="airRadioButton_CheckedChanged" Text="Air" AutoPostBack="True" />
            <br />
            <asp:RadioButton ID="nextDayRadioButton" runat="server" GroupName="postal" OnCheckedChanged="nextDayRadioButton_CheckedChanged" Text="Next Day" AutoPostBack="True" />
            <br />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
