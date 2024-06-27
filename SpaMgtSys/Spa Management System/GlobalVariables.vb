Imports System.Data.SqlClient

Public Module GlobalVariables
    Public _constr As String = "Data Source=SHRIYANKA\SQLEXPRESS;Initial Catalog=SpaMgtSys;Persist Security Info=True;User ID=sa;Password=Saroj@Shree"
    Public IsAdmin As Integer = 0
    Public UserId As Integer = 0
    Public Key As Integer = 0
    Public i As Integer = 0
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
            End Using
        End Using
        Return IsAdmin
    End Function
    Public Function InsertUpdateDelete(ByVal Query As String, ByVal param As List(Of SqlParameter), ByVal CmdType As CommandType) As Integer
        Using Con As SqlConnection = New SqlConnection(_constr)
            Using Cmd As SqlCommand = New SqlCommand(Query, Con)
                Cmd.CommandType = CmdType
                If param IsNot Nothing Then
                    Cmd.Parameters.AddRange(param.ToArray())
                End If
                Try
                    Con.Open()
                    Cmd.ExecuteNonQuery()
                    Return 0
                Catch ex As Exception
                    MsgBox("Exception: " & ex.Message.ToString)
                    Return -1
                End Try
            End Using
        End Using
    End Function
    Public Function Search(ByVal Query As String, ByVal param As List(Of SqlParameter), ByVal CmdType As CommandType) As DataSet
        Using Con As SqlConnection = New SqlConnection(_constr)
            Using Cmd As SqlCommand = New SqlCommand(Query, Con)
                Cmd.CommandType = CmdType
                If param IsNot Nothing Then
                    Cmd.Parameters.AddRange(param.ToArray())
                End If
                Dim Adapter As New SqlDataAdapter(Cmd)
                Dim builder As New SqlCommandBuilder(Adapter)
                Dim Ds As New DataSet()
                Adapter.Fill(Ds)
                Return Ds
            End Using
        End Using
    End Function
End Module
