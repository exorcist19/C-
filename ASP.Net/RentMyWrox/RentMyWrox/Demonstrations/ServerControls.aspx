<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServerControls.aspx.cs" Inherits="RentMyWrox.Demonstrations.ServerControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <div>
        <asp:textbox ID="demoToolBox" runat="server"></asp:textbox>
        <asp:Label ID="displayLabel" runat="server"></asp:Label>
        <asp:Button ID="submitButton" runat="server" OnClick="submitButton_Click" Text="Displays Text" />
      </div>
    </form>
</body>
</html>
