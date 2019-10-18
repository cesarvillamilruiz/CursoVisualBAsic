Imports System.Data.SqlClient

Public Class Formulario
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load



    End Sub

    Protected Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        Dim Nombres As String = txtNombre.Text
        Dim Apellidos As String = txtApellidos.Text
        Dim Nacionalidad As String = txtNacionalidad.Text
        Dim Estado As String = txtEstadoCivil.Text
        Dim Corre As String = txtCorreo.Text

        Try
            Dim con As New SqlConnection(My.Settings.conexion)
            con.Open()
            Dim sql As String = "insert into persona123 (Nombres, Apellidos, Nacionalidad, Estado, Corre) values ('" & Nombres & "','" & Apellidos & "', '" & Nacionalidad & "','" & Estado & "','" & Corre & "')"
            Dim cmd As New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()

            MsgBox("Ingresado correctamente")
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



        txtNombre.Text = ""
        txtApellidos.Text = ""
        txtNacionalidad.Text = ""
        txtEstadoCivil.Text = ""
        txtCorreo.Text = ""

        Response.Redirect("Tabla.aspx")


    End Sub

    Protected Sub txtApellidos1_TextChanged(sender As Object, e As EventArgs) Handles txtApellidos.TextChanged

    End Sub
End Class