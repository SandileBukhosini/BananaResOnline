<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="BananaResOnline.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 1000px;
            height: 656px;
            text-align: center;
        }
        .auto-style6 {
            font-size: xx-large;
            color: #660066;
        }
        .auto-style8 {
            z-index: 1;
            left: 298px;
            top: 219px;
            position: absolute;
            height: 296px;
            width: 401px;
        }
        .auto-style10 {
            color: #FFFFFF;
        }
        .auto-style9 {
            z-index: 1;
            left: 5px;
            top: 10px;
            position: absolute;
            height: 126px;
            width: 359px;
        }
        .auto-style11 {
            width: 1014px;
            height: 672px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style11">
    
        <div class="auto-style1" style="border: thick inset #660066; background-image: url('Images/Best.jpg'); background-attachment: scroll; z-index: 1; left: 10px; top: 15px; position: absolute;">
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style6" style="text-decoration: underline overline">ONLINE RESIDENCE APPLICATION</span>&nbsp; </strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br style="background-image: url('Images/Best.jpg'); border: thick solid #660066" />
    <asp:Image ID="Image3" runat="server" CssClass="auto-style9" ImageUrl="~/Images/636530903951329773_largelogo.png" />
                <br />
            <asp:Button ID="btnAdmin" runat="server" BackColor="#660066" OnClick="btnAdmin_Click" style="z-index: 1; left: 826px; top: 136px; position: absolute; height: 40px; width: 103px; color: #FFFFFF" Text="Admin Use" />
            <br />
            <br />
            <br />
            <br />
            &nbsp;&nbsp;
            <br />
            <br />
            <asp:Panel ID="Panel2" runat="server" BackImageUrl="~/Images/semi-transbgtransparent.png" BorderColor="#660066" BorderStyle="Solid" CssClass="auto-style8" Height="288px" Width="393px">
                <asp:Image ID="Image4" runat="server" ImageUrl="~/Images/636530903951329773_largelogo.png" style="z-index: 1; left: 11px; top: 6px; position: absolute; height: 98px; width: 265px" />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                &nbsp; <span class="auto-style10">STUDENT NUMBER:&nbsp;&nbsp; </span>
                <asp:TextBox ID="txtStNumber" runat="server" Width="147px"></asp:TextBox>
                <br class="auto-style10" />
                <br class="auto-style10" />
                <span class="auto-style10">&nbsp;&nbsp; PASSWORD:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span><asp:TextBox ID="txtPassword" runat="server" Width="144px" TextMode="Password"></asp:TextBox>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<strong><asp:Button ID="btnLogIn" runat="server" BackColor="#660066" BorderStyle="Solid" CssClass="auto-style11" ForeColor="White" Height="34px" OnClick="btnLogIn_Click" Text="Log In" Width="92px" />
                &nbsp;<br /> <em>
                <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="#0000CC">Forgot Password?</asp:HyperLink>
                </em>
                <br />
                </strong>
            </asp:Panel>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    
    </div>
    </form>
</body>
</html>
