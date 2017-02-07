Public Class Class1


    '<SnippetClickHandler>
    Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        MessageBox.Show("The button has been clicked.")
    End Sub
    '</SnippetClickHandler>
End Class

Public Class Control

End Class
Public Class ContentPresenter

End Class
Public Class Popup

End Class

Public Class ItemsControl

End Class

Public Class ButtonBase

End Class

'<SnippetStateContract>
<TemplateVisualStateAttribute(Name:="Pressed", GroupName:="CommonStates")> _
<TemplateVisualStateAttribute(Name:="Focused", GroupName:="FocusStates")> _
<TemplateVisualStateAttribute(Name:="Normal", GroupName:="CommonStates")> _
<TemplateVisualStateAttribute(Name:="MouseOver", GroupName:="CommonStates")> _
<TemplateVisualStateAttribute(Name:="Disabled", GroupName:="CommonStates")> _
<TemplateVisualStateAttribute(Name:="Unfocused", GroupName:="FocusStates")> _
Public Class Button
    Inherits ButtonBase

End Class
'</SnippetStateContract>

'<SnippetComboBoxContract>
<TemplatePartAttribute(Name:="ContentPresenter", Type:=GetType(ContentPresenter))> _
<TemplatePartAttribute(Name:="Popup", Type:=GetType(Popup))> _
Public Class ComboBox
    Inherits ItemsControl

End Class
'</SnippetComboBoxContract>

Namespace ButtonContract

    '<Snippet2>
    <TemplateVisualState(Name:="Normal", GroupName:="CommonStates")> _
    <TemplateVisualState(Name:="MouseOver", GroupName:="CommonStates")> _
    <TemplateVisualState(Name:="Pressed", GroupName:="CommonStates")> _
    <TemplateVisualState(Name:="Disabled", GroupName:="CommonStates")> _
    <TemplateVisualState(Name:="Unfocused", GroupName:="FocusStates")> _
    <TemplateVisualState(Name:="Focused", GroupName:="FocusStates")> _
    Public Class Button
        Inherits ButtonBase

        Public Shared ReadOnly BackgroundProperty As DependencyProperty
        Public Shared ReadOnly BorderBrushProperty As DependencyProperty
        Public Shared ReadOnly BorderThicknessProperty As DependencyProperty
        Public Shared ReadOnly ContentProperty As DependencyProperty
        Public Shared ReadOnly ContentTemplateProperty As DependencyProperty
        Public Shared ReadOnly FontFamilyProperty As DependencyProperty
        Public Shared ReadOnly FontSizeProperty As DependencyProperty
        Public Shared ReadOnly FontStretchProperty As DependencyProperty
        Public Shared ReadOnly FontStyleProperty As DependencyProperty
        Public Shared ReadOnly FontWeightProperty As DependencyProperty
        Public Shared ReadOnly ForegroundProperty As DependencyProperty
        Public Shared ReadOnly HorizontalContentAlignmentProperty As DependencyProperty
        Public Shared ReadOnly PaddingProperty As DependencyProperty
        Public Shared ReadOnly TextAlignmentProperty As DependencyProperty
        Public Shared ReadOnly TextDecorationsProperty As DependencyProperty
        Public Shared ReadOnly TextWrappingProperty As DependencyProperty
        Public Shared ReadOnly VerticalContentAlignmentProperty As DependencyProperty

        Public Background As Brush
        Public BorderBrush As Brush
        Public BorderThickness As Thickness
        Public Content As Object
        Public ContentTemplate As DataTemplate
        Public FontFamily As FontFamily
        Public FontSize As Double
        Public FontStretch As FontStretch
        Public FontStyle As FontStyle
        Public FontWeight As FontWeight
        Public Foreground As Brush
        Public HorizontalContentAlignment As HorizontalAlignment
        Public Padding As Thickness
        Public TextAlignment As TextAlignment
        Public TextDecorations As TextDecorationCollection
        Public TextWrapping As TextWrapping
        Public VerticalContentAlignment As VerticalAlignment
    End Class

    '</Snippet2>


End Namespace