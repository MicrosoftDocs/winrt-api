Imports System 
Imports System.Windows 
Imports System.Windows.Controls 
Imports System.Windows.Media 
Imports System.Windows.Input 
Imports System.Collections.Generic 


Namespace AquariumLibrary

    Partial Public Class SilverlightExampleClass
        Inherits UserControl
        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub UpdateFish(ByVal sender As Object, ByVal e As EventArgs)
            'Fish f = (Fish) aq.AquariumContents[0]; 
            'f.Species = "Guppy"; 
        End Sub
    End Class

    Public Class Fish
        Inherits Control
        Public Shared ReadOnly SpeciesProperty As DependencyProperty = DependencyProperty.Register("Species", GetType(String), GetType(Fish), Nothing)
        Public Property Species() As String
            Get
                Return DirectCast(GetValue(SpeciesProperty), String)
            End Get
            Set(ByVal value As String)
                SetValue(SpeciesProperty, DirectCast(value, String))
            End Set
        End Property
    End Class
    Public Class FishCollection
        Inherits List(Of Fish)
        Public Sub New()
        End Sub
    End Class
    Public Class Aquarium
        Inherits Canvas
        Private Shared ReadOnly AquariumContentsProperty As DependencyProperty = DependencyProperty.Register("AquariumContents", GetType(List(Of Fish)), GetType(Aquarium), Nothing)
        Public ReadOnly Property AquariumContents() As List(Of Fish)
            Get
                Return DirectCast(GetValue(AquariumContentsProperty), List(Of Fish))
            End Get
        End Property
        Public Sub New()
            MyBase.New()
            SetValue(AquariumContentsProperty, New List(Of Fish)())
        End Sub
    End Class
End Namespace