<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PatientPage.aspx.cs" Inherits="HospitalTask.PatientPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btn_addpatient" runat="server" OnClick="btn_addpatient_Click" style="z-index: 1; left: 254px; top: 131px; position: absolute;" Text="Add New Patient" />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; top: 134px; position: absolute; height: 26px; left: 541px" Text="GetPatientList" />
        <asp:GridView ID="GridView1" runat="server" style="z-index: 1; left: 410px; top: 237px; position: absolute; height: 133px; width: 187px">
        </asp:GridView>
        <asp:Label ID="lbloutputp" runat="server" style="z-index: 1; left: 696px; top: 390px; position: absolute" Text="-"></asp:Label>
    </form>
</body>
</html>
