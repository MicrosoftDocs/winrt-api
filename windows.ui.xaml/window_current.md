---
-api-id: P:Windows.UI.Xaml.Window.Current
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Window Current { get; }
-->

# Windows.UI.Xaml.Window.Current

## -description
Gets the window of the current thread.

Equivalent WinUI property: [Microsoft.UI.Xaml.Window.Current](/windows/winui/api/microsoft.ui.xaml.window.current).

## -property-value
The currently activated window.

## -remarks
The value of this property depends on the thread from which it is called. If called from a UI thread, the value is the Window instance for that thread. On any other thread, the value is `null`.

## -examples

## -see-also
