---
-api-id: M:Windows.UI.Input.EdgeGesture.GetForCurrentView
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.UI.Input.EdgeGesture GetForCurrentView()
-->

# Windows.UI.Input.EdgeGesture.GetForCurrentView

## -description
Gets an instance of the [EdgeGesture](edgegesture.md) class that is used to add and remove event delegate handlers for the current view.

## -returns
The currently relevant instance of the [EdgeGesture](edgegesture.md) object.

## -remarks
This method uses the current [CoreWindow](../windows.ui.core/corewindow.md) of your application's [CoreApplication](../windows.applicationmodel.core/coreapplication.md) object to determine the particular instance. That is, there is a 1:1 correspondence between different instances of [EdgeGesture](edgegesture.md) and [CoreWindow](../windows.ui.core/corewindow.md). You cannot obtain an instance of an [EdgeGesture](edgegesture.md) class for another app, nor can an [EdgeGesture](edgegesture.md) instance be obtained for an app without a current [CoreWindow](../windows.ui.core/corewindow.md).

## -examples

## -see-also
[Edge gesture invocation sample](http://go.microsoft.com/fwlink/p/?linkid=242153)