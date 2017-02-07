Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
'<snippet11>
Imports System.Windows.Printing
'</snippet11>

'<snippet10>
Partial Public Class MainPage
    Inherits UserControl
    Private pd As PrintDocument()

    Public Sub New()
        InitializeComponent()
        pd = New PrintDocument()

    End Sub

    Private Sub PrintButton_Click(ByVal sender As Object, _
            ByVal e As RoutedEventArgs)
        pd.Print("M yMap")
    End Sub

    Private Sub pd_PrintPage(ByVal sender As Object, _
            ByVal e As PrintPageEventArgs) Handles pd.PrintPage
        e.PageVisual = mapImage
    End Sub
End Class
'</snippet10>
