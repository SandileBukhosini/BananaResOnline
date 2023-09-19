<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApplicationConfirmation.aspx.cs" Inherits="BananaResOnline.ApplicationConfirmation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
            color: #660066;
        }
        .auto-style2 {
            color: #660066;
            font-size: x-large;
            text-decoration: underline;
        }
        .auto-style3 {
            position: absolute;
            top: 237px;
            left: 176px;
            z-index: 1;
            width: 635px;
            height: 308px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-image: url('Images/118952orig.jpg'); border: thick solid #660066; height: 590px; width: 1024px;">
    
        <asp:Image ID="Image3" runat="server" Height="113px" ImageUrl="~/Images/636530903951329773_largelogo.png" Width="347px" />
&nbsp;<span class="auto-style1"><strong style="text-decoration: underline overline"> ONLINE RESIDENCE APPLICATION</strong></span><br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style2"><strong>Application Confirmation</strong></span><br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:ListBox ID="ListBox1" runat="server" CssClass="auto-style3"></asp:ListBox>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" BackColor="#660066" Height="36px" OnClick="Button1_Click" style="z-index: 1; left: 398px; top: 565px; position: absolute; width: 117px; color: #FFFFFF" Text="Ok" />
    
    </div>
    </form>
</body>
</html>
