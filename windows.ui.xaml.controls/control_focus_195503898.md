---
-api-id: M:Windows.UI.Xaml.Controls.Control.Focus(Windows.UI.Xaml.FocusState)
-api-type: winrt method
---

<!-- Method syntax
public bool Focus(Windows.UI.Xaml.FocusState value)
-->

# Windows.UI.Xaml.Controls.Control.Focus

## -description
Attempts to set the focus on the control.

## -parameters
### -param value
Specifies how focus was set, as a value of the enumeration.

## -returns
**true** if focus was set to the control, or focus was already on the control. **false** if the control is not focusable.

## -remarks
If you call this method on a `Control` with an [IsTabStop](control_istabstop.md) set to `false`, the call will be ignored and focus will not move, and the call will return `false`.

You can't remove focus from a control by calling this method with @Windows.UI.Xaml.FocusState.Unfocused as the parameter. This value is not allowed and causes an exception. To remove focus from a control, set focus to a different control.

You typically pass [FocusState.Programmatic](../windows.ui.xaml/focusstate.md) as the parameter to indicate the control obtained focus through a deliberate call to the Focus method. For example, if clicking an "Edit" button causes focus to be set on a [TextBox](textbox.md), use the [Programmatic](../windows.ui.xaml/focusstate.md) focus state.

Pass [FocusState.Pointer](../windows.ui.xaml/focusstate.md) if you’re setting focus as the direct result of a pointer interaction. Pass [FocusState.Keyboard](../windows.ui.xaml/focusstate.md) as the parameter if you’re setting focus as a result of a keyboard interaction, like a tab sequence or key press. For example, if you’re implementing an [ItemsControl](itemscontrol.md) and handle key presses to let the user move focus between items in the control, use the [Keyboard](../windows.ui.xaml/focusstate.md) focus state when you call Focus in your key press handler.

### Notes for previous versions

> [!NOTE]
> In Windows 8, when [FocusState](control_focusstate.md) is [Programmatic](../windows.ui.xaml/focusstate.md), the keyboard focus visual is shown even if the prior method of input was pointer. In Windows 8.1, when you call Focus (*FocusState.Programmatic*), the prior [FocusState](control_focusstate.md), either [Pointer](../windows.ui.xaml/focusstate.md) or [Keyboard](../windows.ui.xaml/focusstate.md), is retained so that the correct focus visual is shown. This means that if you check the value of the [FocusState](control_focusstate.md) property after you call Focus (*FocusState.Programmatic*), the [FocusState](control_focusstate.md) property will have a value of either [Pointer](../windows.ui.xaml/focusstate.md) or [Keyboard](../windows.ui.xaml/focusstate.md).

In an app that’s compiled for Windows 8, but run in Windows 8.1, the Windows 8 behavior is retained. The [FocusState](control_focusstate.md) property value is [Programmatic](../windows.ui.xaml/focusstate.md) and the keyboard focus visual is shown.

## -examples

In this example, clicking an "Edit" button causes focus to be set on a TextBox, so the Programmatic focus state is passed to the Focus method.

```xaml
<StackPanel>
    <Button Content="Edit" Click="Button_Click"/>
    <TextBox x:Name="EditorTextBox" IsReadOnly="True"/>
</StackPanel>
```

```csharp
private void Button_Click(object sender, RoutedEventArgs e)
{
    EditorTextBox.IsReadOnly = false;
    EditorTextBox.Focus(FocusState.Programmatic);
}
```

## -see-also
[Control.FocusState](control_focusstate.md), [UIElement.GotFocus](../windows.ui.xaml/uielement_gotfocus.md), [UIElement.LostFocus](../windows.ui.xaml/uielement_lostfocus.md), [Control.OnGotFocus](control_ongotfocus_1398920478.md), [Keyboard interactions](/windows/uwp/input-and-devices/keyboard-interactions), [Keyboard accessibility](/windows/uwp/accessibility/keyboard-accessibility), [Touch keyboard sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/TouchKeyboard)
