Public Class Form1

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        acomp.AddItem("103.05.016.1219", "Ahmet Mehmet - 12345683789 - 16.05.1984 - mahmut")
        acomp.AddItem("103.05.016.1220", "Ali Veli - 75465492665 - 22.03.1954 - Fethullah")
        acomp.AddItem("103.05.016.1221", "Bestami Agiragac - 45623423975 - 18.04.1936 - Halim")
        acomp.AddItem("103.05.016.1222", "Mügenur Ahmet - 65685643856 - 22.11.1966 - Edip")
        acomp.AddItem("103.05.016.1223", "Lemi Akarcay - 45345993405 - 06.09.1983 - Adem")
        acomp.AddItem("103.05.016.1224", "Cihan Akarpinar - 34542529452 - 14.01.1982 - Gökay")
        acomp.AddItem("103.05.016.1225", "Servet Akcagunay - 67963592532 - 07.04.1975 - Yüksel")
        acomp.AddItem("103.05.016.1226", "Sarper Akis - 98067503634 - 09.02.1980 - Sakip")
        acomp.AddItem("103.05.016.1227", "Senem Aksevim - 34718934038 - 19.03.1963 - Kazim")
        acomp.AddItem("103.05.016.1228", "Mazlum Altan - 46828953373 - 27.06.1988 - Coskun")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label1.Text = acomp.getVal()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        acomp.setVal("103.05.016.1227")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        acomp.Enabled = False
        acomp.setText("")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        acomp.Enabled = True
    End Sub

    Private Sub acomp_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles acomp.SelectedIndexChanged
        MessageBox.Show("item changed")
    End Sub
End Class
