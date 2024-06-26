---
-api-id: M:Windows.UI.Xaml.Input.FocusManager.GetFocusedElement
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax
public object GetFocusedElement()
-->

# Windows.UI.Xaml.Input.FocusManager.GetFocusedElement

## -description

Retrieves the element in the UI that has focus.



## -returns

The object that has focus. Typically, this is a [Control](../windows.ui.xaml.controls/control.md) class.

## -remarks

> [!WARNING]
> For WinUI 3 apps, this method always returns `null` as it relies on CoreWindow APIs not supported by WinUI 3.
>
> Instead, use the [FocusManager.GetFocusedElement(XamlRoot)](./windows.ui.xaml.input.focusmanager.getfocusedelement#windows-ui-xaml-input-focusmanager-getfocusedelement(windows-ui-xaml-xamlroot))
> overload, where `XamlRoot` can be retrieved any loaded UIElement through the [XamlRoot](/uwp/api/windows.ui.xaml.uielement.xamlroot) property.

## -examples

## -see-also

GetFocusedElement, [Keyboard interactions](/windows/uwp/design/input/keyboard-interactions), [Focus navigation for keyboard, gamepad, remote control, and accessibility tools](/windows/uwp/design/input/focus-navigation), [Programmatic focus navigation](/windows/uwp/design/input/focus-navigation-programmatic)
