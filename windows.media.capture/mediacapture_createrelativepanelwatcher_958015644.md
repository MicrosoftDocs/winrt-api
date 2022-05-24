---
-api-id: M:Windows.Media.Capture.MediaCapture.CreateRelativePanelWatcher(Windows.Media.Capture.StreamingCaptureMode,Windows.UI.WindowManagement.DisplayRegion)
-api-type: winrt method
---

## -description

Creates a new instance of the [MediaCaptureRelativePanelWatcher](mediacapturerelativepanelwatcher.md) class, which monitors the panel associated with the provided [DisplayRegion](/uwp/api/windows.ui.windowmanagement.displayregion), so that the app receives notifications when the relative location of the panel changes. 

## -parameters

### -param captureMode

A value from the [StreamingCaptureMode enumeration](/uwp/api/windows.media.capture.streamingcapturemode) enumeration.

### -param displayRegion

A [DisplayRegion](/uwp/api/windows.ui.windowmanagement.displayregion) for which the associated panel is monitored for changes. Typically this display region will be the camera view finder UI element, so that the app is alerted if the relative location of the panel containing the view finder changes.  

## -returns

A new instance of the [MediaCaptureRelativePanelWatcher](mediacapturerelativepanelwatcher.md) class.

## -remarks

Apps should implement a handler for the [DisplayRegion.Changed Event](/en-us/uwp/api/windows.ui.windowmanagement.displayregion.changed) that is raised whenever the **DisplayRegion** associated with the watcher changes. In this handler, apps should dispose of the watcher object, recreate the object, and reregister a handler for the [MediaCaptureRelativePanelWatcher.Changed](mediacapturerelativepanelwatcher_changed.md) event. 

## -see-also

[MediaCaptureRelativePanelWatcher](mediacapturerelativepanelwatcher.md)
[DisplayRegion](/uwp/api/windows.ui.windowmanagement.displayregion)

## -examples

