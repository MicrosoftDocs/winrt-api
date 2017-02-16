'<Snippet10_VB>
Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports System.Collections.ObjectModel

Partial Public Class Page
    Inherits UserControl
    Public Sub New()
        ' Required to initialize variables 
        InitializeComponent()
    End Sub

    '<Snippet111_VB>
    Private Sub PrintText(ByVal sender As Object, ByVal args As SelectionChangedEventArgs)
        Dim lbi As ListBoxItem = TryCast(TryCast(sender, ListBox).SelectedItem, ListBoxItem)
        textBlock1.Text = " You selected " + lbi.Content.ToString() + "."
    End Sub
    '</Snippet111_VB>

End Class


'<Snippet101_VB>
Public Class Customer
    Private _firstName As String
    Private _lastName As String
    Private _address As String

    Public Property FirstName() As String
        Get
            Return _firstName
        End Get

        Set(ByVal value As String)
            _firstName = value
        End Set
    End Property

    Public Property LastName() As String
        Get
            Return _lastName
        End Get

        Set(ByVal value As String)
            _lastName = value
        End Set
    End Property

    Public Property Address() As String
        Get
            Return _address
        End Get

        Set(ByVal value As String)
            _address = value
        End Set
    End Property

    Public Sub New(ByVal firstName As String, ByVal lastName As String, ByVal address As String)
        Me.FirstName = firstName
        Me.LastName = lastName
        Me.Address = address
    End Sub

End Class

Public Class Customers
    Inherits ObservableCollection(Of Customer)

    Public Sub New()
        Add(New Customer("Michael", "Anderberg", "12 North Third Street, Apartment 45"))
        Add(New Customer("Chris", "Ashton", "34 West Fifth Street, Apartment 67"))
        Add(New Customer("Seo-yun", "Jun", "56 East Seventh Street, Apartment 89"))
        Add(New Customer("Guido", "Pica", "78 South Ninth Street, Apartment 10"))
    End Sub

End Class
' </Snippet101_VB>

'</Snippet10_VB>