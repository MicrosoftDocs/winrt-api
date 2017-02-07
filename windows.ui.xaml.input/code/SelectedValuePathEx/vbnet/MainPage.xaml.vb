Partial Public Class MainPage
    Inherits UserControl

    '<snippetCodeBehind>
    Public MyDocs As System.Collections.ObjectModel.ObservableCollection(Of Document) =
        New System.Collections.ObjectModel.ObservableCollection(Of Document)

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        ' Add items to the collection.
        MyDocs.Add(New Document("How to: Use SelectedValuePath"))
        MyDocs.Add(New Document("DataGrid Overview"))
        MyDocs.Add(New Document("Silverlight Designer Overview"))
        comboBox1.DataContext = MyDocs
        textBlock2.DataContext = comboBox1
    End Sub
End Class

' Simple business object.
Public Class Document
    Private nameValue As String
    Private guidValue As Guid

    Public Sub New()
        MyBase.New()

    End Sub

    Public Sub New(ByVal docName As String)
        MyBase.New()
        guidValue = Guid.NewGuid()
        Name = docName
    End Sub

    Public Property Name As String
        Get

            Return nameValue

        End Get
        Set(ByVal value As String)
            nameValue = value
        End Set

    End Property

    Public Property ID As Guid
        Get
            Return guidValue
        End Get
        Set(ByVal value As Guid)
            guidValue = value
        End Set

    End Property
End Class
' </snippetCodeBehind>