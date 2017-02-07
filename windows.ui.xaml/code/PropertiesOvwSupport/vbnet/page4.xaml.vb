Imports System 
Imports System.Windows 
Imports System.Windows.Controls 
Imports System.Windows.Media 
Imports System.Windows.Input 
Imports System.Collections.Generic 

Namespace DPO 
    Partial Public Class SilverlightExampleClass
        Inherits UserControl
        Private Sub MakeANewThing(ByVal sender As Object, ByVal e As RoutedEventArgs)
            '<SnippetAPCode> 
            Dim myC As New Canvas()
            Dim myCheckBox As New CheckBox()
            myCheckBox.Content = "Hello"
            myC.Children.Add(myCheckBox)
            Canvas.SetTop(myCheckBox, 75)
            '</SnippetAPCode> 
        End Sub
        '<SnippetDPFormBasic> 
        Public Shared ReadOnly IsSpinningProperty As DependencyProperty = _
            DependencyProperty.Register("IsSpinning", _
            GetType(Boolean), _
            GetType(SilverlightExampleClass), _
            Nothing)
        Public Property IsSpinning() As Boolean
            Get
                Return CBool(GetValue(IsSpinningProperty))
            End Get
            Set(ByVal value As Boolean)
                SetValue(IsSpinningProperty, value)
            End Set
        End Property
        '</SnippetDPFormBasic> 
        Private Sub DoAqStuff()
            '<SnippetCollectionProblemTestCode> 
            Dim myAq1 As New Aquarium()
            Dim myAq2 As New Aquarium()
            Dim f1 As New Fish()
            Dim f2 As New Fish()
            myAq1.AquariumContents.Add(f1)
            myAq2.AquariumContents.Add(f2)
            '</SnippetCollectionProblemTestCode> 
        End Sub
        Private Sub BAQ(ByVal sender As Object, ByVal e As EventArgs)
            DoAqStuff()
        End Sub
    End Class
    '<SnippetCollectionProblemDefinition> 
    Public Class Fish 
        Inherits Control 
        Public Sub New() 
            
        End Sub 
    End Class 
    Public Class Aquarium 
        Inherits Control 
        Private Shared ReadOnly AquariumContentsProperty As DependencyProperty = _
            DependencyProperty.Register( _
            "AquariumContents", _
            GetType(List(Of FrameworkElement)), _
            GetType(Aquarium), _
            Nothing)
        
        Public ReadOnly Property AquariumContents() As List(Of FrameworkElement) 
            Get 
                Return DirectCast(GetValue(AquariumContentsProperty), List(Of FrameworkElement)) 
            End Get 
        End Property 
        '</SnippetCollectionProblemDefinition> 
        
        '<SnippetCollectionProblemCtor> 
        Public Sub New() 
            MyBase.New() 
            SetValue(AquariumContentsProperty, New List(Of FrameworkElement)()) 
        End Sub 
    End Class 
    '</SnippetCollectionProblemCtor> 
    
    '<SnippetCollectionProblemEndB> 
End Namespace 
'</SnippetCollectionProblemEndB> 