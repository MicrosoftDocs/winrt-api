---
-api-id: P:Windows.UI.Xaml.Controls.TextControlCuttingToClipboardEventArgs.Handled
-api-type: winrt property
---

<!-- Property syntax.
public bool Handled { get;  set; }
-->

# Windows.UI.Xaml.Controls.TextControlCuttingToClipboardEventArgs.Handled

## -description

Gets or sets a value that marks the routed event as handled. A **true** value for Handled prevents most handlers along the event route from handling the same event again.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.TextControlCuttingToClipboardEventArgs.Handled](/windows/winui/api/microsoft.ui.xaml.controls.textcontrolcuttingtoclipboardeventargs.handled) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value

**true** to mark the routed event handled. **false** to leave the routed event unhandled, which causes the default cut action to be performed. The default is **false**.

## -remarks

## -see-also

## -examples

