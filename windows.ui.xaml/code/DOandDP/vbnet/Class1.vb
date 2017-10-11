Public Class Class1

End Class

'<SnippetDOMain>
Public Class AquariumServices
    Inherits DependencyObject
    Public Enum Buoyancy
        Floats
        Sinks
        Drifts
    End Enum

    Public Shared ReadOnly BuoyancyProperty As DependencyProperty = _
          DependencyProperty.RegisterAttached(
          "Buoyancy", _
          GetType(Buoyancy), _
          GetType(AquariumServices), _
          New PropertyMetadata(Buoyancy.Floats))


    Public Sub SetBuoyancy(element As DependencyObject, value As Buoyancy)
        element.SetValue(BuoyancyProperty, value)
    End Sub
    Public Function GetBuoyancy(element As DependencyObject) As Buoyancy
        GetBuoyancy = CType(element.GetValue(BuoyancyProperty), Buoyancy)
    End Function
End Class
'</SnippetDOMain>

'<SnippetDOSimpleDP>
Public Class Fish
    Inherits Control

    Public Shared ReadOnly SpeciesProperty As DependencyProperty = _
    DependencyProperty.Register(
    "Species", _
    GetType(String), _
    GetType(Fish), _
    Nothing)
    Public Property Species As String
        Get
            Species = CType(GetValue(SpeciesProperty), String)
        End Get
        Set(value As String)
            SetValue(SpeciesProperty, value)
        End Set
    End Property
End Class
'</SnippetDOSimpleDP>
Public Class DependencyPropertyUtilities

    '<SnippetDOCheckClear>
    Public Shared Function ClearSetProperty(targetObject As DependencyObject, targetDP As DependencyProperty) As Boolean
        If targetObject Is Nothing Or targetDP Is Nothing Then
            Throw New ArgumentNullException()
        End If
        Dim localValue As Object = targetObject.ReadLocalValue(targetDP)
        If localValue = DependencyProperty.UnsetValue Then
            ClearSetProperty = False
        Else
            targetObject.ClearValue(targetDP)
            ClearSetProperty = True
        End If
    End Function
    '</SnippetDOCheckClear>
    '<SnippetDPGetMetadata>
    Public Shared Function GetDefaultValueForFrameworkDP(dpIdentifier As DependencyProperty) As Object
        Dim metadataInfo As PropertyMetadata = dpIdentifier.GetMetadata(GetType(FrameworkElement))
        GetDefaultValueForFrameworkDP = metadataInfo.DefaultValue
    End Function
    '</SnippetDPGetMetadata>
End Class