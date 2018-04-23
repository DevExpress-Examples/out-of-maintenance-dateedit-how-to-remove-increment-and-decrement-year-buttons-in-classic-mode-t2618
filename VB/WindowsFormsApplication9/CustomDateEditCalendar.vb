Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo

Namespace WindowsFormsApplication9
    Public Class CustomDateEditCalendar
        Inherits DateEditCalendar

        Public Sub New(ByVal item As RepositoryItemDateEdit, ByVal editDate As Object)
            MyBase.New(item, editDate)

        End Sub
        Protected Overrides Function CreateInfoArgs() As DateEditInfoArgs
            Return New CustomDateEditInfoArgs(Me)
        End Function
    End Class

End Namespace
