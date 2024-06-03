Imports System.Data.SqlClient

Public Module GlobalVariables
    Public _constr As String = "Data Source=Shree0g\SQLEXPRESS;Initial Catalog=SpaMgtSys;Persist Security Info=True;User ID=sa;Password=Sql@Shree"
    Public IsAdmin As Integer
    Public UserId As Integer
    Public Function Login(ByVal Query As String, ByVal param As List(Of SqlParameter), ByVal CmdType As CommandType) As Integer
        Using Con As SqlConnection = New SqlConnection(_constr)
            Using Cmd As SqlCommand = New SqlCommand(Query, Con)
                Cmd.CommandType = CmdType
                If param IsNot Nothing Then
                    Cmd.Parameters.AddRange(param.ToArray())
                End If
                Con.Open()
                Using reader As SqlDataReader = Cmd.ExecuteReader()
                    reader.Read()
                    UserId = Convert.ToInt32(reader("UserId"))
                    IsAdmin = Convert.ToInt32(reader("IsAdmin"))
                End Using
                Con.Close()
            End Using
        End Using
        Return IsAdmin
    End Function
End Module
