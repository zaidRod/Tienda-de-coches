Public Class Form1

    Private Structure Coche
        Public modelo As String
        Public CC As String
        Public CV As String
        Public promocion As Integer
        Public precio As Integer

    End Structure


    Private Structure Pedidos
        Public pedidoMarca As String
        Public pedidoModelo As String
        Public numPedido As Integer

    End Structure
    ' Creo el listado de los pedidos
    Dim listadoPedidos(5) As Pedidos

    ' Almaceno la marca seleccionada en el combobox
    Dim Marca As String


    ' Creo el listado de los coches
    Dim listadoBMW(3) As Coche
    Dim listadoKIA(2) As Coche
    Dim listadoRENAULT(3) As Coche
    ' Guardo el coche seleccionado
    Dim cocheSeleccionado As Coche

    'Indice que guarda la cantidad del pedio
    Dim indice As Integer = 0













    Private Sub ComboMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboMarca.SelectedIndexChanged
        ' Borro el contenido del listbox para cargar un nuevo grupo de coches
        ListBoxModelos.Items.Clear()

        Select Case ComboMarca.SelectedItem
            ' Filtro el funcion de la marca y selecciono el listado a mostrar
            Case "BMW"

                For i As Integer = 0 To 2
                    ListBoxModelos.Items.Add(listadoBMW(i).modelo)
                Next

                'Almaceno la marca
                Marca = "BMW"

            Case "KIA"
                For i As Integer = 0 To 1
                    ListBoxModelos.Items.Add(listadoKIA(i).modelo)
                Next

                'Almaceno la marca
                Marca = "KIA"


            Case "RENAULT"

                For i As Integer = 0 To 2
                    ListBoxModelos.Items.Add(listadoRENAULT(i).modelo)
                Next

                'Almaceno la marca
                Marca = "RENAULT"

        End Select





    End Sub

    ' Creo el listado de todos los coches y los agrego a sus listas
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cocheK1 As Coche
        cocheK1.modelo = "X1"
        cocheK1.CC = "2"
        cocheK1.CV = "3"
        cocheK1.precio = 100
        cocheK1.promocion = 5



        Dim cocheX2 As Coche
        cocheX2.modelo = "X2"
        cocheX2.CC = "30"
        cocheX2.CV = "40"
        cocheX2.precio = 200
        cocheX2.promocion = 5

        Dim cocheX3 As Coche
        cocheX3.modelo = "X3"
        cocheX3.CC = "30"
        cocheX3.CV = "40"
        cocheX3.precio = 300
        cocheX3.promocion = 5

        listadoBMW(0) = cocheK1
        listadoBMW(1) = cocheX2
        listadoBMW(2) = cocheX3


        Dim cocheSorento As Coche
        cocheSorento.modelo = "Sorento"
        cocheSorento.CC = "50"
        cocheSorento.CV = "60"
        cocheSorento.precio = 300
        cocheSorento.promocion = 5


        Dim cocheSoul As Coche
        cocheSoul.modelo = "Soul"
        cocheSoul.CC = "500"
        cocheSoul.CV = "600"
        cocheSoul.precio = 3000
        cocheSoul.promocion = 5

        listadoKIA(0) = cocheSorento
        listadoKIA(1) = cocheSoul



        Dim cocheAlaska As Coche
        cocheAlaska.modelo = "Alaska"
        cocheAlaska.CC = "500"
        cocheAlaska.CV = "600"
        cocheAlaska.precio = 100
        cocheAlaska.promocion = 5

        Dim cocheArkana As Coche
        cocheArkana.modelo = "Arkana"
        cocheArkana.CC = "10"
        cocheArkana.CV = "600"
        cocheArkana.precio = 30000
        cocheArkana.promocion = 5

        Dim cocheAustral As Coche
        cocheAustral.modelo = "Austral"
        cocheAustral.CC = "500"
        cocheAustral.CV = "6000"
        cocheAustral.precio = 900
        cocheAustral.promocion = 5

        listadoRENAULT(0) = cocheAlaska
        listadoRENAULT(1) = cocheArkana
        listadoRENAULT(2) = cocheAustral






    End Sub

    Private Sub ListBoxModelos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxModelos.SelectedIndexChanged


        Dim seleccionado As Integer = ListBoxModelos.SelectedIndex
        If seleccionado <> -1 Then
            'Dependiendo de la marca escojo el el listado pertinente
            Select Case Marca
                Case "BMW"
                    ' En coche Seleccionado guardo el coche con el que trabajare para las imagenes y los precios
                    cocheSeleccionado = listadoBMW(seleccionado)
                    Select Case cocheSeleccionado.modelo
                        Case "X1"
                            PictureBoxCentro.Image = Image.FromFile(Application.StartupPath & "\AUTOS\bmw_x1.jpg")

                        Case "X2"
                            PictureBoxCentro.Image = Image.FromFile(Application.StartupPath & "\AUTOS\bmw_x2.jpg")

                        Case "X3"
                            PictureBoxCentro.Image = Image.FromFile(Application.StartupPath & "\AUTOS\bmw_x3.jpg")

                    End Select
                Case "KIA"
                    cocheSeleccionado = listadoKIA(seleccionado)
                    Select Case cocheSeleccionado.modelo
                        Case "Sorento"
                            PictureBoxCentro.Image = Image.FromFile(Application.StartupPath & "\AUTOS\kia_sorento.jpg")

                        Case "Soul"
                            PictureBoxCentro.Image = Image.FromFile(Application.StartupPath & "\AUTOS\kia_soul.jpg")



                    End Select

                Case "RENAULT"
                    cocheSeleccionado = listadoRENAULT(seleccionado)
                    Select Case cocheSeleccionado.modelo
                        Case "Alaska"
                            PictureBoxCentro.Image = Image.FromFile(Application.StartupPath & "\AUTOS\Renault_alaskan.jpg")

                        Case "Arkana"
                            PictureBoxCentro.Image = Image.FromFile(Application.StartupPath & "\AUTOS\renault_arkana.jpg")

                        Case "Austral"
                            PictureBoxCentro.Image = Image.FromFile(Application.StartupPath & "\AUTOS\renault_austral.jpg")





                    End Select


            End Select

            'If Marca = "BMW" Then
            '    cocheSeleccionado = listadoBMW(seleccionado)

            '    Select Case cocheSeleccionado.modelo
            '        Case "X1"
            '            PictureBoxCentro.Image = Image.FromFile(Application.StartupPath & "\AUTOS\bmw_x1.jpg")

            '        Case "X2"
            '            PictureBoxCentro.Image = Image.FromFile(Application.StartupPath & "\AUTOS\bmw_x2.jpg")

            '        Case "X3"
            '            PictureBoxCentro.Image = Image.FromFile(Application.StartupPath & "\AUTOS\bmw_x3.jpg")

            '    End Select



            'End If

            ' Lleno los textBox con la infomacion del coche seleccionado
            TextBoxCC.Text = cocheSeleccionado.CC
            TextBoxCV.Text = cocheSeleccionado.CV
            TextBoxPrecio.Text = cocheSeleccionado.precio
            TextBoxPromocion.Text = cocheSeleccionado.promocion

        End If








    End Sub

    Private Sub ButtonRealiza_Click(sender As Object, e As EventArgs) Handles ButtonRealiza.Click

        ' Creo un objeto pedido nuevo 
        Dim pedidoNuevo As Pedidos
        ' Cargo los valores en funcion del coche seleccionado
        pedidoNuevo.pedidoModelo = cocheSeleccionado.modelo
        pedidoNuevo.pedidoMarca = Marca
        pedidoNuevo.numPedido = indice
        'Agrego el pedido nuevo al listado
        listadoPedidos(indice) = pedidoNuevo
        'Agrego el pedido al listBox
        ListBoxPedidos.Items.Add(listadoPedidos(pedidoNuevo.numPedido).numPedido)
        ' Incremento el indice para otro pedido
        indice = indice + 1

        MsgBox("El precio con el descuento es: " & cocheSeleccionado.precio - cocheSeleccionado.precio * cocheSeleccionado.promocion / 100)



    End Sub

    Private Sub ButtonVerPedi_Click(sender As Object, e As EventArgs) Handles ButtonVerPedi.Click

        Dim indicedelPedido = ListBoxPedidos.SelectedIndex

        MsgBox("Marca: " & listadoPedidos(indicedelPedido).pedidoMarca & " Modelo: " & listadoPedidos(indicedelPedido).pedidoModelo)


    End Sub

    Private Sub ButtonBorrarP_Click(sender As Object, e As EventArgs) Handles ButtonBorrarP.Click

        Dim posicion As Integer
        posicion = ListBoxPedidos.SelectedIndex
        Dim eliminado As Integer = posicion

        ListBoxPedidos.Items.Remove(listadoPedidos(posicion).numPedido)

        'Sobre escribo la posicion del choche eliminado, corriendolo una vez.
        For i As Integer = eliminado To 2
            listadoPedidos(i) = listadoPedidos(i + 1)
        Next
        ' Borro el indice que se ha liberado del array
        indice = indice - 1



    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Close()
    End Sub
End Class
