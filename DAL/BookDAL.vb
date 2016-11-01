Imports System.Data.SqlClient
Imports Dapper
Imports System.Configuration
Imports BO

Public Class BookDAL
    Private Function GetConnStr() As String
        Return ConfigurationManager.ConnectionStrings("SampleShopDbConnectionString").ConnectionString
    End Function

    Public Function GetAll() As IEnumerable(Of Book)
        Using conn As New SqlConnection(GetConnStr())
            Dim strSql = "select * from Books left join Categories " &
                "on Books.CategoryID = Categories.CategoryID " &
                "order by Books.Title"

            Dim results = conn.Query(Of Book, Category, Book)(strSql, Function(b, c)
                                                                          b.Category = c
                                                                          Return b
                                                                      End Function, splitOn:="CategoryID")
            Return results
        End Using
    End Function
End Class
