<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeScreen.aspx.cs" Inherits="BananaResOnline.HomeScreen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1054px;
            height: 708px;
        }
        .auto-style2 {
            font-size: xx-large;
        }
        .auto-style3 {
            color: #660066;
        }
        .auto-style4 {
            font-size: large;
            font-family: "Vodafone Rg";
        }
        .auto-style7 {
            font-size: large;
            font-family: "Vodafone Rg";
            color: #FFFFFF;
        }
        .auto-style6 {
            color: #660066;
        }
        .auto-style8 {
            text-decoration: underline;
            color: #660066;
            position: absolute;
            top: 259px;
            left: 40px;
            z-index: 1;
        }
        .auto-style9 {
            z-index: 1;
            left: 405px;
            top: 273px;
            position: absolute;
        }
        .auto-style10 {
            z-index: 1;
            left: 39px;
            top: 204px;
            position: absolute;
            height: 43px;
            width: 139px;
            right: 929px;
        }
        .auto-style11 {
            z-index: 1;
            left: 206px;
            top: 204px;
            position: absolute;
            height: 43px;
            width: 138px;
        }
        .auto-style13 {
            width: 348px;
            height: 27px;
            position: absolute;
            top: 283px;
            left: 36px;
            z-index: 1;
        }
        .auto-style14 {
            z-index: 1;
            left: 104px;
            top: 317px;
            position: absolute;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <div class="auto-style1" style="background-image: url('Images/118952orig.jpg'); border: thick solid #660066">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image1" runat="server" BorderColor="Black" CssClass="auto-style16" Height="106px" ImageUrl="~/Images/636530903951329773_largelogo.png" style="z-index: 1; left: 21px; top: 31px; position: absolute;" Width="300px" />
            <span class="auto-style2"><span class="auto-style3"><strong style="text-decoration: underline overline">ONLINE RESIDENCE APPLICATION</strong></span></span><strong><br class="auto-style7" />
            </strong><span class="auto-style4"><strong><span class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span></strong></span><br />
            <br />
            &nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnApply" runat="server" BackColor="#660066" BorderColor="#660066" ForeColor="White" OnClick="btnApply_Click" Text="Apply for Residence" CssClass="auto-style10" />
            <asp:Button ID="Button2" runat="server" BackColor="#660066" BorderColor="#660066" ForeColor="White" style="z-index: 1; top: 206px; position: absolute; width: 88px; height: 29px; left: 947px" Text="About Us" />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnInstructions" runat="server" BackColor="#660066" BorderColor="#660066" ForeColor="White" OnClick="btnInstructions_Click" style="z-index: 1; left: 912px; top: 147px; position: absolute; height: 43px; width: 138px" Text="Instructions" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<strong><asp:Label ID="lblStudent" runat="server" CssClass="auto-style8" Text="SELECT THE TYPE OF STUDENT YOU ARE:" Visible="False"></asp:Label>
            </strong>&nbsp;<asp:RadioButtonList ID="radTypeStudent" runat="server" RepeatDirection="Horizontal" style="color: #660066" Visible="False" Width="348px" CssClass="auto-style13">
                <asp:ListItem>Senior Student</asp:ListItem>
                <asp:ListItem>FirstYear/FirstTimeApplicant</asp:ListItem>
            </asp:RadioButtonList>
            <asp:Button ID="btnContinue" runat="server" BackColor="#660066" BorderColor="#660066" ForeColor="White" OnClick="btnContinue_Click" Text="Continue" Visible="False" BorderStyle="Outset" CssClass="auto-style9" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style6">&nbsp;<asp:Button ID="btnSignOut" runat="server" BackColor="#660066" BorderColor="Black" BorderStyle="Solid" ForeColor="White" OnClick="btnSignOut_Click" style="z-index: 1; left: 944px; top: 245px; position: absolute" Text="Sign Out" />
            </span>&nbsp;&nbsp;
            <br />
            <asp:Image ID="Image2" runat="server" Height="381px" ImageUrl="~/Images/NWU-res.gif" Width="837px" BorderColor="#660066" BorderStyle="Outset" BorderWidth="10px" CssClass="auto-style14" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" BackColor="#660066" BorderColor="#660066" ForeColor="White" OnClick="Button1_Click" Text="Check Status" CssClass="auto-style11" />
            <br />
            <br />
            <br />
            <br />
        </div>
    
    </div>
    </form>
</body>
</html>
