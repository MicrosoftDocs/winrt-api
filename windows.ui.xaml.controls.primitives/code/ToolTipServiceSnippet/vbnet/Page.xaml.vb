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

        '<snippet2> 
        Private Sub Button_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ToolTipService.SetToolTip(DirectCast(sender, Button), "Adding tool tip through code")
        End Sub
    End Class
    '</snippet2> 
