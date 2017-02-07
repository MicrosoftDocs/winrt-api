'<SnippetControlLogic> 
Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Input

'<SnippetClassAttributes> 
<TemplatePart(Name:="TextElement", Type:=GetType(TextBlock))> _
<TemplatePart(Name:="UpButtonElement", Type:=GetType(RepeatButton))> _
<TemplatePart(Name:="DownButtonElement", Type:=GetType(RepeatButton))> _
<TemplateVisualState(Name:="Positive", GroupName:="ValueStates")> _
<TemplateVisualState(Name:="Negative", GroupName:="ValueStates")> _
<TemplateVisualState(Name:="Focused", GroupName:="FocusedStates")> _
<TemplateVisualState(Name:="Unfocused", GroupName:="FocusedStates")> _
Public Class NumericUpDown
    Inherits Control
    '</SnippetClassAttributes> 
    Public Sub New()
        DefaultStyleKey = GetType(NumericUpDown)
        Me.IsTabStop = True
    End Sub

    Public Shared ReadOnly ValueProperty As DependencyProperty = _
        DependencyProperty.Register("Value", GetType(Integer), _
            GetType(NumericUpDown), _
            New PropertyMetadata(0, New PropertyChangedCallback(AddressOf ValueChangedCallback)))


    '<SnippetEntireValueChangedCallback> 
    '<SnippetValueChangedCallback> 
    Private Shared Sub ValueChangedCallback(ByVal obj As DependencyObject, _
                        ByVal args As DependencyPropertyChangedEventArgs)

        Dim ctl As NumericUpDown = DirectCast(obj, NumericUpDown)
        Dim newValue As Integer = args.NewValue

        ' Update the TextElement to the new value. 
        If ctl.TextElement IsNot Nothing Then
            ctl.TextElement.Text = newValue.ToString()
        End If

        '</SnippetValueChangedCallback> 
        ' Call UpdateStates because the Value might have caused the 
        ' control to change ValueStates. 
        ctl.UpdateStates(True)

        ' Raise the ValueChanged event so applications can be alerted 
        ' when Value changes. 
        Dim e As New ValueChangedEventArgs(newValue)
        ctl.OnValueChanged(e)
        '<SnippetValueChangedCallbackEnd> 
    End Sub
    '</SnippetValueChangedCallbackEnd> 
    '</SnippetEntireValueChangedCallback> 


    Public Event ValueChanged As ValueChangedEventHandler

    Protected Overridable Sub OnValueChanged(ByVal e As ValueChangedEventArgs)

        RaiseEvent ValueChanged(Me, e)

    End Sub

    '<SnippetUpdateStates> 
    Private Sub UpdateStates(ByVal useTransitions As Boolean)
        '<SnippetValueStateChange> 
        If Value >= 0 Then
            VisualStateManager.GoToState(Me, "Positive", useTransitions)
        Else
            VisualStateManager.GoToState(Me, "Negative", useTransitions)
        End If
        '</SnippetValueStateChange> 

        If isFocused Then
            VisualStateManager.GoToState(Me, "Focused", useTransitions)
        Else
            VisualStateManager.GoToState(Me, "Unfocused", useTransitions)
        End If

    End Sub
    '</SnippetUpdateStates> 

    Public Property Value() As Integer
        Get
            Return CInt(GetValue(ValueProperty))
        End Get

        Set(ByVal value As Integer)

            SetValue(ValueProperty, value)
        End Set
    End Property


    '<SnippetApplyTemplate> 
    Protected Overloads Sub OnApplyTemplate()
        UpButtonElement = TryCast(GetTemplateChild("UpButton"), RepeatButton)
        DownButtonElement = TryCast(GetTemplateChild("DownButton"), RepeatButton)
        TextElement = TryCast(GetTemplateChild("TextBlock"), TextBlock)

        UpdateStates(False)
    End Sub
    '</SnippetApplyTemplate> 

    Private m_textElement As TextBlock

    Private Property TextElement() As TextBlock
        Get
            Return m_textElement
        End Get

        Set(ByVal txtBlock As TextBlock)
            m_textElement = txtBlock

            If m_textElement IsNot Nothing Then
                m_textElement.Text = Value.ToString()
                m_textElement.IsHitTestVisible = True
            End If
        End Set
    End Property


    Private m_downButtonElement As RepeatButton

    Private Property DownButtonElement() As RepeatButton
        Get
            Return m_downButtonElement
        End Get

        Set(ByVal repeatBtn As RepeatButton)
            If m_downButtonElement IsNot Nothing Then
                RemoveHandler m_downButtonElement.Click, AddressOf downButtonElement_Click
            End If
            m_downButtonElement = repeatBtn

            If m_downButtonElement IsNot Nothing Then
                AddHandler m_downButtonElement.Click, AddressOf downButtonElement_Click
            End If
        End Set
    End Property

    Private Sub downButtonElement_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Value -= 1
    End Sub

    '<SnippetUpButtonProperty> 
    Private m_upButtonElement As RepeatButton

    Private Property UpButtonElement() As RepeatButton
        Get
            Return m_upButtonElement
        End Get

        Set(ByVal repeatBtn As RepeatButton)
            If m_upButtonElement IsNot Nothing Then
                RemoveHandler m_upButtonElement.Click, AddressOf upButtonElement_Click
            End If
            m_upButtonElement = repeatBtn

            If m_upButtonElement IsNot Nothing Then
                AddHandler m_upButtonElement.Click, AddressOf upButtonElement_Click
            End If
        End Set
    End Property
    '</SnippetUpButtonProperty> 

    Private Sub upButtonElement_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Value += 1
    End Sub

    '<SnippetControlFocus> 
    Protected Overloads Overrides Sub OnPointerPressed(ByVal e As PointerRoutedEventArgs)
        MyBase.OnPointerPressed(e)
        Focus()
    End Sub
    '</SnippetControlFocus> 

    '<SnippetFocusProperty> 
    Private isFocused As Boolean

    '<SnippetOnGotFocus> 
    Protected Overloads Overrides Sub OnGotFocus(ByVal e As RoutedEventArgs)
        MyBase.OnGotFocus(e)
        isFocused = True
        UpdateStates(True)
    End Sub
    '</SnippetOnGotFocus> 

    Protected Overloads Overrides Sub OnLostFocus(ByVal e As RoutedEventArgs)
        MyBase.OnLostFocus(e)
        isFocused = False
        UpdateStates(True)
    End Sub
    '</SnippetFocusProperty> 

End Class


Public Delegate Sub ValueChangedEventHandler(ByVal sender As Object, ByVal e As ValueChangedEventArgs)

Public Class ValueChangedEventArgs
    Inherits EventArgs
    Private _value As Integer

    Public Sub New(ByVal num As Integer)
        _value = num
    End Sub

    Public ReadOnly Property Value() As Integer
        Get
            Return _value
        End Get
    End Property
End Class
'</SnippetControlLogic> 

Namespace ControlContract
    '<SnippetControlContract> 
    <TemplatePart(Name:="TextElement", Type:=GetType(TextBlock))> _
    <TemplatePart(Name:="UpButtonElement", Type:=GetType(RepeatButton))> _
    <TemplatePart(Name:="DownButtonElement", Type:=GetType(RepeatButton))> _
    <TemplateVisualState(Name:="Positive", GroupName:="ValueStates")> _
    <TemplateVisualState(Name:="Negative", GroupName:="ValueStates")> _
    <TemplateVisualState(Name:="Focused", GroupName:="FocusedStates")> _
    <TemplateVisualState(Name:="Unfocused", GroupName:="FocusedStates")> _
    Public Class NumericUpDown
        Inherits Control

        Public Shared ReadOnly BackgroundProperty As DependencyProperty
        Public Shared ReadOnly BorderBrushProperty As DependencyProperty
        Public Shared ReadOnly BorderThicknessProperty As DependencyProperty
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


        Public Property Background() As Brush
            Get
            End Get

            Set(ByVal value As Brush)
            End Set
        End Property

        Public Property BorderBrush() As Brush
            Get
            End Get

            Set(ByVal value As Brush)
            End Set
        End Property

        Public Property BorderThickness() As Thickness
            Get
            End Get

            Set(ByVal value As Thickness)
            End Set
        End Property

        Public Property FontFamily() As FontFamily
            Get
            End Get

            Set(ByVal value As FontFamily)
            End Set
        End Property

        Public Property FontSize() As Double
            Get
            End Get

            Set(ByVal value As Double)
            End Set
        End Property

        Public Property FontStretch() As FontStretch
            Get
            End Get

            Set(ByVal value As FontStretch)
            End Set
        End Property

        Public Property FontStyle() As FontStyle
            Get
            End Get

            Set(ByVal value As FontStyle)
            End Set
        End Property

        Public Property FontWeight() As FontWeight
            Get
            End Get

            Set(ByVal value As FontWeight)
            End Set
        End Property

        Public Property Foreground() As Brush
            Get
            End Get

            Set(ByVal value As Brush)
            End Set
        End Property

        Public Property HorizontalContentAlignment() As HorizontalAlignment
            Get
            End Get

            Set(ByVal value As HorizontalAlignment)
            End Set
        End Property

        Public Property Padding() As Thickness
            Get
            End Get

            Set(ByVal value As Thickness)
            End Set
        End Property

        Public Property TextAlignment() As TextAlignment
            Get
            End Get

            Set(ByVal value As TextAlignment)
            End Set
        End Property

        Public Property TextDecorations() As TextDecorationCollection
            Get
            End Get

            Set(ByVal value As TextDecorationCollection)
            End Set
        End Property

        Public Property TextWrapping() As TextWrapping
            Get
            End Get

            Set(ByVal value As TextWrapping)
            End Set
        End Property

        Public Property VerticalContentAlignment() As VerticalAlignment
            Get
            End Get

            Set(ByVal value As VerticalAlignment)
            End Set
        End Property
    End Class
    '</SnippetControlContract> 
End Namespace