Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors.Popup

Namespace WindowsFormsApplication9
    Public Class CustomEdit1PopupForm
        Inherits PopupDateEditForm

        Public Sub New(ByVal ownerEdit As CustomEdit1)
            MyBase.New(ownerEdit)
        End Sub

        Protected Overrides Function CreateViewInfo() As PopupBaseFormViewInfo
            Return MyBase.CreateViewInfo()
        End Function
        Protected Overrides Function CreateCalendar() As DevExpress.XtraEditors.Controls.DateEditCalendar
            Return New CustomDateEditCalendar(OwnerEdit.Properties, Me.OwnerEdit.EditValue)
        End Function
    End Class
End Namespace
