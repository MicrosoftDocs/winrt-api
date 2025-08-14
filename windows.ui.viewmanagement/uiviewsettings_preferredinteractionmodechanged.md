---
-api-id: E:Windows.UI.ViewManagement.UIViewSettings.PreferredInteractionModeChanged
-api-type: winrt event
---

# Windows.UI.ViewManagement.UIViewSettings.PreferredInteractionModeChanged

<!--
public event Windows.Foundation.TypedEventHandler<Windows.UI.ViewManagement.UIViewSettings,object> PreferredInteractionModeChanged;
-->


## -description

An event that's raised when the system state has changed in such a way that the system's preferred user interaction mode might have changed. In response to this event being raised, call [GetPreferredInteractionMode](./uiviewsettings_getpreferredinteractionmode_653911321.md) to retrieve the system's current preferred user interaction mode, and update your user interface (UI) if the preferred mode has changed.

## -remarks

**PreferredInteractionModeChanged** is raised on a background thread, so your app should marshal the signal back to the proper thread for your app's user interface.

If **PreferredInteractionModeChanged** is not supported on the target device, then it will never be raised on that device.

## -see-also

[GetPreferredInteractionMode](./uiviewsettings_getpreferredinteractionmode_653911321.md)

## -examples
