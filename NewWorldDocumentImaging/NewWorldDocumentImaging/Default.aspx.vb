Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim PermitNumber As String
        Dim PermitType
        PermitNumber = Request.QueryString("PermitNumber")
        PermitType = Request.QueryString("PermitType")

        lblPermit.Text = PermitNumber
        lblPermitType.Text = PermitType

        'btnSearch.Attributes.Add("onclick", "window.open('http://weblink.yourdomain.com/weblink/Search.aspx?dbid=0&searchcommand=" & PermitNumber & "');window.close();")

        'btnScan.Attributes.Add("onclick", "window.location.href(""lfwa80://scanning/http://weblink.yourdomain.com/laserfiche/App_Services/ScanningService.asmx?r=Randolph-County-Records&custom=name:\'" & PermitNumber & "\'path:\'\\\\Central Permitting\'volid:\'33\'template:\'EH - Central Permitting\'[Application No]\'" & PermitNumber & "\'(ProtectedItems)\'15\'"");return false;window.close();")
        'btnScan.Attributes.Add("onclick", "window.open('lfwa80://scanning/http://weblink.yourdomain.com/laserfiche/App_Services/ScanningService.asmx?r=Randolph-County-Records&custom=name:\'" & PermitNumber & "\'path:\'\\\\Central Permitting\'volid:\'33\'template:\'EH - Central Permitting\'[Application No]\'" & PermitNumber & "\'(ProtectedItems)\'15\'');window.close();")
    End Sub


    Protected Sub btnScan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnScan.Click
        Dim PermitNumber As String
        Dim PermitType
        PermitNumber = Request.QueryString("PermitNumber")
        PermitType = Trim(Request.QueryString("PermitType"))

        lblPermitTypeText.Visible = False
        lblPermitNumberText.Visible = False
        lblPermitType.Visible = False
        lblPermit.Visible = False
        btnSearch.Visible = False
        btnSearchType.Visible = False
        btnScan.Visible = False
        imgScan.Visible = False
        imgSearchPermit.Visible = False
        imgSearchPermitType.Visible = False
        lblWait.Visible = True
        btnClose.Visible = True


        ClientScript.RegisterStartupScript(Me.GetType(), "Scan", "<script language='Javascript'>window.location=""lfwa80://scanning/http://rcimage02.yourdomain.com/laserfiche8/App_Services/ScanningService.asmx?r=Randolph-County-Records&custom=name:\'" & PermitNumber & "_" & PermitType & "\'path:\'\\\\Central Permitting\\\\Import\\\\Scan-Snapshot\'volid:\'33\'template:\'CP - Records\'[Permit Nbr]\'" & PermitNumber & "\'[CP - Records - Permit Type]\'" & PermitType & "\'(ProtectedItems)\'15\'"";</script>")

        lblWait.Text = "You can close this window"

    End Sub

    Protected Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
        Dim PermitNumber As String
        PermitNumber = Request.QueryString("PermitNumber")

        ClientScript.RegisterStartupScript(Me.GetType(), "Search", "<script language='Javascript'>window.open('http://weblink.yourdomain.com/weblink/Search.aspx?dbid=0&searchcommand={[CP - Records]:[Permit Nbr]=&quot;" & PermitNumber & "&quot;}');window.close();</script>")

    End Sub

    Protected Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        ClientScript.RegisterStartupScript(Me.GetType(), "Close", "<script language='Javascript'>self.close();</script>")
    End Sub

    Protected Sub btnSearchType_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearchType.Click
        Dim PermitNumber As String
        Dim PermitType As String
        PermitNumber = Request.QueryString("PermitNumber")
        PermitType = Trim(Request.QueryString("PermitType"))

        ClientScript.RegisterStartupScript(Me.GetType(), "Search", "<script language='Javascript'>window.open('http://weblink.yourdomain.com/weblink/Search.aspx?dbid=0&searchcommand={[CP - Records]:[Permit Nbr]=&quot;" & PermitNumber & "&quot;}%26{[CP - Records]:[CP - Records - Permit Type]=&quot;" & PermitType & "&quot;}');window.close();</script>")

    End Sub
End Class