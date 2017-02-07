Imports System.Collections.ObjectModel

Partial Public Class Page
    Inherits UserControl

    Public Sub New()


        InitializeComponent()
        '<snippet71> 
        '<snippet81> 
        Dim Uris As New ObservableCollection(Of Uri)()
        Uris.Add(New Uri("http://www.contoso.com"))
        Uris.Add(New Uri("http://www.tailspintoys.com"))
        Uris.Add(New Uri("http://www.cohowinery.com/"))
        '</snippet81> 

        UriBox1.ItemsSource = Uris
        '</snippet71> 

        '<snippet82> 
        UriBox2.DataContext = Uris
        '</snippet82> 

        '<snippet91> 
        UriGrid1.ItemsSource = Uris
        '</snippet91> 

        '<snippet101> 
         UriGrid2.DataContext = Uris
  	'</snippet101> 
    End Sub


End Class