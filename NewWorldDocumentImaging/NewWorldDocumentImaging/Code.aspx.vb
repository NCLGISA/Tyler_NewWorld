Partial Public Class _Code
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim CodeNumber As String
        CodeNumber = Request.QueryString("CodeNumber")

        lblCode.Text = CodeNumber

    End Sub


    Protected Sub btnScan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnScanCode.Click
        Dim CodeNumber As String
        CodeNumber = Request.QueryString("CodeNumber")

        lblCode.Visible = False
        btnSearchCode.Visible = False
        btnScanCode.Visible = False
        imgScan.Visible = False
        imgSearchPermit.Visible = False
        lblWait.Visible = True
        btnCloseCode.Visible = True


        ClientScript.RegisterStartupScript(Me.GetType(), "Scan", "<script language='Javascript'>window.location=""lfwa80://scanning/http://rcimage02.yourdomain.com/laserfiche8/App_Services/ScanningService.asmx?r=Randolph-County-Records&custom=name:\'" & CodeNumber & "\'path:\'\\\\Central Permitting\\\\Import\\\\Scan-Snapshot\'volid:\'33\'template:\'CP - Records\'[Code Enforcement Nbr]\'" & CodeNumber & "\'(ProtectedItems)\'15\'"";</script>")

        lblWait.Text = "You can close this window"

    End Sub

    Protected Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearchCode.Click
        Dim CodeNumber As String
        CodeNumber = Request.QueryString("CodeNumber")

        ClientScript.RegisterStartupScript(Me.GetType(), "Search", "<script language='Javascript'>window.open('http://weblink.yourdomain.com/weblink/Search.aspx?dbid=0&searchcommand={[CP - Records]:[Code Enforcement Nbr]=&quot;" & CodeNumber & "&quot;}');window.close();</script>")

    End Sub

    Protected Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCloseCode.Click
        ClientScript.RegisterStartupScript(Me.GetType(), "Close", "<script language='Javascript'>self.close();</script>")
    End Sub

End Class