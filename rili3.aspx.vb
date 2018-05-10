Partial Class rili3
    Inherits System.Web.UI.Page
    Dim holidays(12, 31) As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        holidays(1, 1) = "元旦"
        holidays(3, 8) = "妇女节"
        holidays(5, 1) = "劳动节"
        holidays(5, 4) = "青年节"
        holidays(6, 1) = "儿童节"
        holidays(8, 1) = "建军节"
        holidays(9, 9) = "教师节"
        holidays(10, 1) = "国庆节"
        holidays(12, 25) = "圣诞节"
    End Sub

    Protected Sub Calendar1_DayRender(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DayRenderEventArgs) Handles Calendar1.DayRender
        Dim dtmDate As DateTime = e.Day.Date
        Dim ctlCell As TableCell = e.Cell
        Dim strTask As String = holidays(dtmDate.Month, dtmDate.Day)
        'If e.Day.IsOtherMonth Then
        '    e.Cell.Controls.Clear()
        'Else
        If strTask <> "" Then
            '以桔黄色的背景色显示有备忘录内容的这一天
            ctlCell.BackColor = Drawing.Color.Orange
            ctlCell.ForeColor = Drawing.Color.Red
            ctlCell.Controls.Add(New LiteralControl("<br/>"))
            ctlCell.Controls.Add(New LiteralControl(strTask))
        End If
        'End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = zhy.xyj(MapPath("rili3.aspx.vb"))
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Text = zhy.szy(MapPath("rili3.aspx.vb"))
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label1.Text = ""
    End Sub
End Class
