<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddPatient.aspx.cs" Inherits="HospitalTask.AddPatient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 69px; top: 115px; position: absolute; width: 84px" Text="PersonName"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 70px; top: 176px; position: absolute" Text="DateOfBirth"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 67px; top: 243px; position: absolute" Text="ContactPerson"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 48px; top: 335px; position: absolute" Text="Phone Number"></asp:Label>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 61px; top: 398px; position: absolute" Text="Address"></asp:Label>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 67px; top: 456px; position: absolute" Text="Gender"></asp:Label>
        <asp:TextBox ID="pName_text" runat="server" style="z-index: 1; left: 225px; top: 114px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="dob_text" runat="server" OnTextChanged="dob_text_TextChanged" style="z-index: 1; left: 218px; top: 172px; position: absolute;"></asp:TextBox>
        <asp:TextBox ID="Contact_text" runat="server" OnTextChanged="Contact_text_TextChanged" style="z-index: 1; left: 222px; top: 246px; position: absolute;"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="Ph_text" ErrorMessage="-" MaximumValue="9999999999" MinimumValue="1000000000" style="z-index: 1; left: 401px; top: 303px; position: absolute; right: 862px"></asp:RangeValidator>
        <asp:TextBox ID="Address_text" runat="server" style="z-index: 1; left: 219px; top: 407px; position: absolute"></asp:TextBox>
        <asp:DropDownList ID="genderdrop" runat="server" style="z-index: 1; left: 230px; top: 460px; position: absolute">
        </asp:DropDownList>
        <asp:TextBox ID="Ph_text" runat="server" OnTextChanged="Ph_text_TextChanged" style="z-index: 1; left: 221px; top: 339px; position: absolute;"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 173px; top: 517px; position: absolute; height: 26px" Text="Add Patient" />
        <asp:Label ID="lbloutput" runat="server" style="z-index: 1; left: 773px; top: 266px; position: absolute" Text="-"></asp:Label>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 71px; top: 65px; position: absolute" Text="Identity Number"></asp:Label>
        <asp:TextBox ID="id_text" runat="server" style="z-index: 1; top: 63px; position: absolute; right: 953px;"></asp:TextBox>
        <asp:Label ID="lbloutputp" runat="server" style="z-index: 1; left: 589px; top: 57px; position: absolute" Text="lbloutputp"></asp:Label>
        <asp:Button ID="btn_update" runat="server" OnClick="btn_update_Click" style="z-index: 1; left: 365px; top: 509px; position: absolute; right: 884px" Text="Update" />
        <asp:Button ID="Btn_save" runat="server" OnClick="Btn_save_Click" style="z-index: 1; left: 671px; top: 510px; position: absolute" Text="Save" />
        <asp:Button ID="btn_remove" runat="server" OnClick="btn_remove_Click" style="z-index: 1; left: 518px; top: 511px; position: absolute" Text="Remove" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 452px; top: 59px; position: absolute" Text="Search" />
        <asp:GridView ID="GridView1" runat="server" style="z-index: 1; left: 1093px; top: 136px; position: absolute; height: 133px; width: 187px">
        </asp:GridView>
    </form>
</body>
</html>
