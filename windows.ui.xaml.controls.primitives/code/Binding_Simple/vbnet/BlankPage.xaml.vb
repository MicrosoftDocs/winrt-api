Imports Windows.UI

Public NotInheritable Class BlankPage
    Inherits Page

    Public Sub New()
        InitializeComponent()

        '<SnippetDataContext> 
        ' Create an instance of the MyColors class 
        ' that implements INotifyPropertyChanged. 
        Dim textcolor As New MyColors()

        ' Brush1 is set to be a SolidColorBrush with the value Red. 
        textcolor.Brush1 = New SolidColorBrush(Colors.Red)

        ' Set the DataContext of the TextBox MyTextBox. 
        MyTextBox.DataContext = textcolor
        '</SnippetDataContext> 

    End Sub

    '<Snippet1> 
    ' Create a class that implements INotifyPropertyChanged. 
    Public Class MyColors
        Implements INotifyPropertyChanged
        Private _Brush1 As SolidColorBrush

        ' Declare the PropertyChanged event. 
        Public Event PropertyChanged As PropertyChangedEventHandler _
            Implements INotifyPropertyChanged.PropertyChanged

        ' Create the property that will be the source of the binding. 
        Public Property Brush1() As SolidColorBrush
            Get
                Return _Brush1
            End Get
            Set(ByVal value As SolidColorBrush)
                _Brush1 = value
                ' Call NotifyPropertyChanged when the source property 
                ' is updated. 
                NotifyPropertyChanged("Brush1")
            End Set
        End Property


        ' NotifyPropertyChanged will raise the PropertyChanged event, 
        ' passing the source property that is being updated. 
        Public Sub NotifyPropertyChanged(ByVal propertyName As String)
            RaiseEvent PropertyChanged(Me, _
                New PropertyChangedEventArgs(propertyName))
        End Sub


    End Class
    '</Snippet1> 

End Class
