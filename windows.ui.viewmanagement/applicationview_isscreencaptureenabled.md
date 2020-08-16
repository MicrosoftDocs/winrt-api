---
-api-id: P:Windows.UI.ViewManagement.ApplicationView.IsScreenCaptureEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool IsScreenCaptureEnabled { get;  set; }
-->

# Windows.UI.ViewManagement.ApplicationView.IsScreenCaptureEnabled

## -description
Gets or sets whether screen capture is enabled for the window (app view).

## -property-value
**true** if screen capture is enabled for the window; **false** if it is not.

## -remarks
This property lets you protect against unwanted copies of the window. When screen capture is disabled for a window, the window appears black in images produced by screen capture operations. For an example of setting the isScreenCaptureEnabled property, see the [Disable screen capture sample](https://code.msdn.microsoft.com/windowsapps/Disable-screen-capture-00efe630).

The property is a nonstatic member of the window object. For JavaScript, this means that it is a method of the window object that [getForCurrentView](applicationview_getforcurrentview_1363600702.md) creates, not of the [ApplicationView](applicationview.md) class.

## -examples

## -see-also
[Disabling screen capture sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/DisablingScreenCapture)
