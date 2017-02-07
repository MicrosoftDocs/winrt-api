Imports DPO

Namespace PropertiesOvwSupport


    Partial Public Class Page
        Inherits UserControl
        Public Sub New()
            InitializeComponent()
        End Sub
        Private myapp As Application = Application.Current
        Private Sub ToOne(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.LayoutRoot.Children(0) = New DPO.Page1()
            Me.UpdateLayout()
        End Sub
        Private Sub ToTwo(ByVal sender As Object, ByVal e As RoutedEventArgs)
            'this.LayoutRoot.Children[0] = new Page2(); 
        End Sub
        Private Sub ToThree(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.LayoutRoot.Children(0) = New DPO.Page3()
            Me.UpdateLayout()
        End Sub
        Private Sub ToFour(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.LayoutRoot.Children(0) = New DPO.SilverlightExampleClass()
            Me.UpdateLayout()
        End Sub
        Private Sub ToFive(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.LayoutRoot.Children(0) = New AquariumLibrary.SilverlightExampleClass()
            Me.UpdateLayout()
        End Sub
    End Class
End Namespace