<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PatientDoctor.aspx.cs" Inherits="TestProject.PatientDoctor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 110px; top: 132px; position: absolute" Text="Doctor ID"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 110px; top: 179px; position: absolute" Text="Person ID"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 113px; top: 230px; position: absolute" Text="Patient Type"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 114px; top: 282px; position: absolute" Text="RefferedBy"></asp:Label>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 115px; top: 330px; position: absolute" Text="Health Problem"></asp:Label>
        <asp:TextBox ID="TextBoxid" runat="server" style="z-index: 1; left: 212px; top: 131px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBoxpid" runat="server" style="z-index: 1; left: 214px; top: 177px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBoxPtype" runat="server" style="z-index: 1; left: 216px; top: 230px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBoxRef" runat="server" style="z-index: 1; left: 217px; top: 282px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBoxHealth" runat="server" style="z-index: 1; left: 222px; top: 331px; position: absolute"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 176px; top: 402px; position: absolute" Text="Add" />
        <asp:Label ID="output" runat="server" style="z-index: 1; left: 592px; top: 83px; position: absolute"></asp:Label>
        <asp:Button ID="BtnVList" runat="server" OnClick="BtnVList_Click" style="z-index: 1; left: 608px; top: 128px; position: absolute; width: 76px" Text="View List" />
    </form>
</body>
</html>
