---
-api-id: T:Windows.UI.Xaml.WindowClosedEventHandler
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate void WindowClosedEventHandler(System.Object sender, Windows.UI.Core.CoreWindowEventArgs e)
-->
# Windows.UI.Xaml.WindowClosedEventHandler

## -description
Represents the method that will handle the [Closed](window_closed.md) event.

## -parameters
### -param sender
The object where the handler is attached.

### -param e
Event data for the event.


## -remarks
The [Closed](window_closed.md) event occurs when a [Window](window.md) closes. However, Windows Store app typically use a single [Window](window.md) instance, and do not open and close additional [Window](window.md) instances.

## -examples

## -see-also