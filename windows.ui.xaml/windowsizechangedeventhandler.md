---
-api-id: T:Windows.UI.Xaml.WindowSizeChangedEventHandler
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate void WindowSizeChangedEventHandler(System.Object sender, Windows.UI.Core.WindowSizeChangedEventArgs e)
-->
# Windows.UI.Xaml.WindowSizeChangedEventHandler

## -description
Represents the method that will handle the [Window.SizeChanged](window_sizechanged.md) event.

## -parameters

### -param sender
The object where the handler is attached.

### -param e
Event data for the event.


## -remarks
The [SizeChanged](window_sizechanged.md) event fires when the [Window](window.md) size changes. There are multiple reasons why the [Window](window.md) size of an app might change. These reasons include changes to device orientation that result in a redraw of the current app UI, or the user resizes the app. By handling the [SizeChanged](window_sizechanged.md) event, an app can determine what the current app view is in order to modify their UI. This gives your app code a chance to assure that the elements are presented correctly for the new window size and shape. If the view state is changing to a narrow width, this often means that you are making choices about which UI elements should remain displayed and which should be hidden until the app is restored to a wider view. [SizeChanged](window_sizechanged.md) is an important event to handle because the multiple views that your UWP app can offer are controlled by the user and can change at any time. 
<!--Can they change while app is suspended?-->

## -examples

## -see-also
[ApplicationView](../windows.ui.viewmanagement/applicationview.md), [Window](window.md), [FrameworkElement.SizeChanged](frameworkelement_sizechanged.md), [Quickstart: Designing apps for different window sizes](/previous-versions/windows/apps/dn297195(v=win.10))
