<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Que01.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>S3504100005-1</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>六都選擇如下：</h2>
        <div>
            <asp:ListBox ID="ListBox1" runat="server">
                <asp:ListItem>台北市</asp:ListItem>
                <asp:ListItem>新北市</asp:ListItem>
                <asp:ListItem>桃園市</asp:ListItem>
                <asp:ListItem>台中市</asp:ListItem>
                <asp:ListItem>台南市</asp:ListItem>
                <asp:ListItem>高雄市</asp:ListItem>
            </asp:ListBox>
            <asp:Button ID="Button1" runat="server" Text="確定" OnClick="Button1_Click"/>
        </div>
        <div>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
