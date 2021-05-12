<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="TestProject.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <style>
        .color{
            background-color:bisque;
        }
        #form1 {
            height: 591px;
        }
    </style>
</head>
<body>
    <div class="color">
        <form id="form1" runat="server">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" style="z-index: 1; left: 353px; top: 119px; position: absolute" Text="ADMIN LOGIN"></asp:Label>
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 238px; top: 186px; position: absolute" Text="UserName"></asp:Label>
            <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 240px; top: 230px; position: absolute" Text="Password"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 328px; top: 185px; position: absolute; height: 21px; width: 127px"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 326px; top: 231px; position: absolute; height: 19px; width: 129px"></asp:TextBox>
            <asp:Button ID="BTNAdminLogin" runat="server" Font-Bold="True" OnClick="BTNAdminLogin_Click" style="z-index: 1; left: 351px; top: 321px; position: absolute" Text="LOGIN" />
            <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 297px; top: 45px; position: absolute" Text="GAVS HealthCare"></asp:Label>
    </form>
    </div>
    
        <div style="height: 328px" >
        </div>
        
</body>
</html>
