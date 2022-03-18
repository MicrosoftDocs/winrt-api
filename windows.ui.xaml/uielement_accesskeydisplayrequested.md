---
-api-id: E:Windows.UI.Xaml.UIElement.AccessKeyDisplayRequested
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler AccessKeyDisplayRequested<Windows.UI.Xaml.UIElement,  Windows.UI.Xaml.Input.AccessKeyDisplayRequestedEventArgs>
-->

# Windows.UI.Xaml.UIElement.AccessKeyDisplayRequested

## -description

Occurs when the user requests that access keys be displayed.

Equivalent WinUI event: [Microsoft.UI.Xaml.UIElement.AccessKeyDisplayRequested](/windows/winui/api/microsoft.ui.xaml.uielement.accesskeydisplayrequested).

## -xaml-syntax

```xaml
<uiElement AccessKeyDisplayRequested="eventhandler"/>
```

## -remarks

This event notifies an element to show access key visuals.

This event is not raised if the element is under an element with its [Visibility](uielement_visibility.md) property set to **Collapsed**.

## -examples

## -see-also

[AccessKeyDisplayDismissedEventArgs](../windows.ui.xaml.input/accesskeydisplarequestedeventargs.md), [Access keys](/windows/uwp/design/input/access-keys)
