<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AppointmentForm.aspx.cs" Inherits="Adodotnet.AppointmentForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 256px; top: 64px; position: absolute; height: 22px; width: 97px" Text="AppointmentNo"></asp:Label>
        </div>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 260px; top: 106px; position: absolute; width: 86px" Text="DoctorID"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 259px; top: 189px; position: absolute" Text="DateOfAppointment"></asp:Label>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 260px; top: 232px; position: absolute; width: 107px" Text="Consulting Fee"></asp:Label>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 261px; top: 146px; position: absolute; width: 89px" Text="PersonNo"></asp:Label>
        <asp:TextBox ID="txtNo" runat="server" style="z-index: 1; left: 430px; top: 62px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtdocID" runat="server" style="z-index: 1; left: 431px; top: 104px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtpno" runat="server" style="z-index: 1; left: 432px; top: 142px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtdoa" runat="server" style="z-index: 1; left: 431px; top: 189px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtcf" runat="server" style="z-index: 1; left: 429px; top: 236px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnsubmit" runat="server" OnClick="btnsubmit_Click" style="z-index: 1; left: 255px; top: 353px; position: absolute; width: 94px" Text="Submit" />
        <asp:Button ID="btnlist" runat="server" OnClick="btnlist_Click" style="z-index: 1; left: 383px; top: 354px; position: absolute" Text="ListAppointment" />
        <asp:Label ID="lbloutput" runat="server" style="z-index: 1; left: 28px; top: 43px; position: absolute; width: 115px"></asp:Label>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 555px; top: 355px; position: absolute; width: 132px" Text="SaveChanges" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 723px; top: 354px; position: absolute" Text="Update" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="z-index: 1; left: 622px; top: 57px; position: absolute" Text="Search" />
        <asp:Label ID="Label9" runat="server" style="z-index: 1; left: 257px; top: 281px; position: absolute; width: 100px" Text="Specialization"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" style="z-index: 1; left: 432px; top: 281px; position: absolute; height: 23px; width: 129px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
    </form>
</body>
</html>
