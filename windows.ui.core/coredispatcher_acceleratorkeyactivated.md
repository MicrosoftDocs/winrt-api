---
-api-id: E:Windows.UI.Core.CoreDispatcher.AcceleratorKeyActivated
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler AcceleratorKeyActivated<Windows.UI.Core.CoreDispatcher,  Windows.UI.Core.AcceleratorKeyEventArgs>
-->

# Windows.UI.Core.CoreDispatcher.AcceleratorKeyActivated

## -description
Fired when an accelerator key is activated (pressed or held down).

## -remarks
** behavior**

XAML processes CTRL+TAB or CTRL+SHIFT+TAB key presses for tab navigation, and apps do not get a chance to handle them from the **AcceleratorKeyActivated** event. Starting in Windows 8.1, we will allow the tab navigation processing with CTRL+TAB or ALT+TAB or SHIFT+TAB.

If you handled the **AcceleratorKeyActivated** event in Windows 8 to do special processing, the event will get fired for Tab keys when invoked with CTRL, ALT, or SHIFT modifiers in Windows 8.1. Verify tab navigation with CTRL+TAB or ALT+TAB or SHIFT+TAB keys.

## -examples

## -see-also
