Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo

Namespace WindowsFormsApplication9
    <UserRepositoryItem("RegisterCustomEdit1")> _
    Public Class RepositoryItemCustomEdit1
        Inherits RepositoryItemDateEdit

        Shared Sub New()
            RegisterCustomEdit1()
        End Sub

        Public Const CustomEditName As String = "CustomEdit1"

        Public Sub New()
        End Sub

        Public Overrides ReadOnly Property EditorTypeName() As String
            Get
                Return CustomEditName
            End Get
        End Property

        Public Shared Sub RegisterCustomEdit1()
            Dim img As Image = Nothing
            EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(CustomEditName, GetType(CustomEdit1), GetType(RepositoryItemCustomEdit1), GetType(DateEditViewInfo), New ButtonEditPainter(), True, img))
        End Sub

        Public Overrides Sub Assign(ByVal item As RepositoryItem)
            BeginUpdate()
            Try
                MyBase.Assign(item)
                Dim source As RepositoryItemCustomEdit1 = TryCast(item, RepositoryItemCustomEdit1)
                If source Is Nothing Then
                    Return
                End If
            Finally
                EndUpdate()
            End Try
        End Sub
    End Class

End Namespace
