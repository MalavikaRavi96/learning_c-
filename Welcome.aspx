<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="TestProject.Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome</title>
    <style>
        /* Split the screen in half */
    .split {
      height: 100%;
      width: 50%;
      position: fixed;
      z-index: 1;
      top: 0;
      overflow-x: hidden;
      padding-top: 20px;
    }

    /* Control the left side */
    .left {
      left: 0;
        background-image:url("/imageswelcome.png");
        background-repeat:no-repeat;
            background-size: cover;
    }

    /* Control the right side */
    .right {
      right: 0;
      background-color:aliceblue;
  
    }
      #form1 {
            height: 517px;
        }
    </style>
</head>
<body>
     <div class="split left">
  
</div>
        <div  class="split right">
           
    <form id="form1" runat="server">
        
        
        
        <asp:Button ID="BtnDocDetail" runat="server" style="z-index: 1; left: 147px; top: 148px; position: absolute; height: 23px;" Text="Doctor Details" OnClick="BtnDocDetail_Click" />
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 151px; top: 201px; position: absolute; height: 32px; width: 119px" Text="Patient Details" OnClick="Button1_Click" />
        
        <asp:Button ID="BtnAppoint" runat="server" OnClick="BtnAppoint_Click" style="z-index: 1; left: 141px; top: 336px; position: absolute" Text="Add Appointment" />
        
    
        
    
        
        <asp:Button ID="BtnDocpatient" runat="server" OnClick="BtnDocpatient_Click" style="z-index: 1; left: 152px; top: 273px; position: absolute; height: 25px" Text="Doctor Patient" />
        
    
        
    
        
    </form>
                
       </div>
</body>
</html>
