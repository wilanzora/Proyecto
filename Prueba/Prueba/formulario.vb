Public Class formulario 

    Private Sub NB_Bitacora_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NB_Bitacora.LinkClicked
        Dim vista As New Vistas
        vista.MdiParent = Me
        vista.Show()

    End Sub
End Class