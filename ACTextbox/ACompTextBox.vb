Public Class ACompTextBox
    Private data As New Dictionary(Of String, String)
    Private temp As New Dictionary(Of String, String)
    Private valueset As Boolean = False
    Private deleted As Boolean = False
    Private dataloaded As Boolean = False
    Public Event SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    Public Sub init()
        ListBox1.Left = TextBox1.Left
        ListBox1.Top = TextBox1.Bottom
        ListBox1.Width = TextBox1.Width
        ListBox1.Visible = False
    End Sub

    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        TextBox1.SelectionStart = 0
        TextBox1.SelectionLength = TextBox1.Text.Length
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Clear Or e.KeyCode = Keys.Delete Then
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If (TextBox1.Text.Length >= 3) Then
            temp.Clear()
            For Each kvp As KeyValuePair(Of String, String) In data
                If kvp.Value.ToLower().Contains(TextBox1.Text.ToLower()) Then
                    temp.Add(kvp.Key, kvp.Value)
                End If
            Next
            dataloaded = True
            ListBox1.DataSource = Nothing
            If temp.Count > 0 Then
                dataloaded = True
                ListBox1.DataSource = New BindingSource(temp, Nothing)
                ListBox1.DisplayMember = "Value"
                ListBox1.ValueMember = "Key"
            End If
            If Not valueset Then
                ListBox1.Visible = True
                Me.Height = ListBox1.Height + TextBox1.Height
                ListBox1.BringToFront()
                CType(Me.Parent, Form).Controls.SetChildIndex(Me, 0)
            Else
                valueset = False
            End If
        Else
            Me.Height = TextBox1.Height
            dataloaded = True
            ListBox1.DataSource = Nothing
            ListBox1.Visible = False
        End If
    End Sub

    Public Sub AddItem(ByVal key As String, ByVal val As String)
        data.Add(key, val)
    End Sub

    Public Sub Clear()
        dataloaded = True
        ListBox1.DataSource = Nothing
        temp.Clear()
        data.Clear()
    End Sub

    Private Sub ACompTextBox_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        TextBox1.Width = Me.Width
        ListBox1.Width = Me.Width
    End Sub
    Public Function getVal() As String
        If Not ListBox1.SelectedItem Is Nothing Then
            Return DirectCast(ListBox1.SelectedItem, KeyValuePair(Of String, String)).Key
        End If
        Return ""
    End Function

    Public Function getText() As String
        Return TextBox1.Text
    End Function

    Public Sub setVal(ByVal val As String)
        If (data.ContainsKey(val)) Then
            valueset = True
            TextBox1.Text = data.Item(val)
        End If
    End Sub

    Public Sub setText(ByVal val As String)
        TextBox1.Text = val
    End Sub

    Private Sub ListBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.GotFocus
        dataloaded = False
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If Not dataloaded Then
            valueset = True
            TextBox1.Text = DirectCast(ListBox1.SelectedItem, KeyValuePair(Of String, String)).Value
            ListBox1.Visible = False
            Me.Height = TextBox1.Height
            RaiseEvent SelectedIndexChanged(sender, e)
        End If
    End Sub
End Class