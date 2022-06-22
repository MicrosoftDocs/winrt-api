---
-api-id: T:Windows.UI.Xaml.FocusState
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.FocusState : int
-->

# FocusState

## -description

Describes how an element obtained focus.



## -enum-fields

### -field Unfocused:0

Element is not currently focused.

### -field Pointer:1

Element obtained focus through a pointer action.

### -field Keyboard:2

Element obtained focus through a keyboard action, such as tab sequence traversal.

### -field Programmatic:3

Element obtained focus through a deliberate call to [Focus](../windows.ui.xaml.controls/control_focus_195503898.md) or a related API.

## -remarks

FocusState is used as a value by the [Control.FocusState](../windows.ui.xaml.controls/control_focusstate.md) property. It's also used as an input by the [Control.Focus](../windows.ui.xaml.controls/control_focus_195503898.md) method.

If used as an input parameter for [Control.Focus](../windows.ui.xaml.controls/control_focus_195503898.md), you can't use **Unfocused**. Which value of FocusState to pass to a [Control.Focus](../windows.ui.xaml.controls/control_focus_195503898.md) call depends on the input scenario and which user interaction your control or app code is responding to. For more info, see Remarks in [Control.Focus](../windows.ui.xaml.controls/control_focus_195503898.md).

The exact meaning of the FocusState values depends on whether you're reading it from [Control.FocusState](../windows.ui.xaml.controls/control_focusstate.md), or using a value to send to [Control.Focus](../windows.ui.xaml.controls/control_focus_195503898.md). If you are setting [Control.Focus](../windows.ui.xaml.controls/control_focus_195503898.md) you're informing other callers (like the control templates) about how that control obtained focus.

## -examples

## -see-also

[Control.FocusState](../windows.ui.xaml.controls/control_focusstate.md), [Control.Focus](../windows.ui.xaml.controls/control_focus_195503898.md), [Keyboard interactions](/windows/uwp/input-and-devices/keyboard-interactions)
