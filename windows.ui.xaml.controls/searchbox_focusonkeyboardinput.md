---
-api-id: P:Windows.UI.Xaml.Controls.SearchBox.FocusOnKeyboardInput
-api-type: winrt property
---

<!-- Property syntax
public bool FocusOnKeyboardInput { get;  set; }
-->

# Windows.UI.Xaml.Controls.SearchBox.FocusOnKeyboardInput

## -description
Gets or sets a value that determines whether a user can search by typing anywhere in the app.

## -xaml-syntax
```xaml
<SearchBox FocusOnKeyboardInput="bool"/>
```


## -property-value
**true** if the user can search by typing anywhere in the app; otherwise, **false**. The default is **false**.

## -remarks
> [!NOTE]
> When FocusOnKeyboardInput is set to **true**, there’s an issue that sometimes creates duplicate characters in the [SearchBox](searchbox.md) control when using the touch keyboard. You can work around the issue by following these steps:

1. Disable FocusOnKeyboardInput after the [SearchBox](searchbox.md) receives focus. To do this, register for the [PrepareForFocusOnKeyboardInput](searchbox_prepareforfocusonkeyboardinput.md) event and use the event handler to set FocusOnKeyboardInput to **false**.
1. When the [SearchBox](searchbox.md) loses focus, set FocusOnKeyboardInput back to **true**. To do this, register for the [LostFocus](control_onlostfocus_679101471.md) event and use the event handler to set FocusOnKeyboardInput back to **true**.


When FocusOnKeyboardInput is **true**, keyboard input on the current thread is intercepted and textual input is redirected to the [SearchBox](searchbox.md). Only textual input will cause the [SearchBox](searchbox.md) to receive focus. Non-text keys, such as arrows or Tab, are not redirected to the [SearchBox](searchbox.md). WIN/CTRL/ALT key combinations (except for Ctrl-V for paste) are also not redirected.

To do more than just set focus in the [SearchBox](searchbox.md), such as make the control visible, handle the [PrepareForFocusOnKeyboardInput](searchbox_prepareforfocusonkeyboardinput.md) event.

You should set FocusOnKeyboardInput to **false** if the user sets focus on some other editable text field.

To learn more about when you should let users type to search, see [Guidelines and checklist for search](/windows/uwp/controls-and-patterns/search).

## -examples

## -see-also
[PrepareForFocusOnKeyboardInput](searchbox_prepareforfocusonkeyboardinput.md), [Guidelines and checklist for search](/windows/uwp/controls-and-patterns/search)
