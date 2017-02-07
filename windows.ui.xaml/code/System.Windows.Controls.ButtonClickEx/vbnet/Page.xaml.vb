
Imports System 
Imports System.Collections.Generic 
Imports System.Linq 
Imports System.Net 
Imports System.Windows 
Imports System.Windows.Controls 
Imports System.Windows.Documents 
Imports System.Windows.Input 
Imports System.Windows.Media 
Imports System.Windows.Media.Animation 
Imports System.Windows.Shapes 


Partial Public Class Page
    Inherits UserControl
    Public Sub New()
        InitializeComponent()
    End Sub

    '<snippet41> 
    Private Sub submitButtonClick(ByVal sender As Object, ByVal e As RoutedEventArgs)
        textBlock1.Text = "You clicked the Submit button."
    End Sub
'</snippet41> 
End Class

