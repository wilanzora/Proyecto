Public Class formulario 

    Private Sub NB_Bitacora_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NB_Bitacora.LinkClicked
        Dim vista As New Vistas
        vista.MdiParent = Me
        vista.Show()

    End Sub

    Private Sub NB_Reporte_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NB_Reporte.LinkClicked
        'Dim f As New XtraReport1
        'f.MdiParent = Me
        'f.ShowPrintStatusDialog


    End Sub
End Class