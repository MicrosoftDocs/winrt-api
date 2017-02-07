Imports System.Collections.ObjectModel

'<snippet2> 
Partial Public Class Page
    Inherits UserControl
    Public MyMusic As New ObservableCollection(Of Recording)()
    Public Sub New()
        InitializeComponent()
        MyMusic.Add(New Recording("Sheryl Crow", "Detours", New DateTime(2008, 2, 5)))
        MyMusic.Add(New Recording("Brandi Carlisle", "The Story", New DateTime(2007, 4, 3)))
        MyMusic.Add(New Recording("Patty Griffin", "Children Running Through", New DateTime(2007, 2, 6)))
        MusicCombo.DataContext = MyMusic
    End Sub
End Class

Public Class Recording
    Public Sub New()
    End Sub
    Public Sub New(ByVal artistName As String, ByVal cdName As String, ByVal release As DateTime)
        Artist = artistName
        Name = cdName
        ReleaseDate = release
    End Sub
    Private artistValue As String
    Private nameValue As String
    Private releaseDateValue As DateTime
    Private dateTi
    Public Property Artist() As String
        Get
            Return artistValue
        End Get
        Set(ByVal value As String)
            artistValue = value
        End Set
    End Property
    Public Property Name() As String
        Get
            Return nameValue
        End Get
        Set(ByVal value As String)
            nameValue = value
        End Set
    End Property
    Public Property ReleaseDate() As DateTime
        Get
            Return releaseDateValue
        End Get
        Set(ByVal value As DateTime)
            releaseDateValue = value
        End Set
    End Property
End Class
'</snippet2> 