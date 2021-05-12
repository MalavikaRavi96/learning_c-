<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddDoctor.aspx.cs" Inherits="TestProject.AddDoctor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DoctorPage</title>
    <style>
        .Backgroundimg{
            background-image: url("/doctorimage.jpg");
            background-repeat: no-repeat;
            background-size: cover;
        }
    </style>
</head>
<body class="Backgroundimg">
    <form id="form1" runat="server">
        <div >
        </div>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 310px; top: 51px; position: absolute; height: 34px; width: 168px" Text="Doctor Details"></asp:Label>
        <asp:Label ID="Label2" runat="server" Font-Bold="True" style="z-index: 1; left: 99px; top: 104px; position: absolute" Text="Doctor ID"></asp:Label>
        <asp:Label ID="Label3" runat="server" Font-Bold="True" style="z-index: 1; left: 97px; top: 158px; position: absolute" Text="Doctor Name"></asp:Label>
        <asp:Label ID="Label4" runat="server" Font-Bold="True" style="z-index: 1; left: 100px; top: 212px; position: absolute" Text="DOB"></asp:Label>
        <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 101px; top: 264px; position: absolute" Text="Service Started "></asp:Label>
        <asp:TextBox ID="TextBoxID" runat="server" style="z-index: 1; left: 252px; top: 101px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" Font-Bold="True" style="z-index: 1; left: 99px; top: 313px; position: absolute; bottom: 206px" Text="Specialization"></asp:Label>
        <asp:Label ID="Label7" runat="server" Font-Bold="True" style="z-index: 1; left: 102px; top: 370px; position: absolute" Text="Contact No"></asp:Label>
        <asp:Label ID="Label8" runat="server" Font-Bold="True" style="z-index: 1; left: 101px; top: 422px; position: absolute; bottom: 97px" Text="Department"></asp:Label>
        <asp:Label ID="Label9" runat="server" Font-Bold="True" style="z-index: 1; left: 99px; top: 466px; position: absolute" Text="Gender"></asp:Label>
        <asp:TextBox ID="TextBoxDName" runat="server" style="z-index: 1; left: 252px; top: 160px; position: absolute; height: 16px"></asp:TextBox>
        <asp:TextBox ID="TextBoxDDOB" runat="server" style="z-index: 1; left: 249px; top: 211px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBoxSS" runat="server" style="z-index: 1; left: 250px; top: 265px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBoxContNo" runat="server" style="z-index: 1; left: 243px; top: 372px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBoxDept" runat="server" style="z-index: 1; left: 242px; top: 421px; position: absolute"></asp:TextBox>
        <asp:Button ID="BtnAddDDetails" runat="server" Font-Bold="True" style="z-index: 1; left: 433px; top: 449px; position: absolute" Text="Add" OnClick="BtnAddDDetails_Click" />
        <asp:DropDownList ID="DropDownSpecial" runat="server" style="z-index: 1; left: 254px; top: 317px; position: absolute">
        </asp:DropDownList>
        <asp:Label ID="lbloutputs" runat="server" style="z-index: 1; left: 695px; top: 44px; position: absolute"></asp:Label>
        <asp:DropDownList ID="DropDownDGender" runat="server" style="z-index: 1; left: 244px; top: 469px; position: absolute">
        </asp:DropDownList>
        <asp:Button ID="BtnCheck" runat="server" OnClick="BtnCheck_Click" style="z-index: 1; left: 412px; top: 97px; position: absolute" Text="Check" />
        <asp:Button ID="BtnUpd" runat="server" Font-Bold="True" OnClick="BtnUpd_Click" style="z-index: 1; left: 501px; top: 449px; position: absolute" Text="Update" />
        <asp:Button ID="BtnSave" runat="server" Font-Bold="True" OnClick="BtnSave_Click" style="z-index: 1; left: 597px; top: 449px; position: absolute" Text="Save" />
        <asp:Button ID="BtnDel" runat="server" Font-Bold="True" OnClick="BtnDel_Click" style="z-index: 1; left: 667px; top: 449px; position: absolute" Text="Delete" />
        <asp:Button ID="BtnClear" runat="server" Font-Bold="True" OnClick="BtnClear_Click" style="z-index: 1; left: 541px; top: 497px; position: absolute" Text="Clear" />
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/DoctorMaster.aspx" style="z-index: 1; left: 59px; top: 524px; position: absolute">Back To List</asp:HyperLink>
        <asp:Label ID="Label10" runat="server" Font-Bold="True" ForeColor="#CC0000" style="z-index: 1; left: 403px; top: 419px; position: absolute" Text="(IP, OP, EMG)"></asp:Label>
    </form>
    
</html>
