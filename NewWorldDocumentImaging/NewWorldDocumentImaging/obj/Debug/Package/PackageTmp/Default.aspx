<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="NewWorldDocumentImaging._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>New World Document Imaging</title>
    <style type="text/css">
        .style1
        {
            text-align: center;
        }
        .style2
        {
            width: 100px;
        }
        .style3
        {
            width: 36px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <p class="style1">
            <asp:Label ID="lblPermitNumberText" runat="server" Font-Bold="False" 
                Font-Names="Calibri" Text="Permit Number:  "></asp:Label>
            <asp:Label ID="lblPermit" runat="server" Font-Bold="False" Font-Names="Calibri" 
                Text="Label"></asp:Label>
        </p>
        <p class="style1">
            <asp:Label ID="lblPermitTypeText" runat="server" Font-Bold="False" 
                Font-Names="Calibri" Text="Permit Type:  "></asp:Label>
            <asp:Label ID="lblPermitType" runat="server" Font-Bold="False" 
                Font-Names="Calibri" Text="Label"></asp:Label>
        </p>
        <p class="style1">
            <asp:Label ID="lblWait" runat="server" Text="Please wait..." Visible="False" 
                Font-Names="Calibri"></asp:Label>
        </p>
        <p class="style1">
            <asp:Button ID="btnClose" runat="server" Text="Close" Visible="False" 
                Font-Names="Calibri" Font-Size="Medium" />
        </p>
        <p class="style1">
            <table>
                <tr>
                    <td class="style2">
                        <asp:Image ID="imgSearchPermitType" runat="server" ImageUrl="~/Preview.png" 
                            Width="48px" />
                    </td>
                    <td class="style3">
            <asp:Button ID="btnSearchType" runat="server" Text="Search by Permit Number &amp; Type" 
                Width="225px" Font-Names="Calibri" Font-Size="Medium" Height="40px" 
                            ToolTip="Use this search to narrow your search of documents to just the permits of the type above." />
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        <asp:Image ID="imgSearchPermit" runat="server" ImageUrl="~/Preview.png" 
                            Width="48px" />
                    </td>
                    <td class="style3">
            <asp:Button ID="btnSearch" runat="server" Text="Search by Permit Number" 
                Width="225px" Font-Names="Calibri" Font-Size="Medium" Height="40px" 
                            ToolTip="Broaden your search to include documents of any type of Permit." />
                    </td>
                 </tr>
                <tr>
                    <td class="style2">
                        <asp:Image ID="imgScan" runat="server" ImageUrl="~/Scanner .png" Width="48px" />
                    </td>
                    <td class="style3">
            <asp:Button ID="btnScan" runat="server" Text="Scan New Document" Width="225px" 
                            Font-Names="Calibri" Font-Size="Medium" Height="40px" 
                            ToolTip="Enter a new Image into the system." />
                    </td>
                </tr>
            </table>
            <br />
            <br />
        </p>
    
    </div>
    </form>
</body>
</html>
