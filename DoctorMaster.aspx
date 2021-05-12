<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DoctorMaster.aspx.cs" Inherits="TestProject.DoctorMaster" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Doctor Room</title>
    <style>
        .Background{
            background-image: url("/doctorimage2.jpg");
            background-repeat: no-repeat;
            background-size: cover;
        }

        #doctorview{
            z-index: 1; 
            left: 253px; 
            top: 250px; 
            position: absolute; 
            height: 133px; 
            width: 187px;
            background-color:silver;
            border-color:Black;
            border-style: Solid;
            border-width: 5px;
            
        }
    </style>
</head>
<body class="Background">
    <form id="form1" runat="server">
        <div>
        </div>
        
        <asp:GridView ID="doctorview" runat="server" >
            <EditRowStyle BorderStyle="Solid" />
        </asp:GridView>
        
        <asp:Button ID="BtnList" runat="server" OnClick="BtnList_Click1" style="z-index: 1; left: 349px; top: 183px; position: absolute" Text="LIST" Font-Bold="True" />
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 327px; top: 119px; position: absolute" Text="LIST DOCTOR"></asp:Label>
        <asp:Label ID="lbloutput" runat="server" style="z-index: 1; left: 640px; top: 79px; position: absolute"></asp:Label>
        
        <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="Large" OnClick="Button1_Click" style="z-index: 1; left: 658px; top: 177px; position: absolute" Text="Add New Doctor" />
        
    </form>
    <a href="C:\Users\GAVSLTPBCP\source\repos\TestProject\TestProject\DoctorMaster.aspx" >Back to List</a>
</body>
</html>
