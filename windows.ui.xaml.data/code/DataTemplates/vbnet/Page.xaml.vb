'add namespaces 
Imports System.Windows.Data
Imports System.Collections.ObjectModel
Imports System.Windows.Media.Imaging
Imports System.Windows.Controls.Primitives

Partial Public Class Page
    Inherits UserControl

    Private MyThings As ObservableCollection(Of Thing)

    Public Sub New()
        InitializeComponent()

        '<Snippet2> 
        'Create collection 
        MyThings = New ObservableCollection(Of Thing)()

        'Create each object in the collection 
        Dim flower As New Thing("Flower", "flower.jpg")
        Dim snake As New Thing("Snake", "snake.jpg")
        Dim sunset As New Thing("Sunset", "sunset.jpg")

        'Add the objects to the collection 
        MyThings.Add(flower)
        MyThings.Add(snake)
        MyThings.Add(sunset)
        '</Snippet2> 

        '<Snippet5> 
        'LayoutRoot is the name of the root Grid 
        LayoutRoot.DataContext = MyThings
        '</Snippet5> 

    End Sub

End Class

'<Snippet1> 
Public Class Thing
    Public Sub New(ByVal title As String, ByVal imageUri As String)
        Me.Title = title
        Me.Photo = imageUri
    End Sub

    Private photoValue As String
    Private titleValue As String

    Public Property Photo() As String
        Get
            Return photoValue
        End Get
        Set(ByVal value As String)
            photoValue = value
        End Set
    End Property
    Public Property Title() As String
        Get
            Return titleValue
        End Get
        Set(ByVal value As String)
            titleValue = value
        End Set
    End Property

End Class
'</Snippet1> 
