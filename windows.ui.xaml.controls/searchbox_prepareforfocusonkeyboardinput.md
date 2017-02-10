---
-api-id: E:Windows.UI.Xaml.Controls.SearchBox.PrepareForFocusOnKeyboardInput
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler PrepareForFocusOnKeyboardInput<Windows.UI.Xaml.Controls.SearchBox,  Windows.UI.Xaml.RoutedEventArgs>
-->

# Windows.UI.Xaml.Controls.SearchBox.PrepareForFocusOnKeyboardInput

## -description
Occurs when the [FocusOnKeyboardInput](searchbox_focusonkeyboardinput.md) property is **true** and the app receives textual keyboard input.

## -xaml-syntax
```xaml
<SearchBox PrepareForFocusOnKeyboardInput="eventhandler"/>
```


## -remarks
This event occurs only if the [FocusOnKeyboardInput](searchbox_focusonkeyboardinput.md) property is **true**. If you wan to provide "type-to-search" behavior in your app, you should handle this event and synchronously ensure the [SearchBox](searchbox.md) control is visible before the event call completes. After this event occurs, the control sets focus to itself.

When [FocusOnKeyboardInput](searchbox_focusonkeyboardinput.md) is **true**, keyboard input on the current thread is intercepted and textual input is redirected to the [SearchBox](searchbox.md). Only textual input will cause the [SearchBox](searchbox.md) to receive focus. Non-text keys, such as arrows or Tab, are not redirected to the [SearchBox](searchbox.md). WIN/CTRL/ALT key combinations (except for Ctrl-V for paste) are also not redirected.

## -examples

## -see-also
[FocusOnKeyboardInput](searchbox_focusonkeyboardinput.md)