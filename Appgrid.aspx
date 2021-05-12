<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Appgrid.aspx.cs" Inherits="Adodotnet.Appgrid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView2" runat="server" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" style="z-index: 1; left: 374px; top: 76px; position: absolute; height: 133px; width: 187px">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
