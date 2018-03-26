Partial Public Class _Parcel
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ParcelNumber As String
        ParcelNumber = Request.QueryString("ParcelNumber")

        lblParcel.Text = ParcelNumber

    End Sub


    Protected Sub btnScan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnScanParcel.Click
        Dim ParcelNumber As String
        ParcelNumber = Request.QueryString("ParcelNumber")

        lblParcelNumberText.Visible = False
        lblParcel.Visible = False
        btnSearchParcel.Visible = False
        btnScanParcel.Visible = False
        imgScan.Visible = False
        imgSearchPermit.Visible = False
        lblWait.Visible = True
        btnCloseParcel.Visible = True


        ClientScript.RegisterStartupScript(Me.GetType(), "Scan", "<script language='Javascript'>window.location=""lfwa80://scanning/http://rcimage02.yourdomain.com/laserfiche8/App_Services/ScanningService.asmx?r=Randolph-County-Records&custom=name:\'" & ParcelNumber & "\'path:\'\\\\Central Permitting\\\\Import\\\\Scan-Snapshot\'volid:\'33\'template:\'CP - Records\'[PIN No]\'" & ParcelNumber & "\'(ProtectedItems)\'15\'"";</script>")

        lblWait.Text = "You can close this window"

    End Sub

    Protected Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearchParcel.Click
        Dim ParcelNumber As String
        ParcelNumber = Request.QueryString("ParcelNumber")

        ClientScript.RegisterStartupScript(Me.GetType(), "Search", "<script language='Javascript'>window.open('http://weblink.yourdomain.com/weblink/Search.aspx?dbid=0&searchcommand={[CP - Records]:[PIN No]=&quot;" & ParcelNumber & "&quot;}');window.close();</script>")

    End Sub

    Protected Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCloseParcel.Click
        ClientScript.RegisterStartupScript(Me.GetType(), "Close", "<script language='Javascript'>self.close();</script>")
    End Sub

End Class