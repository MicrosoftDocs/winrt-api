Partial Public Class MainPage
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
        '<snippet10>
        myACB.ItemsSource = New String() {"London", "Paris", _
            "Johannesburg", "Bucharest", "Berlin", "Lisbon", "New York", _
            "Nairobi", "Seattle", "Mexico City", "Vancouver"}
        '</snippet10>
    End Sub

End Class