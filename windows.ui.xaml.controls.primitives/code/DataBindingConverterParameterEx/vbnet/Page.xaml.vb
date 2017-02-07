' <snippet2>
Imports System.Collections.ObjectModel
Imports System.Windows.Data
Imports System.Globalization

Partial Public Class Page
    Inherits UserControl

    Public MyMusic As New ObservableCollection(Of Recording)()
    Public Sub New()
        InitializeComponent()

        ' Add items to the collection.
        MyMusic.Add(New Recording("Sheryl Crow", "Detours", New DateTime(2008, 2, 5)))
        MyMusic.Add(New Recording("Brandi Carlisle", "The Story", New DateTime(2007, 4, 3)))
        MyMusic.Add(New Recording("Patty Griffin", "Children Running Through", New DateTime(2007, 2, 6)))

        ' Set the data context for the combo box.
        MusicCombo.DataContext = MyMusic
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
    Private artistValue As String
    Private nameValue As String
    Private releaseDateValue As DateTime
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

Public Class DateFormatter
    Implements IValueConverter

    ' This converts the DateTime object to the string to display. 
    Public Function Convert(ByVal value As Object, ByVal targetType As Type, _
        ByVal parameter As Object, ByVal language As System.String) As Object _
        Implements IValueConverter.Convert

        ' Retrieve the format string and use it to format the value. 
        Dim formatString As String = TryCast(parameter, String)
        If Not String.IsNullOrEmpty(formatString) Then

            Return String.Format(New CultureInfo(language), formatString, value)
        End If

        ' If the format string is null or empty, simply call ToString() 
        ' on the value. 
        Return value.ToString()
    End Function

    ' No need to implement converting back on a one-way binding.
    Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, _
        ByVal parameter As Object, _
        ByVal language As System.String) As Object _
        Implements IValueConverter.ConvertBack
        Throw New NotImplementedException()
    End Function
End Class
' </snippet2>

