Public Class Book
    '<snippet1>


    Public Sub New(ByVal isbn As String, ByVal title As String, _
        ByVal publishdate As DateTime, ByVal price As Double)

        Me.ISBN = isbn
        Me.Title = title
        Me.PublishDate = publishdate
        Me.Price = price
    End Sub

    'Define the public properties
    Private isbnValue As String
    Public Property ISBN() As String
        Get
            Return isbnValue
        End Get
        Set(ByVal value As String)
            isbnValue = value
        End Set
    End Property
    Private titleValue As String
    Public Property Title() As String
        Get
            Return titleValue
        End Get
        Set(ByVal value As String)
            titleValue = value
        End Set
    End Property

    Private publishDateValue As DateTime
    Public Property PublishDate() As DateTime
        Get
            Return publishDateValue
        End Get
        Set(ByVal value As DateTime)
            publishDateValue = value
        End Set
    End Property
    Private priceValue As Double
    Public Property Price() As Double
        Get
            Return priceValue
        End Get
        Set(ByVal value As Double)
            priceValue = value
        End Set
    End Property
    '</snippet1>

End Class
