Partial Public Class _License
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim LicenseNumber As String
        Dim LicenseType
        LicenseNumber = Request.QueryString("LicenseNumber")
        LicenseType = Request.QueryString("LicenseType")

        lblLicense.Text = LicenseNumber
        lblLicenseType.Text = LicenseType

        'btnSearch.Attributes.Add("onclick", "window.open('http://weblink.yourdomain.com/weblink/Search.aspx?dbid=0&searchcommand=" & LicenseNumber & "');window.close();")

        'btnScan.Attributes.Add("onclick", "window.location.href(""lfwa80://scanning/http://weblink.yourdomain.com/laserfiche/App_Services/ScanningService.asmx?r=Randolph-County-Records&custom=name:\'" & LicenseNumber & "\'path:\'\\\\Central Permitting\'volid:\'33\'template:\'EH - Central Permitting\'[Application No]\'" & LicenseNumber & "\'(ProtectedItems)\'15\'"");return false;window.close();")
        'btnScan.Attributes.Add("onclick", "window.open('lfwa80://scanning/http://weblink.yourdomain.com/laserfiche/App_Services/ScanningService.asmx?r=Randolph-County-Records&custom=name:\'" & LicenseNumber & "\'path:\'\\\\Central Permitting\'volid:\'33\'template:\'EH - Central Permitting\'[Application No]\'" & LicenseNumber & "\'(ProtectedItems)\'15\'');window.close();")
    End Sub


    Protected Sub btnScan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnScan.Click
        Dim LicenseNumber As String
        Dim LicenseType
        LicenseNumber = Request.QueryString("LicenseNumber")
        LicenseType = Trim(Request.QueryString("LicenseType"))

        lblLicenseTypeText.Visible = False
        lblLicenseNumberText.Visible = False
        lblLicenseType.Visible = False
        lblLicense.Visible = False
        btnSearch.Visible = False
        btnSearchType.Visible = False
        btnScan.Visible = False
        imgScan.Visible = False
        imgSearchLicense.Visible = False
        imgSearchLicenseType.Visible = False
        lblWait.Visible = True
        btnClose.Visible = True


        ClientScript.RegisterStartupScript(Me.GetType(), "Scan", "<script language='Javascript'>window.location=""lfwa80://scanning/http://rcimage02.yourdomain.com/laserfiche8/App_Services/ScanningService.asmx?r=Randolph-County-Records&custom=name:\'" & LicenseNumber & "_" & LicenseType & "\'path:\'\\\\Central Permitting\\\\Import\\\\Scan-Snapshot\'volid:\'33\'template:\'CP - Records\'[License Number]\'" & LicenseNumber & "\'[License Type]\'" & LicenseType & "\'(ProtectedItems)\'15\'"";</script>")

        lblWait.Text = "You can close this window"

    End Sub

    Protected Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
        Dim LicenseNumber As String
        LicenseNumber = Request.QueryString("LicenseNumber")

        ClientScript.RegisterStartupScript(Me.GetType(), "Search", "<script language='Javascript'>window.open('http://weblink.yourdomain.com/weblink/Search.aspx?dbid=0&searchcommand={[CP - Records]:[License Number]=&quot;" & LicenseNumber & "&quot;}');window.close();</script>")

    End Sub

    Protected Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        ClientScript.RegisterStartupScript(Me.GetType(), "Close", "<script language='Javascript'>self.close();</script>")
    End Sub

    Protected Sub btnSearchType_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearchType.Click
        Dim LicenseNumber As String
        Dim LicenseType As String
        LicenseNumber = Request.QueryString("LicenseNumber")
        LicenseType = Trim(Request.QueryString("LicenseType"))

        ClientScript.RegisterStartupScript(Me.GetType(), "Search", "<script language='Javascript'>window.open('http://weblink.yourdomain.com/weblink/Search.aspx?dbid=0&searchcommand={[CP - Records]:[License Number]=&quot;" & LicenseNumber & "&quot;}%26{[CP - Records]:[License Type]=&quot;" & LicenseType & "&quot;}');window.close();</script>")

    End Sub
End Class