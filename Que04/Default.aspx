<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Que04.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            旅遊景點：
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
        </div>
        <div>
            新增旅遊景點：
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="insert1" runat="server" Text="新增" OnClick="insert1_Click"/>
            <asp:Button ID="delete1" runat="server" Text="移除" OnClick="delete1_Click"/>
        </div>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </form>

</body>
</html>
