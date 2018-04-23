Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.ViewInfo

Namespace WindowsFormsApplication9
    Public Class CustomDateEditInfoArgs
        Inherits DateEditInfoArgs

        Public Sub New(ByVal calendar As DateEditCalendarBase)
            MyBase.New(calendar)

        End Sub

        Protected Overrides Sub CalcHeaderInfo()
            MyBase.CalcHeaderInfo()

            Dim buttonSize As Size = CalcArrowButtonSize()
            Dim margin As Integer = 2
            Dim x As Integer = Header.X + margin
            Dim y As Integer = Header.Y + (Header.Height - buttonSize.Height) \ 2
            DecMonthInfo.Bounds = New Rectangle(New Point(x, y), buttonSize)
            x = DecMonthInfo.Bounds.Right
            If Not ShowDecMonth Then
                DecMonthInfo.Bounds = Rectangle.Empty
            End If
            EditMonth = New Rectangle(MonthTitleWidth, Header.Y, MonthTitleWidth, Header.Height)
            'Prev code: new Rectangle(new Point(EditMonth.Right, y), buttonSize);
            IncMonthInfo.Bounds = New Rectangle(New Point(Header.Right - buttonSize.Width - margin, y), buttonSize)
            x = IncMonthInfo.Bounds.Right
            If Not ShowIncMonth Then
                IncMonthInfo.Bounds = Rectangle.Empty
            End If
            x += margin
            If ShowIncYear Then
                'Prev code: new Rectangle(new Point(Header.Right - buttonSize.Width - margin, y), buttonSize);
                IncYearInfo.Bounds = Rectangle.Empty
            End If
            x = Header.Right - buttonSize.Width - margin
            'Prev code: new Rectangle(x - YearTitleWidth, Header.Y, YearTitleWidth, Header.Height);
            EditYear = Rectangle.Empty
            If ShowDecYear Then
                'Prev code: new Rectangle(new Point(EditYear.Left - buttonSize.Width, y), buttonSize);
                DecYearInfo.Bounds = Rectangle.Empty
            End If
            If Calendar.IsHandleCreated Then
                UpdateArrowButtonsState(Control.MouseButtons, Calendar.PointToClient(Cursor.Position), False)
            End If
        End Sub
    End Class
End Namespace
