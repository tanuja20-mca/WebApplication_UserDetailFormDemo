<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm_UserDetails.aspx.cs" Inherits="WebApplication_UserDetailForm.WebForm_UserDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 40px">
            <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblLocation" runat="server" Text="Location"></asp:Label>
            <asp:ListBox ID="lstLocation" runat="server" AutoPostBack="True" OnSelectedIndexChanged="lstLocation_SelectedIndexChanged">
                <asp:ListItem>Nainital</asp:ListItem>
                <asp:ListItem>Haldwani</asp:ListItem>
                <asp:ListItem>Almora</asp:ListItem>
                <asp:ListItem>Delhi</asp:ListItem>
            </asp:ListBox>
            <br />
            <br />
            <asp:Label ID="lblGender" runat="server" Text="Gender"></asp:Label>
            <asp:RadioButton ID="rdbtnFemale" runat="server" Text="Female" GroupName="gender" />
            <asp:RadioButton ID="rdbtnMale" runat="server" Text="Male" GroupName="gender" />
            <asp:RadioButton ID="rdbtnOther" runat="server" Text="Other" GroupName="gender"/>
            <br />
            <br />
            <asp:Label ID="lblCourse" runat="server" Text="Course"></asp:Label>
            <asp:CheckBox ID="chkJava" runat="server" Text="Java" />
            <asp:CheckBox ID="chkCs" runat="server" Text="C#" />
            <asp:CheckBox ID="chkReact" runat="server" Text="React" />
            <asp:CheckBox ID="chkPython" runat="server" Text="Python" />
            <br />
        </div>
        <div style="margin-left: 80px">
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
        </div>
    </form>
</body>
</html>
