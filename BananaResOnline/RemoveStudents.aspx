<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RemoveStudents.aspx.cs" Inherits="BananaResOnline.RemoveStudents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #660066;
        }
        #TextArea1 {
            z-index: 1;
            left: 61px;
            top: 448px;
            position: absolute;
            height: 135px;
            width: 389px;
        }
        #AreaDelete {
            z-index: 1;
            left: 59px;
            top: 441px;
            position: absolute;
            height: 130px;
            width: 409px;
        }
    </style>
</head>
<body style="height: 684px; width: 1199px">
    <form id="form1" runat="server">
    <div style="background-image: url('Images/118952orig.jpg'); border: thick solid #000000; height: 671px;">
    
        <asp:Image ID="Image1" runat="server" Height="121px" ImageUrl="~/Images/636530903951329773_largelogo.png" Width="333px" />
        <br />
        <br />
        <br />
        <br />
&nbsp; <span class="auto-style1"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Enter the student number of the student you would like to remove:<br />
        <br />
        <asp:TextBox ID="txtStudent" runat="server" OnTextChanged="txtStudent_TextChanged" style="z-index: 1; left: 67px; top: 233px; position: absolute; width: 150px"></asp:TextBox>
        <asp:Button ID="btnRemove" runat="server" BackColor="#660066" ForeColor="White" style="z-index: 1; left: 371px; top: 233px; position: absolute; width: 94px" Text="Remove" OnClick="btnRemove_Click" />
        <asp:Button ID="btnSearch" runat="server" BackColor="#660066" ForeColor="White" OnClick="btnSearch_Click" style="z-index: 1; left: 242px; top: 232px; position: absolute; width: 76px" Text="Search" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" style="z-index: 1; left: 58px; top: 282px; position: absolute; height: 114px; width: 1080px">
        </asp:GridView>
        <br />
        <asp:Label ID="lblDelete" runat="server" style="z-index: 1; left: 67px; top: 472px; position: absolute" Text="Label" Visible="False"></asp:Label>
        <asp:Button ID="txtReturn" runat="server" BackColor="#660066" ForeColor="White" OnClick="txtReturn_Click" style="z-index: 1; left: 79px; top: 535px; position: absolute; height: 43px" Text="Return to placement" />
        </strong></span>
    
    </div>
    </form>
</body>
</html>
