Public Class Form1
    Dim stopClick As Boolean = False
    Dim N As Integer = 28
    Dim Nomes As String()
    Dim i As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Button1.Enabled = False
        Button2.Enabled = True
        Button3.Enabled = False
        TextBox2.Text = ""
        i = 0
        While Button1.Enabled = False

            i = Math.Floor(Rnd() * N)
            If Nomes(i) <> "" Then
                TextBox1.Text = i
                Threading.Thread.Sleep(50)
            End If
            Application.DoEvents()
        End While

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = True
        TextBox2.Text = Nomes(i)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Nomes = {"Boia (de piscina)", "Colete", "Cofre", "Bola (de futebol)", "Cogumelo", "Girafa", "Chave", "Tesoura", "Pincel", "Caracol", "Garfo", "Calendário", "Iglu", "Garrafa", "Sofá", "Elevador", "Cruzeta (de roupa)", "Sapato", "Borracha", "Gato", "Baliza", "Luva", "Correio", "Autocarro", "Moeda", "Copo", "Rato (de computador)", "Gravata"}
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.Enabled = False
        ListBox1.Items.Add(TextBox2.Text)
        Nomes(i) = ""

    End Sub
End Class
