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
            Dim strSql = "select * from Books left join Categories 
                          on Books.CategoryID = Categories.CategoryID 
                          left join Authors on Books.AuthorID=Authors.AuthorID
                          order by Books.Title"

            Dim results = conn.Query(Of Book, Category, Author, Book)(strSql, Function(b, c, a)
                                                                                  b.Category = c
                                                                                  b.Author = a
                                                                                  Return b
                                                                              End Function, splitOn:="CategoryID,AuthorID")
            Return results
        End Using
    End Function
End Class
