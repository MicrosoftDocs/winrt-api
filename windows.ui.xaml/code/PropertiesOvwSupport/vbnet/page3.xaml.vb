Imports System 
Imports System.Windows 
Imports System.Windows.Controls 
Imports System.Windows.Media 
Imports System.Windows.Input 


Namespace DPO 
    Public Partial Class Page3 
        Inherits UserControl 
        Private Sub DoStuff() 
            '<SnippetDPBasicPropSet> 
            myCanvas.Background = New SolidColorBrush(Colors.Green) 
            '</SnippetDPBasicPropSet> 
        End Sub 
        '<SnippetResourceProceduralGet> 
        Private Sub SetBGByResource(sender As Object, e As RoutedEventArgs)
            Dim b As Button = TryCast(sender, Button)
            b.Background = DirectCast(Me.Resources("RainbowBrush"), Brush)
        End Sub
        '</SnippetResourceProceduralGet> 
    End Class 
End Namespace