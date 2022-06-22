---
-api-id: P:Windows.UI.Xaml.Controls.TextControlPasteEventArgs.Handled
-api-type: winrt property
---

<!-- Property syntax
public bool Handled { get;  set; }
-->

# Windows.UI.Xaml.Controls.TextControlPasteEventArgs.Handled

## -description
Gets or sets a value that marks the routed event as handled. A **true** value for Handled prevents most handlers along the event route from handling the same event again.



## -property-value
**true** to mark the routed event handled. **false** to leave the routed event unhandled, which permits the event to potentially route further and be acted on by other handlers. The default is **false**.

## -remarks
For more info, see the [Paste](textbox_paste.md) event.

## -examples

## -see-also
[TextBox.Paste](textbox_paste.md), [RichEditBox.Paste](richeditbox_paste.md), [PasswordBox.Paste](passwordbox_paste.md)
