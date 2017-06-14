<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TicTacToe.aspx.cs" Inherits="TicTacToe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Enabled="False" Font-Names="helvetica" Font-Size="XX-Large" Text="Tic-Tac-Toe Game"></asp:Label>
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
        <asp:Button ID="Button1" runat="server" Height="65px" Width="65px" OnClick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Height="65px" Width="65px" OnClick="Button2_Click1" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Height="65px" Width="65px" OnClick="Button3_Click1" />
    
    </div>
        <p style="margin-left: 440px">
        <asp:Button ID="Button4" runat="server" Height="65px" Width="65px" OnClick="Button4_Click1" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button5" runat="server" Height="65px" Width="65px" OnClick="Button5_Click1" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button6" runat="server" Height="65px" Width="65px" OnClick="Button6_Click1" />
        &nbsp;&nbsp;&nbsp;
        </p>
        <p style="margin-left: 440px">
            <asp:Button ID="Button7" runat="server" Height="65px" Width="65px" OnClick="Button7_Click1" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button8" runat="server" Height="65px" Width="65px" OnClick="Button8_Click1" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button9" runat="server" Height="65px" Width="65px" OnClick="Button9_Click1" />
        </p>
        <p style="margin-left: 440px">
            &nbsp;
            <asp:Label ID="Result" runat="server" Font-Names="helvetica"></asp:Label>
        </p>
        <p style="margin-left: 440px">
            &nbsp;
            <asp:Label ID="gw" runat="server" Font-Names="helvetica" Text="Games won : "></asp:Label>
            <asp:Label ID="gwon" runat="server" Font-Names="helvetica"></asp:Label>
        </p>
        <p style="margin-left: 440px">
            <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="Play game" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button11" runat="server" Text="Reset" Width="93px" OnClick="Button11_Click" />
            &nbsp;</p>

    </form>
</body>
</html>
