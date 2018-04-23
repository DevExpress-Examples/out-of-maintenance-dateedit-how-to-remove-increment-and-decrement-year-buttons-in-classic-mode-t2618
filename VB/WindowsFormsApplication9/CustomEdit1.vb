Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Popup
Imports DevExpress.XtraEditors.Controls
Imports System.Windows.Forms

Namespace WindowsFormsApplication9
    <ToolboxItem(True)> _
    Public Class CustomEdit1
        Inherits DateEdit

        Shared Sub New()
            RepositoryItemCustomEdit1.RegisterCustomEdit1()
        End Sub

        Public Sub New()
        End Sub

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public Shadows ReadOnly Property Properties() As RepositoryItemCustomEdit1
            Get
                Return TryCast(MyBase.Properties, RepositoryItemCustomEdit1)
            End Get
        End Property

        Public Overrides ReadOnly Property EditorTypeName() As String
            Get
                Return RepositoryItemCustomEdit1.CustomEditName
            End Get
        End Property

        Protected Overrides Function CreatePopupForm() As PopupBaseForm
            Return New CustomEdit1PopupForm(Me)
        End Function
    End Class
End Namespace
