'<snippet10> 
Imports System.Collections

Partial Public Class MainPage
    Inherits UserControl
    Private MyMusic As New List(Of Recording)()
    Public Sub New()
        InitializeComponent()

        ' Add items to the collection. 
        MyMusic.Add(New Recording("Chris Sells", "Chris Sells Live", _
            New DateTime(2008, 3, 5)))
        MyMusic.Add(New Recording("Chris Sells", "Sells Tells", _
            New DateTime(2004, 4, 6)))
        MyMusic.Add(New Recording("Luka Abrus", "The Road to Redmond", _
            New DateTime(2007, 8, 3)))
        MyMusic.Add(New Recording("Luka Abrus", "Luka", _
            New DateTime(2005, 12, 8)))
        MyMusic.Add(New Recording("Luka Abrus", "Love and Luka ", _
            New DateTime(2005, 11, 8)))
        MyMusic.Add(New Recording("Jim Hance", "The Best of Jim Hance", _
            New DateTime(2007, 2, 6)))

        ' Set the data context for the AutoCompleteBox. 
        myACB.DataContext = MyMusic
    End Sub
End Class

' Simple business object. 
Public Class Recording
    Public Sub New()
    End Sub
    Public Sub New(ByVal artistName As String, ByVal cdName As String, _
                   ByVal release As DateTime)
        Artist = artistName
        Name = cdName
        ReleaseDate = release
    End Sub
    Private _Artist As String
    Public Property Artist() As String
        Get
            Return _Artist
        End Get
        Set(ByVal value As String)
            _Artist = value
        End Set
    End Property
    Private _Name As String
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property
    Private _ReleaseDate As DateTime
    Public Property ReleaseDate() As DateTime
        Get
            Return _ReleaseDate
        End Get
        Set(ByVal value As DateTime)
            _ReleaseDate = value
        End Set
    End Property
End Class
'</snippet10> 