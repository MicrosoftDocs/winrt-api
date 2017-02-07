'<Snippet1> 
'Add Imports statements 
Imports System.ComponentModel
Imports System.Windows.Data
'</Snippet1> 


Partial Public Class Page
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

End Class

'<Snippet2> 
' Create a class that implements INotifyPropertyChanged 
Public Class Person
    Implements INotifyPropertyChanged

    Private firstNameValue As String
    Public Property FirstName() As String
        Get
            Return firstNameValue
        End Get
        Set(ByVal value As String)
            firstNameValue = value
            ' Call NotifyPropertyChanged when the property is updated 
            NotifyPropertyChanged("FirstName")
        End Set
    End Property

    ' Declare the PropertyChanged event 
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    ' NotifyPropertyChanged will raise the PropertyChanged event passing the 
    ' source property that is being updated. 
    Public Sub NotifyPropertyChanged(ByVal propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
End Class
'</Snippet2> 
