<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="landingPage.aspx.cs" Inherits="Project1.landingPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblLoginStudent" runat="server" Text="Welcome Student"></asp:Label>
        <p>
            <asp:Button ID="btnView" runat="server" Height="26px" Text="View Courses" />
        </p>
        <p>
            <asp:Button ID="btnTrans" runat="server" Text="View Transcript" />
        </p>
        <asp:Button ID="btnEdit" runat="server" Text="Add/Drop Classes" />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="sidno" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" style="z-index: 1; left: 343px; top: 52px; position: absolute; height: 133px; width: 187px">
            <Columns>
                <asp:BoundField DataField="sidno" HeaderText="Student-ID" />
                <asp:BoundField DataField="sName" HeaderText="Name" />
                <asp:BoundField DataField="mCode" HeaderText="Major Code" />
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
