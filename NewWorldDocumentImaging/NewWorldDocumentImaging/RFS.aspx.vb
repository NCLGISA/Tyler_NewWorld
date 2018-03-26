Partial Public Class _RFS
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim RFSNumber As String
        RFSNumber = Request.QueryString("RFSNumber")

        lblRFS.Text = RFSNumber

    End Sub


    Protected Sub btnScan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnScanRFS.Click
        Dim RFSNumber As String
        RFSNumber = Request.QueryString("RFSNumber")

        lblRFSNumberText.Visible = False
        lblRFS.Visible = False
        btnSearchRFS.Visible = False
        btnScanRFS.Visible = False
        imgScan.Visible = False
        imgSearchPermit.Visible = False
        lblWait.Visible = True
        btnCloseRFS.Visible = True


        ClientScript.RegisterStartupScript(Me.GetType(), "Scan", "<script language='Javascript'>window.location=""lfwa80://scanning/http://rcimage02.yourdomain.com/laserfiche8/App_Services/ScanningService.asmx?r=Randolph-County-Records&custom=name:\'" & RFSNumber & "\'path:\'\\\\Central Permitting\\\\Import\\\\Scan-Snapshot\'volid:\'33\'template:\'CP - Records\'[Request for Service Nbr]\'" & RFSNumber & "\'(ProtectedItems)\'15\'"";</script>")

        lblWait.Text = "You can close this window"

    End Sub

    Protected Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearchRFS.Click
        Dim RFSNumber As String
        RFSNumber = Request.QueryString("RFSNumber")

        ClientScript.RegisterStartupScript(Me.GetType(), "Search", "<script language='Javascript'>window.open('http://weblink.yourdomain.com/weblink/Search.aspx?dbid=0&searchcommand={[CP - Records]:[Request for Service Nbr]=&quot;" & RFSNumber & "&quot;}');window.close();</script>")

    End Sub

    Protected Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCloseRFS.Click
        ClientScript.RegisterStartupScript(Me.GetType(), "Close", "<script language='Javascript'>self.close();</script>")
    End Sub

End Class