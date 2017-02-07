Partial Public Class Page
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

End Class

'<Snippet4> 
Public Class Dog
    Private _DogName As String
    Public Property DogName() As String
        Get
            Return _DogName
        End Get
        Set(ByVal value As String)
            _DogName = value
        End Set
    End Property
End Class
'</Snippet4> 