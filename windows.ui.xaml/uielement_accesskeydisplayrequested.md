---
-api-id: E:Windows.UI.Xaml.UIElement.AccessKeyDisplayRequested
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler AccessKeyDisplayRequested<Windows.UI.Xaml.UIElement,  Windows.UI.Xaml.Input.AccessKeyDisplayRequestedEventArgs>
-->

# Windows.UI.Xaml.UIElement.AccessKeyDisplayRequested

## -description
Occurs when the access key sequence is started to notify controls that they should show access key visuals.

## -xaml-syntax

```xaml
<uiElement AccessKeyDisplayRequested="eventhandler"/>
```

## -remarks
This event is not raised if the element is under an element with its [Visibility](uielement_visibility.md) property set to **Collapsed**.

## -examples

## -see-also
