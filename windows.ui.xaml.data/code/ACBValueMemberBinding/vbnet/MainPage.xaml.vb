'<snippet10> 
Imports System.Windows.Data

Partial Public Class MainPage
    Inherits UserControl
    Private MyMusic As New List(Of Recording)()
    Public Sub New()
        InitializeComponent()

        ' Add items to the collection. 
        MyMusic.Add(New Recording("Chris Sells", "Chris Sells Live", New DateTime(2008, 3, 5)))
        MyMusic.Add(New Recording("Chris Sells", "Chris Sells", New DateTime(2004, 4, 6)))
        MyMusic.Add(New Recording("Luka Abrus", "The Road to Redmond", New DateTime(2007, 8, 3)))
        MyMusic.Add(New Recording("Luka Abrus", "Luka", New DateTime(2005, 12, 8)))
        MyMusic.Add(New Recording("Jim Hance", "The Best of Jim Hance", New DateTime(2007, 2, 6)))

        ' Set the data context for the AutoCompleteBox. 
        myACB.DataContext = MyMusic
        AddHandler myACB.SelectionChanged, AddressOf myACB_SelectionChanged
    End Sub

    ' Handle the SelectionChanged event-setting the data context for the stack panel 
    ' that contains the details to the selected item. 
    Private Sub myACB_SelectionChanged(ByVal sender As Object, ByVal e As SelectionChangedEventArgs)
        RecordingDetails.DataContext = e.AddedItems(0)
        Dim acb As AutoCompleteBox = TryCast(sender, AutoCompleteBox)
    End Sub
End Class

    ' Simple business object. 
    Public Class Recording
        Public Sub New()
        End Sub
        Public Sub New(ByVal artistName As String, ByVal cdName As String, ByVal release As DateTime)
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

    Public Class ObjectFormatter
        Implements IValueConverter
        ' This converts the object to the string to display. 
    Public Function Convert(ByVal value As Object, ByVal targetType As Type, _
                            ByVal parameter As Object, _
                            ByVal culture As System.Globalization.CultureInfo) As Object _
                            Implements IValueConverter.Convert

        ' Retrieve the format string and use it to format the value. 
        Dim formatString As String = TryCast(parameter, String)
        If Not String.IsNullOrEmpty(formatString) Then
            Return String.Format(culture, formatString, value)
        End If

        ' If the format string is null or empty, simply call ToString() 
        ' on the value. 
        Return value.ToString()
    End Function

        ' No need to implement converting back on a one-way binding 
    Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, _
                                ByVal parameter As Object, _
                                ByVal culture As System.Globalization.CultureInfo) As Object _
                                Implements IValueConverter.ConvertBack
        Throw New NotImplementedException()
    End Function
    End Class

'</snippet10> 