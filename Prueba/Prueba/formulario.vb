
Imports DevExpress.XtraReports.UI
Public Class formulario

    Private Sub NB_Bitacora_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NB_Bitacora.LinkClicked
        Dim f As New Vistas
        f.MdiParent = Me
        f.Show()

    End Sub

    Private Sub NB_Reporte_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NB_Reporte.LinkClicked
        Dim f As New XtraReport1
        Dim print As New ReportPrintTool(f)
        f.ShowRibbonPreviewDialog()
        


    End Sub
End Class