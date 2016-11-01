Imports System.Data.SqlClient
Imports Dapper
Imports System.Configuration
Imports BO
Public Class CategoryDAL
    Private Function GetConnStr() As String
        Return ConfigurationManager.ConnectionStrings("SampleShopDbConnectionString").ConnectionString
    End Function

    Public Function GetAll() As IEnumerable(Of Category)
        Using conn As New SqlConnection(GetConnStr())
            Dim strSql = "select * from Categories order by CategoryName"

            Dim results = conn.Query(Of Category)(strSql)

            Return results
        End Using
    End Function
End Class
