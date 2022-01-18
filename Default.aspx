<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p class="center">Hosey-Stewart Calculator</p>

            <table class="center">
                <tr>
                    <td colspan="5">
                        <asp:Label class="RightAlign" ID="Result" runat="server" Text="0"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Button class="center button " ID="Seven" runat="server" Text="7" BorderStyle="None" OnClick="Seven_Click" />
                    </td>
                    <td class="auto-style3">
                        <asp:Button class="center button" ID="Eight" runat="server" Text="8" BorderStyle="None" OnClick="Eight_Click" />
                    </td>
                    <td>
                        <asp:Button class="center button" ID="Nine" runat="server" Text="9" BorderStyle="None" OnClick="Nine_Click" />
                    </td>
                    <td>
                        <asp:Button class="center button" ID="Add" runat="server" Text="+" BorderStyle="None" OnClick="Add_Click" />
                    </td>
                    <td rowspan="4" class="auto-style5" >
                        <asp:Button class="center button" ID="Equal" runat="server" Text="=" BorderStyle="None" OnClick="Equal_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Button class="center button" ID="Four" runat="server" Text="4" BorderStyle="None" OnClick="Four_Click"  />
                    </td>
                    <td class="auto-style3">
                        <asp:Button class="center button" ID="Five" runat="server" Text="5" BorderStyle="None" OnClick="Five_Click" />
                    </td>
                    <td>
                        <asp:Button  class="center button" ID="Six" runat="server" Text="6" BorderStyle="None" OnClick="Six_Click" />
                    </td>
                    <td>
                        <asp:Button class="center button" ID="Subtract" runat="server" Text="-" BorderStyle="None" OnClick="Subtract_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Button class="center button" ID="One" runat="server" Text="1" BorderStyle="None" OnClick="One_Click"  />
                    </td>
                    <td class="auto-style3">
                        <asp:Button class="center button" ID="Two" runat="server" Text="2" BorderStyle="None" OnClick="Two_Click" />
                    </td>
                    <td>
                        <asp:Button class="center button" ID="Three" runat="server" Text="3" BorderStyle="None" OnClick="Three_Click"  />
                    </td>
                    <td>
                        <asp:Button class="center button" ID="Multiply" runat="server" Text="*" BorderStyle="None" OnClick="Multiply_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button class="center button" ID="Clear" runat="server" Text="Clear" BorderStyle="None" OnClick="Clear_Click"  />
                    </td>
                    <td class="auto-style3">
                        <asp:Button class="center button" ID="Zero" runat="server" Text="0" BorderStyle="None" OnClick="Zero_Click" style="width: 19px" />
                    </td>
                    <td>
                        <asp:Button class="center button" ID="Decimal" runat="server" Text="." BorderStyle="None" OnClick="Decimal_Click"  />
                    </td>
                    <td>
                        <asp:Button class="center button" ID="Division" runat="server" Text="/" BorderStyle="None" OnClick="Division_Click"  />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
