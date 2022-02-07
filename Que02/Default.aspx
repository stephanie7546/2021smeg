<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Que02.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>日期選擇如下：</h2>
        <div>
            <asp:Calendar ID="calendar1" runat="server" OnSelectionChanged="calendar1_SelectionChanged">
                <SelectedDayStyle BackColor="Gray" />
                <NextPrevStyle BackColor="Blue" />
                <TodayDayStyle BackColor="Orange" />
                <DayHeaderStyle BackColor="LightYellow" />
            </asp:Calendar>
        </div>
        <div>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
