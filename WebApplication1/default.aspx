<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication1._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-weight: 700">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Re-Issue Token" />
&nbsp;<br />
            <br />
            token: <asp:TextBox ID="TextBox1" runat="server" Rows="5" TextMode="MultiLine" Width="300px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Send Sticker With New Token" />
        </div>
    </form>
</body>
</html>
