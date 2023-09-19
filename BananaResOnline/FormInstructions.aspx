<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormInstructions.aspx.cs" Inherits="BananaResOnline.FormInstructions" %>

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
            color: #660066;
        }
        .auto-style4 {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <div style="background-image: url('Images/118952orig.jpg'); border: thick solid #660066; height: 590px; width: 1024px;">
    
        <asp:Image ID="Image3" runat="server" Height="113px" ImageUrl="~/Images/636530903951329773_largelogo.png" Width="347px" />
&nbsp;<span class="auto-style1"><strong style="text-decoration: underline overline"> ONLINE RESIDENCE APPLICATION</strong></span><br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style2"><strong>Application Instructions</strong></span><br />
        <br />
        &nbsp;<br />
        <asp:Panel ID="Panel1" runat="server" style="z-index: 1; left: 155px; top: 220px; position: absolute; height: 319px; width: 680px">
            <span class="auto-style3"><span class="auto-style4"><strong>APPLICATION</strong></span></span><br class="auto-style3" /> <span class="auto-style3">On the home page, there is a button, &quot;Apply for residence&quot;, when you want to begin with your application for residences, you click on the button and there will be options where you can select the type of student you are. Based on the type of student you have specified there will be an application form for you to fill.<br />
            <br />
            <br />
            <span class="auto-style4"><strong>SUBMIT</strong></span><br /> After completing the application form with all the required fields, then you can click on the button &quot;Submit&quot; to submit your application, and if all required information is provided, an application confirmation screen will be displayed.<br />
            <br />
            <span class="auto-style4"><strong>CHECK STATUS</strong></span><br /> On the home page there is a button &quot;Check Status&quot;, should you want to know your application status, to see if you have been placed in a particular residence of choice or your application was not successful.</span></asp:Panel>
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
    
    </div>
    </form>
</body>
</html>
