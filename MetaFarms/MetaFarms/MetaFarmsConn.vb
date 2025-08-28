Imports MySql.Data.MySqlClient

Module MetaFarmsConn
    Private dbConn As MySqlConnection
    Private sqlCommand As MySqlCommand
    Private da As MySqlDataAdapter
    Private dt As DataTable

    'connenction string
    Private strConn = "server=localhost; user id=root; database=metafarmsdb"

    Public Sub dbConnection()
        dbConn = New MySqlConnection(strConn)
        'dbConn.ConnectionString = strConn

        dbConn.Open()
        MessageBox.Show("Test connection successful!")
        dbConn.Close()

    End Sub

    Public Sub displayRecords(ByVal SQL As String, ByVal DG As DataGridView)
        dbConn.Open()
        da = New MySqlDataAdapter(SQL, dbConn)
        dt = New DataTable
        da.Fill(dt) ' fill or populate records to dt thru da
        DG.DataSource = dt ' keep and send the records to Datagridview in the GUI
        dbConn.Close()
    End Sub

    Public Sub SQLManager(ByVal SQL As String)
        dbConn.Open()
        sqlCommand = New MySqlCommand(SQL, dbConn)
        Try
            With sqlCommand
                .CommandType = CommandType.Text
                '.CommandText = SQL
                '.Connection = dbConn
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
        End Try

        dbConn.Close()
    End Sub
    Public Function IdSearch(query As String) As String
        Dim Ivalue As String
        dbConn.Open()
        Dim cmd As MySqlCommand = New MySqlCommand(query, dbConn)
        Ivalue = cmd.ExecuteScalar()

        dbConn.Close()
        Return Ivalue
    End Function
End Module
