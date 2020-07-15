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
[Edge gesture invocation sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BJavaScript%5D-Windows%208%20app%20samples/JavaScript/Windows%208%20app%20samples/Edge%20gesture%20invocation%20sample%20(Windows%208))
