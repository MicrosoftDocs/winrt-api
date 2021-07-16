---
-api-id: E:Windows.Media.Capture.MediaCaptureRelativePanelWatcher.Changed
-api-type: winrt event
---

## -description

Raised when the relative location of the panel being monitored by the [MediaCaptureRelativePanelWatcher](mediacapturerelativepanelwatcher.md) changes.

## -remarks

This event may be raised on any thread. If you make UI updates in the handler for this event, be sure to dispatch them to the UI thread by making the updates within a call to [CoreDispatcher.RunAsync](/uwp/api/windows.ui.core.coredispatcher.runasync).

Apps should implement a handler for the [DisplayRegion.Changed Event](/en-us/uwp/api/windows.ui.windowmanagement.displayregion.changed) that is raised whenever the **DisplayRegion** associated with the watcher changes. In this handler, apps should dispose of the watcher object, recreate the object, and reregister a handler for the [MediaCaptureRelativePanelWatcher.Changed](mediacapturerelativepanelwatcher_changed.md) event.

## -see-also

## -examples

