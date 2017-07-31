---
-api-id: E:Windows.UI.Xaml.UIElement.AccessKeyInvoked
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler AccessKeyInvoked<Windows.UI.Xaml.UIElement,  Windows.UI.Xaml.Input.AccessKeyInvokedEventArgs>
-->

# Windows.UI.Xaml.UIElement.AccessKeyInvoked

## -description
Occurs when a user completes an access key sequence to notify the element that the access key action should be invoked.

## -xaml-syntax

```xaml
<uiElement AccessKeyInvoked="eventhandler"/>
```

## -remarks
This event indicates that an element’s access key action should be invoked. For example, this will be raised if an element’s [AccessKey](uielement_accesskey.md) is "A" and the user presses Alt-A.

An access key can have one or several characters. This event occurs only when users type all the characters of an access key. For example, if an [AccessKey](uielement_accesskey.md) value is "BC", the event doesn't occur when the user presses "B". The event occurs when the user presses "B", then "C".

This event occurs when the key is pressed, not when it's released.

## -examples

## -see-also
