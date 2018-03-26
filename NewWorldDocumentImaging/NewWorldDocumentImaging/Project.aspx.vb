Partial Public Class _Project
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ProjectNumber As String
        Dim ProjectType
        ProjectNumber = Request.QueryString("ProjectNumber")
        ProjectType = Request.QueryString("ProjectType")

        lblProject.Text = ProjectNumber
        lblProjectType.Text = ProjectType

        'btnSearch.Attributes.Add("onclick", "window.open('http://weblink.yourdomain.com/weblink/Search.aspx?dbid=0&searchcommand=" & ProjectNumber & "');window.close();")

        'btnScan.Attributes.Add("onclick", "window.location.href(""lfwa80://scanning/http://weblink.yourdomain.com/laserfiche/App_Services/ScanningService.asmx?r=Randolph-County-Records&custom=name:\'" & ProjectNumber & "\'path:\'\\\\Central Permitting\'volid:\'33\'template:\'EH - Central Permitting\'[Application No]\'" & ProjectNumber & "\'(ProtectedItems)\'15\'"");return false;window.close();")
        'btnScan.Attributes.Add("onclick", "window.open('lfwa80://scanning/http://weblink.yourdomain.com/laserfiche/App_Services/ScanningService.asmx?r=Randolph-County-Records&custom=name:\'" & ProjectNumber & "\'path:\'\\\\Central Permitting\'volid:\'33\'template:\'EH - Central Permitting\'[Application No]\'" & ProjectNumber & "\'(ProtectedItems)\'15\'');window.close();")
    End Sub


    Protected Sub btnScan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnScan.Click
        Dim ProjectNumber As String
        Dim ProjectType
        ProjectNumber = Request.QueryString("ProjectNumber")
        ProjectType = Trim(Request.QueryString("ProjectType"))

        lblProjectTypeText.Visible = False
        lblProjectNumberText.Visible = False
        lblProjectType.Visible = False
        lblProject.Visible = False
        btnSearch.Visible = False
        btnSearchType.Visible = False
        btnScan.Visible = False
        imgScan.Visible = False
        imgSearchProject.Visible = False
        imgSearchProjectType.Visible = False
        lblWait.Visible = True
        btnClose.Visible = True


        ClientScript.RegisterStartupScript(Me.GetType(), "Scan", "<script language='Javascript'>window.location=""lfwa80://scanning/http://rcimage02.yourdomain.com/laserfiche8/App_Services/ScanningService.asmx?r=Randolph-County-Records&custom=name:\'" & ProjectNumber & "_" & ProjectType & "\'path:\'\\\\Central Permitting\\\\Import\\\\Scan-Snapshot\'volid:\'33\'template:\'CP - Records\'[Project Planning Nbr]\'" & ProjectNumber & "\'[Project Planning Type]\'" & ProjectType & "\'(ProtectedItems)\'15\'"";</script>")

        lblWait.Text = "You can close this window"

    End Sub

    Protected Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
        Dim ProjectNumber As String
        ProjectNumber = Request.QueryString("ProjectNumber")

        ClientScript.RegisterStartupScript(Me.GetType(), "Search", "<script language='Javascript'>window.open('http://weblink.yourdomain.com/weblink/Search.aspx?dbid=0&searchcommand={[CP - Records]:[Project Planning Nbr]=&quot;" & ProjectNumber & "&quot;}');window.close();</script>")

    End Sub

    Protected Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        ClientScript.RegisterStartupScript(Me.GetType(), "Close", "<script language='Javascript'>self.close();</script>")
    End Sub

    Protected Sub btnSearchType_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearchType.Click
        Dim ProjectNumber As String
        Dim ProjectType As String
        ProjectNumber = Request.QueryString("ProjectNumber")
        ProjectType = Trim(Request.QueryString("ProjectType"))

        ClientScript.RegisterStartupScript(Me.GetType(), "Search", "<script language='Javascript'>window.open('http://weblink.yourdomain.com/weblink/Search.aspx?dbid=0&searchcommand={[CP - Records]:[Project Planning Nbr]=&quot;" & ProjectNumber & "&quot;}%26{[CP - Records]:[Project Planning Type]=&quot;" & ProjectType & "&quot;}');window.close();</script>")

    End Sub
End Class