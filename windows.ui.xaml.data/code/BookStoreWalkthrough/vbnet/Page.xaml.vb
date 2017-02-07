Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
'<snippet20>
Imports System.Collections.ObjectModel
'</snippet20>
'<snippet80>
Imports System.Windows.Data
'</snippet80>
Partial Public Class Page
    Inherits UserControl


    Public Sub New()
        InitializeComponent()
        '<snippet4>
        ' You can add items to your collection.
        AllBooks.Add(New Book("4458907683", "Training Your Dog", _
            New DateTime(2000, 2, 8), 44.25))
        AllBooks.Add(New Book("0446675385", "Good Owners, Great Dogs", _
            New DateTime(1999, 9, 1), 15.99))

        'Set the data context for the list of books
        MyBooks.DataContext = AllBooks
        '</snippet4>

        '<snippet6>
        AddHandler MyBooks.SelectionChanged, AddressOf Me.MyBooks_SelectionChanged
        MyBooks.SelectedIndex = 0
        '</snippet6>
    End Sub


    '<snippet2>
    ' Create a collection to store data items.
    Private _AllBooks As ObservableCollection(Of Book)
    Public ReadOnly Property AllBooks() As ObservableCollection(Of Book)
        Get
            If (_AllBooks Is Nothing) Then
                _AllBooks = New ObservableCollection(Of Book)
                _AllBooks.Add(New Book("3390092284", "All About Dogs", _
                    New DateTime(2004, 3, 4), 12.99))
            End If
            Return _AllBooks
        End Get
    End Property
    '</snippet2>

    '<snippet7>
    Private Sub MyBooks_SelectionChanged(ByVal sender As Object, _
            ByVal e As SelectionChangedEventArgs)
        Dim myBooks As ListBox = CType(sender, ListBox)
        BookDetails.DataContext = myBooks.SelectedItem
    End Sub
    '</snippet7>
End Class
