'<Snippet2> 
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls

Partial Public Class NameReporter
    Inherits UserControl
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim displayText As New StringBuilder("Hello, ")
        'displayText.AppendFormat("{0} {1}.", firstName.Text, lastName.Text)

        MessageBox.Show(displayText.ToString())
    End Sub

End Class
'</Snippet2> 