Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        If txtCarnet.Text = "" Then
            MsgBox("Error Campo Carné")
            Exit Sub
        End If


        If txtNombre.Text = "" Then
            MsgBox("Error Campo nombre")
            Exit Sub
        End If

        If cbxIdioma.SelectedItem = "" Then
            MsgBox("Error Campo idioma")
            Exit Sub
        End If

        If dtpFecha.Value = "" Then
            MsgBox("Error Campo fecha")
            Exit Sub
        End If

        If cbxDias.SelectedItem = "" Then
            MsgBox("Error Campo dias")
            Exit Sub
        End If

        If txtHoras.Text = "" Then
            MsgBox("Error Campo dias")
            Exit Sub
        End If


        If cbxIdioma.SelectedIndex = -1 Then
            MsgBox("Error Campo Idioma")
            Exit Sub
        End If

        If indice < 8 Then
            'Guardar todos los campos de entrada en la matriz
            matriz(0, indice) = txtCarnet.Text
            matriz(1, indice) = txtNombre.Text
            matriz(2, indice) = cbxIdioma.SelectedItem
            matriz(3, indice) = dtpFecha.Value
            matriz(4, indice) = cbxDias.SelectedItem
            matriz(5, indice) = txtHoras.Text

            If rbCheque.Checked Then
                matriz(6, indice) = rbCheque.Text
            ElseIf rbEfectivo.Checked Then
                matriz(6, indice) = rbEfectivo.Text
            End If

            If rbCheque.Checked Then
                matriz(7, indice) = txtHoras.Text
            ElseIf rbEfectivo.Checked Then
                matriz(7, indice) = txtHoras.Text
            End If


            If rbEfectivo.Checked Then
                matriz(10, indice) = rbEfectivo.Text  '= "EFECTIVO"
                matriz(10, indice) = Str(Val(matriz(10, indice) * 0.02))
            ElseIf (rbEfectivo.Checked) Then
                matriz(10, indice) = rbEfectivo.Text
            End If

            If rbCheque.Checked Then
                matriz(11, indice) = rbCheque.Text  '= "CHEQUE"
                matriz(11, indice) = Str(Val(matriz(11, indice) * 0.015))
            ElseIf (rbCheque.Checked) Then
                matriz(11, indice) = rbCheque.Text
            End If

            matriz(12, indice) = Str(Val(matriz(9, indice)) - Val(matriz(10, indice) - Val(matriz(11, indice))))



            DataGridView1.Rows.Add(indice + 1, matriz(0, indice), matriz(1, indice), matriz(2, indice), matriz(3, indice), matriz(4, indice), matriz(5, indice), matriz(6, indice), 0, 0, 0, 0)
            indice = indice + 1
        Else
            MessageBox.Show("Ya se llegó al límite")
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("¿Desea Salir?", vbYesNo) = vbYes Then
            End
        End If
    End Sub
End Class
