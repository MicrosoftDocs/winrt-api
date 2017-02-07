'<snippetCodeBehind>
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
Imports System.Windows.Threading

Partial Public Class MainPage
    Inherits UserControl
    Private WithEvents dt As New DispatcherTimer()
    Public Sub New()
        InitializeComponent()
        dt.Interval = New TimeSpan(100)
    End Sub

    Private Sub dt_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles dt.Tick

        htmlBrush.Redraw()
    End Sub

    Private animating As Boolean = False

    Private Sub LayoutRoot_PointerMoved(ByVal sender As Object, ByVal e As PointerRoutedEventArgs)
        dt.Start()
        If Not animating Then
            WB1.Visibility = Visibility.Collapsed
            Brush.Visibility = Visibility.Visible
            Spin.Begin()
            animating = True
        End If
    End Sub

    Private Sub brush_PointerPressed(ByVal sender As Object, ByVal e As PointerRoutedEventArgs)
        Spin.[Stop]()
        WB1.Visibility = Visibility.Visible
        Brush.Visibility = Visibility.Collapsed
        animating = False
    End Sub
End Class

'</snippetCodeBehind>
