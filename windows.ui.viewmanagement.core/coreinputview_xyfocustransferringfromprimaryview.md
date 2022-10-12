---
-api-id: E:Windows.UI.ViewManagement.Core.CoreInputView.XYFocusTransferringFromPrimaryView
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler XYFocusTransferringFromPrimaryView<CoreInputView, CoreInputViewTransferringXYFocusEventArgs>
-->

# Windows.UI.ViewManagement.Core.CoreInputView.XYFocusTransferringFromPrimaryView

## -description

Occurs before the input pane loses focus and before a UI element gets focus.

## -remarks

Primary view refers to either of the [CoreInputViewKind.Keyboard](https://github.com/MicrosoftDocs/winrt-api/blob/docs/windows.ui.viewmanagement.core/coreinputviewkind.md#-field-keyboard1) or [CoreInputViewKind.Handwriting](https://github.com/MicrosoftDocs/winrt-api/blob/docs/windows.ui.viewmanagement.core/coreinputviewkind.md#-field-handwriting2) views, while CoreInputView can be any of the values from [CoreInputViewKind](coreinputviewkind.md).

Designate the focus target when navigating from the input pane to a UI element in your application.

## -examples

Here, we show how to handle the XYFocusTransferringFromPrimaryView event and identify which UI element should receive focus in the application. The focus candidates are differentiated based on location relative to the bounding rect of the last input pane child element.

```csharp
private void OnXYFocusTransferringFromPrimaryView(CoreInputView sender,
CoreInputViewTransferringXYFocusEventArgs args)
{
    bool acceptXYFocusTransfer = false;

    switch (args.Direction)
    {
        case CoreInputViewXYFocusTransferDirection.Down:
            // If focus navigation is moving down,
            // set focus to the top element (usernameTextBox).
            this.usernameTextBox.Focus(FocusState.Programmatic);
            acceptXYFocusTransfer = true;
            break;

        case CoreInputViewXYFocusTransferDirection.Up:
            // If focus navigation is moving up,
            // there are two focus candidates.
            // Check the Origin rect to determine the more
            // suitable candidate.
            if ((args.Origin.X + (args.Origin.Width / 2.0)) <
            Window.Current.Bounds.Width / 2.0)
            {
            this.cancelButton.Focus(FocusState.Programmatic);
            }
            else
            {
            this.submitButton.Focus(FocusState.Programmatic);
            }
            acceptXYFocusTransfer = true;
            break;

        case CoreInputViewXYFocusTransferDirection.Left:
        case CoreInputViewXYFocusTransferDirection.Right:
            // If focus navigation is moving left or right,
            // maintain focus on the currently focused UI element.
            acceptXYFocusTransfer = true;
            break;

        default:
            // Don't accept XY focus movement.
            break;
    }

    if (acceptXYFocusTransfer)
    {
        args.TransferHandled = true;
        this.KeyDown += OnMainPageKeyDown;
    }
}
```

## -see-also

[CoreInputViewTransferringXYFocusEventArgs](coreinputviewtransferringxyfocuseventargs.md), [TryTransferXYFocusToPrimaryView](coreinputview_trytransferxyfocustoprimaryview_587038147.md), [XYFocusTransferredToPrimaryView](coreinputview_xyfocustransferredtoprimaryview.md), [CoreInputViewTransferringXYFocusEventArgs.TransferHandled](coreinputviewtransferringxyfocuseventargs_transferhandled.md)
